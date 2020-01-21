using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Forum.Business.Abstract;
using Forum.Entities;
using Forum.WebUI.Models.Forum;
using Forum.WebUI.Models.Post;
using Forum.WebUI.Models.Search;
using Microsoft.AspNetCore.Mvc;

namespace Forum.WebUI.Controllers
{
    public class SearchController : Controller
    {
        private readonly IPostService _postService;
        public SearchController(IPostService postService)
        {
            _postService = postService;
        }


        public IActionResult Results(string searchQuery)
        {
            var posts = _postService.GetFilteredPosts(searchQuery).ToList();

            var areNoResults = (!string.IsNullOrEmpty(searchQuery) && !posts.Any());

            var postListings = posts.Select(post => new PostListingModel
            {
                Id = post.Id,
                AuthorId = post.User.Id,
                AuthorName = post.User.UserName,
                Title = post.Title,
                DatePosted = post.Created.ToString(),
                RepliesCount = post.Replies.Count(),
                Forum = BuildForumListing(post)
            });

            var model = new SearchResultModel
            {
                Posts = postListings,
                SearchQuery = searchQuery,
                EmptySearchResults = areNoResults
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Search(string searchQuery)
        {
            return RedirectToAction("Results", new { searchQuery });
        }

        private ForumListingModel BuildForumListing(Post post)
        {
            var forum = post.Forum;

            return new ForumListingModel
            {
                Id = forum.Id,
                ImageUrl = forum.ImageUrl,
                Name = forum.Title,
                Description = forum.Description
            };
        }
    }
}