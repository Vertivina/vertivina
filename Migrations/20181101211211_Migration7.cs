using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace vertivina.Migrations
{
    public partial class Migration7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
