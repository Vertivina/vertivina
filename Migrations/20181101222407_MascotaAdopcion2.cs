using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace vertivina.Migrations
{
    public partial class MascotaAdopcion2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Adopcion",
                table: "Adopcion");

            migrationBuilder.RenameTable(
                name: "Adopcion",
                newName: "Mascota");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Mascota",
                table: "Mascota",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Mascota",
                table: "Mascota");

            migrationBuilder.RenameTable(
                name: "Mascota",
                newName: "Adopcion");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Adopcion",
                table: "Adopcion",
                column: "Id");
        }
    }
}
