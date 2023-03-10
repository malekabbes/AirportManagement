using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FluentAPI2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FlightPassanger_MyFlight_flightsFlightId",
                table: "FlightPassanger");

            migrationBuilder.DropForeignKey(
                name: "FK_MyFlight_Plane_PlaneId",
                table: "MyFlight");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyFlight",
                table: "MyFlight");

            migrationBuilder.RenameTable(
                name: "MyFlight",
                newName: "Flights");

            migrationBuilder.RenameIndex(
                name: "IX_MyFlight_PlaneId",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                newName: "MyFlight");

            migrationBuilder.RenameIndex(
                name: "IX_Flights_PlaneId",
                table: "MyFlight",
                newName: "IX_MyFlight_PlaneId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyFlight",
                table: "MyFlight",
                column: "FlightId");

            migrationBuilder.AddForeignKey(
                name: "FK_FlightPassanger_MyFlight_flightsFlightId",
                table: "FlightPassanger",
                column: "flightsFlightId",
                principalTable: "MyFlight",
                principalColumn: "FlightId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MyFlight_Plane_PlaneId",
                table: "MyFlight",
                column: "PlaneId",
                principalTable: "Plane",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
