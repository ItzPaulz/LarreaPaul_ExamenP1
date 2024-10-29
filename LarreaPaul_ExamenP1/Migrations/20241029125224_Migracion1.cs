using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LarreaPaul_ExamenP1.Migrations
{
    /// <inheritdoc />
    public partial class Migracion1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PLarrea",
                columns: table => new
                {
                    idNombre = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    correo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    celular = table.Column<int>(type: "int", nullable: false),
                    iq = table.Column<float>(type: "real", maxLength: 3, nullable: false),
                    casado = table.Column<bool>(type: "bit", nullable: false),
                    FechaCumple = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PLarrea", x => x.idNombre);
                });

            migrationBuilder.CreateTable(
                name: "Celular",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Modelo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    año = table.Column<int>(type: "int", maxLength: 4, nullable: false),
                    precio = table.Column<float>(type: "real", nullable: false),
                    clienteidNombre = table.Column<int>(type: "int", nullable: true),
                    IdEquipo = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Celular", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Celular_PLarrea_clienteidNombre",
                        column: x => x.clienteidNombre,
                        principalTable: "PLarrea",
                        principalColumn: "idNombre");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Celular_clienteidNombre",
                table: "Celular",
                column: "clienteidNombre");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Celular");

            migrationBuilder.DropTable(
                name: "PLarrea");
        }
    }
}
