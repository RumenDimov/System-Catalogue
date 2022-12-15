using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceCatalogue.Migrations
{
    public partial class ChangedFKs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SystemAsset_ServerAsset_ServerNameServerId",
                table: "SystemAsset");

            migrationBuilder.DropIndex(
                name: "IX_SystemAsset_ServerNameServerId",
                table: "SystemAsset");

            migrationBuilder.DropColumn(
                name: "ServerId",
                table: "SystemAsset");

            migrationBuilder.DropColumn(
                name: "ServerNameServerId",
                table: "SystemAsset");

            migrationBuilder.AddColumn<string>(
                name: "ServerName",
                table: "SystemAsset",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SystemAssetId",
                table: "ServerAsset",
                nullable: true);

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
                name: "ServerName",
                table: "SystemAsset");

            migrationBuilder.DropColumn(
                name: "SystemAssetId",
                table: "ServerAsset");

            migrationBuilder.AddColumn<int>(
                name: "ServerId",
                table: "SystemAsset",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServerNameServerId",
                table: "SystemAsset",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SystemAsset_ServerNameServerId",
                table: "SystemAsset",
                column: "ServerNameServerId");

            migrationBuilder.AddForeignKey(
                name: "FK_SystemAsset_ServerAsset_ServerNameServerId",
                table: "SystemAsset",
                column: "ServerNameServerId",
                principalTable: "ServerAsset",
                principalColumn: "ServerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
