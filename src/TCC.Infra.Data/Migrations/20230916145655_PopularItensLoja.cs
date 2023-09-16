using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCC.Infra.Data.Migrations
{
    public partial class PopularItensLoja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            var random = new Random();

            for (int i = 1; i <= 10; i++)
            {
                migrationBuilder.Sql("INSERT INTO Itens(Id, Nome, ImagemUrl, Preco, ValidadeInicio, ValidadeFim)" +
                $"VALUES('{Guid.NewGuid()}', 'Teste{i}', 'Teste{i}.jpg', {random.Next(1, 3)}, '2023-03-30 07:16:45.1', '2023-03-30 07:16:45.1')");
            }
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Itens");
        }
    }
}
