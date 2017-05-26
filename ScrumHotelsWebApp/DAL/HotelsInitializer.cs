using ScrumHotelsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace ScrumHotelsWebApp.DAL
{
    public class HotelsInitializer : DropCreateDatabaseIfModelChanges<HotelContext>
    {
        // GET: HotelsInitializer
        protected override void Seed(HotelContext context)
        {
            var hotels = new List<Hotel>
            {
                new Hotel { nombrehotel = "ThePunkyFunky",ciudad="Lima",distrito="Surco",estrellas=3,precio=(decimal)2.95,direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif" },
                new Hotel { nombrehotel = "LePettite",ciudad="Lima",distrito="Surco",estrellas=2,precio=(decimal)99.95,direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif" },
                new Hotel { nombrehotel = "Lebon",ciudad="Lima",distrito="Surco",estrellas=5,precio=(decimal)52.95,direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif" }
            };
            hotels.ForEach(s => context.Hotels.Add(s));
            context.SaveChanges();

        }
    }
}