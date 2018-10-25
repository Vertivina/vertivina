using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace pangu.Models
{
    public class Contacto
    {
        [Required]
        public string Nombre { get; set; }
        
        [Required]
        public string Apellido{get; set;}

        [Required]
        [EmailAddress]
        public string Email { get; set; }
        
        [Required]
        public int Telefono { get; set; }

        [Required]
        public string Direccion { get; set; }

        [Required]
        public string Mensaje{get; set;}


    }
}