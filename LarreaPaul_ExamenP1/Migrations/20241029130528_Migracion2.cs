using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LarreaPaul_ExamenP1.Migrations
{
    /// <inheritdoc />
    public partial class Migracion2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdEquipo",
                table: "Celular",
                newName: "IdCliente");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "IdCliente",
                table: "Celular",
                newName: "IdEquipo");
        }
    }
}
