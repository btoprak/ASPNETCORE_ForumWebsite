using Forum.Business.Abstract;
using Forum.DataAccess.Abstract;
using Forum.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Forum.Business.Concrete
{
    public class ApplicationUserManager : IApplicationUserService
    {

        private IApplicationUserDal _applicationUserDal;

        public ApplicationUserManager(IApplicationUserDal applicationUserDal)
        {
            _applicationUserDal = applicationUserDal;
        }
        public IEnumerable<ApplicationUser> GetAll()
        {
            return _applicationUserDal.GetAll();
        }

        public ApplicationUser GetById(string id)
        {
            return _applicationUserDal.GetById(id);
        }

        public Task IncrementRating(string id, Type type)
        {
            return _applicationUserDal.IncrementRating(id, type);
        }

        public Task SetProfileImage(string id, Uri uri)
        {
            return _applicationUserDal.SetProfileImage(id, uri);
        }

        public void Update(ApplicationUser entity)
        {
            _applicationUserDal.Update(entity);
        }
    }
}
