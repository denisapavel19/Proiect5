using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect5.Migrations
{
    public partial class ElevMaterie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ElevMaterie",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    data_inscriere = table.Column<DateTime>(type: "datetime2", nullable: false),
                    nota = table.Column<int>(type: "int", nullable: true),
                    elevid = table.Column<int>(type: "int", nullable: true),
                    materieid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElevMaterie", x => x.id);
                    table.ForeignKey(
                        name: "FK_ElevMaterie_Elev_elevid",
                        column: x => x.elevid,
                        principalTable: "Elev",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_ElevMaterie_Materie_materieid",
                        column: x => x.materieid,
                        principalTable: "Materie",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElevMaterie_elevid",
                table: "ElevMaterie",
                column: "elevid");

            migrationBuilder.CreateIndex(
                name: "IX_ElevMaterie_materieid",
                table: "ElevMaterie",
                column: "materieid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElevMaterie");
        }
    }
}
