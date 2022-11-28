using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopManagementSystem.Migrations
{
    public partial class UpdatedTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fastags_Users_userId",
                table: "Fastags");

            migrationBuilder.DropForeignKey(
                name: "FK_JioPsoslites_Users_UserId",
                table: "JioPsoslites");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDetails_Users_userID",
                table: "UserDetails");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "UserTypes");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "UserTypes");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "UserDetails");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "UserDetails");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "SoundBoxs");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "SoundBoxs");

            migrationBuilder.DropColumn(
                name: "ShopName",
                table: "SoundBoxs");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Shops");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "ODCategorys");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "ODCategorys");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "JioPsoslites");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "JioPsoslites");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Inventorys");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "InsuranceDetails");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "InsuranceDetails");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "InsuranceDetails");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Fastags");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "Fastags");

            migrationBuilder.DropColumn(
                name: "MobileNumber",
                table: "Categorys");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Categorys");

            migrationBuilder.RenameColumn(
                name: "userID",
                table: "UserDetails",
                newName: "UserID");

            migrationBuilder.RenameIndex(
                name: "IX_UserDetails_userID",
                table: "UserDetails",
                newName: "IX_UserDetails_UserID");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "JioPsoslites",
                newName: "CustomerId");

            migrationBuilder.RenameIndex(
                name: "IX_JioPsoslites_UserId",
                table: "JioPsoslites",
                newName: "IX_JioPsoslites_CustomerId");

            migrationBuilder.RenameColumn(
                name: "userId",
                table: "Fastags",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_Fastags_userId",
                table: "Fastags",
                newName: "IX_Fastags_UserId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserTypes",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "UserTypes",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PanCard",
                table: "Users",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MobileNumber",
                table: "Users",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "AadharID",
                table: "Users",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "UserTypeID",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "UserDetails",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ItemPlan",
                table: "SoundBoxs",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Place",
                table: "Shops",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Shops",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MobileNumber",
                table: "Shops",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ODCategorys",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ODCategorys",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "JioPsoslites",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Inventorys",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Inventorys",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PartyName",
                table: "Inventorys",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "MobileNumber",
                table: "Inventorys",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "VehicleModel",
                table: "InsuranceDetails",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Premium",
                table: "InsuranceDetails",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "PolicyNumber",
                table: "InsuranceDetails",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "ODPremium",
                table: "InsuranceDetails",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "NomineeName",
                table: "InsuranceDetails",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<decimal>(
                name: "Expense",
                table: "InsuranceDetails",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CompanyName",
                table: "InsuranceDetails",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<decimal>(
                name: "Commission",
                table: "InsuranceDetails",
                type: "decimal(18,4)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<decimal>(
                name: "NoClaimBonusPercentage",
                table: "InsuranceDetails",
                type: "decimal(18,4)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categorys",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categorys",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Users_UserTypeID",
                table: "Users",
                column: "UserTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_SoundBoxs_CategoryId",
                table: "SoundBoxs",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_SoundBoxs_ShopId",
                table: "SoundBoxs",
                column: "ShopId");

            migrationBuilder.AddForeignKey(
                name: "FK_Fastags_Users_UserId",
                table: "Fastags",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JioPsoslites_Users_CustomerId",
                table: "JioPsoslites",
                column: "CustomerId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SoundBoxs_Categorys_CategoryId",
                table: "SoundBoxs",
                column: "CategoryId",
                principalTable: "Categorys",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_SoundBoxs_Shops_ShopId",
                table: "SoundBoxs",
                column: "ShopId",
                principalTable: "Shops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetails_Users_UserID",
                table: "UserDetails",
                column: "UserID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Users_UserTypes_UserTypeID",
                table: "Users",
                column: "UserTypeID",
                principalTable: "UserTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Fastags_Users_UserId",
                table: "Fastags");

            migrationBuilder.DropForeignKey(
                name: "FK_JioPsoslites_Users_CustomerId",
                table: "JioPsoslites");

            migrationBuilder.DropForeignKey(
                name: "FK_SoundBoxs_Categorys_CategoryId",
                table: "SoundBoxs");

            migrationBuilder.DropForeignKey(
                name: "FK_SoundBoxs_Shops_ShopId",
                table: "SoundBoxs");

            migrationBuilder.DropForeignKey(
                name: "FK_UserDetails_Users_UserID",
                table: "UserDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_Users_UserTypes_UserTypeID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_Users_UserTypeID",
                table: "Users");

            migrationBuilder.DropIndex(
                name: "IX_SoundBoxs_CategoryId",
                table: "SoundBoxs");

            migrationBuilder.DropIndex(
                name: "IX_SoundBoxs_ShopId",
                table: "SoundBoxs");

            migrationBuilder.DropColumn(
                name: "UserTypeID",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "NoClaimBonusPercentage",
                table: "InsuranceDetails");

            migrationBuilder.RenameColumn(
                name: "UserID",
                table: "UserDetails",
                newName: "userID");

            migrationBuilder.RenameIndex(
                name: "IX_UserDetails_UserID",
                table: "UserDetails",
                newName: "IX_UserDetails_userID");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "JioPsoslites",
                newName: "UserId");

            migrationBuilder.RenameIndex(
                name: "IX_JioPsoslites_CustomerId",
                table: "JioPsoslites",
                newName: "IX_JioPsoslites_UserId");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Fastags",
                newName: "userId");

            migrationBuilder.RenameIndex(
                name: "IX_Fastags_UserId",
                table: "Fastags",
                newName: "IX_Fastags_userId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "UserTypes",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "UserTypes",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MobileNumber",
                table: "UserTypes",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "UserTypes",
                type: "decimal(18,4)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "PanCard",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<int>(
                name: "MobileNumber",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "AadharID",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Users",
                type: "decimal(18,4)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "UserDetails",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MobileNumber",
                table: "UserDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "UserDetails",
                type: "decimal(18,4)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ItemPlan",
                table: "SoundBoxs",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "SoundBoxs",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MobileNumber",
                table: "SoundBoxs",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ShopName",
                table: "SoundBoxs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Place",
                table: "Shops",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Shops",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<int>(
                name: "MobileNumber",
                table: "Shops",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Shops",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ODCategorys",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "ODCategorys",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MobileNumber",
                table: "ODCategorys",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "ODCategorys",
                type: "decimal(18,4)",
                nullable: true);

            migrationBuilder.AlterColumn<decimal>(
                name: "Total",
                table: "JioPsoslites",
                type: "decimal(18,4)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "JioPsoslites",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MobileNumber",
                table: "JioPsoslites",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ProductName",
                table: "Inventorys",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<int>(
                name: "Price",
                table: "Inventorys",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<string>(
                name: "PartyName",
                table: "Inventorys",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<int>(
                name: "MobileNumber",
                table: "Inventorys",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Inventorys",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "VehicleModel",
                table: "InsuranceDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<int>(
                name: "Premium",
                table: "InsuranceDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<string>(
                name: "PolicyNumber",
                table: "InsuranceDetails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<int>(
                name: "ODPremium",
                table: "InsuranceDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<string>(
                name: "NomineeName",
                table: "InsuranceDetails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "Expense",
                table: "InsuranceDetails",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AlterColumn<int>(
                name: "CompanyName",
                table: "InsuranceDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<int>(
                name: "Commission",
                table: "InsuranceDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,4)");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "InsuranceDetails",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MobileNumber",
                table: "InsuranceDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "InsuranceDetails",
                type: "decimal(18,4)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Fastags",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MobileNumber",
                table: "Fastags",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categorys",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Categorys",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MobileNumber",
                table: "Categorys",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Categorys",
                type: "decimal(18,4)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Fastags_Users_userId",
                table: "Fastags",
                column: "userId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_JioPsoslites_Users_UserId",
                table: "JioPsoslites",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetails_Users_userID",
                table: "UserDetails",
                column: "userID",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
