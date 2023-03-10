using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FluentAPI3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassanger_Flights_flightsFlightId",
                table: "FlightPassanger");

            migrationBuilder.DropForeignKey(
                name: "FK_Flights_Plane_PlaneId",
                table: "Flights");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Flights",
                table: "Flights");

            migrationBuilder.RenameTable(
                name: "Flights",
                newName: "Table_Flight");

            migrationBuilder.RenameIndex(
                name: "IX_Flights_PlaneId",
                table: "Table_Flight",
                newName: "IX_Table_Flight_PlaneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Table_Flight",
                table: "Table_Flight",
                column: "FlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassanger_Table_Flight_flightsFlightId",
                table: "FlightPassanger",
                column: "flightsFlightId",
                principalTable: "Table_Flight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Table_Flight_Plane_PlaneId",
                table: "Table_Flight",
                column: "PlaneId",
                principalTable: "Plane",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassanger_Table_Flight_flightsFlightId",
                table: "FlightPassanger");

            migrationBuilder.DropForeignKey(
                name: "FK_Table_Flight_Plane_PlaneId",
                table: "Table_Flight");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Table_Flight",
                table: "Table_Flight");

            migrationBuilder.RenameTable(
                name: "Table_Flight",
                newName: "Flights");

            migrationBuilder.RenameIndex(
                name: "IX_Table_Flight_PlaneId",
                table: "Flights",
                newName: "IX_Flights_PlaneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Flights",
                table: "Flights",
                column: "FlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassanger_Flights_flightsFlightId",
                table: "FlightPassanger",
                column: "flightsFlightId",
                principalTable: "Flights",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Flights_Plane_PlaneId",
                table: "Flights",
                column: "PlaneId",
                principalTable: "Plane",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
