using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceCatalogue.Migrations
{
    public partial class StartAgain : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ServerId",
                table: "SystemAsset");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "ServerAsset");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ServerId",
                table: "SystemAsset",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "ServerAsset",
                type: "int",
                nullable: true);
        }
    }
}
