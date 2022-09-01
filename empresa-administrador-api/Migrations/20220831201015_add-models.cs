using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace empresa_administrador_api.Migrations
{
    public partial class addmodels : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Nombre",
                table: "Empleados",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "Apellido",
                table: "Empleados",
                newName: "LastName");

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Empleados",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "EmploymentStatusId",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "JobCategoryId",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LanguageId",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LicenseId",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NationalityId",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PayGradeId",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SkillId",
                table: "Empleados",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Educations",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Educations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmploymentStatus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmploymentStatus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "jobTitles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Description = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobTitles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Licenses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licenses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PayGrades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Currency = table.Column<int>(type: "int", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PayGrades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    Description = table.Column<string>(type: "VARCHAR(100)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_EmploymentStatusId",
                table: "Empleados",
                column: "EmploymentStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_JobCategoryId",
                table: "Empleados",
                column: "JobCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_LanguageId",
                table: "Empleados",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_LicenseId",
                table: "Empleados",
                column: "LicenseId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_NationalityId",
                table: "Empleados",
                column: "NationalityId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_PayGradeId",
                table: "Empleados",
                column: "PayGradeId");

            migrationBuilder.CreateIndex(
                name: "IX_Empleados_SkillId",
                table: "Empleados",
                column: "SkillId");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_EmploymentStatus_EmploymentStatusId",
                table: "Empleados",
                column: "EmploymentStatusId",
                principalTable: "EmploymentStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_JobCategories_JobCategoryId",
                table: "Empleados",
                column: "JobCategoryId",
                principalTable: "JobCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Languages_LanguageId",
                table: "Empleados",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Licenses_LicenseId",
                table: "Empleados",
                column: "LicenseId",
                principalTable: "Licenses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Nationalities_NationalityId",
                table: "Empleados",
                column: "NationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_PayGrades_PayGradeId",
                table: "Empleados",
                column: "PayGradeId",
                principalTable: "PayGrades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Empleados_Skills_SkillId",
                table: "Empleados",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_EmploymentStatus_EmploymentStatusId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_JobCategories_JobCategoryId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Languages_LanguageId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Licenses_LicenseId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Nationalities_NationalityId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_PayGrades_PayGradeId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Skills_SkillId",
                table: "Empleados");

            migrationBuilder.DropTable(
                name: "Educations");

            migrationBuilder.DropTable(
                name: "EmploymentStatus");

            migrationBuilder.DropTable(
                name: "JobCategories");

            migrationBuilder.DropTable(
                name: "jobTitles");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Licenses");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "PayGrades");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_EmploymentStatusId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_JobCategoryId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_LanguageId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_LicenseId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_NationalityId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_PayGradeId",
                table: "Empleados");

            migrationBuilder.DropIndex(
                name: "IX_Empleados_SkillId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "EmploymentStatusId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "JobCategoryId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "LanguageId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "LicenseId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "NationalityId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "PayGradeId",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "SkillId",
                table: "Empleados");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Empleados",
                newName: "Nombre");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Empleados",
                newName: "Apellido");
        }
    }
}
