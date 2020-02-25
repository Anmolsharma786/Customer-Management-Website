using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD.Migrations.JobPosting
{
    public partial class JobPosting : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_JobPostings",
                table: "JobPostings");

            migrationBuilder.DropColumn(
                name: "EmployeeId",
                table: "JobPostings");

            migrationBuilder.DropColumn(
                name: "EmpCode",
                table: "JobPostings");

            migrationBuilder.DropColumn(
                name: "OfficeLocation",
                table: "JobPostings");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "JobPostings");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "JobPostings",
                newName: "Experience");

            migrationBuilder.AddColumn<int>(
                name: "JobId",
                table: "JobPostings",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "JobDescription",
                table: "JobPostings",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "endingDate",
                table: "JobPostings",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "startingDate",
                table: "JobPostings",
                type: "date",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobPostings",
                table: "JobPostings",
                column: "JobId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_JobPostings",
                table: "JobPostings");

            migrationBuilder.DropColumn(
                name: "JobId",
                table: "JobPostings");

            migrationBuilder.DropColumn(
                name: "JobDescription",
                table: "JobPostings");

            migrationBuilder.DropColumn(
                name: "endingDate",
                table: "JobPostings");

            migrationBuilder.DropColumn(
                name: "startingDate",
                table: "JobPostings");

            migrationBuilder.RenameColumn(
                name: "Experience",
                table: "JobPostings",
                newName: "FullName");

            migrationBuilder.AddColumn<int>(
                name: "EmployeeId",
                table: "JobPostings",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "EmpCode",
                table: "JobPostings",
                type: "varchar(10)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OfficeLocation",
                table: "JobPostings",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "JobPostings",
                type: "varchar(100)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_JobPostings",
                table: "JobPostings",
                column: "EmployeeId");
        }
    }
}
