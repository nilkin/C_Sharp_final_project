using Microsoft.EntityFrameworkCore.Migrations;

namespace Library_App.Migrations
{
    public partial class bookPropNamechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Books",
                newName: "BookName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BookName",
                table: "Books",
                newName: "Name");
        }
    }
}
