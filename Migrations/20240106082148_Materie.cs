using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect5.Migrations
{
    public partial class Materie : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Materie",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    denumire = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nivel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    clasa = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materie", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Materie");
        }
    }
}
