using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect5.Migrations
{
    public partial class ParticipareElev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParticipareElev",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    descriere = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prezenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    tema = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    elevid = table.Column<int>(type: "int", nullable: true),
                    sedintameditatieid = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParticipareElev", x => x.id);
                    table.ForeignKey(
                        name: "FK_ParticipareElev_Elev_elevid",
                        column: x => x.elevid,
                        principalTable: "Elev",
                        principalColumn: "id");
                    table.ForeignKey(
                        name: "FK_ParticipareElev_SedintaMeditatie_sedintameditatieid",
                        column: x => x.sedintameditatieid,
                        principalTable: "SedintaMeditatie",
                        principalColumn: "id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_ParticipareElev_elevid",
                table: "ParticipareElev",
                column: "elevid");

            migrationBuilder.CreateIndex(
                name: "IX_ParticipareElev_sedintameditatieid",
                table: "ParticipareElev",
                column: "sedintameditatieid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ParticipareElev");
        }
    }
}
