using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Infra.Data.Migrations
{
    public partial class CreateMoreTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QtdMoedas",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<long>(
                name: "Xp",
                table: "AspNetUsers",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateTable(
                name: "Aulas",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(100)", nullable: false),
                    ContentUrl = table.Column<string>(type: "varchar(100)", nullable: false),
                    Xp = table.Column<int>(type: "int", nullable: false),
                    QtdMoedas = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Aulas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Exercicios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Enunciado = table.Column<string>(type: "varchar(100)", nullable: false),
                    AlternativaA = table.Column<string>(type: "varchar(100)", nullable: false),
                    AlternativaB = table.Column<string>(type: "varchar(100)", nullable: false),
                    AlternativaC = table.Column<string>(type: "varchar(100)", nullable: false),
                    AlternativaD = table.Column<string>(type: "varchar(100)", nullable: false),
                    Resposta = table.Column<string>(type: "varchar(100)", nullable: false),
                    Xp = table.Column<int>(type: "int", nullable: false),
                    QtdMoedas = table.Column<int>(type: "int", nullable: false),
                    AulaId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exercicios", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Exercicios_Aulas_AulaId",
                        column: x => x.AulaId,
                        principalTable: "Aulas",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Exercicios_AulaId",
                table: "Exercicios",
                column: "AulaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Exercicios");

            migrationBuilder.DropTable(
                name: "Aulas");

            migrationBuilder.DropColumn(
                name: "QtdMoedas",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Xp",
                table: "AspNetUsers");
        }
    }
}
