using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.DataAccess.Abstract
{
    public interface IRepository<T> where T : class
    {
        void Update(T entity);
    }
}
