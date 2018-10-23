using System;

namespace pangu.Models
{
    public class Doctor: Persona
    {
        
        public string fecha{get; set;}
        public string horario {get; set;}
        public string tipoCita{get; set;}

        public int celular { get; set; }

        

    }
}