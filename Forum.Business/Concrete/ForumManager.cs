using Forum.Business.Abstract;
using Forum.DataAccess.Abstract;
using Forum.Entities;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Business.Concrete
{
    public class ForumManager : IForumService
    {
        private IForumDal _forumDal;
        public ForumManager(IForumDal forumDal)
        {
            _forumDal = forumDal;
        }

        public Task Create(Forumm forum)
        {
            return _forumDal.Create(forum);
        }

        public Task Delete(int forumId)
        {
            return _forumDal.Delete(forumId);
        }

        public IEnumerable<Forumm> GetAll()
        {
            return _forumDal.GetAll();
        }

        public IEnumerable<ApplicationUser> GetActiveUsers(int id)
        {
            return _forumDal.GetActiveUsers(id);
        }

        public Forumm GetById(int id)
        {
            return _forumDal.GetById(id);
        }

        public Task UpdateForumDescription(int forumId, string newDescription)
        {
            return _forumDal.UpdateForumDescription(forumId, newDescription);
        }

        public Task UpdateForumTitle(int forumId, string newTitle)
        {
            return _forumDal.UpdateForumTitle(forumId, newTitle);
        }

        public bool HasRecentPost(int id)
        {
            return _forumDal.HasRecentPost(id);
        }
    }
}
