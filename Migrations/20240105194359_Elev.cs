using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect5.Migrations
{
    public partial class Elev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Elev",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prenume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    varsta = table.Column<int>(type: "int", nullable: false),
                    clasa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nr_tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    scoala = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    parinteid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Elev", x => x.id);
                    table.ForeignKey(
                        name: "FK_Elev_Parinte_parinteid",
                        column: x => x.parinteid,
                        principalTable: "Parinte",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Elev_parinteid",
                table: "Elev",
                column: "parinteid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Elev");
        }
    }
}
