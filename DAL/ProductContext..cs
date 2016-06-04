using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using armstrongkarate_.Models;

namespace armstrongkarate_.DAL 
{
    public class ProductContext : DbContext
    {

        public ProductContext() : base("ProductContext")
        {
        }

        public DbSet<product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
      

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}