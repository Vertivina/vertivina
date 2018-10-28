using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace vertivina.Migrations
{
    public partial class Migration5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "TipoTelefono",
                table: "Cita",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.CreateTable(
                name: "Faq",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    contactoNombre = table.Column<string>(nullable: false),
                    email = table.Column<string>(nullable: false),
                    msj = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faq", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Producto2",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    cantidad = table.Column<int>(nullable: false),
                    descrip = table.Column<string>(nullable: true),
                    fecven = table.Column<DateTime>(nullable: true),
                    nombre = table.Column<string>(nullable: true),
                    precio = table.Column<double>(nullable: false),
                    tipo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producto2", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faq");

            migrationBuilder.DropTable(
                name: "Producto2");

            migrationBuilder.AlterColumn<string>(
                name: "TipoTelefono",
                table: "Cita",
                nullable: true,
                oldClrType: typeof(string));
        }
    }
}
