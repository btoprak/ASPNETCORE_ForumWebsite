using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Forum.Business.Abstract;
using Forum.Entities;
using Forum.WebUI.Models.Forum;
using Forum.WebUI.Models.Post;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Forum.WebUI.Controllers
{
    public class ForumController : Controller
    {
        private IForumService _forumService;
        private IPostService _postService;
        private IApplicationUserService _applicationUserService;
        public ForumController(IForumService forumService, IPostService postService, IApplicationUserService applicationUserService)
        {
            _forumService = forumService;
            _postService = postService;
            _applicationUserService = applicationUserService;
        }
        public IActionResult Index()
        {
            var forums = _forumService.GetAll().Select(forum => new ForumListingModel
            {
                Id = forum.Id,
                Name = forum.Title,
                Description = forum.Description,
                NumberOfPosts = forum.Posts?.Count() ?? 0,
                NumberOfUsers = _forumService.GetActiveUsers(forum.Id).Count(),
                ImageUrl = forum.ImageUrl,
                HasRecentPost = _forumService.HasRecentPost(forum.Id),
            });

            var model = new ForumIndexModel
            {
                ForumList = forums.OrderBy(f => f.Name)
            };
            return View(model);
        }

        public IActionResult Topic(int id, string searchQuery)
        {
            var forum = _forumService.GetById(id);
            var posts = new List<Post>();

            posts = _postService.GetFilteredPosts(forum, searchQuery).ToList();

            var postListings = posts.Select(post => new PostListingModel
            {
                Id = post.Id,
                AuthorId = post.User.Id,
                AuthorRating = post.User.Rating,
                AuthorName = post.User.UserName,
                Title = post.Title,
                DatePosted = post.Created.ToString(),
                RepliesCount = post.Replies.Count(),
                Forum = BuildForumListing(post)
            });

            var model = new ForumTopicModel
            {
                Posts = postListings,
                Forum = BuildForumListing(forum)
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Search(int id, string searchQuery)
        {
            return RedirectToAction("Topic", new { id, searchQuery });
        }

        [Authorize(Roles = "Admin")]
        public IActionResult CreateForum()
        {
            var model = new AddForumModel();

            return View(model);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public async Task<IActionResult> AddForum(AddForumModel model)
        {
            if (model.ImageUpload != null)
            {
                var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot\\images\\forum", model.ImageUpload.FileName);
                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await model.ImageUpload.CopyToAsync(stream);
                }
            }
            var forum = new Forumm
            {
                Title = model.Title,
                Description = model.Description,
                Created = DateTime.Now,
                ImageUrl = "/images/forum/" + model.ImageUpload.FileName
            };

            await _forumService.Create(forum);
            return RedirectToAction("Index", "Forum");
        }


        private ForumListingModel BuildForumListing(Post post)
        {
            var forum = post.Forum;
            return BuildForumListing(forum);
        }

        private ForumListingModel BuildForumListing(Forumm forum)
        {
            return new ForumListingModel
            {
                Id = forum.Id,
                Name = forum.Title,
                Description = forum.Description,
                ImageUrl = forum.ImageUrl
            };
        }
    }
}