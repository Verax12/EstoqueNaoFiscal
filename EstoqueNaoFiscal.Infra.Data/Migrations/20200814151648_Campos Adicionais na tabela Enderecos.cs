using Microsoft.EntityFrameworkCore.Migrations;

namespace EstoqueNaoFiscal.Infra.Data.Migrations
{
    public partial class CamposAdicionaisnatabelaEnderecos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Bairro",
                table: "Enderecos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CEP",
                table: "Enderecos",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Estado",
                table: "Enderecos",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Bairro",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "CEP",
                table: "Enderecos");

            migrationBuilder.DropColumn(
                name: "Estado",
                table: "Enderecos");
        }
    }
}
