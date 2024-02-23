using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace App.EF.Migrations
{
    public partial class TransactionLineRelashionships : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLine_Engineers_EngineerID",
                table: "TransactionLine");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLine_ServiceTasks_ServiceTaskID",
                table: "TransactionLine");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLine_Engineers_EngineerID",
                table: "TransactionLine",
                column: "EngineerID",
                principalTable: "Engineers",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLine_ServiceTasks_ServiceTaskID",
                table: "TransactionLine",
                column: "ServiceTaskID",
                principalTable: "ServiceTasks",
                principalColumn: "ID");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLine_Transactions_ID",
                table: "TransactionLine",
                column: "ID",
                principalTable: "Transactions",
                principalColumn: "ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLine_Engineers_EngineerID",
                table: "TransactionLine");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLine_ServiceTasks_ServiceTaskID",
                table: "TransactionLine");

            migrationBuilder.DropForeignKey(
                name: "FK_TransactionLine_Transactions_ID",
                table: "TransactionLine");

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLine_Engineers_EngineerID",
                table: "TransactionLine",
                column: "EngineerID",
                principalTable: "Engineers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TransactionLine_ServiceTasks_ServiceTaskID",
                table: "TransactionLine",
                column: "ServiceTaskID",
                principalTable: "ServiceTasks",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
