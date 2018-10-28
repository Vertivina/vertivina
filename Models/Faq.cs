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
    
    }
    
}