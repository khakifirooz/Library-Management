using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibraryInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class IndependentAuth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MemberCredentials_Members_MemberId",
                schema: "dbo",
                table: "MemberCredentials");

            migrationBuilder.DropIndex(
                name: "IX_MemberCredentials_MemberId",
                schema: "dbo",
                table: "MemberCredentials");

            migrationBuilder.DropColumn(
                name: "MemberId",
                schema: "dbo",
                table: "MemberCredentials");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "MemberId",
                schema: "dbo",
                table: "MemberCredentials",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_MemberCredentials_MemberId",
                schema: "dbo",
                table: "MemberCredentials",
                column: "MemberId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_MemberCredentials_Members_MemberId",
                schema: "dbo",
                table: "MemberCredentials",
                column: "MemberId",
                principalSchema: "dbo",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
