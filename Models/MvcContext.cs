using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using MySql.Data.EntityFrameworkCore.Extensions;

namespace Models.MvcContext
{
    public class MvcContext: DbContext{
        public MvcContext(DbContextOptions<MvcContext> options) : base(options){

        }

        public DbSet<vertivina.Models.Cita> Cita{get; set;}

        public DbSet<vertivina.Models.Producto> Producto{get; set;}
         
        public DbSet<vertivina.Models.Servicio> Servicio{get; set;}

        public DbSet<vertivina.Models.Contacto> Contacto{get; set;}
        public DbSet<vertivina.Models.Producto2> Producto2{get; set;}
         public DbSet<vertivina.Models.Faq> Faq{get; set;}
    }


}
