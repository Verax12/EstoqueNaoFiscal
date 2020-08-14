using Microsoft.EntityFrameworkCore.Migrations;

namespace EstoqueNaoFiscal.Infra.Data.Migrations
{
    public partial class criandorelacionamentos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Users_UsersId",
                table: "Enderecos");

            migrationBuilder.AlterColumn<int>(
                name: "UsersId",
                table: "Enderecos",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Users_UsersId",
                table: "Enderecos",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enderecos_Users_UsersId",
                table: "Enderecos");

            migrationBuilder.AlterColumn<int>(
                name: "UsersId",
                table: "Enderecos",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Enderecos_Users_UsersId",
                table: "Enderecos",
                column: "UsersId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
