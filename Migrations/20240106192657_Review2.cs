using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect5.Migrations
{
    public partial class Review2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Parinte_parinteid",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Profesor_profesorid",
                table: "Review");

            migrationBuilder.AlterColumn<int>(
                name: "profesorid",
                table: "Review",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "parinteid",
                table: "Review",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Parinte_parinteid",
                table: "Review",
                column: "parinteid",
                principalTable: "Parinte",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Profesor_profesorid",
                table: "Review",
                column: "profesorid",
                principalTable: "Profesor",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Review_Parinte_parinteid",
                table: "Review");

            migrationBuilder.DropForeignKey(
                name: "FK_Review_Profesor_profesorid",
                table: "Review");

            migrationBuilder.AlterColumn<int>(
                name: "profesorid",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "parinteid",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Parinte_parinteid",
                table: "Review",
                column: "parinteid",
                principalTable: "Parinte",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Review_Profesor_profesorid",
                table: "Review",
                column: "profesorid",
                principalTable: "Profesor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
