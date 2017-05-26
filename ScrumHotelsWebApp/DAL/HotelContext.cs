using ScrumHotelsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;


namespace ScrumHotelsWebApp.DAL
{
    public class HotelContext : DbContext
    {
       


        public HotelContext(): base("HotelContext")
        {

        }

        public DbSet<Hotel> Hotels { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}