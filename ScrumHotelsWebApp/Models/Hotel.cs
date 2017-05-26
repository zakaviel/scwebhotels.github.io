using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ScrumHotelsWebApp.Models
{
    public class Hotel
    {
        [ScaffoldColumn(false)]
        public int hotelid { get; set; }

        [Required(ErrorMessage = "Un Hotel debe tener Ciudad")]
        [StringLength(160)]
        [DisplayName("Nombre del Hotel")]
        public string nombrehotel { get; set; }

        [Required(ErrorMessage = "Un Hotel debe tener Ciudad")]
        [StringLength(160)]
        [DisplayName("Ciudad")]
        public string ciudad { get; set; }

        [Required(ErrorMessage = "Un Hotel debe tener Distrito")]
        [StringLength(160)]
        [DisplayName("Distrito")]
        public string distrito { get; set; }

        [Required(ErrorMessage = "Un Hotel debe tener Descripcion")]
        [StringLength(160)]
        [DisplayName("Descripcion")]
        public string descripcion { get; set; }

        [Required(ErrorMessage = "Un Hotel debe tener Direccion")]
        [StringLength(160)]
        [DisplayName("Direccion")]
        public string direccion { get; set; }
        
        [Required(ErrorMessage = "Un Hotel debe tener un precio base.")]
        [Range(0.01, 100.00,ErrorMessage = "Price must be between 0.01 and 100.00")]
        public float precio { get; set; }

        public int estrellas { get; set; }

        [DisplayName("Foto del Hotel")]
        [StringLength(1024)]
        public string ImagenHoteltUrl { get; set; }

        

    }
}