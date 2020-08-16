using Microsoft.EntityFrameworkCore.Migrations;

namespace Library_App.Migrations
{
    public partial class SeedManagerTableUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Managements",
                columns: new[] { "Id", "Name", "Parol", "Position", "Surname", "UserName" },
                values: new object[] { 1, "admin", "admin", 0, "admin", "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Managements",
                keyColumn: "Id",
                keyValue: 1);
        }
    }
}
