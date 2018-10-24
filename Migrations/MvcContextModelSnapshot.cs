﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Models.MvcContext;
using MySql.Data.EntityFrameworkCore.Storage.Internal;
using System;

namespace pangu.Migrations
{
    [DbContext(typeof(MvcContext))]
    partial class MvcContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.3-rtm-10026");

            modelBuilder.Entity("pangu.Models.Cita", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Direccion");

                    b.Property<string>("Doctor");

                    b.Property<DateTime>("Fecha");

                    b.Property<string>("Mascota")
                        .IsRequired();

                    b.Property<string>("Nombre")
                        .IsRequired();

                    b.Property<int>("Telefono");

                    b.Property<string>("TipoCita");

                    b.Property<string>("TipoMascota");

                    b.Property<string>("TipoTelefono");

                    b.HasKey("ID");

                    b.ToTable("Cita");
                });

            modelBuilder.Entity("pangu.Models.Producto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Nombre");

                    b.Property<double>("Precio");

                    b.Property<int>("Stock");

                    b.Property<string>("TipoProd");

                    b.HasKey("ID");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("pangu.Models.Servicio", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Celular");

                    b.Property<string>("Email");

                    b.Property<string>("Mensaje");

                    b.Property<string>("Nombre");

                    b.Property<double>("Precio");

                    b.HasKey("ID");

                    b.ToTable("Servicio");
                });
#pragma warning restore 612, 618
        }
    }
}
