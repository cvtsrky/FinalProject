using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    //Context: Database tabloları ile proje classlarını bağlamak
    public class NorthwindContext:DbContext
    {
        //Sql servera bağlanmak için
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Northwind;Trusted_Connection=true"); //Sql servera nasıl bağlanacağını belirtmemiz yeterli
        }
        //Aşağıda tablo eşitlemeleri yapılıyor. Bizim product sınıfımız products tablosuna gibi.
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
    }
}
