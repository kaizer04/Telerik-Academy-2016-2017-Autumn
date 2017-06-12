
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;


namespace ImportFromXMLFile
{
    class Program
    {
        static void Main(string[] args)
        {
            var doc = new XmlDocument();
            doc.Load("..\\..\\books.xml");
            var root = doc.DocumentElement;
            PrintChildren(root);
            var books =  ExtractBooksFromXml();
            foreach (Book book in books)
            {
                Console.WriteLine("title = {0},author = {1}",book.Title, book.Authorname  );
            }
        }

        private static List<Book> ExtractBooksFromXml()
        {
            XDocument xmlDoc = XDocument.Load("../../books.xml" );
            var books =
                from book in xmlDoc.Descendants("book")
                select new Book(book.Element("author").Value, 
                book.Element("title").Value);

            return books.ToList(); 
        }

        private static List<Book> GenerateListofBooksFromXmlFile()
        {
            List<Book> booklist = new List<Book>();
            XDocument xmlDoc = XDocument.Load("../../books.xml");
            
            foreach (XElement book in xmlDoc.Descendants("book"))
            {
                string title = book.Element("title").Value;
                string author = book.Element("author").Value;
                booklist.Add(new Book(author,title));
            }

            return booklist;
        }

        static void PrintChildren(XmlNode node, string indent = "")
        {
            Console.WriteLine(node.Name);
            foreach (XmlNode child in node.ChildNodes)
            {
                PrintChildren(child, indent + "--");
            }
        }
    }
}
