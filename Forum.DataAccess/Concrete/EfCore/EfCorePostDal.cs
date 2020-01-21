using Forum.DataAccess.Abstract;
using Forum.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.DataAccess.Concrete.EfCore
{
    public class EfCorePostDal : EfCoreGenericRepository<Post>, IPostDal
    {
        public EfCorePostDal(ForumContext forumContext)
                : base(forumContext) { }

        public async Task Add(Post post)
        {
            context.Add(post);
            await context.SaveChangesAsync();
        }

        public async Task AddReply(PostReply reply)
        {
            context.PostReplies.Add(reply);
            await context.SaveChangesAsync();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task EditPostContent(int id, string newContent)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Post> GetAll()
        {
            return context.Posts
                .Include(post => post.User)
                .Include(post => post.Replies).ThenInclude(reply => reply.User)
                .Include(post => post.Forum);
        }

        public Post GetById(int id)
        {
            return context.Posts.Where(post => post.Id == id)
                 .Include(post => post.User)
                 .Include(post => post.Replies)
                 .ThenInclude(reply => reply.User)
                 .Include(post => post.Forum)
                 .First();

        }

        public IEnumerable<Post> GetFilteredPosts(Forumm forum, string searchQuery)
        {
            return string.IsNullOrEmpty(searchQuery)
                ? forum.Posts
                : forum.Posts.Where(post
                    => post.Title.Contains(searchQuery)
                    || post.Content.Contains(searchQuery));
        }

        public IEnumerable<Post> GetFilteredPosts(string searchQuery)
        {
            var normalized = searchQuery.ToLower();

            return GetAll().Where(post
                => post.Title.ToLower()
                .Contains(normalized)
                || post.Content.ToLower().Contains(normalized));
        }

        public IEnumerable<Post> GetLastestPosts(int nPosts)
        {
            return GetAll().OrderByDescending(post => post.Created).Take(nPosts);
        }

        public IEnumerable<Post> GetPostsByForum(int id)
        {
            return context.Forums.
            Where(forum => forum.Id == id)
            .First()
             .Posts.ToList();

        }
    }
}
