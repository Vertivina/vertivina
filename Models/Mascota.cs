using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace vertivina.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        [Required]
        public string nombre {get; set;}
        [Required]
        public string tipoMascota {get; set;}

        public string imagen { get; set; }

        public Mascota(String nombre, String tipoMascota,String imagen){
            this.nombre = nombre;
            this.tipoMascota = tipoMascota;
            this.imagen=imagen;
        }
        
       
    }
}