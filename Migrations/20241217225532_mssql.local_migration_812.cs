using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FEH.Migrations
{
    /// <inheritdoc />
    public partial class mssqllocal_migration_812 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserID",
                table: "Forms",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "UserID",
                table: "Forms");
        }
    }
}
