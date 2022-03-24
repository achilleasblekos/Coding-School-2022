using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Session_15.EF.Migrations
{
    public partial class foreign_keys : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Transaction_CustomerID",
                table: "Transaction",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_EmployeeID",
                table: "Transaction",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_Transaction_PetID",
                table: "Transaction",
                column: "PetID",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Customer_CustomerID",
                table: "Transaction",
                column: "CustomerID",
                principalTable: "Customer",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Employee_EmployeeID",
                table: "Transaction",
                column: "EmployeeID",
                principalTable: "Employee",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Transaction_Pet_PetID",
                table: "Transaction",
                column: "PetID",
                principalTable: "Pet",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Customer_CustomerID",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Employee_EmployeeID",
                table: "Transaction");

            migrationBuilder.DropForeignKey(
                name: "FK_Transaction_Pet_PetID",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_CustomerID",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_EmployeeID",
                table: "Transaction");

            migrationBuilder.DropIndex(
                name: "IX_Transaction_PetID",
                table: "Transaction");
        }
    }
}
