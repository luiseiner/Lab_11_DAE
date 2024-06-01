﻿// <auto-generated />
using System;
using Lab_11.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab_11.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.20")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lab_11.Models.Customer", b =>
                {
                    b.Property<int>("IdCustomers")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCustomers"));

                    b.Property<string>("DocumentNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCustomers");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Lab_11.Models.Detail", b =>
                {
                    b.Property<int>("IdDetails")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdDetails"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("Invoices_IdInvoices")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("Products_IdProducts")
                        .HasColumnType("int");

                    b.Property<float>("SubTotal")
                        .HasColumnType("real");

                    b.HasKey("IdDetails");

                    b.HasIndex("Invoices_IdInvoices");

                    b.HasIndex("Products_IdProducts");

                    b.ToTable("Details");
                });

            modelBuilder.Entity("Lab_11.Models.Invoice", b =>
                {
                    b.Property<int>("IdInvoices")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdInvoices"));

                    b.Property<int>("Customers_IdCustomers")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("InvoiceNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Total")
                        .HasColumnType("real");

                    b.HasKey("IdInvoices");

                    b.HasIndex("Customers_IdCustomers");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("Lab_11.Models.Product", b =>
                {
                    b.Property<int>("IdProducts")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProducts"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("IdProducts");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Lab_11.Models.Detail", b =>
                {
                    b.HasOne("Lab_11.Models.Invoice", "Invoice")
                        .WithMany("Details")
                        .HasForeignKey("Invoices_IdInvoices")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Lab_11.Models.Product", "Product")
                        .WithMany("Details")
                        .HasForeignKey("Products_IdProducts")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Invoice");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Lab_11.Models.Invoice", b =>
                {
                    b.HasOne("Lab_11.Models.Customer", "Customer")
                        .WithMany("Invoices")
                        .HasForeignKey("Customers_IdCustomers")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Lab_11.Models.Customer", b =>
                {
                    b.Navigation("Invoices");
                });

            modelBuilder.Entity("Lab_11.Models.Invoice", b =>
                {
                    b.Navigation("Details");
                });

            modelBuilder.Entity("Lab_11.Models.Product", b =>
                {
                    b.Navigation("Details");
                });
#pragma warning restore 612, 618
        }
    }
}
