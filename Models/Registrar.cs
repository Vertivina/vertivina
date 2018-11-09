using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace vertivina.Models
{
    public class Registrar
    {
       /*  sss */
        public int ID { get; set; }

        [Required]
        public string names { get; set; }


        [Required]
        [EmailAddress]
        public string email { get; set; }

        [Required]
        [MinLength(8)]
        public string user { get; set; }

        [Required]
        public string pass { get; set; }

        [Required]
        public string pass2 { get; set; }

    }

}