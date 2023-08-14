using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AUA.ProjectName.DataLayer.Migrations
{
    public partial class editEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameTable(
                name: "Teacher",
                schema: "Sch",
                newName: "Teacher");

            migrationBuilder.RenameTable(
                name: "StudentTeacher",
                schema: "Sch",
                newName: "StudentTeacher");

            migrationBuilder.RenameTable(
                name: "Student",
                schema: "Sch",
                newName: "Student");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Sch");

            migrationBuilder.RenameTable(
                name: "Teacher",
                newName: "Teacher",
                newSchema: "Sch");

            migrationBuilder.RenameTable(
                name: "StudentTeacher",
                newName: "StudentTeacher",
                newSchema: "Sch");

            migrationBuilder.RenameTable(
                name: "Student",
                newName: "Student",
                newSchema: "Sch");
        }
    }
}
