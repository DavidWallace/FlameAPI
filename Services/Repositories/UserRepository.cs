
using System;
using FlameAPI.Model.Context;
using FlameAPI.Model.Entities;
using FlameAPI.Model;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlameAPI.Services.Repositories
{
    public class UserRepository : IUserRepository
    {
        private static EntityContext _context;

        public UserRepository(EntityContext context)
        {
            _context = context;
        }

        public IQueryable<Users> getUser(int userID)
        {
            return _context.Users.Where(d => d.id == userID);
        }
    }


}
