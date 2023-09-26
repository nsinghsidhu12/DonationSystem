using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MvcApp.Data.Migrations
{
    /// <inheritdoc />
    public partial class DonationSchemaData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Donation",
                columns: table => new
                {
                    TransId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AccountNo = table.Column<int>(type: "INTEGER", nullable: false),
                    TransactionTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Amount = table.Column<float>(type: "REAL", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "INTEGER", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", nullable: true),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Modified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Donation", x => x.TransId);
                    table.ForeignKey(
                        name: "FK_Donation_Contact_AccountNo",
                        column: x => x.AccountNo,
                        principalTable: "Contact",
                        principalColumn: "AccountNo",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donation_PaymentMethod_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethod",
                        principalColumn: "PaymentMethodId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Donation_TransactionType_TransactionTypeId",
                        column: x => x.TransactionTypeId,
                        principalTable: "TransactionType",
                        principalColumn: "TransactionTypeId",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Donation",
                columns: new[] { "TransId", "AccountNo", "Amount", "Created", "CreatedBy", "Date", "Modified", "ModifiedBy", "Notes", "PaymentMethodId", "TransactionTypeId" },
                values: new object[,]
                {
                    { 1, 1, 100f, new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4208), "System", new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4207), new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4209), "System", "Making a general donation using direct deposit", 1, 1 },
                    { 2, 2, 200f, new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4212), "System", new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4211), new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4212), "System", "Making a donation for food for homeless people using paypal", 2, 2 },
                    { 3, 3, 300f, new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4214), "System", new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4213), new DateTime(2023, 9, 26, 5, 31, 40, 388, DateTimeKind.Utc).AddTicks(4215), "System", "Making a donation for upgrading the gym using a cheque", 3, 3 }
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Donation_AccountNo",
                table: "Donation",
                column: "AccountNo");

            migrationBuilder.CreateIndex(
                name: "IX_Donation_PaymentMethodId",
                table: "Donation",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_Donation_TransactionTypeId",
                table: "Donation",
                column: "TransactionTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Donation");

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

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "PaymentMethodId",
                keyValue: 1,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1412), new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1413) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "PaymentMethodId",
                keyValue: 2,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1416), new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1416) });

            migrationBuilder.UpdateData(
                table: "PaymentMethod",
                keyColumn: "PaymentMethodId",
                keyValue: 3,
                columns: new[] { "Created", "Modified" },
                values: new object[] { new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1417), new DateTime(2023, 9, 26, 4, 49, 58, 996, DateTimeKind.Utc).AddTicks(1418) });

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
    }
}
