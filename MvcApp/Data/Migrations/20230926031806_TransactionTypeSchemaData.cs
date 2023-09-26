using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MvcApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class TransactionTypeSchemaData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TransactionType",
                columns: table => new
                {
                    TransactionTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Description = table.Column<string>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Modified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionType", x => x.TransactionTypeId);
                });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "AccountNo",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 3, 18, 6, 367, DateTimeKind.Utc).AddTicks(2692), new DateTime(2023, 9, 26, 3, 18, 6, 367, DateTimeKind.Utc).AddTicks(2694) });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "AccountNo",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 3, 18, 6, 367, DateTimeKind.Utc).AddTicks(2700), new DateTime(2023, 9, 26, 3, 18, 6, 367, DateTimeKind.Utc).AddTicks(2700) });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "AccountNo",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 3, 18, 6, 367, DateTimeKind.Utc).AddTicks(2702), new DateTime(2023, 9, 26, 3, 18, 6, 367, DateTimeKind.Utc).AddTicks(2702) });

            migrationBuilder.InsertData(
                table: "TransactionType",
                columns: new[] { "TransactionTypeId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 26, 3, 18, 6, 367, DateTimeKind.Utc).AddTicks(2728), "System", "Donations made without any special purpose", new DateTime(2023, 9, 26, 3, 18, 6, 367, DateTimeKind.Utc).AddTicks(2728), "System", "General Donation" },
                    { 2, new DateTime(2023, 9, 26, 3, 18, 6, 367, DateTimeKind.Utc).AddTicks(2731), "System", "Donations made for homeless people", new DateTime(2023, 9, 26, 3, 18, 6, 367, DateTimeKind.Utc).AddTicks(2732), "System", "Food for homeless" },
                    { 3, new DateTime(2023, 9, 26, 3, 18, 6, 367, DateTimeKind.Utc).AddTicks(2733), "System", "Donations for the purpose of upgrading the gym", new DateTime(2023, 9, 26, 3, 18, 6, 367, DateTimeKind.Utc).AddTicks(2733), "System", "Repair of Gym" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TransactionType");

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "AccountNo",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 2, 42, 0, 719, DateTimeKind.Utc).AddTicks(3447), new DateTime(2023, 9, 26, 2, 42, 0, 719, DateTimeKind.Utc).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "AccountNo",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 2, 42, 0, 719, DateTimeKind.Utc).AddTicks(3456), new DateTime(2023, 9, 26, 2, 42, 0, 719, DateTimeKind.Utc).AddTicks(3456) });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "AccountNo",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 2, 42, 0, 719, DateTimeKind.Utc).AddTicks(3458), new DateTime(2023, 9, 26, 2, 42, 0, 719, DateTimeKind.Utc).AddTicks(3458) });
        }
    }
}
