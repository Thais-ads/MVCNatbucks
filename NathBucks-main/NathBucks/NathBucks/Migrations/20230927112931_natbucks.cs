using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NathBucks.Migrations
{
    /// <inheritdoc />
    public partial class natbucks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Avaliacao",
                columns: table => new
                {
                    Id = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Nome = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Email = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Texto = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    Estrelas = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    Autorizacao = table.Column<bool>(type: "NUMBER(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Avaliacao", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cafeteria",
                columns: table => new
                {
                    IdCafeteria = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    Funcionarios = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    EstoqueCafe = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    EstoqueCopos = table.Column<int>(type: "NUMBER(10)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cafeteria", x => x.IdCafeteria);
                });

            migrationBuilder.CreateTable(
                name: "Cardapio",
                columns: table => new
                {
                    IdCardapio = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TipoDrink = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    TamanhoDrink = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DescricaoDrink = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    PrecoDrink = table.Column<float>(type: "BINARY_FLOAT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cardapio", x => x.IdCardapio);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Avaliacao");

            migrationBuilder.DropTable(
                name: "Cafeteria");

            migrationBuilder.DropTable(
                name: "Cardapio");
        }
    }
}
