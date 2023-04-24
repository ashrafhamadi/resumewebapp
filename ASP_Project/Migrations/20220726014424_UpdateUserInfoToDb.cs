using Microsoft.EntityFrameworkCore.Migrations;

namespace ASP_Project.Migrations
{
    public partial class UpdateUserInfoToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Grade",
                table: "UserInfo",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Grade",
                table: "UserInfo");
        }
    }
}
