using Forum.Business.Abstract;
using Forum.DataAccess.Abstract;
using Forum.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Business.Concrete
{
    public class PostManager : IPostService
    {
        IPostDal _postDal;
        public PostManager(IPostDal postDal)
        {
            _postDal = postDal;
        }
        public Task Add(Post post)
        {
            return _postDal.Add(post);
        }

        public Task AddReply(PostReply reply)
        {
            return _postDal.AddReply(reply);
        }

        public Task Delete(int id)
        {
            return _postDal.Delete(id);
        }

        public Task EditPostContent(int id, string newContent)
        {
            return _postDal.EditPostContent(id, newContent);
        }

        public IEnumerable<Post> GetAll()
        {
            return _postDal.GetAll();
        }

        public Post GetById(int id)
        {
            return _postDal.GetById(id);
        }

        public IEnumerable<Post> GetFilteredPosts(Forumm forum, string searchQuery)
        {
            return _postDal.GetFilteredPosts(forum, searchQuery);
        }

        public IEnumerable<Post> GetFilteredPosts(string searchQuery)
        {
            return _postDal.GetFilteredPosts(searchQuery);
        }

        public IEnumerable<Post> GetLastestPosts(int nPosts)
        {
            return _postDal.GetLastestPosts(nPosts);
        }

        public IEnumerable<Post> GetPostsByForum(int id)
        {
            return _postDal.GetPostsByForum(id);
        }
    }
}
