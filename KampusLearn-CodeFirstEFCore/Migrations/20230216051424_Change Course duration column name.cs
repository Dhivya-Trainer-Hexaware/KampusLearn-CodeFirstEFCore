using Microsoft.EntityFrameworkCore.Migrations;

namespace KampusLearn_CodeFirstEFCore.Migrations
{
    public partial class ChangeCoursedurationcolumnname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DurationOfCourse",
                table: "Courses",
                newName: "CourseDuration");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CourseDuration",
                table: "Courses",
                newName: "DurationOfCourse");
        }
    }
}
