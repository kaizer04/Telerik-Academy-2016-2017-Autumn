using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest
{
    class DataLayer : IProduct
    {
        public string InsertProduct()
        {
            string output = "Implementing Ninject";
            return output;
        }
    }
}
