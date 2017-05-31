using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace BookStoreDatabase
{
    public class Book
    {
        string authorName;
        string title;

        public Book(string authorname, string title)
        {
            authorName = authorname;
            title = title;
        }

        public string Authorname 
        {
            get
            {
                return authorName;
            }
            set
            {
                authorName = value;
            }
        }

        public string Title
        {
            get { return title; }
            set { title = value;}
        }
    }


}
