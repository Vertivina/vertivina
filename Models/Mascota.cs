using System;

namespace vertivina.Models
{
    public class Mascota
    {
        public string nombre {get; set;}
        
        public string tipoMascota{get; set;}


        public Mascota(String nom, String tipM){
            nombre=nom;
            tipoMascota=tipM;
        }
        
        public Mascota(){
            
        }
    }
}