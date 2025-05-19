using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class MaisCamposFornecedor2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "celular",
                table: "Fornecedores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "endereco",
                table: "Fornecedores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "nuit",
                table: "Fornecedores",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "telefone",
                table: "Fornecedores",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "celular",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "endereco",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "nuit",
                table: "Fornecedores");

            migrationBuilder.DropColumn(
                name: "telefone",
                table: "Fornecedores");
        }
    }
}
