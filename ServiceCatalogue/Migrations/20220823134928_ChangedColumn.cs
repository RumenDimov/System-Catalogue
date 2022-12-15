using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceCatalogue.Migrations
{
    public partial class ChangedColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ServerAsset_AppRoleId",
                table: "ServerAsset");

            migrationBuilder.DropColumn(
                name: "ServerId",
                table: "AppRole");

            migrationBuilder.CreateIndex(
                name: "IX_ServerAsset_AppRoleId",
                table: "ServerAsset",
                column: "AppRoleId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ServerAsset_AppRoleId",
                table: "ServerAsset");

            migrationBuilder.AddColumn<int>(
                name: "ServerId",
                table: "AppRole",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ServerAsset_AppRoleId",
                table: "ServerAsset",
                column: "AppRoleId",
                unique: true);
        }
    }
}
