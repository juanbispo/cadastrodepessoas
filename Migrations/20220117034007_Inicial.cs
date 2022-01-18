using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CadastroDePessoas.Migrations
{
    public partial class Inicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pessoas",
                columns: table => new
                {
                    PessoaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    Sobrenome = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    DataNascimento = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Endereco1 = table.Column<string>(type: "nvarchar(80)", nullable: false),
                    Endereco2 = table.Column<string>(type: "nvarchar(80)", nullable: false),
                    Cidade = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Estado = table.Column<string>(type: "nvarchar(20)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(50)", nullable: false),
                    Telefone = table.Column<string>(type: "nvarchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pessoas", x => x.PessoaId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pessoas");
        }
    }
}
