using Ninjas.Data;
using System;
using System.Linq;

namespace Ninjas.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new NinjasDbContext();

            Console.WriteLine(context.Ninjas.Count());
        }
    }
}
