using Microsoft.EntityFrameworkCore.Migrations;

namespace CRUD.Migrations.Project
{
    public partial class Project : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProjectRunning",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    projectDeadline = table.Column<string>(type: "nvarchar(250)", nullable: false),
                    ProjectManager = table.Column<string>(type: "varchar(10)", nullable: true),
                    ProjectName = table.Column<string>(type: "varchar(100)", nullable: true),
                    ProjectId = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectRunning", x => x.EmployeeId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProjectRunning");
        }
    }
}
