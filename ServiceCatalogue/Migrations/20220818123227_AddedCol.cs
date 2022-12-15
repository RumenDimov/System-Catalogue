using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceCatalogue.Migrations
{
    public partial class AddedCol : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "App",
                table: "SystemAsset",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "App",
                table: "SystemAsset");
        }
    }
}
