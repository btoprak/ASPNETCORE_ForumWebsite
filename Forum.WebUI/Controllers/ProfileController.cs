using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using Forum.Business.Abstract;
using Forum.Entities;
using Forum.WebUI.Models.ApplicationUser;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Forum.WebUI.Controllers
{
    [Authorize]
    public class ProfileController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationUserService _applicationUserService;
        private readonly IUploadService _uploadService;
        private readonly IConfiguration _configuration;

        public ProfileController(UserManager<ApplicationUser> userManager, IApplicationUserService applicationUserService, IUploadService uploadService, IConfiguration configuration)
        {
            _userManager = userManager;
            _applicationUserService = applicationUserService;
            _uploadService = uploadService;
            _configuration = configuration;

        }
        public IActionResult Detail(string id)
        {
            var user = _applicationUserService.GetById(id);
            var userRoles = _userManager.GetRolesAsync(user).Result;

            var model = new ProfileModel()
            {
                UserId = user.Id,
                UserName = user.UserName,
                UserRating = user.Rating.ToString(),
                Email = user.Email,
                ProfileImageUrl = user.ProfileImageUrl,
                MemberSince = user.MemberSince,
                IsAdmin = userRoles.Contains("Admin")
            };
            return View(model);
        }


        [HttpPost]
        public async Task<IActionResult> UploadProfileImage(string id, IFormFile file)
        {
            var userId = _userManager.GetUserId(User);
            var entity = _applicationUserService.GetById(userId);

            if (file != null)
            {
                entity.ProfileImageUrl = "/images/users/" + file.FileName;

                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\users", file.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await file.CopyToAsync(stream);
                }
            }
            _applicationUserService.Update(entity);

            return RedirectToAction("Detail", new { id = userId });
        }

        [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            var profiles = _applicationUserService.GetAll()
                .OrderByDescending(user => user.Rating)
                .Select(u => new ProfileModel
                {
                    Email = u.Email,
                    UserName = u.UserName,
                    ProfileImageUrl = u.ProfileImageUrl,
                    UserRating = u.Rating.ToString(),
                    MemberSince = u.MemberSince
                });

            var model = new ProfileListModel
            {
                Profiles = profiles
            };
            return View(model);
        }
    }
}