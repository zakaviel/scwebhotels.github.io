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


            var hotels2 = new List<Hotel>
            {

                new Hotel { nombrehotel = "ThePunkyFunky",ciudad="Lima",distrito="Surco",estrellas=3,precio=(float)2.95,direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif",descripcion="sdfds"},
                new Hotel { nombrehotel = "LePettite",ciudad="Lima",distrito="Surco",estrellas=2,precio=(float)99.95,direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif",descripcion="ds"},
                new Hotel { nombrehotel = "Lebon",ciudad="Lima",distrito="Ate",estrellas=5,precio=(float)52.95,direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif",descripcion="sdsd"},
                new Hotel { nombrehotel = "Leboned",ciudad="Lima",distrito="Callao",estrellas=2,precio=(float)35.95,direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif",descripcion="sdsd"},
                new Hotel { nombrehotel = "Boned",ciudad="Lima",distrito="Surquuillo",estrellas=5,precio=(float)72.95,direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif",descripcion="sdsd"},
                new Hotel { nombrehotel = "Lebon",ciudad="Lima",distrito="VillaMaria",estrellas=5,precio=(float)62.95,direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif",descripcion="sdsd"}
                //,new Hotel { nombrehotel = "Lebon",ciudad="Lima",distrito="Barranco",estrellas=5,precio=(float)150.95,direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif",descripcion="sdsd"},
                //new Hotel { nombrehotel = "Lebon",ciudad="Lima",distrito="Chorrillos",estrellas=5,precio=(float)200.95,direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif",descripcion="sdsd"},
                //new Hotel { nombrehotel = "Wolol",ciudad="Lima",distrito="Ate",estrellas=5,precio=(float)100.95,direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif",descripcion="sdsd"},
                //new Hotel { nombrehotel = "Helliun",ciudad="Lima",distrito="Surco",estrellas=5,precio=(float)85.95,direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif",descripcion="sdsd"},
                //new Hotel { nombrehotel = "Alborn",ciudad="Lima",distrito="Surquillo",estrellas=5,precio=(float)45.95,direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif",descripcion="sdsd"},
                //new Hotel { nombrehotel = "HighBorn",ciudad="Lima",distrito="Callao",estrellas=5,precio=(float)35.95,direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif",descripcion="sdsd"},
                //new Hotel { nombrehotel = "EluneAnote",ciudad="Lima",distrito="VillaelSalvador",estrellas=5,precio=(float)25.95,direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif",descripcion="sdsd"},
                //new Hotel { nombrehotel = "Vatrois",ciudad="Lima",distrito="VillaMaria",estrellas=5,precio=(float)5.95,direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif",descripcion="sdsd"},
                //new Hotel { nombrehotel = "MoiLeJus",ciudad="Lima",distrito="Surquillo",estrellas=5,precio=(float)10.95,direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif",descripcion="sdsd"},
                //new Hotel { nombrehotel = "Joene",ciudad="Lima",distrito="Surquillo",estrellas=5,precio=(float)15.95,direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif",descripcion="sdsd"},
                //new Hotel { nombrehotel = "Leker",ciudad="Lima",distrito="Ate",estrellas=5,precio=(float)200.95,direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif",descripcion="sdsd"},
                //new Hotel { nombrehotel = "Paras",ciudad="Lima",distrito="Callao",estrellas=5,precio=(float)152.95,direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif",descripcion="sdsd"},
                //new Hotel { nombrehotel = "WEll",ciudad="Lima",distrito="Callao",estrellas=5,precio=(float)352.95,direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif",descripcion="sdsd"},
                //new Hotel { nombrehotel = "Done",ciudad="Lima",distrito="Surco",estrellas=5,precio=(float)252.95,direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif",descripcion="sdsd"}
            };


            hotels2.ForEach(s => context.Hotels.Add(s));
            
            context.SaveChanges();

        }
    }
}