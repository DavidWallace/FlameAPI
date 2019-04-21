using System;
using System.Linq;
using FlameAPI.Model.Entities;

namespace FlameAPI.Services.Repositories
{
    public interface IPostsReporitory
    {
         IQueryable<Posts> getPostsForUser(int userID);
        Boolean insertPost(Posts post);
    }
}
