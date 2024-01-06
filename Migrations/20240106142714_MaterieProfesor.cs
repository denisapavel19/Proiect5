using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect5.Migrations
{
    public partial class MaterieProfesor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MaterieProfesor",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    sedinta_fizica = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sedinta_online = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tarif = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    profesorid = table.Column<int>(type: "int", nullable: true),
                    materieid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterieProfesor", x => x.id);
                    table.ForeignKey(
                        name: "FK_MaterieProfesor_Materie_materieid",
                        column: x => x.materieid,
                        principalTable: "Materie",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_MaterieProfesor_Profesor_profesorid",
                        column: x => x.profesorid,
                        principalTable: "Profesor",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaterieProfesor_materieid",
                table: "MaterieProfesor",
                column: "materieid");

            migrationBuilder.CreateIndex(
                name: "IX_MaterieProfesor_profesorid",
                table: "MaterieProfesor",
                column: "profesorid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterieProfesor");
        }
    }
}
