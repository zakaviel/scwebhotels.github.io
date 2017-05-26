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
        private List<Hotel> AllHotels()
        {


            try
            {
                using (hotelsDB)
                {
                    var cmn = hotelsDB.Hotels.ToList();
                    cmn.OrderBy(v => v.precio);
                    return cmn.ToList();
                }
            }
            catch
            {
                return null;
            }
        }
        private List<Hotel> AllHotels(Decimal precio, int estrellas, String Ciudad, String Distrito)
        {
            
            
            try
            {
                using (hotelsDB)
                {
                    var cmn = hotelsDB.Hotels.ToList().Where(v => v.precio < precio).Where(x=>x.estrellas==estrellas).Where(x=>x.ciudad==Ciudad).Where(x=>x.distrito==Distrito);
                    cmn.OrderBy(v => v.precio);
                    return cmn.ToList();
                }
            }
            catch
            {
                return null;
            }
        }
        private List<Hotel> AllHotels(Decimal precio)
        {
            

           try
            {
                using (hotelsDB)
                {
                    var cmn = hotelsDB.Hotels.ToList().Where(v=>v.precio<precio);
                    cmn.OrderBy(v => v.precio);
                    return cmn.ToList();
                    //return hotelsDB.Hotels.Where(x => x.precio < precio)
                    //               .OrderBy(x => x.precio)
                    //               .Select(x => new Hotel
                    //               {
                    //                   ImagenHoteltUrl = x.ImagenHoteltUrl,
                    //                   nombrehotel = x.nombrehotel,
                    //                   hotelid = x.hotelid,
                    //                   precio=x.precio,
                    //                   estrellas=x.estrellas,
                    //                   ciudad = x.ciudad,
                    //                   distrito = x.distrito,
                    //                   direccion = x.direccion
                    //               })
                    //               .ToList();
                }
            }
            catch
            {

                return null;

        
            }
        }
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Browse(decimal? price,int? estrellas,string ciudad,string distrito)
        {

            HotelsViewModel hotelviewmodel = new HotelsViewModel();
           
            try
            {
                if (price.HasValue)
                {
                    if (estrellas.HasValue && ciudad != "" && distrito != "")
                    {
                        hotelviewmodel.ListaHoteles = AllHotels(price.Value, estrellas.Value, ciudad, distrito);
                        hotelviewmodel.estrellas = estrellas.Value;
                        hotelviewmodel.ciudad = ciudad;
                        hotelviewmodel.distrito = distrito;

                    }
                    else
                    {
                        hotelviewmodel.ListaHoteles = AllHotels(price.Value);
                    }
                }
                else
                {
                    hotelviewmodel.ListaHoteles = AllHotels();
                }



                hotelviewmodel.Precio = price.Value;

                return View(hotelviewmodel);
            }
            catch
            {

                return View(hotelviewmodel);
            }
            
           

           


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
