using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookStoreDatabase;
using Microsoft.Office.Interop.Excel;
using System.Data.Entity;
using dbtster.Migrations;

namespace dbtster
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BookStoreDbContext, Configuration>());
            using (var db = new BookStoreDbContext())
            {
                var publisher = new Publisher("Pesho");
                db.Publishers.Add(publisher);

                var genre = new Genre("fiction");
                db.AddGenre(genre);

                var book = new Book("Layla", "Pirsig");
                db.AddBook(book);
                db.SaveChanges();
            }

            Console.WriteLine("Commit");
        }
    }
}

