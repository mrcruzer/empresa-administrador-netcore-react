using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace empresa_administrador_api.Migrations
{
    public partial class relationsjobstitles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nomina",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "TipoNomina",
                table: "Empleados");

            migrationBuilder.RenameColumn(
                name: "Telefono",
                table: "Empleados",
                newName: "Telephone");

            migrationBuilder.RenameColumn(
                name: "Posicion",
                table: "Empleados",
                newName: "Province");

            migrationBuilder.RenameColumn(
                name: "Edad",
                table: "Empleados",
                newName: "JobTitleId");

            migrationBuilder.RenameColumn(
                name: "Direccion",
                table: "Empleados",
                newName: "Country");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Empleados",
                type: "VARCHAR(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                table: "Empleados",
                type: "VARCHAR(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Empleados",
                type: "VARCHAR(25)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_JobTitleId",
                table: "Empleados",
                column: "JobTitleId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_jobTitles_JobTitleId",
                table: "Empleados",
                column: "JobTitleId",
                principalTable: "jobTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_jobTitles_JobTitleId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_JobTitleId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "City",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Empleados");

            migrationBuilder.RenameColumn(
                name: "Telephone",
                table: "Empleados",
                newName: "Telefono");

            migrationBuilder.RenameColumn(
                name: "Province",
                table: "Empleados",
                newName: "Posicion");

            migrationBuilder.RenameColumn(
                name: "JobTitleId",
                table: "Empleados",
                newName: "Edad");

            migrationBuilder.RenameColumn(
                name: "Country",
                table: "Empleados",
                newName: "Direccion");

            migrationBuilder.AddColumn<long>(
                name: "Nomina",
                table: "Empleados",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<string>(
                name: "TipoNomina",
                table: "Empleados",
                type: "VARCHAR(50)",
                nullable: true);
        }
    }
}
