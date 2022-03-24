using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session_15.EF.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Tin = table.Column<string>(type: "nvarchar(9)", maxLength: 9, nullable: false),
                    ObjectStatus = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Employee",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", maxLength: 50, nullable: false),
                    EmpType = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    ObjectStatus = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employee", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "PetFood",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ObjectStatus = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", maxLength: 50, nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetFood", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Transaction",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", maxLength: 100, nullable: false),
                    CustomerID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 100, nullable: false),
                    EmployeeID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 100, nullable: false),
                    PetID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 100, nullable: false),
                    PetPrice = table.Column<decimal>(type: "decimal(18,2)", maxLength: 100, nullable: false),
                    PetFoodID = table.Column<Guid>(type: "uniqueidentifier", maxLength: 100, nullable: false),
                    PetFoodQty = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    PetFoodPrice = table.Column<decimal>(type: "decimal(18,2)", maxLength: 100, nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Transaction", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FoodTypeID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HealthStatus = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    AnimalType = table.Column<int>(type: "int", maxLength: 50, nullable: false),
                    Breed = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ObjectStatus = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", maxLength: 50, nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(18,2)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Pet_PetFood_FoodTypeID",
                        column: x => x.FoodTypeID,
                        principalTable: "PetFood",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Pet_FoodTypeID",
                table: "Pet",
                column: "FoodTypeID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Employee");

            migrationBuilder.DropTable(
                name: "Pet");

            migrationBuilder.DropTable(
                name: "Transaction");

            migrationBuilder.DropTable(
                name: "PetFood");
        }
    }
}
