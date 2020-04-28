using Microsoft.EntityFrameworkCore.Migrations;

namespace empresa_administrador_api.Migrations
{
    public partial class initia : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Empleados",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombre = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Apellido = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Direccion = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Edad = table.Column<int>(nullable: false),
                    Nomina = table.Column<int>(nullable: false),
                    TipoNomina = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Telefono = table.Column<int>(nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Posicion = table.Column<string>(type: "VARCHAR(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Empleados", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Empleados");
        }
    }
}
