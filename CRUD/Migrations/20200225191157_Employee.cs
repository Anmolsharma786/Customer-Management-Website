using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD.Migrations
{
    public partial class Employee : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OfficeLocation",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "Position",
                table: "Employees",
                newName: "gender");

            migrationBuilder.RenameColumn(
                name: "FullName",
                table: "Employees",
                newName: "fName");

            migrationBuilder.RenameColumn(
                name: "EmpCode",
                table: "Employees",
                newName: "lName");

            migrationBuilder.AddColumn<string>(
                name: "JobId",
                table: "Employees",
                type: "varchar(100)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "JobId",
                table: "Employees");

            migrationBuilder.RenameColumn(
                name: "lName",
                table: "Employees",
                newName: "EmpCode");

            migrationBuilder.RenameColumn(
                name: "gender",
                table: "Employees",
                newName: "Position");

            migrationBuilder.RenameColumn(
                name: "fName",
                table: "Employees",
                newName: "FullName");

            migrationBuilder.AddColumn<string>(
                name: "OfficeLocation",
                table: "Employees",
                type: "varchar(100)",
                nullable: true);
        }
    }
}
