using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AUA.ProjectName.DataLayer.Migrations
{
    public partial class addUpdateAudit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "ModifierUserId",
                schema: "acc",
                table: "UserRoleAccess",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                schema: "acc",
                table: "UserRoleAccess",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifierUserId",
                schema: "acc",
                table: "UserRole",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                schema: "acc",
                table: "UserRole",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifierUserId",
                schema: "acc",
                table: "UserAccess",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                schema: "acc",
                table: "UserAccess",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifierUserId",
                schema: "Sch",
                table: "Teacher",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                schema: "Sch",
                table: "Teacher",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifierUserId",
                schema: "Sch",
                table: "StudentTeacher",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                schema: "Sch",
                table: "StudentTeacher",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifierUserId",
                schema: "Sch",
                table: "Student",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                schema: "Sch",
                table: "Student",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifierUserId",
                schema: "acc",
                table: "Role",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                schema: "acc",
                table: "Role",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifierUserId",
                schema: "acc",
                table: "AppUser",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                schema: "acc",
                table: "AppUser",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "ModifierUserId",
                schema: "acc",
                table: "ActiveAccessToken",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "ModifyDate",
                schema: "acc",
                table: "ActiveAccessToken",
                type: "datetime2",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ModifierUserId",
                schema: "acc",
                table: "UserRoleAccess");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                schema: "acc",
                table: "UserRoleAccess");

            migrationBuilder.DropColumn(
                name: "ModifierUserId",
                schema: "acc",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                schema: "acc",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "ModifierUserId",
                schema: "acc",
                table: "UserAccess");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                schema: "acc",
                table: "UserAccess");

            migrationBuilder.DropColumn(
                name: "ModifierUserId",
                schema: "Sch",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                schema: "Sch",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "ModifierUserId",
                schema: "Sch",
                table: "StudentTeacher");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                schema: "Sch",
                table: "StudentTeacher");

            migrationBuilder.DropColumn(
                name: "ModifierUserId",
                schema: "Sch",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                schema: "Sch",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "ModifierUserId",
                schema: "acc",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                schema: "acc",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "ModifierUserId",
                schema: "acc",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                schema: "acc",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "ModifierUserId",
                schema: "acc",
                table: "ActiveAccessToken");

            migrationBuilder.DropColumn(
                name: "ModifyDate",
                schema: "acc",
                table: "ActiveAccessToken");
        }
    }
}
