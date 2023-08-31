using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AUA.ProjectName.DataLayer.Migrations
{
    public partial class softDelete : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                schema: "acc",
                table: "UserRoleAccess",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionDate",
                schema: "acc",
                table: "UserRoleAccess",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "acc",
                table: "UserRoleAccess",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                schema: "acc",
                table: "UserRole",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionDate",
                schema: "acc",
                table: "UserRole",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "acc",
                table: "UserRole",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                schema: "acc",
                table: "UserAccess",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionDate",
                schema: "acc",
                table: "UserAccess",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "acc",
                table: "UserAccess",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                schema: "Sch",
                table: "Teacher",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionDate",
                schema: "Sch",
                table: "Teacher",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Sch",
                table: "Teacher",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                schema: "Sch",
                table: "StudentTeacher",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionDate",
                schema: "Sch",
                table: "StudentTeacher",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Sch",
                table: "StudentTeacher",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                schema: "Sch",
                table: "Student",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionDate",
                schema: "Sch",
                table: "Student",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "Sch",
                table: "Student",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                schema: "acc",
                table: "Role",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionDate",
                schema: "acc",
                table: "Role",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "acc",
                table: "Role",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                schema: "acc",
                table: "AppUser",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionDate",
                schema: "acc",
                table: "AppUser",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "acc",
                table: "AppUser",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<long>(
                name: "DeleterUserId",
                schema: "acc",
                table: "ActiveAccessToken",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DeletionDate",
                schema: "acc",
                table: "ActiveAccessToken",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                schema: "acc",
                table: "ActiveAccessToken",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                schema: "acc",
                table: "UserRoleAccess");

            migrationBuilder.DropColumn(
                name: "DeletionDate",
                schema: "acc",
                table: "UserRoleAccess");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "acc",
                table: "UserRoleAccess");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                schema: "acc",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "DeletionDate",
                schema: "acc",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "acc",
                table: "UserRole");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                schema: "acc",
                table: "UserAccess");

            migrationBuilder.DropColumn(
                name: "DeletionDate",
                schema: "acc",
                table: "UserAccess");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "acc",
                table: "UserAccess");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                schema: "Sch",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "DeletionDate",
                schema: "Sch",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Sch",
                table: "Teacher");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                schema: "Sch",
                table: "StudentTeacher");

            migrationBuilder.DropColumn(
                name: "DeletionDate",
                schema: "Sch",
                table: "StudentTeacher");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Sch",
                table: "StudentTeacher");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                schema: "Sch",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "DeletionDate",
                schema: "Sch",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "Sch",
                table: "Student");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                schema: "acc",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "DeletionDate",
                schema: "acc",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "acc",
                table: "Role");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                schema: "acc",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "DeletionDate",
                schema: "acc",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "acc",
                table: "AppUser");

            migrationBuilder.DropColumn(
                name: "DeleterUserId",
                schema: "acc",
                table: "ActiveAccessToken");

            migrationBuilder.DropColumn(
                name: "DeletionDate",
                schema: "acc",
                table: "ActiveAccessToken");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                schema: "acc",
                table: "ActiveAccessToken");
        }
    }
}
