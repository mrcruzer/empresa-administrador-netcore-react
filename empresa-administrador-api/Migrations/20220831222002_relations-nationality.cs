using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace empresa_administrador_api.Migrations
{
    public partial class relationsnationality : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_jobTitles_JobTitleId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Nationalities_NationalityId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_NationalityId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "NationalityId",
                table: "Empleados");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Nationalities",
                type: "VARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Nationalities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<int>(
                name: "JobTitleId",
                table: "Empleados",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_Nationalities_EmployeeId",
                table: "Nationalities",
                column: "EmployeeId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_jobTitles_JobTitleId",
                table: "Empleados",
                column: "JobTitleId",
                principalTable: "jobTitles",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Nationalities_Empleados_EmployeeId",
                table: "Nationalities",
                column: "EmployeeId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_jobTitles_JobTitleId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Nationalities_Empleados_EmployeeId",
                table: "Nationalities");

            migrationBuilder.DropIndex(
                name: "IX_Nationalities_EmployeeId",
                table: "Nationalities");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Nationalities");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Nationalities",
                type: "VARCHAR(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "JobTitleId",
                table: "Empleados",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NationalityId",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_NationalityId",
                table: "Empleados",
                column: "NationalityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_jobTitles_JobTitleId",
                table: "Empleados",
                column: "JobTitleId",
                principalTable: "jobTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Nationalities_NationalityId",
                table: "Empleados",
                column: "NationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id");
        }
    }
}
