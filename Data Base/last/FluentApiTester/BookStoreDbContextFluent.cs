using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FluentApiTester
{
    class BookStoreDbContextFluent : DbContext
    {
        public BookStoreDbContextFluent():base("BookStoreDbFluent")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            // Configure PublisherId as PK for PublisherAddress
            modelBuilder.Entity<PublisherAddress>()
                .HasKey(e => e.PublisherId);

            // Configure PublisherId as FK for PublisherAddress
            modelBuilder.Entity<Publisher>()
                        .HasRequired(s => s.Address)
                        .WithRequiredPrincipal(ad => ad.Publisherp);

            modelBuilder.Entity<Book>()
                .HasMany<Supplier>(s => s.Suppliers)
                .WithMany(c => c.Books)
                .Map(cs =>
                {
                    cs.MapLeftKey("RefId");
                    cs.MapRightKey("SupplierRefId");
                    cs.ToTable("BookSuppliers");
                });


        }

        public DbSet<Supplier> SSuppliers { get; set;}
        public DbSet<PublisherAddress> PublisherAddresses { get; set; }
        public DbSet<Book> BBooks { get; set; }
        public DbSet<Genre> Genres { get; set; }

        public DbSet<Publisher> Publishers { get; set; }

        public void AddPublisher(Publisher publisher)
        {
            Publishers.Add(publisher);
        }

        public void AddPublisherAddress(PublisherAddress publisherAddress)
        {
            PublisherAddresses.Add(publisherAddress);
        }

        public void AddGenre(Genre g)
        {
            Genres.Add(g);
        }

        public void AddBook(Book b)
        {
            BBooks.Add(b);
        }

        public void AddSuplier(Supplier supplier)
        {
            SSuppliers.Add(supplier);
        }
    }

}
