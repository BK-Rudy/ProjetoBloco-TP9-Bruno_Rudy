using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SocialNetwork.Data.Migrations
{
    public partial class Correcao : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Profiles",
                newName: "PaisFundacao");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Profiles",
                newName: "Nome");

            migrationBuilder.AddColumn<string>(
                name: "Biografia",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CidadeFundacao",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "EstadoFundacao",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Fundacao",
                table: "Profiles",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Fundador",
                table: "Profiles",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "TotalFieis",
                table: "Profiles",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalIgrejas",
                table: "Profiles",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Biografia",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "CidadeFundacao",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "EstadoFundacao",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Fundacao",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "Fundador",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "TotalFieis",
                table: "Profiles");

            migrationBuilder.DropColumn(
                name: "TotalIgrejas",
                table: "Profiles");

            migrationBuilder.RenameColumn(
                name: "PaisFundacao",
                table: "Profiles",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "Nome",
                table: "Profiles",
                newName: "FirstName");
        }
    }
}
