using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceCatalogue.Migrations
{
    public partial class FreshStart : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppRole_ServerAsset_ServerAssetServerId",
                table: "AppRole");

            migrationBuilder.DropForeignKey(
                name: "FK_SystemAsset_ServerAsset_ServerTermsServerId",
                table: "SystemAsset");

            migrationBuilder.DropIndex(
                name: "IX_SystemAsset_ServerTermsServerId",
                table: "SystemAsset");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServerAsset",
                table: "ServerAsset");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRole",
                table: "AppRole");

            migrationBuilder.DropIndex(
                name: "IX_AppRole_ServerAssetServerId",
                table: "AppRole");

            migrationBuilder.DropColumn(
                name: "ServerTermsServerId",
                table: "SystemAsset");

            migrationBuilder.DropColumn(
                name: "ServerId",
                table: "ServerAsset");

            migrationBuilder.DropColumn(
                name: "Role",
                table: "ServerAsset");

            migrationBuilder.DropColumn(
                name: "AppRoleId",
                table: "AppRole");

            migrationBuilder.DropColumn(
                name: "ServerAssetServerId",
                table: "AppRole");

            migrationBuilder.AlterColumn<int>(
                name: "ServerId",
                table: "SystemAsset",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "ServerAssetsId",
                table: "SystemAsset",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "ServerAsset",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "AppsId",
                table: "ServerAsset",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "ServerAsset",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "AppRole",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "AppRole",
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

            migrationBuilder.CreateIndex(
                name: "IX_SystemAsset_ServerAssetsId",
                table: "SystemAsset",
                column: "ServerAssetsId");

            migrationBuilder.CreateIndex(
                name: "IX_ServerAsset_AppsId",
                table: "ServerAsset",
                column: "AppsId");

            migrationBuilder.AddForeignKey(
                name: "FK_ServerAsset_AppRole_AppsId",
                table: "ServerAsset",
                column: "AppsId",
                principalTable: "AppRole",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_SystemAsset_ServerAsset_ServerAssetsId",
                table: "SystemAsset",
                column: "ServerAssetsId",
                principalTable: "ServerAsset",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ServerAsset_AppRole_AppsId",
                table: "ServerAsset");

            migrationBuilder.DropForeignKey(
                name: "FK_SystemAsset_ServerAsset_ServerAssetsId",
                table: "SystemAsset");

            migrationBuilder.DropIndex(
                name: "IX_SystemAsset_ServerAssetsId",
                table: "SystemAsset");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ServerAsset",
                table: "ServerAsset");

            migrationBuilder.DropIndex(
                name: "IX_ServerAsset_AppsId",
                table: "ServerAsset");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppRole",
                table: "AppRole");

            migrationBuilder.DropColumn(
                name: "ServerAssetsId",
                table: "SystemAsset");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "ServerAsset");

            migrationBuilder.DropColumn(
                name: "AppsId",
                table: "ServerAsset");

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "ServerAsset");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "AppRole");

            migrationBuilder.AlterColumn<int>(
                name: "ServerId",
                table: "SystemAsset",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServerTermsServerId",
                table: "SystemAsset",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ServerId",
                table: "ServerAsset",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "Role",
                table: "ServerAsset",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "AppRole",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "AppRoleId",
                table: "AppRole",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ServerAssetServerId",
                table: "AppRole",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ServerAsset",
                table: "ServerAsset",
                column: "ServerId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppRole",
                table: "AppRole",
                column: "AppRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_SystemAsset_ServerTermsServerId",
                table: "SystemAsset",
                column: "ServerTermsServerId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_SystemAsset_ServerAsset_ServerTermsServerId",
                table: "SystemAsset",
                column: "ServerTermsServerId",
                principalTable: "ServerAsset",
                principalColumn: "ServerId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
