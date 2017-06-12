using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentApiTester.Migrations;

namespace FluentApiTester
{
    class Program
    {
        static void Main(string[] args)
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<BookStoreDbContextFluent, Configuration>());
            using (var db = new BookStoreDbContextFluent())
            {
                var publisherAddress = new PublisherAddress("41 Vassil Levski st", "Sofia", 1100, "Bulgaria");
                var publisher = new Publisher("Pesho");

                publisher.Address = publisherAddress;
                publisherAddress.Publisherp = publisher;

                db.AddPublisher(publisher);
                db.AddPublisherAddress(publisherAddress);

                var genre = new Genre("fiction");
                db.AddGenre(genre);
                
                var supplier=new Supplier("Wizard");
                db.AddSuplier(supplier);

                var book = new Book("Layla", "Pirsig");
                db.AddBook(book);

                db.SaveChanges();
            }

            Console.WriteLine("Success....");
        }
    }
}
