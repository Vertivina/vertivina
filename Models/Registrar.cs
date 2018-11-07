using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace vertivina.Models
{
    public class Registrar
    {
       /*  s */
        public int ID { get; set; }

        [Required]
        public string names { get; set; }


        [Required]
        [EmailAddress]
        public string email { get; set; }

        [MinLength(12)]
        public string user { get; set; }

        [Required]
        public string pass { get; set; }

        [Required]
        public string pass2 { get; set; }

    }

}