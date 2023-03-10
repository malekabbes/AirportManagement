using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class testztat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fullname_LastName",
                table: "Passangers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "fullname_FirstName",
                table: "Passangers",
                newName: "FirstName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Passangers",
                newName: "fullname_LastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Passangers",
                newName: "fullname_FirstName");
        }
    }
}
