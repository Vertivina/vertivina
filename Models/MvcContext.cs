using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MySql.Data.EntityFrameworkCore.Extensions;
using vertivina.Models;

namespace Models.MvcContext
{
    public class MvcContext : DbContext
    {
        public MvcContext(DbContextOptions<MvcContext> options) : base(options)
        {

        }

        #region CodigoAaron;
        private List<Producto2> datos= new List<Producto2>();



         //public List<Producto2> Listar() {
           // return datos;
        //}
            


        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        base.OnModelCreating(modelBuilder);
        
            modelBuilder.Entity<Producto2>().HasData(
                    new Producto2
                    {

                        Codigo = 1,
                        Nombre = "Producto 1",
                        Cantidad = 15,
                        Desc = "Articulo para tu cachorro",
                        Tipo = "Correa",
                        Precio = 150.00
                    },
                    new Producto2
                    {
                        Codigo = 2,
                        Nombre = "Producto 2",
                        Cantidad = 15,
                        Desc = "Articulo para tu cachorro",
                        Tipo = "Correa",
                        Precio = 150.00
                    },
                    new Producto2
                    {

                        Codigo = 3,
                        Nombre = "Producto 3",
                        Cantidad = 15,
                        Desc = "Articulo para tu cachorro",
                        Tipo = "Correa",
                        Precio = 150.00
                    }
                );} 

    -- Insertar datos 2
                 public void Configure(EntityTypeBuilder<Producto2> builder){
                    builder.HasKey(u => u.Codigo);
                    builder.HasData(
                        new Producto2
                    {

                        Codigo = 1,
                        Nombre = "Producto 1",
                        Cantidad = 15,
                        Desc = "Articulo para tu cachorro",
                        Tipo = "Correa",
                        Precio = 150.00
                    },
                    new Producto2
                    {
                        Codigo = 2,
                        Nombre = "Producto 2",
                        Cantidad = 15,
                        Desc = "Articulo para tu cachorro",
                        Tipo = "Correa",
                        Precio = 150.00
                    },
                    new Producto2
                    {

                        Codigo = 3,
                        Nombre = "Producto 3",
                        Cantidad = 15,
                        Desc = "Articulo para tu cachorro",
                        Tipo = "Correa",
                        Precio = 150.00
                    }
                );
                }*/

    

        public DbSet<Cita> Cita { get; set; }

        public DbSet<Producto> Producto { get; set; }

        public DbSet<Servicio> Servicio { get; set; }

        public DbSet<Contacto> Contacto { get; set; }
        public DbSet<Producto2> Producto2 { get; set; }
        public DbSet<Faq> Faq { get; set; }
        public DbSet<Mascota> Mascota{ get; set; }
        
    }
    #endregion
}