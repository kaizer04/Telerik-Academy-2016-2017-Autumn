using Ninjas.Data.Migrations;
using Ninjas.Models;
using System.Data.Entity;

namespace Ninjas.Data
{
    public class NinjasDbContext:DbContext
    {
        public NinjasDbContext()
            :base("name=Test")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NinjasDbContext, Configuration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder
                .Entity<Ninja>()
                .HasMany(x => x.Weapons)
                .WithMany(x => x.Ninjas);
        }

        public IDbSet<Ninja> Ninjas { get; set; }
    }
}
