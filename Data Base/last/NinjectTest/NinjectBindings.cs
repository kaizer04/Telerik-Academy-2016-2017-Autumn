using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;

namespace NinjectTest
{
    public class NinjectBindings : NinjectModule
    {
        public override void Load()
        {
            Bind<IProduct>().To<DataLayer>();
        }
    }
}
