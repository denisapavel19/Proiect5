using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect5.Migrations
{
    public partial class Review : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Review",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    feedback = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nota = table.Column<int>(type: "int", nullable: false),
                    profesorid = table.Column<int>(type: "int", nullable: false),
                    parinteid = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Review", x => x.id);
                    table.ForeignKey(
                        name: "FK_Review_Parinte_parinteid",
                        column: x => x.parinteid,
                        principalTable: "Parinte",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Review_Profesor_profesorid",
                        column: x => x.profesorid,
                        principalTable: "Profesor",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Review_parinteid",
                table: "Review",
                column: "parinteid");

            migrationBuilder.CreateIndex(
                name: "IX_Review_profesorid",
                table: "Review",
                column: "profesorid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Review");
        }
    }
}
