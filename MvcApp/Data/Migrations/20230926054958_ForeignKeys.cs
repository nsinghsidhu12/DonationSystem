using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MvcApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class ForeignKeys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "AccountNo",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(124), new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(126) });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "AccountNo",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(130), new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(130) });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "AccountNo",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(132), new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(132) });

            migrationBuilder.UpdateData(
                table: "Donation",
                keyColumn: "TransId",
                keyValue: 1,
                columns: new[] { "Created", "Date", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(234), new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(233), new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(234) });

            migrationBuilder.UpdateData(
                table: "Donation",
                keyColumn: "TransId",
                keyValue: 2,
                columns: new[] { "Created", "Date", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(238), new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(237), new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(238) });

            migrationBuilder.UpdateData(
                table: "Donation",
                keyColumn: "TransId",
                keyValue: 3,
                columns: new[] { "Created", "Date", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(240), new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(239), new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(240) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "PaymentMethodId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(211), new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(212) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "PaymentMethodId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(215), new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(216) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "PaymentMethodId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(217), new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(217) });

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(189), new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(190) });

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(193), new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(194) });

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(195), new DateTime(2023, 9, 26, 5, 49, 58, 660, DateTimeKind.Utc).AddTicks(195) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "AccountNo",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4039), new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4045) });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "AccountNo",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4051), new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4052) });

            migrationBuilder.UpdateData(
                table: "Contact",
                keyColumn: "AccountNo",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4053), new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "Donation",
                keyColumn: "TransId",
                keyValue: 1,
                columns: new[] { "Created", "Date", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4208), new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4207), new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4209) });

            migrationBuilder.UpdateData(
                table: "Donation",
                keyColumn: "TransId",
                keyValue: 2,
                columns: new[] { "Created", "Date", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4212), new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4211), new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4212) });

            migrationBuilder.UpdateData(
                table: "Donation",
                keyColumn: "TransId",
                keyValue: 3,
                columns: new[] { "Created", "Date", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4214), new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4213), new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4215) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "PaymentMethodId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4162), new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4162) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "PaymentMethodId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4166), new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4166) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "PaymentMethodId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4167), new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4168) });

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4076), new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4077) });

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4079), new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4080) });

            migrationBuilder.UpdateData(
                table: "TransactionType",
                keyColumn: "TransactionTypeId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4081), new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4081) });
        }
    }
}
