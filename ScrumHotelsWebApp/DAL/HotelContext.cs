using ScrumHotelsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace ScrumHotelsWebApp.DAL
{
    public class HotelContext : DbContext
    {
        public DbSet<Hotel> Hotels { get; set; }


        public HotelContext()
        : base("HotelContext")
    {
        }
        
    }
}