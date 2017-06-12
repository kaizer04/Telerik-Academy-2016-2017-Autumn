using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApiTester
{
   public class Supplier//introduced in order to show many to many relationship with book
    {
        private ICollection<Book> books;

        public Supplier(string name)
        {
            SupplierName = name;
            this.books = new HashSet<Book>();
        }

        public int SupplierId { get; set; }
        public string SupplierName { get; set; }

        public virtual ICollection<Book> Books
        {
            get { return books; }
            set { books = value; }
        }

    }
}
