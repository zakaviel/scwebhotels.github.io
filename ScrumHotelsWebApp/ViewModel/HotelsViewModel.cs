using ScrumHotelsWebApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ScrumHotelsWebApp.ViewModel
{
    public class HotelsViewModel
    {
        public List<Hotel> ListaHoteles {get;set;}
        public float Precio { get; set; }
        public int estrellas { get;set; }
        public string ciudad { get; set; }
        public string distrito { get; set; }
        public HotelsViewModel()
        {
            ListaHoteles = null;
            Precio = 0;
            
        }
    }
}