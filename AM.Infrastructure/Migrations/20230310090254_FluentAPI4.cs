using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class FluentAPI4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Table_Flight_Plane_PlaneId",
                table: "Table_Flight");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Plane",
                table: "Plane");

            migrationBuilder.RenameTable(
                name: "Plane",
                newName: "MyPlanes");

            migrationBuilder.RenameColumn(
                name: "Capacity",
                table: "MyPlanes",
                newName: "PlaneCapacity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MyPlanes",
                table: "MyPlanes",
                column: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Table_Flight_MyPlanes_PlaneId",
                table: "Table_Flight",
                column: "PlaneId",
                principalTable: "MyPlanes",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Table_Flight_MyPlanes_PlaneId",
                table: "Table_Flight");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MyPlanes",
                table: "MyPlanes");

            migrationBuilder.RenameTable(
                name: "MyPlanes",
                newName: "Plane");

            migrationBuilder.RenameColumn(
                name: "PlaneCapacity",
                table: "Plane",
                newName: "Capacity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Plane",
                table: "Plane",
                column: "PlaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Table_Flight_Plane_PlaneId",
                table: "Table_Flight",
                column: "PlaneId",
                principalTable: "Plane",
                principalColumn: "PlaneId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
