using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AM.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class neww : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Table_PassangerFlight_Passangers_passangersPassportNumber",
                table: "Table_PassangerFlight");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passangers",
                table: "Passangers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Passangers");

            migrationBuilder.DropColumn(
                name: "EmployementDate",
                table: "Passangers");

            migrationBuilder.DropColumn(
                name: "Function",
                table: "Passangers");

            migrationBuilder.DropColumn(
                name: "HealthInformation",
                table: "Passangers");

            migrationBuilder.DropColumn(
                name: "Nationality",
                table: "Passangers");

            migrationBuilder.DropColumn(
                name: "Salary",
                table: "Passangers");

            migrationBuilder.RenameTable(
                name: "Passangers",
                newName: "Passanger");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passanger",
                table: "Passanger",
                column: "PassportNumber");

            migrationBuilder.CreateTable(
                name: "Staff",
                columns: table => new
                {
                    PassportNumber = table.Column<int>(type: "int", maxLength: 7, nullable: false),
                    EmployementDate = table.Column<DateTime>(type: "date", nullable: false),
                    Function = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Salary = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Staff", x => x.PassportNumber);
                    table.ForeignKey(
                        name: "FK_Staff_Passanger_PassportNumber",
                        column: x => x.PassportNumber,
                        principalTable: "Passanger",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Traveller",
                columns: table => new
                {
                    PassportNumber = table.Column<int>(type: "int", maxLength: 7, nullable: false),
                    HealthInformation = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false),
                    Nationality = table.Column<string>(type: "varchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Traveller", x => x.PassportNumber);
                    table.ForeignKey(
                        name: "FK_Traveller_Passanger_PassportNumber",
                        column: x => x.PassportNumber,
                        principalTable: "Passanger",
                        principalColumn: "PassportNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Table_PassangerFlight_Passanger_passangersPassportNumber",
                table: "Table_PassangerFlight",
                column: "passangersPassportNumber",
                principalTable: "Passanger",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Table_PassangerFlight_Passanger_passangersPassportNumber",
                table: "Table_PassangerFlight");

            migrationBuilder.DropTable(
                name: "Staff");

            migrationBuilder.DropTable(
                name: "Traveller");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Passanger",
                table: "Passanger");

            migrationBuilder.RenameTable(
                name: "Passanger",
                newName: "Passangers");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Passangers",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Passangers",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Passangers",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "EmployementDate",
                table: "Passangers",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Function",
                table: "Passangers",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "HealthInformation",
                table: "Passangers",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nationality",
                table: "Passangers",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Salary",
                table: "Passangers",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Passangers",
                table: "Passangers",
                column: "PassportNumber");

            migrationBuilder.AddForeignKey(
                name: "FK_Table_PassangerFlight_Passangers_passangersPassportNumber",
                table: "Table_PassangerFlight",
                column: "passangersPassportNumber",
                principalTable: "Passangers",
                principalColumn: "PassportNumber",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
