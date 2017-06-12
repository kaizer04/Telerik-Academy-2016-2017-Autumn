using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Ninject;

namespace NinjectTest
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardKernel kernel = new StandardKernel();
            kernel.Load(Assembly.GetExecutingAssembly());
            IProduct objProduct1 = kernel.Get<IProduct>();
            BusinessLayer bl = new BusinessLayer(objProduct1);
            bl.Insert();
        }
    }
}
