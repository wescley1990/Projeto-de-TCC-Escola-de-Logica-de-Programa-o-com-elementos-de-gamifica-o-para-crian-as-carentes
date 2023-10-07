using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Infra.Data.Migrations
{
    public partial class AjusteCurso : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QtdMoeda",
                table: "Cursos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Xp",
                table: "Cursos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<Guid>(
                name: "CursoId",
                table: "Aulas",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Aulas_CursoId",
                table: "Aulas",
                column: "CursoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Aulas_Cursos_CursoId",
                table: "Aulas",
                column: "CursoId",
                principalTable: "Cursos",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Aulas_Cursos_CursoId",
                table: "Aulas");

            migrationBuilder.DropIndex(
                name: "IX_Aulas_CursoId",
                table: "Aulas");

            migrationBuilder.DropColumn(
                name: "QtdMoeda",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "Xp",
                table: "Cursos");

            migrationBuilder.DropColumn(
                name: "CursoId",
                table: "Aulas");
        }
    }
}
