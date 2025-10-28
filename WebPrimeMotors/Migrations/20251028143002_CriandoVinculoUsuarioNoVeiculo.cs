using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebPrimeMotors.Migrations
{
    /// <inheritdoc />
    public partial class CriandoVinculoUsuarioNoVeiculo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Veiculos",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Veiculos_UsuarioId",
                table: "Veiculos",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Veiculos_Usuarios_UsuarioId",
                table: "Veiculos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Veiculos_Usuarios_UsuarioId",
                table: "Veiculos");

            migrationBuilder.DropIndex(
                name: "IX_Veiculos_UsuarioId",
                table: "Veiculos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Veiculos");
        }
    }
}
