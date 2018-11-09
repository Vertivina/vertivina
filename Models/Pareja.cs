using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace vertivina.Models
{
    public class Pareja
    {
        public int ID { get; set; }


        [Required]
        [MinLength(20)]
        public string NombreDueño { get; set; }
        [Required]
        public string Mascota { get; set; }

        [Required]
        public string NombreMascota { get; set; }

        [Required]
        public string Parejas { get; set; }

        

        [Required]
        public int Telefono { get; set; }


        public string TipoTelefono { get; set; }

        [Required]
        [EmailAddress]
        public string email { get; set; }

       
        [Required]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Fecha { get; set; }

        public string Direccion { get; set; }

        public string Motivo1 { get; set; }
        public string Motivo2 { get; set; }

        public string Solicito{ get; set; }

    }
}