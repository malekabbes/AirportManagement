using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TypeEntiteRetenue2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "PassangerName",
                table: "Passangers",
                newName: "fullname_FirstName");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Passangers",
                newName: "fullname_LastName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "fullname_LastName",
                table: "Passangers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "fullname_FirstName",
                table: "Passangers",
                newName: "PassangerName");
        }
    }
}
