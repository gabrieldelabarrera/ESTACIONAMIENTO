using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ESTACIONAMIENTO.Models;
using System.ComponentModel.DataAnnotations;

namespace ESTACIONAMIENTO.Models
{
    public class Auto
    {
        [Required(ErrorMessage = "Vehiculo no reconocido...")]
        public string Tarjeton { get; set; }
        public string Marca { get; set; }
        public int Modelo { get; set; }
        public string Color { get; set; }
        public string Placas { get; set; }
        public string Propietario { get; set; }
        public string PhotoPath { get; set; }
    }
}