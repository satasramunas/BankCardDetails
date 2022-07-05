using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankCardDetails.API.Migrations
{
    public partial class id2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Id",
                table: "BankCards",
                newName: "CardId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "CardId",
                table: "BankCards",
                newName: "Id");
        }
    }
}
