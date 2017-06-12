using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UIotwsqkude
{
    class ConsoleWriter : IWriter
    {
        public void WriteLine(string input)
        {
            Console.WriteLine(input);
        }

        public void WriteLine()
        {
            Console.WriteLine();
        }

    }
}
