using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace vertivina.Models
{
    public class Comunidad
    {
        public int ID{get; set;}
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
