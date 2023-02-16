using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class test : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Passangers_Flights_FlightId",
                table: "Passangers");

            migrationBuilder.DropIndex(
                name: "IX_Passangers_FlightId",
                table: "Passangers");

            migrationBuilder.DropColumn(
                name: "FlightId",
                table: "Passangers");

            migrationBuilder.CreateTable(
                name: "FlightPassanger",
                columns: table => new
                {
                    flightsFlightId = table.Column<int>(type: "int", nullable: false),
                    passangersPassportNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FlightPassanger", x => new { x.flightsFlightId, x.passangersPassportNumber });
                    table.ForeignKey(
                        name: "FK_FlightPassanger_Flights_flightsFlightId",
                        column: x => x.flightsFlightId,
                        principalTable: "Flights",
                        principalColumn: "FlightId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FlightPassanger_Passangers_passangersPassportNumber",
                        column: x => x.passangersPassportNumber,
                        principalTable: "Passangers",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FlightPassanger_passangersPassportNumber",
                table: "FlightPassanger",
                column: "passangersPassportNumber");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FlightPassanger");

            migrationBuilder.AddColumn<int>(
                name: "FlightId",
                table: "Passangers",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Passangers_FlightId",
                table: "Passangers",
                column: "FlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_Passangers_Flights_FlightId",
                table: "Passangers",
                column: "FlightId",
                principalTable: "Flights",
                principalColumn: "FlightId");
        }
    }
}
