using Ninjas.Models;
using System.Data.Entity;

namespace Ninjas.Data
{
    public class NinjasDbContext:DbContext
    {
        public NinjasDbContext()
            :base("name=Test")
        {
                
        }

        public IDbSet<Ninja> Ninjas { get; set; }
    }
}
