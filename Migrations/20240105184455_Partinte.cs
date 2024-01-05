using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect5.Migrations
{
    public partial class Partinte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parinte",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    prenume = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    nr_tel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parinte", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parinte");
        }
    }
}
