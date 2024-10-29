using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LarreaPaul_ExamenP1.Migrations
{
    /// <inheritdoc />
    public partial class MigracionDef : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "iq",
                table: "PLarrea",
                newName: "sueldo");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "sueldo",
                table: "PLarrea",
                newName: "iq");
        }
    }
}
