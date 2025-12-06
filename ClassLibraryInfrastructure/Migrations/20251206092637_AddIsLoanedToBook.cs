using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibraryInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddIsLoanedToBook : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsLoaned",
                schema: "dbo",
                table: "Books",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsLoaned",
                schema: "dbo",
                table: "Books");
        }
    }
}
