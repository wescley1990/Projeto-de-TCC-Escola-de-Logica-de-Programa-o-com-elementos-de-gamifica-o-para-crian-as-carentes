using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Infra.Data.Migrations
{
    public partial class PopularCursos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var random = new Random();

            for (int i = 1; i <= 10; i++)
            {
                migrationBuilder.Sql("INSERT INTO Cursos(Id, Nome, Descricao, NivelCurso, Duracao)" +
                $"VALUES('{Guid.NewGuid().ToString()}', 'Teste{i}', 'Teste{i}', {random.Next(1, 3)}, {random.Next(150, 200)})");
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Cursos");
        }
    }
}
