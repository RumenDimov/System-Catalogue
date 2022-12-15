using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceCatalogue.Migrations
{
    public partial class AddRelationships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ServerAsset",
                table: "ServerAsset");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRole",
                table: "AppRole");

            migrationBuilder.DropColumn(
                name: "Sql",
                table: "SystemAsset");

            migrationBuilder.DropColumn(
                name: "Web",
                table: "SystemAsset");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ServerAsset");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "ServerAsset");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "ServerAsset");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AppRole");

            migrationBuilder.AddColumn<int>(
                name: "ServerAssetServerId",
                table: "SystemAsset",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServerId",
                table: "SystemAsset",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ServerId",
                table: "ServerAsset",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AppRoleId",
                table: "ServerAsset",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "ServerName",
                table: "ServerAsset",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AppRoleId",
                table: "AppRole",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ServerId",
                table: "AppRole",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServerAsset",
                table: "ServerAsset",
                column: "ServerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRole",
                table: "AppRole",
                column: "AppRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemAsset_ServerAssetServerId",
                table: "SystemAsset",
                column: "ServerAssetServerId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SystemAsset_ServerAsset_ServerAssetServerId",
                table: "SystemAsset",
                column: "ServerAssetServerId",
                principalTable: "ServerAsset",
                principalColumn: "ServerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServerAsset",
                table: "ServerAsset");

            migrationBuilder.DropIndex(
                name: "IX_ServerAsset_AppRoleId",
                table: "ServerAsset");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRole",
                table: "AppRole");

            migrationBuilder.DropColumn(
                name: "ServerAssetServerId",
                table: "SystemAsset");

            migrationBuilder.DropColumn(
                name: "ServerId",
                table: "SystemAsset");

            migrationBuilder.DropColumn(
                name: "ServerId",
                table: "ServerAsset");

            migrationBuilder.DropColumn(
                name: "AppRoleId",
                table: "ServerAsset");

            migrationBuilder.DropColumn(
                name: "ServerName",
                table: "ServerAsset");

            migrationBuilder.DropColumn(
                name: "AppRoleId",
                table: "AppRole");

            migrationBuilder.DropColumn(
                name: "ServerId",
                table: "AppRole");

            migrationBuilder.AddColumn<string>(
                name: "Sql",
                table: "SystemAsset",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Web",
                table: "SystemAsset",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ServerAsset",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "ServerAsset",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Role",
                table: "ServerAsset",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AppRole",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServerAsset",
                table: "ServerAsset",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRole",
                table: "AppRole",
                column: "Id");
        }
    }
}
