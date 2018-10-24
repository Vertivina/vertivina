using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace pangu.Migrations
{
    public partial class Mejora3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Hora",
                table: "Cita",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Hora",
                table: "Cita");
        }
    }
}
