using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ShopManagementSystem.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MobileNumber = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ODCategorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MobileNumber = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ODCategorys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SoundBoxs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemPlan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoOfItem = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    ShopName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ShopId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MobileNumber = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoundBoxs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MobileNumber = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MobileNumber = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Inventorys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    PartyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoOfItem = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MobileNumber = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inventorys", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Inventorys_Categorys_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Shops",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Place = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MobileNumber = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shops", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Shops_Categorys_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Fastags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MobileNumber = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fastags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Fastags_Categorys_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Fastags_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InsuranceDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userId = table.Column<int>(type: "int", nullable: false),
                    UserDetailsId = table.Column<int>(type: "int", nullable: true),
                    NomineeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PolicyNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: true),
                    Premium = table.Column<int>(type: "int", nullable: false),
                    ODCategoryId = table.Column<int>(type: "int", nullable: true),
                    ODPremium = table.Column<int>(type: "int", nullable: false),
                    ODPercentage = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Commission = table.Column<int>(type: "int", nullable: false),
                    CompanyName = table.Column<int>(type: "int", nullable: false),
                    VehicleModel = table.Column<int>(type: "int", nullable: false),
                    VehicleNumber = table.Column<int>(type: "int", nullable: false),
                    ExpireDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Broker = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Income = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Expense = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MobileNumber = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InsuranceDetails_Categorys_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categorys",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InsuranceDetails_ODCategorys_ODCategoryId",
                        column: x => x.ODCategoryId,
                        principalTable: "ODCategorys",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_InsuranceDetails_Users_userId",
                        column: x => x.userId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "JioPsoslites",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    TarifPlan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MobileNumber = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JioPsoslites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_JioPsoslites_Categorys_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_JioPsoslites_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    userID = table.Column<int>(type: "int", nullable: false),
                    CategoryID = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MobileNumber = table.Column<int>(type: "int", nullable: true),
                    Total = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserDetails_Categorys_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "Categorys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserDetails_Users_userID",
                        column: x => x.userID,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Fastags_CategoryId",
                table: "Fastags",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Fastags_userId",
                table: "Fastags",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceDetails_CategoryId",
                table: "InsuranceDetails",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceDetails_ODCategoryId",
                table: "InsuranceDetails",
                column: "ODCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_InsuranceDetails_userId",
                table: "InsuranceDetails",
                column: "userId");

            migrationBuilder.CreateIndex(
                name: "IX_Inventorys_CategoryId",
                table: "Inventorys",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_JioPsoslites_CategoryId",
                table: "JioPsoslites",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_JioPsoslites_UserId",
                table: "JioPsoslites",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Shops_CategoryId",
                table: "Shops",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_CategoryID",
                table: "UserDetails",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_UserDetails_userID",
                table: "UserDetails",
                column: "userID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Fastags");

            migrationBuilder.DropTable(
                name: "InsuranceDetails");

            migrationBuilder.DropTable(
                name: "Inventorys");

            migrationBuilder.DropTable(
                name: "JioPsoslites");

            migrationBuilder.DropTable(
                name: "Shops");

            migrationBuilder.DropTable(
                name: "SoundBoxs");

            migrationBuilder.DropTable(
                name: "UserDetails");

            migrationBuilder.DropTable(
                name: "UserTypes");

            migrationBuilder.DropTable(
                name: "ODCategorys");

            migrationBuilder.DropTable(
                name: "Categorys");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
