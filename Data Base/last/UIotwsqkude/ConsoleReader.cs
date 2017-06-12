using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIotwsqkude
{
    class ConsoleReader:IReader
    {
        public string ReadLine()
        {
         return   Console.ReadLine();
        }

       
    }
}
