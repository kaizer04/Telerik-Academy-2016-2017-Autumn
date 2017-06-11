using System.Collections.Generic;

namespace Ninjas.Models     
{
    public class Weapon
    {
        public Weapon()
        {
            this.Ninjas = new HashSet<Ninja>();
        }

        public int Id { get; set; }

        public string Name { get; set; }

        public double Damage { get; set; }

        public string Material { get; set; }

        public virtual ICollection<Ninja> Ninjas { get; set; }
    }
}