using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace empresa_administrador_api.Migrations
{
    public partial class primera : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_EmploymentStatus_EmploymentStatusId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_JobCategories_JobCategoryId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_jobTitles_JobTitleId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Languages_LanguageId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Licenses_LicenseId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_PayGrades_PayGradeId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Empleados_Skills_SkillId",
                table: "Empleados");

            migrationBuilder.DropForeignKey(
                name: "FK_Nationalities_Empleados_EmployeeId",
                table: "Nationalities");

            migrationBuilder.DropIndex(
                name: "IX_Nationalities_EmployeeId",
                table: "Nationalities");

            migrationBuilder.DropPrimaryKey(
                name: "PK_jobTitles",
                table: "jobTitles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "Nationalities");

            migrationBuilder.RenameTable(
                name: "jobTitles",
                newName: "JobTitles");

            migrationBuilder.RenameTable(
                name: "Empleados",
                newName: "Employees");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_SkillId",
                table: "Employees",
                newName: "IX_Employees_SkillId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_PayGradeId",
                table: "Employees",
                newName: "IX_Employees_PayGradeId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_LicenseId",
                table: "Employees",
                newName: "IX_Employees_LicenseId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_LanguageId",
                table: "Employees",
                newName: "IX_Employees_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_JobTitleId",
                table: "Employees",
                newName: "IX_Employees_JobTitleId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_JobCategoryId",
                table: "Employees",
                newName: "IX_Employees_JobCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Empleados_EmploymentStatusId",
                table: "Employees",
                newName: "IX_Employees_EmploymentStatusId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Nationalities",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "JobTitles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "JobTitles",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "VARCHAR(100)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "JobTitleId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NationalityId",
                table: "Employees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobTitles",
                table: "JobTitles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Employees",
                table: "Employees",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_NationalityId",
                table: "Employees",
                column: "NationalityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_EmploymentStatus_EmploymentStatusId",
                table: "Employees",
                column: "EmploymentStatusId",
                principalTable: "EmploymentStatus",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobCategories_JobCategoryId",
                table: "Employees",
                column: "JobCategoryId",
                principalTable: "JobCategories",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_JobTitles_JobTitleId",
                table: "Employees",
                column: "JobTitleId",
                principalTable: "JobTitles",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Languages_LanguageId",
                table: "Employees",
                column: "LanguageId",
                principalTable: "Languages",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Licenses_LicenseId",
                table: "Employees",
                column: "LicenseId",
                principalTable: "Licenses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Nationalities_NationalityId",
                table: "Employees",
                column: "NationalityId",
                principalTable: "Nationalities",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_PayGrades_PayGradeId",
                table: "Employees",
                column: "PayGradeId",
                principalTable: "PayGrades",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Skills_SkillId",
                table: "Employees",
                column: "SkillId",
                principalTable: "Skills",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_EmploymentStatus_EmploymentStatusId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobCategories_JobCategoryId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_JobTitles_JobTitleId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Languages_LanguageId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Licenses_LicenseId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Nationalities_NationalityId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_PayGrades_PayGradeId",
                table: "Employees");

            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Skills_SkillId",
                table: "Employees");

            migrationBuilder.DropPrimaryKey(
                name: "PK_JobTitles",
                table: "JobTitles");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Employees",
                table: "Employees");

            migrationBuilder.DropIndex(
                name: "IX_Employees_NationalityId",
                table: "Employees");

            migrationBuilder.DropColumn(
                name: "NationalityId",
                table: "Employees");

            migrationBuilder.RenameTable(
                name: "JobTitles",
                newName: "jobTitles");

            migrationBuilder.RenameTable(
                name: "Employees",
                newName: "Empleados");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_SkillId",
                table: "Empleados",
                newName: "IX_Empleados_SkillId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_PayGradeId",
                table: "Empleados",
                newName: "IX_Empleados_PayGradeId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_LicenseId",
                table: "Empleados",
                newName: "IX_Empleados_LicenseId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_LanguageId",
                table: "Empleados",
                newName: "IX_Empleados_LanguageId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_JobTitleId",
                table: "Empleados",
                newName: "IX_Empleados_JobTitleId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_JobCategoryId",
                table: "Empleados",
                newName: "IX_Empleados_JobCategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Employees_EmploymentStatusId",
                table: "Empleados",
                newName: "IX_Empleados_EmploymentStatusId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Nationalities",
                type: "VARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "Nationalities",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "jobTitles",
                type: "VARCHAR(50)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "jobTitles",
                type: "VARCHAR(100)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<int>(
                name: "JobTitleId",
                table: "Empleados",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddPrimaryKey(
                name: "PK_jobTitles",
                table: "jobTitles",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Empleados",
                table: "Empleados",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Nationalities_EmployeeId",
                table: "Nationalities",
                column: "EmployeeId",
                unique: true);

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
                name: "FK_Empleados_jobTitles_JobTitleId",
                table: "Empleados",
                column: "JobTitleId",
                principalTable: "jobTitles",
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

            migrationBuilder.AddForeignKey(
                name: "FK_Nationalities_Empleados_EmployeeId",
                table: "Nationalities",
                column: "EmployeeId",
                principalTable: "Empleados",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
