using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceCatalogue.Migrations
{
    public partial class Modifications : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Sql",
                table: "ServerAsset",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SystemAssetId",
                table: "ServerAsset",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Web",
                table: "ServerAsset",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ServerAsset_SystemAssetId",
                table: "ServerAsset",
                column: "SystemAssetId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServerAsset_SystemAsset_SystemAssetId",
                table: "ServerAsset",
                column: "SystemAssetId",
                principalTable: "SystemAsset",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServerAsset_SystemAsset_SystemAssetId",
                table: "ServerAsset");

            migrationBuilder.DropIndex(
                name: "IX_ServerAsset_SystemAssetId",
                table: "ServerAsset");

            migrationBuilder.DropColumn(
                name: "Sql",
                table: "ServerAsset");

            migrationBuilder.DropColumn(
                name: "SystemAssetId",
                table: "ServerAsset");

            migrationBuilder.DropColumn(
                name: "Web",
                table: "ServerAsset");
        }
    }
}
