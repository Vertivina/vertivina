using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace vertivina.Models
{
    public class Comunidad
    {
        public int ID{get; set;}

        public string Nombre{get; set;}

        public string Descripcion{get; set;}

    }
}
