using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibraryInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PreserveLoanHistoryAndIntegrity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Books_BookId",
                schema: "dbo",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Members_MemberId",
                schema: "dbo",
                table: "Loans");

            migrationBuilder.AddColumn<DateTime>(
                name: "ReturnedAt",
                schema: "dbo",
                table: "Loans",
                type: "datetime2",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Loans_BookId_Active",
                schema: "dbo",
                table: "Loans",
                column: "BookId",
                unique: true,
                filter: "[Status] = 0");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Books_BookId",
                schema: "dbo",
                table: "Loans",
                column: "BookId",
                principalSchema: "dbo",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Members_MemberId",
                schema: "dbo",
                table: "Loans",
                column: "MemberId",
                principalSchema: "dbo",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Books_BookId",
                schema: "dbo",
                table: "Loans");

            migrationBuilder.DropForeignKey(
                name: "FK_Loans_Members_MemberId",
                schema: "dbo",
                table: "Loans");

            migrationBuilder.DropIndex(
                name: "IX_Loans_BookId_Active",
                schema: "dbo",
                table: "Loans");

            migrationBuilder.DropColumn(
                name: "ReturnedAt",
                schema: "dbo",
                table: "Loans");

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Books_BookId",
                schema: "dbo",
                table: "Loans",
                column: "BookId",
                principalSchema: "dbo",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Loans_Members_MemberId",
                schema: "dbo",
                table: "Loans",
                column: "MemberId",
                principalSchema: "dbo",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
