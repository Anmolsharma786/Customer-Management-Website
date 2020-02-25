using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD.Migrations.salary
{
    public partial class Salary : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Salary",
                columns: table => new
                {
                    salaryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    startingDate = table.Column<DateTime>(nullable: false),
                    endingDate = table.Column<DateTime>(nullable: false),
                    salary = table.Column<int>(nullable: false),
                    emp_id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Salary", x => x.salaryId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Salary");
        }
    }
}
