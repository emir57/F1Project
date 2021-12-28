using Microsoft.EntityFrameworkCore.Migrations;

namespace f1project.webui.Migrations
{
    public partial class AddColumnIsSubscribe : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsSubscribe",
                table: "AspNetUsers",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsSubscribe",
                table: "AspNetUsers");
        }
    }
}
