using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ffa : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Passanger",
                newName: "fullname_LastName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Passanger",
                newName: "fullname_FirstName");

            migrationBuilder.AlterColumn<string>(
                name: "fullname_LastName",
                table: "Passanger",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "fullname_FirstName",
                table: "Passanger",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20);

            migrationBuilder.CreateTable(
                name: "Table_Ticket",
                columns: table => new
                {
                    FlightFK = table.Column<int>(type: "int", nullable: false),
                    PassengerFK = table.Column<int>(type: "int", nullable: false),
                    VIP = table.Column<bool>(type: "bit", nullable: false),
                    Siege = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    prix = table.Column<double>(type: "float(2)", precision: 2, scale: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table_Ticket", x => new { x.PassengerFK, x.FlightFK });
                    table.ForeignKey(
                        name: "FK_Table_Ticket_Passanger_PassengerFK",
                        column: x => x.PassengerFK,
                        principalTable: "Passanger",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Table_Ticket_Table_Flight_FlightFK",
                        column: x => x.FlightFK,
                        principalTable: "Table_Flight",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Table_Ticket_FlightFK",
                table: "Table_Ticket",
                column: "FlightFK");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Table_Ticket");

            migrationBuilder.RenameColumn(
                name: "fullname_LastName",
                table: "Passanger",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "fullname_FirstName",
                table: "Passanger",
                newName: "FirstName");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Passanger",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Passanger",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50);
        }
    }
}
