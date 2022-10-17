using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SalesWebMvc.Migrations
{
    public partial class CorrectionSeller : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SelerId",
                table: "SalesRecord");

            migrationBuilder.RenameColumn(
                name: "SelerId",
                table: "SalesRecord",
                newName: "SellerId");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecord_SelerId",
                table: "SalesRecord",
                newName: "IX_SalesRecord_SellerId");

            migrationBuilder.UpdateData(
                table: "Seller",
                keyColumn: "Name",
                keyValue: null,
                column: "Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Seller",
                type: "varchar(60)",
                maxLength: 60,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Seller",
                keyColumn: "Email",
                keyValue: null,
                column: "Email",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Seller",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord",
                column: "SellerId",
                principalTable: "Seller",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SalesRecord_Seller_SellerId",
                table: "SalesRecord");

            migrationBuilder.RenameColumn(
                name: "SellerId",
                table: "SalesRecord",
                newName: "SelerId");

            migrationBuilder.RenameIndex(
                name: "IX_SalesRecord_SellerId",
                table: "SalesRecord",
                newName: "IX_SalesRecord_SelerId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Seller",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(60)",
                oldMaxLength: 60)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Seller",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddForeignKey(
                name: "FK_SalesRecord_Seller_SelerId",
                table: "SalesRecord",
                column: "SelerId",
                principalTable: "Seller",
                principalColumn: "Id");
        }
    }
}
