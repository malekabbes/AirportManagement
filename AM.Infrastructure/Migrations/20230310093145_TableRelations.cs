using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class TableRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassanger_Passangers_passangersPassportNumber",
                table: "FlightPassanger");

            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassanger_Table_Flight_flightsFlightId",
                table: "FlightPassanger");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FlightPassanger",
                table: "FlightPassanger");

            migrationBuilder.RenameTable(
                name: "FlightPassanger",
                newName: "Table_PassangerFlight");

            migrationBuilder.RenameIndex(
                name: "IX_FlightPassanger_passangersPassportNumber",
                table: "Table_PassangerFlight",
                newName: "IX_Table_PassangerFlight_passangersPassportNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Table_PassangerFlight",
                table: "Table_PassangerFlight",
                columns: new[] { "flightsFlightId", "passangersPassportNumber" });

            migrationBuilder.AddForeignKey(
                name: "FK_Table_PassangerFlight_Passangers_passangersPassportNumber",
                table: "Table_PassangerFlight",
                column: "passangersPassportNumber",
                principalTable: "Passangers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Table_PassangerFlight_Table_Flight_flightsFlightId",
                table: "Table_PassangerFlight",
                column: "flightsFlightId",
                principalTable: "Table_Flight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Table_PassangerFlight_Passangers_passangersPassportNumber",
                table: "Table_PassangerFlight");

            migrationBuilder.DropForeignKey(
                name: "FK_Table_PassangerFlight_Table_Flight_flightsFlightId",
                table: "Table_PassangerFlight");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Table_PassangerFlight",
                table: "Table_PassangerFlight");

            migrationBuilder.RenameTable(
                name: "Table_PassangerFlight",
                newName: "FlightPassanger");

            migrationBuilder.RenameIndex(
                name: "IX_Table_PassangerFlight_passangersPassportNumber",
                table: "FlightPassanger",
                newName: "IX_FlightPassanger_passangersPassportNumber");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FlightPassanger",
                table: "FlightPassanger",
                columns: new[] { "flightsFlightId", "passangersPassportNumber" });

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassanger_Passangers_passangersPassportNumber",
                table: "FlightPassanger",
                column: "passangersPassportNumber",
                principalTable: "Passangers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassanger_Table_Flight_flightsFlightId",
                table: "FlightPassanger",
                column: "flightsFlightId",
                principalTable: "Table_Flight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
