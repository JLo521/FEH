using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FEH.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_379 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "Felon",
                table: "Forms",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "HouseholdHumans",
                table: "Forms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "HouseholdPets",
                table: "Forms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "MonthlyIncome",
                table: "Forms",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Felon",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "HouseholdHumans",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "HouseholdPets",
                table: "Forms");

            migrationBuilder.DropColumn(
                name: "MonthlyIncome",
                table: "Forms");
        }
    }
}
