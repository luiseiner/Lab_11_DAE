using Microsoft.EntityFrameworkCore;

namespace Lab_11.Models
{
    public class ApplicationDbContext:DbContext
    {

        

        public DbSet<Customer> Customers { get; set; }
        public DbSet<Invoice> Invoices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Detail> Details { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) 
        {
            optionsBuilder.UseSqlServer("Server = LAB1504-10\\SQLEXPRESS;Initial Catalog=Code_First;User Id=Luis; Password = 123456; trustservercertificate = True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                .HasKey(c => c.IdCustomers);

            modelBuilder.Entity<Invoice>()
                .HasKey(i => i.IdInvoices);
            modelBuilder.Entity<Invoice>()
                .HasOne(i => i.Customer)
                .WithMany(c => c.Invoices)
                .HasForeignKey(i => i.Customers_IdCustomers);

            modelBuilder.Entity<Product>()
                .HasKey(p => p.IdProducts);

            modelBuilder.Entity<Detail>()
                .HasKey(d => d.IdDetails);
            modelBuilder.Entity<Detail>()
                .HasOne(d => d.Product)
                .WithMany(p => p.Details)
                .HasForeignKey(d => d.Products_IdProducts);
            modelBuilder.Entity<Detail>()
                .HasOne(d => d.Invoice)
                .WithMany(i => i.Details)
                .HasForeignKey(d => d.Invoices_IdInvoices);
        }
    }
}
