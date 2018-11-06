using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vertivina.Models
{
    public class Producto2
    {
        //[Key]
        //[Column(Order=0)]
        public int Id { get; set; }
        //[Key]
        //[Column(Order=0)]
        public string Nombre { get; set; }
        public int Cantidad { get; set; }
        public string Desc { get; set; }
        public string Tipo { get; set; }
        public double Precio { get; set; }

        public string Imagen { get; set; }
        public DateTime? Fecven { get; set; }
    }
}