using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Infra.Data.Migrations
{
    public partial class userCustomFields : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "NivelXp",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Sobrenome",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "AspNetUsers",
                type: "varchar(250)",
                maxLength: 250,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(100)",
                oldNullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Nome",
                table: "AspNetUsers",
                type: "varchar(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NivelXp",
                table: "AspNetUsers",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Sobrenome",
                table: "AspNetUsers",
                type: "varchar(100)",
                nullable: true);
        }
    }
}
