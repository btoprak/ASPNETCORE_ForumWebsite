using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Business.Abstract;
using Forum.Entities;
using Forum.WebUI.Models.Post;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Forum.WebUI.Controllers
{
    [Authorize]
    public class ReplyController : Controller
    {
        private readonly IPostService _postService;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly IApplicationUserService _applicationUserService;

        public ReplyController(IPostService postService, UserManager<ApplicationUser> userManager, IApplicationUserService applicationUserService)
        {
            _postService = postService;
            _userManager = userManager;
            _applicationUserService = applicationUserService;
        }
        public async Task<IActionResult> CreatePost(int id)
        {
            var post = _postService.GetById(id);
            var user = await _userManager.FindByNameAsync(User.Identity.Name);

            var model = new PostReplyModel
            {
                PostContent = post.Content,
                PostName = post.Title,
                PostId = post.Id,

                AuthorName = User.Identity.Name,
                AuthorId = user.Id,
                AuthorImageUrl = user.ProfileImageUrl,
                AuthorRating = user.Rating,
                IsAuthorAdmin = User.IsInRole("Admin"),

                ForumId = post.Forum.Id,
                ForumName = post.Forum.Title,
                ForumImageUrl = post.Forum.ImageUrl,

                Created = DateTime.Now,
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddReply(PostReplyModel model)
        {
            var userId = _userManager.GetUserId(User);
            var user = await _userManager.FindByIdAsync(userId);

            var reply = BuildReply(model, user);

            await _postService.AddReply(reply);
            await _applicationUserService.IncrementRating(userId, typeof(PostReply));
            return RedirectToAction("Index", "Post", new { id = model.PostId });
        }

        private PostReply BuildReply(PostReplyModel model, ApplicationUser user)
        {
            var post = _postService.GetById(model.PostId);

            return new PostReply
            {
                Post = post,
                Content = model.ReplyContent,
                Created = DateTime.Now,
                User = user
            };
        }
    }
}