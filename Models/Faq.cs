using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace vertivina.Models
{
    public class Faq
    {
        public int ID { get; set; }
        [Required]
        public string contactoNombre { get; set; }
        [Required]
        [EmailAddress]
        public string email { get; set; }
        [MinLength(10)]
        public string msj { get; set; }
        [Required]
        public string nombrePersonal {get;set;}
        [Required]
        public DateTime fechaInc { get;set;}
        [Required]
        public string respuesta{get;set;}
        [Required]
        public string solicito{get;set;}
        [Required]
        public string motivos{get;set;}
        [Required]
        public int tlf {get;set;}
        [Required]
        public string tipo { get;set;}
    
    }
    
}