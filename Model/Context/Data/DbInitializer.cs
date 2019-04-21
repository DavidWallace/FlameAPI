using System;
using System.Linq;

namespace FlameAPI.Model.Context.Data
{
    public class DbInitializer
    {


        public static void Initialize(EntityContext context)
        {
            // Ensures database context exists
            context.Database.EnsureCreated();
        }
    }
}
