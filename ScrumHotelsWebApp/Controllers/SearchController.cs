using ScrumHotelsWebApp.DAL;
using ScrumHotelsWebApp.Models;
using ScrumHotelsWebApp.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ScrumHotelsWebApp.Controllers
{
    public class SearchController : Controller
    {

        //HotelsEnitity hotelsDB = new HotelsEnitity();
        // GET: Search

        private HotelContext hotelsDB = new HotelContext();

        private List<Hotel> AllHotels(Decimal precio, int? estrellas, String Ciudad, String Distrito)
        {
            
            
            try
            {
                using (hotelsDB)
                {
                    return hotelsDB.Hotels.Where(x => x.precio <precio )
                                   .OrderBy(x => x.precio)
                                   .Select(x => new Hotel { ImagenHoteltUrl = x.ImagenHoteltUrl,
                                   nombrehotel = x.nombrehotel,
                                   hotelid = x.hotelid,
                                   ciudad = x.ciudad,
                                   distrito=x.distrito,
                                   direccion=x.direccion})
                                   .ToList();
                }
            }
            catch
            {
                return null;
            }
        }
        private List<Hotel> AllHotels(Decimal precio)
        {
            

            var hotels = new List<Hotel>
            {
                new Hotel { nombrehotel = "ThePunkyFunky",ciudad="Lima",precio=(decimal)5.56,distrito="Surco",direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif" },
                new Hotel { nombrehotel = "LePettite",ciudad="Lima",precio=(decimal)2.34,distrito="Surco",direccion="Encalada 123",ImagenHoteltUrl= "/Content/Images/placeholder.gif" }
            };


            try
            {
                using (hotelsDB)
                {
                    return hotelsDB.Hotels.Where(x => x.precio < precio)
                                   .OrderBy(x => x.precio)
                                   .Select(x => new Hotel
                                   {
                                       ImagenHoteltUrl = x.ImagenHoteltUrl,
                                       nombrehotel = x.nombrehotel,
                                       hotelid = x.hotelid,
                                       precio=x.precio,
                                       estrellas=x.estrellas,
                                       ciudad = x.ciudad,
                                       distrito = x.distrito,
                                       direccion = x.direccion
                                   })
                                   .ToList();
                }
            }
            catch
            {
                
                    return hotels.Where(x => x.precio < precio)
                                   .OrderBy(x => x.precio)
                                   .Select(x => new Hotel
                                   {
                                       ImagenHoteltUrl = x.ImagenHoteltUrl,
                                       nombrehotel = x.nombrehotel,
                                       hotelid = x.hotelid,
                                       ciudad = x.ciudad,
                                       precio = x.precio,
                                       estrellas = x.estrellas,
                                       distrito = x.distrito,
                                       direccion = x.direccion
                                   })
                                   .ToList();

        
            }
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Browse(Decimal price)
        {

            
            HotelsViewModel hotelviewmodel = new HotelsViewModel();
            hotelviewmodel.ListaHoteles = AllHotels(price);
            hotelviewmodel.Precio = price;
            
            return View(hotelviewmodel);
        }
        public ActionResult BrowseFiltered(Decimal precio,int? estrellas,String Ciudad,String Distrito)
        {
            // Retrieve Genre and its Associated Albums from database
          
            // Retrieve Genre and its Associated Albums from database
            var hotelsModel = hotelsDB.Hotels.Include("").Single(g => g.precio < precio);
           


            return View(hotelsModel);
        }

        // GET: Search/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Search/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Search/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Search/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Search/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Search/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Search/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
