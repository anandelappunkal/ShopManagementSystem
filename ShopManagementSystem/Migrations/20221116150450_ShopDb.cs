using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopManagementSystem.Migrations
{
    public partial class ShopDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsuranceDetails_Users_userId",
                table: "InsuranceDetails");

            migrationBuilder.DropColumn(
                name: "UserDetailsId",
                table: "InsuranceDetails");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "InsuranceDetails",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_InsuranceDetails_userId",
                table: "InsuranceDetails",
                newName: "IX_InsuranceDetails_UserId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "InsuranceDetails",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_InsuranceDetails_Users_UserId",
                table: "InsuranceDetails",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InsuranceDetails_Users_UserId",
                table: "InsuranceDetails");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "InsuranceDetails",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_InsuranceDetails_UserId",
                table: "InsuranceDetails",
                newName: "IX_InsuranceDetails_userId");

            migrationBuilder.AlterColumn<int>(
                name: "userId",
                table: "InsuranceDetails",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UserDetailsId",
                table: "InsuranceDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_InsuranceDetails_Users_userId",
                table: "InsuranceDetails",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
