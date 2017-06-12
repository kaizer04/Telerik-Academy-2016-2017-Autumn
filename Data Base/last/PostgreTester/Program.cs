using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PostgreTester
{
    [Table("pets", Schema = "public")]
    public class Pet
    {
        [Key]
        [Column("id")]
        public int ID { get; set; }
        [Column("name")]
        public string Name { get; set; }
    }
    public class DB : DbContext
    {
        public DB() : base("alabash1") { }
        public DbSet<Pet> Pets { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var db = new DB();

            var pet = new Pet { ID = 1, Name = "Stevie" };
            db.Pets.Add(pet);
            db.SaveChanges();

            var pets = db.Pets;
            foreach (var p in pets)
            {
                Console.WriteLine(p.Name);
            }
            Console.Read();

        }
    }
}
