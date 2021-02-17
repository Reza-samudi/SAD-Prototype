using Microsoft.EntityFrameworkCore.Migrations;

namespace Database.Migrations
{
    public partial class M2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "gender1",
                table: "users");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "gender1",
                table: "users",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
