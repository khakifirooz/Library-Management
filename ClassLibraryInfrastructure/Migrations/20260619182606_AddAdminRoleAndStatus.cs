using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibraryInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddAdminRoleAndStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                schema: "dbo",
                table: "MemberCredentials",
                type: "bit",
                nullable: false,
                defaultValue: true);

            migrationBuilder.AddColumn<string>(
                name: "Role",
                schema: "dbo",
                table: "MemberCredentials",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "Admin");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsActive",
                schema: "dbo",
                table: "MemberCredentials");

            migrationBuilder.DropColumn(
                name: "Role",
                schema: "dbo",
                table: "MemberCredentials");
        }
    }
}
