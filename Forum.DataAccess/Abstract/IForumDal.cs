﻿using Forum.Entities;

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Forum.DataAccess.Abstract
{
    public interface IForumDal : IRepository<Forumm>
    {
        Forumm GetById(int id);
        IEnumerable<Forumm> GetAll();
        IEnumerable<ApplicationUser> GetActiveUsers(int id);

        Task Create(Forumm forum);
        Task Delete(int forumId);
        Task UpdateForumTitle(int forumId, string newTitle);
        Task UpdateForumDescription(int forumId, string newDescription);

        bool HasRecentPost(int id);
    }
}
