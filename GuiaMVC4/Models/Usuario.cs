using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GuiaMVC4.Models
{
    public class Usuario
    {
        public string Mensaje { get; set; }        
        public DateTime FechaAlta { get; set; }
        public string Vista { get; set; }
        public List<Ciudad> ListaCiudades { get; set; }        
    }

    public class Ciudad
    { 
        public Ciudad(string city)
        {
            ciudad = city;  
        }
        public string ciudad { get; set; }             
    }
}