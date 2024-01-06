using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect5.Migrations
{
    public partial class Programare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Programare",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data = table.Column<DateTime>(type: "datetime2", nullable: false),
                    elevmaterieid = table.Column<int>(type: "int", nullable: true),
                    materieprofesorid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programare", x => x.id);
                    table.ForeignKey(
                        name: "FK_Programare_ElevMaterie_elevmaterieid",
                        column: x => x.elevmaterieid,
                        principalTable: "ElevMaterie",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_Programare_MaterieProfesor_materieprofesorid",
                        column: x => x.materieprofesorid,
                        principalTable: "MaterieProfesor",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Programare_elevmaterieid",
                table: "Programare",
                column: "elevmaterieid");

            migrationBuilder.CreateIndex(
                name: "IX_Programare_materieprofesorid",
                table: "Programare",
                column: "materieprofesorid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Programare");
        }
    }
}
