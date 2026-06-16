using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClassLibraryInfrastructure.Migrations
{
    /// <inheritdoc />
    public partial class LoginForm2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "char(11)",
                schema: "dbo",
                table: "Members",
                newName: "Mobile");

            migrationBuilder.RenameColumn(
                name: "char(10)",
                schema: "dbo",
                table: "Members",
                newName: "NationalCode");

            migrationBuilder.AlterColumn<string>(
                name: "Mobile",
                schema: "dbo",
                table: "Members",
                type: "char(11)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "NationalCode",
                schema: "dbo",
                table: "Members",
                type: "char(10)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "MemberCredentials",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberCredentials", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MemberCredentials_Members_MemberId",
                        column: x => x.MemberId,
                        principalSchema: "dbo",
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MemberCredentials_MemberId",
                schema: "dbo",
                table: "MemberCredentials",
                column: "MemberId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MemberCredentials",
                schema: "dbo");

            migrationBuilder.RenameColumn(
                name: "NationalCode",
                schema: "dbo",
                table: "Members",
                newName: "char(10)");

            migrationBuilder.RenameColumn(
                name: "Mobile",
                schema: "dbo",
                table: "Members",
                newName: "char(11)");

            migrationBuilder.AlterColumn<string>(
                name: "char(10)",
                schema: "dbo",
                table: "Members",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(10)");

            migrationBuilder.AlterColumn<string>(
                name: "char(11)",
                schema: "dbo",
                table: "Members",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(11)");
        }
    }
}
