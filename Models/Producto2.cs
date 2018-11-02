using System;
using System.ComponentModel.DataAnnotations;

namespace vertivina.Models
{
    public class Producto2
    {
        [Key]
        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Desc { get; set; }
        public string Tipo { get; set; }
        public double Precio { get; set; }
        public DateTime? Fecven { get; set; }
    }
}