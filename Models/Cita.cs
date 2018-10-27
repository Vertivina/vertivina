using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace vertivina.Models
{
    public class Cita{
        public int ID{get; set;}
        [Required]
        [MinLength(4)]
        public string Nombre { get; set; }
        [Required]
        public string Mascota{get; set;}

        [Required]
        public int Telefono{get; set;}
        [Required]
        public string TipoTelefono{get; set;}

        public string Doctor{get; set;}
        [Required]
        [DisplayFormat(DataFormatString = "{0:yyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime Fecha{get; set;}

        public string Hora{ get; set; }


        public string TipoMascota{get; set;}
        public string TipoCita{get; set;}
        public string Direccion{get; set;}
        
    }
}