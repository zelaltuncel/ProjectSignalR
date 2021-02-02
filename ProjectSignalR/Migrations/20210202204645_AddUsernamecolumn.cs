using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjectSignalR.Migrations
{
    public partial class AddUsernamecolumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "AdminUsers",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserName",
                table: "AdminUsers");
        }
    }
}
