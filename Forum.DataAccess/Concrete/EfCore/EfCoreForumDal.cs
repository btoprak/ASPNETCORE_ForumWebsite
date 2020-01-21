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
    public class EfCoreForumDal : EfCoreGenericRepository<Forumm>, IForumDal
    {
        public EfCoreForumDal(ForumContext forumContext)
                : base(forumContext) { }
        public async Task Create(Forumm forum)
        {
            context.Add(forum);
            await context.SaveChangesAsync();
        }

        public async Task Delete(int forumId)
        {
            var forum = GetById(forumId);
            context.Remove(forum);
            await context.SaveChangesAsync();
        }

        public IEnumerable<Forumm> GetAll()
        {

            return context.Forums.Include(forum => forum.Posts).ToList();
        }

        public IEnumerable<ApplicationUser> GetActiveUsers(int id)
        {
            var posts = GetById(id).Posts;

            if (posts != null || !posts.Any())
            {
                var postUsers = posts.Select(p => p.User);
                var replyUsers = posts.SelectMany(p => p.Replies).Select(r => r.User);
                return postUsers.Union(replyUsers).Distinct();
            }
            return new List<ApplicationUser>();
        }

        public Forumm GetById(int id)
        {

            var forum = context.Forums.Where(f => f.Id == id)
                .Include(f => f.Posts)
                .ThenInclude(f => f.User)
                .Include(f => f.Posts)
                .ThenInclude(p => p.Replies)
                .ThenInclude(r => r.User)
                .FirstOrDefault();

            return forum;

        }

        public Task UpdateForumDescription(int forumId, string newDescription)
        {
            throw new NotImplementedException();
        }

        public Task UpdateForumTitle(int forumId, string newTitle)
        {
            throw new NotImplementedException();
        }

        public bool HasRecentPost(int id)
        {
            const int hoursAgo = 12;
            var window = DateTime.Now.AddHours(-hoursAgo);
            return GetById(id).Posts.Any(post => post.Created > window);
        }
    }
}
