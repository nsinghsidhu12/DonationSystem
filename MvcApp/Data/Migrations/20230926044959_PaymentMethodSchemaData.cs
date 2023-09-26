using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MvcApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class PaymentMethodSchemaData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    PaymentMethodId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Modified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.PaymentMethodId);
                });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "AccountNo",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1355), new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1356) });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "AccountNo",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1363), new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1363) });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "AccountNo",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1365), new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1365) });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "PaymentMethodId", "Created", "CreatedBy", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1412), "System", new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1413), "System", "Direct Deposit" },
                    { 2, new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1416), "System", new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1416), "System", "Paypal" },
                    { 3, new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1417), "System", new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1418), "System", "Cheque" }
                });

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1390), new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1391) });

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1394), new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1394) });

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1395), new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1396) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentMethod");

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

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 3, 18, 6, 367, DateTimeKind.Utc).AddTicks(2728), new DateTime(2023, 9, 26, 3, 18, 6, 367, DateTimeKind.Utc).AddTicks(2728) });

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 3, 18, 6, 367, DateTimeKind.Utc).AddTicks(2731), new DateTime(2023, 9, 26, 3, 18, 6, 367, DateTimeKind.Utc).AddTicks(2732) });

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 3, 18, 6, 367, DateTimeKind.Utc).AddTicks(2733), new DateTime(2023, 9, 26, 3, 18, 6, 367, DateTimeKind.Utc).AddTicks(2733) });
        }
    }
}
