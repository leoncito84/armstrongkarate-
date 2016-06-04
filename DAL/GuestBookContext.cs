using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using armstrongkarate_.Models;

namespace armstrongkarate_.DAL
{

public class GuestBookContext : DbContext
{
    public GuestBookContext() : base("GuestBookContext")
        {
        }

    public DbSet<Entry> Entries { get; set; }
        //Guestbook
    
    public DbSet<Customer> Customer { get; set; }
        //Customer ID - Auto
    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
    }

    }

}