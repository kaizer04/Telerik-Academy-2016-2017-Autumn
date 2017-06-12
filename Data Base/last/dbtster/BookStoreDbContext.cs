using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BookStoreDatabase;

namespace dbtster
{
   public class BookStoreDbContext:DbContext
    {
        public BookStoreDbContext():base("BookStoreDb")
        {
                
        }
        public DbSet<Book> BBooks { get; set; }
        public DbSet<Genre>Genres { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

       public void AddGenre(Genre g)
       {
           Genres.Add(g);
       }

       public void AddBook(Book b)
       {
           BBooks.Add(b);
       }

    }
}
