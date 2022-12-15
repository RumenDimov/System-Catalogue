using Microsoft.EntityFrameworkCore.Migrations;

namespace ServiceCatalogue.Migrations
{
    public partial class NewChangeMade : Migration
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
                name: "Sql",
                table: "ServerAsset");

            migrationBuilder.DropColumn(
                name: "SystemAssetId",
                table: "ServerAsset");

            migrationBuilder.DropColumn(
                name: "Web",
                table: "ServerAsset");

            migrationBuilder.AlterColumn<string>(
                name: "Web",
                table: "SystemAsset",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Sql",
                table: "SystemAsset",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Web",
                table: "SystemAsset",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Sql",
                table: "SystemAsset",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Sql",
                table: "ServerAsset",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "SystemAssetId",
                table: "ServerAsset",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Web",
                table: "ServerAsset",
                type: "int",
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
    }
}
