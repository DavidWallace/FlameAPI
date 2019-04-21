using System;
using System.Linq;
using FlameAPI.Model.Context;
using FlameAPI.Model.Entities;

namespace FlameAPI.Services.Repositories
{
    public class PostsRepository : IPostsReporitory
    {

        private static EntityContext _context;

        public PostsRepository(EntityContext context)
        {
            _context = context;
        }

        public IQueryable<Posts> getPostsForUser(int userID)
        {
            return _context.Posts.Where(d => d.userID == userID).OrderBy(d => d.timestamp);
        }

        public IQueryable<Posts> getPostsForUserFeed(int userID)
        {
            return _context.Posts.Where(d => d.userID == userID).OrderBy(d => d.timestamp);
        }

        Func<bool> Save = () => { return (_context.SaveChanges() >= 0); };

        public Boolean insertPost(Posts post)
        {
            post.timestamp = DateTime.UtcNow.ToUniversalTime();
            _context.Posts.Add(post);
            return Save();
        }
    }
}
