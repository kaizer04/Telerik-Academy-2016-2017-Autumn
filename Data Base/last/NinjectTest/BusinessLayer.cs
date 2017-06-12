using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NinjectTest
{
    class BusinessLayer
    {
        IProduct objectIProduct;

        /// <summary>
        /// injecting data layer
        /// </summary>
        /// <param name="oProduct"></param>
        public BusinessLayer(IProduct oProduct)
        {
            objectIProduct = oProduct;
        }

        public void Insert()
        {
            ////calling method of data layer
            Console.WriteLine( objectIProduct.InsertProduct());
        }
    }
}
