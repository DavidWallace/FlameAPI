using System;
using System.Linq;
using FlameAPI.Model.Entities;

namespace FlameAPI.Services.Repositories
{
    public interface IUserRepository
    {
        IQueryable<Users> getUser(int userID);
    }
}
