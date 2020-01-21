using Forum.DataAccess.Abstract;
using Forum.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forum.DataAccess.Concrete.EfCore
{
    public class EfCoreApplicationUserDal : EfCoreGenericRepository<ApplicationUser>, IApplicationUserDal
    {
        public EfCoreApplicationUserDal(ForumContext forumContext)
                : base(forumContext) { }

        public IEnumerable<ApplicationUser> GetAll()
        {
            return context.User;
        }

        public ApplicationUser GetById(string id)
        {
            return GetAll().FirstOrDefault(user => user.Id == id);
        }

        public async Task IncrementRating(string id, Type type)
        {
            var user = GetById(id);
            var newRating = CalculateUserRating(type, user.Rating);
            user.Rating += newRating;
            await context.SaveChangesAsync();
        }

        private int CalculateUserRating(Type type, int userRating)
        {
            var inc = 0;
            if (type == typeof(Post))
            {
                inc = 1;
            }

            if (type == typeof(PostReply))
            {
                inc = 3;
            }
            return userRating = inc;
        }

        public async Task SetProfileImage(string id, Uri uri)
        {
            var user = GetById(id);

            user.ProfileImageUrl = uri.AbsoluteUri;
            context.Update(user);

            await context.SaveChangesAsync();
        }
    }
}
