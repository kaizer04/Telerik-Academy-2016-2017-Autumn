using System.Data.Entity;

using Forum.Data;
using Forum.Data.Migrations;

namespace Forum.ConsoleClient
{
    public class Program
    {
        public static void Main()
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<ForumDbContext, Configuration>());

            var dbContext = new ForumDbContext();
            
            dbContext.Database.CreateIfNotExists();
        }
    }
}
