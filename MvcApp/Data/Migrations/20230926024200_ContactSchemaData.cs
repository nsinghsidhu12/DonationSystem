using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MvcApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class ContactSchemaData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    AccountNo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    Street = table.Column<string>(type: "TEXT", nullable: true),
                    City = table.Column<string>(type: "TEXT", nullable: true),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: true),
                    Country = table.Column<string>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Modified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.AccountNo);
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "AccountNo", "City", "Country", "Created", "CreatedBy", "Email", "FirstName", "LastName", "Modified", "ModifiedBy", "PostalCode", "Street" },
                values: new object[,]
                {
                    { 1, "Edmonton", "Canada", new DateTime(2023, 9, 26, 2, 42, 0, 719, DateTimeKind.Utc).AddTicks(3447), "System", "connor@mcdavid.com", "Connor", "McDavid", new DateTime(2023, 9, 26, 2, 42, 0, 719, DateTimeKind.Utc).AddTicks(3450), "System", "T5J 0H6", "10220 104 Ave NW" },
                    { 2, "Ottawa", "Canada", new DateTime(2023, 9, 26, 2, 42, 0, 719, DateTimeKind.Utc).AddTicks(3456), "System", "thomas@chabot.com", "Thomas", "Chabot", new DateTime(2023, 9, 26, 2, 42, 0, 719, DateTimeKind.Utc).AddTicks(3456), "System", "K2V 1A5", "1000 Palladium Dr" },
                    { 3, "Winnipeg", "Canada", new DateTime(2023, 9, 26, 2, 42, 0, 719, DateTimeKind.Utc).AddTicks(3458), "System", "josh@morrisey.com", "Josh", "Morrissey", new DateTime(2023, 9, 26, 2, 42, 0, 719, DateTimeKind.Utc).AddTicks(3458), "System", "R3C 5S4", "300 Portage Ave" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contact");
        }
    }
}
