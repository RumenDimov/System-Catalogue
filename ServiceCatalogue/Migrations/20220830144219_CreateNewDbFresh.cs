using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceCatalogue.Migrations
{
    public partial class CreateNewDbFresh : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServerAsset_AppRole_AppRoleId",
                table: "ServerAsset");

            migrationBuilder.DropForeignKey(
                name: "FK_SystemAsset_ServerAsset_ServerAssetServerId",
                table: "SystemAsset");

            migrationBuilder.DropIndex(
                name: "IX_SystemAsset_ServerAssetServerId",
                table: "SystemAsset");

            migrationBuilder.DropIndex(
                name: "IX_ServerAsset_AppRoleId",
                table: "ServerAsset");

            migrationBuilder.DropColumn(
                name: "ServerAssetServerId",
                table: "SystemAsset");

            migrationBuilder.DropColumn(
                name: "ServerId",
                table: "SystemAsset");

            migrationBuilder.DropColumn(
                name: "AppRoleId",
                table: "ServerAsset");

            migrationBuilder.AddColumn<int>(
                name: "ServerNameId",
                table: "SystemAsset",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoleAppRoleId",
                table: "ServerAsset",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_SystemAsset_ServerNameId",
                table: "SystemAsset",
                column: "ServerNameId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerAsset_RoleAppRoleId",
                table: "ServerAsset",
                column: "RoleAppRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServerAsset_AppRole_RoleAppRoleId",
                table: "ServerAsset",
                column: "RoleAppRoleId",
                principalTable: "AppRole",
                principalColumn: "AppRoleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SystemAsset_SystemAsset_ServerNameId",
                table: "SystemAsset",
                column: "ServerNameId",
                principalTable: "SystemAsset",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServerAsset_AppRole_RoleAppRoleId",
                table: "ServerAsset");

            migrationBuilder.DropForeignKey(
                name: "FK_SystemAsset_SystemAsset_ServerNameId",
                table: "SystemAsset");

            migrationBuilder.DropIndex(
                name: "IX_SystemAsset_ServerNameId",
                table: "SystemAsset");

            migrationBuilder.DropIndex(
                name: "IX_ServerAsset_RoleAppRoleId",
                table: "ServerAsset");

            migrationBuilder.DropColumn(
                name: "ServerNameId",
                table: "SystemAsset");

            migrationBuilder.DropColumn(
                name: "RoleAppRoleId",
                table: "ServerAsset");

            migrationBuilder.AddColumn<int>(
                name: "ServerAssetServerId",
                table: "SystemAsset",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServerId",
                table: "SystemAsset",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "AppRoleId",
                table: "ServerAsset",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_SystemAsset_ServerAssetServerId",
                table: "SystemAsset",
                column: "ServerAssetServerId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerAsset_AppRoleId",
                table: "ServerAsset",
                column: "AppRoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServerAsset_AppRole_AppRoleId",
                table: "ServerAsset",
                column: "AppRoleId",
                principalTable: "AppRole",
                principalColumn: "AppRoleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SystemAsset_ServerAsset_ServerAssetServerId",
                table: "SystemAsset",
                column: "ServerAssetServerId",
                principalTable: "ServerAsset",
                principalColumn: "ServerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
