using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AdoTask5.Migrations
{
    /// <inheritdoc />
    public partial class addNotAllowingEmptyStrings : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddCheckConstraint(
                name: "Name3",
                table: "Teachers",
                sql: "Name<>''");

            migrationBuilder.AddCheckConstraint(
                name: "Surname",
                table: "Teachers",
                sql: "Surname<>''");

            migrationBuilder.AddCheckConstraint(
                name: "Name2",
                table: "Groups",
                sql: "Name<>''");

            migrationBuilder.AddCheckConstraint(
                name: "Name1",
                table: "Faculties",
                sql: "Name<>''");

            migrationBuilder.AddCheckConstraint(
                name: "Name",
                table: "Chairs",
                sql: "Name<>''");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropCheckConstraint(
                name: "Name3",
                table: "Teachers");

            migrationBuilder.DropCheckConstraint(
                name: "Surname",
                table: "Teachers");

            migrationBuilder.DropCheckConstraint(
                name: "Name2",
                table: "Groups");

            migrationBuilder.DropCheckConstraint(
                name: "Name1",
                table: "Faculties");

            migrationBuilder.DropCheckConstraint(
                name: "Name",
                table: "Chairs");
        }
    }
}
