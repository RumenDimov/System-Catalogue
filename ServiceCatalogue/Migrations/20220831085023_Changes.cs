using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceCatalogue.Migrations
{
    public partial class Changes : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServerAsset_AppRole_AppRoleId",
                table: "ServerAsset");

            migrationBuilder.DropIndex(
                name: "IX_ServerAsset_AppRoleId",
                table: "ServerAsset");

            migrationBuilder.DropColumn(
                name: "AppRoleId",
                table: "ServerAsset");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "ServerAsset",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServerAssetServerId",
                table: "AppRole",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AppRole_ServerAssetServerId",
                table: "AppRole",
                column: "ServerAssetServerId");

            migrationBuilder.AddForeignKey(
                name: "FK_AppRole_ServerAsset_ServerAssetServerId",
                table: "AppRole",
                column: "ServerAssetServerId",
                principalTable: "ServerAsset",
                principalColumn: "ServerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppRole_ServerAsset_ServerAssetServerId",
                table: "AppRole");

            migrationBuilder.DropIndex(
                name: "IX_AppRole_ServerAssetServerId",
                table: "AppRole");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "ServerAsset");

            migrationBuilder.DropColumn(
                name: "ServerAssetServerId",
                table: "AppRole");

            migrationBuilder.AddColumn<int>(
                name: "AppRoleId",
                table: "ServerAsset",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_ServerAsset_AppRoleId",
                table: "ServerAsset",
                column: "AppRoleId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_ServerAsset_AppRole_AppRoleId",
                table: "ServerAsset",
                column: "AppRoleId",
                principalTable: "AppRole",
                principalColumn: "AppRoleId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
