using System.Data.Entity;

using Forum.Models;

namespace Forum.Data
{
    public class ForumDbContext : DbContext
    {
        public ForumDbContext()
            : base("ForumDb")
        {
        }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<PostAnswer> PostAnswers { get; set; }

        public DbSet<Tag> Tags { get; set; }
    }
}
