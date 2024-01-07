using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Proiect5.Migrations
{
    public partial class Validare : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElevMaterie_Materie_materieid",
                table: "ElevMaterie");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterieProfesor_Materie_materieid",
                table: "MaterieProfesor");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterieProfesor_Profesor_profesorid",
                table: "MaterieProfesor");

            migrationBuilder.DropForeignKey(
                name: "FK_Programare_ElevMaterie_elevmaterieid",
                table: "Programare");

            migrationBuilder.DropForeignKey(
                name: "FK_Programare_MaterieProfesor_materieprofesorid",
                table: "Programare");

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

            migrationBuilder.AlterColumn<int>(
                name: "materieprofesorid",
                table: "Programare",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "elevmaterieid",
                table: "Programare",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "profesorid",
                table: "MaterieProfesor",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "materieid",
                table: "MaterieProfesor",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "materieid",
                table: "ElevMaterie",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ElevMaterie_Materie_materieid",
                table: "ElevMaterie",
                column: "materieid",
                principalTable: "Materie",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterieProfesor_Materie_materieid",
                table: "MaterieProfesor",
                column: "materieid",
                principalTable: "Materie",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterieProfesor_Profesor_profesorid",
                table: "MaterieProfesor",
                column: "profesorid",
                principalTable: "Profesor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_ElevMaterie_elevmaterieid",
                table: "Programare",
                column: "elevmaterieid",
                principalTable: "ElevMaterie",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_MaterieProfesor_materieprofesorid",
                table: "Programare",
                column: "materieprofesorid",
                principalTable: "MaterieProfesor",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ElevMaterie_Materie_materieid",
                table: "ElevMaterie");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterieProfesor_Materie_materieid",
                table: "MaterieProfesor");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterieProfesor_Profesor_profesorid",
                table: "MaterieProfesor");

            migrationBuilder.DropForeignKey(
                name: "FK_Programare_ElevMaterie_elevmaterieid",
                table: "Programare");

            migrationBuilder.DropForeignKey(
                name: "FK_Programare_MaterieProfesor_materieprofesorid",
                table: "Programare");

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

            migrationBuilder.AlterColumn<int>(
                name: "materieprofesorid",
                table: "Programare",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "elevmaterieid",
                table: "Programare",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "profesorid",
                table: "MaterieProfesor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "materieid",
                table: "MaterieProfesor",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "materieid",
                table: "ElevMaterie",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_ElevMaterie_Materie_materieid",
                table: "ElevMaterie",
                column: "materieid",
                principalTable: "Materie",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterieProfesor_Materie_materieid",
                table: "MaterieProfesor",
                column: "materieid",
                principalTable: "Materie",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterieProfesor_Profesor_profesorid",
                table: "MaterieProfesor",
                column: "profesorid",
                principalTable: "Profesor",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_ElevMaterie_elevmaterieid",
                table: "Programare",
                column: "elevmaterieid",
                principalTable: "ElevMaterie",
                principalColumn: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_Programare_MaterieProfesor_materieprofesorid",
                table: "Programare",
                column: "materieprofesorid",
                principalTable: "MaterieProfesor",
                principalColumn: "id");

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
    }
}
