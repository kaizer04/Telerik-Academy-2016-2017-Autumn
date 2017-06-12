using Ninject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIotwsqkude
{
    class Program
    {
        static void Main(string[] args)
        {
            IKernel kernel = new StandardKernel(new BuildingManagerModule());
            IEngine engine = kernel.Get<IEngine>();
            engine.Start();
        }
    }
}
