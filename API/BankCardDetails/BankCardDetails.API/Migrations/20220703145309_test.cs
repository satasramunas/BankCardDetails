using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BankCardDetails.API.Migrations
{
    public partial class test : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BankCards",
                table: "BankCards");

            migrationBuilder.DropColumn(
                name: "CardId",
                table: "BankCards");

            migrationBuilder.AddColumn<Guid>(
                name: "Id",
                table: "BankCards",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_BankCards",
                table: "BankCards",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_BankCards",
                table: "BankCards");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "BankCards");

            migrationBuilder.AddColumn<int>(
                name: "CardId",
                table: "BankCards",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_BankCards",
                table: "BankCards",
                column: "CardId");
        }
    }
}
