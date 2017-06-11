using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ninjas.Models
{
    public class Ninja
    {
        public Ninja()
        {
            this.Weapons = new HashSet<Weapon>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public NinjaType Type { get; set; }

        public bool IsFemale { get; set; }

        public virtual ICollection<Weapon> Weapons { get; set; }
    }
}
