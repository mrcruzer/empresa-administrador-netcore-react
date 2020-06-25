using Microsoft.EntityFrameworkCore.Migrations;

namespace empresa_administrador_api.Migrations
{
    public partial class longcampos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "Telefono",
                table: "Empleados",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<long>(
                name: "Nomina",
                table: "Empleados",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Telefono",
                table: "Empleados",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));

            migrationBuilder.AlterColumn<int>(
                name: "Nomina",
                table: "Empleados",
                type: "int",
                nullable: false,
                oldClrType: typeof(long));
        }
    }
}
