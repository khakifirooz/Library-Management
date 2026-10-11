using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibraryInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class EnforceUniqueMemberIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Members_NationalCode",
                schema: "dbo",
                table: "Members",
                column: "NationalCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_MemberCredentials_UserName",
                schema: "dbo",
                table: "MemberCredentials",
                column: "UserName",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Members_NationalCode",
                schema: "dbo",
                table: "Members");

            migrationBuilder.DropIndex(
                name: "IX_MemberCredentials_UserName",
                schema: "dbo",
                table: "MemberCredentials");
        }
    }
}
