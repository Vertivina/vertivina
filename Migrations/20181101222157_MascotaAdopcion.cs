using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace vertivina.Migrations
{
    public partial class MascotaAdopcion : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "tipo",
                table: "Producto2",
                newName: "Tipo");

            migrationBuilder.RenameColumn(
                name: "precio",
                table: "Producto2",
                newName: "Precio");

            migrationBuilder.RenameColumn(
                name: "nombre",
                table: "Producto2",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "fecven",
                table: "Producto2",
                newName: "Fecven");

            migrationBuilder.RenameColumn(
                name: "cantidad",
                table: "Producto2",
                newName: "Cantidad");

            migrationBuilder.RenameColumn(
                name: "descrip",
                table: "Producto2",
                newName: "Desc");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Producto2",
                newName: "Codigo");

            migrationBuilder.AddColumn<DateTime>(
                name: "fechaInc",
                table: "Faq",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "motivos",
                table: "Faq",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nombrePersonal",
                table: "Faq",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "respuesta",
                table: "Faq",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "solicito",
                table: "Faq",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "tipo",
                table: "Faq",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "tlf",
                table: "Faq",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Adopcion",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    nombre = table.Column<string>(nullable: false),
                    tipoMascota = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Adopcion", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Adopcion");

            migrationBuilder.DropColumn(
                name: "fechaInc",
                table: "Faq");

            migrationBuilder.DropColumn(
                name: "motivos",
                table: "Faq");

            migrationBuilder.DropColumn(
                name: "nombrePersonal",
                table: "Faq");

            migrationBuilder.DropColumn(
                name: "respuesta",
                table: "Faq");

            migrationBuilder.DropColumn(
                name: "solicito",
                table: "Faq");

            migrationBuilder.DropColumn(
                name: "tipo",
                table: "Faq");

            migrationBuilder.DropColumn(
                name: "tlf",
                table: "Faq");

            migrationBuilder.RenameColumn(
                name: "Tipo",
                table: "Producto2",
                newName: "tipo");

            migrationBuilder.RenameColumn(
                name: "Precio",
                table: "Producto2",
                newName: "precio");

            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Producto2",
                newName: "nombre");

            migrationBuilder.RenameColumn(
                name: "Fecven",
                table: "Producto2",
                newName: "fecven");

            migrationBuilder.RenameColumn(
                name: "Cantidad",
                table: "Producto2",
                newName: "cantidad");

            migrationBuilder.RenameColumn(
                name: "Desc",
                table: "Producto2",
                newName: "descrip");

            migrationBuilder.RenameColumn(
                name: "Codigo",
                table: "Producto2",
                newName: "ID");
        }
    }
}
