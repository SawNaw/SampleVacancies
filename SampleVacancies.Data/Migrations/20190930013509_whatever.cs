using Microsoft.EntityFrameworkCore.Migrations;

namespace SampleVacancies.Data.Migrations
{
    public partial class whatever : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Vacancies",
                columns: new[] { "Id", "Department", "Description", "JobTitle", "Location", "Salary" },
                values: new object[] { 1, "Sales", "This is a wonderful opportunity for an up-and-coming manager.", "Manager", "Manchester", "£50,000" });

            migrationBuilder.InsertData(
                table: "Vacancies",
                columns: new[] { "Id", "Department", "Description", "JobTitle", "Location", "Salary" },
                values: new object[] { 3, "Human Resources", "Calling all skilled accountants to this exciting opportunity.", "Accountant", "Salford", "£45,000" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Vacancies",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
