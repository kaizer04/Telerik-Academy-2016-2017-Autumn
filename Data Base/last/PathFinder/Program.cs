using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            GetRelativePath();
        }

        private static void GetRelativePath()
        {
            Uri file = new Uri(@"c:\foo\bar\blop\blap.txt");
            // Must end in a slash to indicate folder
            Uri folder = new Uri(@"c:\foo\bar\");
            string relativePath =
                Uri.UnescapeDataString(
                    folder.MakeRelativeUri(file)
                        .ToString()
                        .Replace('/', Path.DirectorySeparatorChar)
                    );
            Console.WriteLine(relativePath);
        }
    }
}
