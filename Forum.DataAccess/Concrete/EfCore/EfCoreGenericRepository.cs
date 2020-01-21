using Forum.DataAccess.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.DataAccess.Concrete.EfCore
{
    public class EfCoreGenericRepository<TEntity> : IRepository<TEntity>
        where TEntity : class
    {
        internal ForumContext context;
        internal DbSet<TEntity> dbSet;

        public EfCoreGenericRepository(ForumContext context)
        {
            this.context = context;
            this.dbSet = context.Set<TEntity>();
        }

        public void Update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }
    }
}
