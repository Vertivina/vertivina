using System;
using System.ComponentModel.DataAnnotations;

namespace vertivina.Models
{
    public class Mascota
    {
        public int Id { get; set; }
        [Required]
        public string nombre {get; set;}
        [Required]
        public string tipoMascota{get; set;}


        public Mascota(String nom, String tipM){
            nombre=nom;
            tipoMascota=tipM;
        }
        
        public Mascota(){
            
        }
    }
}