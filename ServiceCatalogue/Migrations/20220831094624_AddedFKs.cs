using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceCatalogue.Migrations
{
    public partial class AddedFKs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServerTermsServerId",
                table: "SystemAsset",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SystemAsset_ServerTermsServerId",
                table: "SystemAsset",
                column: "ServerTermsServerId");

            migrationBuilder.AddForeignKey(
                name: "FK_SystemAsset_ServerAsset_ServerTermsServerId",
                table: "SystemAsset",
                column: "ServerTermsServerId",
                principalTable: "ServerAsset",
                principalColumn: "ServerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SystemAsset_ServerAsset_ServerTermsServerId",
                table: "SystemAsset");

            migrationBuilder.DropIndex(
                name: "IX_SystemAsset_ServerTermsServerId",
                table: "SystemAsset");

            migrationBuilder.DropColumn(
                name: "ServerId",
                table: "SystemAsset");

            migrationBuilder.DropColumn(
                name: "ServerTermsServerId",
                table: "SystemAsset");

            migrationBuilder.AddColumn<int>(
                name: "ServerName",
                table: "SystemAsset",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SystemAssetId",
                table: "ServerAsset",
                type: "int",
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
    }
}
