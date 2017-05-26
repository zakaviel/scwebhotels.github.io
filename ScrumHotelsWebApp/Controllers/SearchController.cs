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
        private List<Hotel> AllHotels(float precio, int estrellas, String Ciudad, String Distrito)
        {
            
            
            try
            {
                using (hotelsDB)
                {
                    var cmn = hotelsDB.Hotels.ToList().Where(v => v.precio <= precio);
                    cmn.OrderBy(v => v.precio);
                    List<Hotel> f1 = new List<Hotel>();
                    if (estrellas>=0)
                    {
                       f1= cmn.Where(x => x.estrellas <= estrellas).ToList();
                    }

                    

                    List<Hotel> f2 = new List<Hotel>();
                    if (Ciudad!="" &&Ciudad!=null)
                    {
                        foreach (var ele in f1)
                        {
                            if (String.Compare(ele.ciudad.ToUpper(), Ciudad.ToUpper()) == 0)
                            {
                                f2.Add(ele);
                            }
                        }
                        f2.OrderBy(v => v.precio);

                    }
                    else
                    {
                        f2 = f1;
                    }
                    List<Hotel> f3 = new List<Hotel>();
                    if (Distrito!=""&&Distrito!=null)
                    {
                        

                        foreach(var ele in f2)
                        {
                            if(ele.distrito.ToUpper().CompareTo(Distrito.ToUpper())==0)
                            { 
                            f3.Add(ele);
                            }
                        }
                        f3.OrderBy(v => v.precio);
                    }
                    else
                    {
                        f3 = f2;
                    }
                  



                    return f3;
                }
            }
            catch
            {
                return null;
            }
        }
        private List<Hotel> AllHotels(float precio)
        {
            

           try
            {
                using (hotelsDB)
                {
                    var cmn = hotelsDB.Hotels.ToList().Where(v=>v.precio<=precio);
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

        public ActionResult Browse(float? price,int? estrellas,string ciudad,string distrito)
        {

            HotelsViewModel hotelviewmodel = new HotelsViewModel();
           
            try
            {
                if (price.HasValue)
                {
                    if (estrellas.HasValue || ciudad != "" || distrito != "")
                    {
                        
                        hotelviewmodel.ListaHoteles = AllHotels(price.Value, estrellas.HasValue?estrellas.Value:5, ciudad, distrito);
                        hotelviewmodel.estrellas = estrellas.HasValue ? estrellas.Value : 5;
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

        public ActionResult BrowseFiltered(float precio,int? estrellas,String Ciudad,String Distrito)
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
