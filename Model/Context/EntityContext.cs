using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FlameAPI.Model.Entities;

namespace FlameAPI.Model.Context
{
    public class EntityContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        public DbSet<Posts> Posts { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Samples> Samples { get; set; }
        public DbSet<StepSequencer> StepSequencer { get; set; }
        public DbSet<Projects> Projects { get; set; }


        public EntityContext(DbContextOptions<EntityContext> options) : base(options)
        {
           
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                throw new ArgumentException($"'DbContextOptionsBuilder' not configured'");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Users>().ToTable("users");
            modelBuilder.Entity<Posts>().ToTable("posts");
            modelBuilder.Entity<Comments>().ToTable("comments");
            modelBuilder.Entity<Samples>().ToTable("samples");
            modelBuilder.Entity<StepSequencer>().ToTable("stepSequence");
            modelBuilder.Entity<Projects>().ToTable("projects");
        }
    }
}
