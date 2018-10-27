using System;
using System.ComponentModel.DataAnnotations;

namespace vertivina.Models
{
    public class Doctor: Persona
    {
        
        public DateTime? fecha{get; set;}
        [Required]
        public string horario {get; set;}
        [Required]
        public string tipoCita{get; set;}
        [Required]
        [MaxLength(9)]
        [MinLength(9)]
        public int celular { get; set; }

        

    }
}