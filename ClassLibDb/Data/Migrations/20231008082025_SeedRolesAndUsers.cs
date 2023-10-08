using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassLibDb.Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedRolesAndUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Donation",
                keyColumn: "TransId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Donation",
                keyColumn: "TransId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Donation",
                keyColumn: "TransId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "AccountNo",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "AccountNo",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Contact",
                keyColumn: "AccountNo",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PaymentMethod",
                keyColumn: "PaymentMethodId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PaymentMethod",
                keyColumn: "PaymentMethodId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PaymentMethod",
                keyColumn: "PaymentMethodId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "TransactionType",
                keyColumn: "TransactionTypeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "TransactionType",
                keyColumn: "TransactionTypeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "TransactionType",
                keyColumn: "TransactionTypeId",
                keyValue: 3);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TransactionType",
                type: "TEXT",
                maxLength: 64,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TransactionType",
                type: "TEXT",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PaymentMethod",
                type: "TEXT",
                maxLength: 64,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Donation",
                type: "TEXT",
                maxLength: 256,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Contact",
                type: "TEXT",
                maxLength: 64,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Contact",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Contact",
                type: "TEXT",
                maxLength: 64,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Contact",
                type: "TEXT",
                maxLength: 64,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Contact",
                type: "TEXT",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Contact",
                type: "TEXT",
                maxLength: 64,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Contact",
                type: "TEXT",
                maxLength: 64,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9bbee4dd-86e9-4666-8bb8-4055ad20d2b3", null, "Finance", "FINANCE" },
                    { "d48f1596-aec2-4276-8dfa-1495b0d04913", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "328ed5da-2bef-4ded-9128-8b3bea14d6a5", 0, "e52cc55c-8007-4f47-a83b-aaf079ddee5f", "mm@mm.mm", true, false, null, "MM@MM.MM", "MM@MM.MM", "AQAAAAIAAYagAAAAEDgqOk2Fh0+3QZZSmVYpISf9wcSi0+JOTXZgqvoVqgxYuyQNcJ2BZa06HHyP4FWCcA==", null, false, "ddae0a31-8ee7-4dc3-bdf3-2156961e1fa0", false, "mm@mm.mm" },
                    { "8c862689-7bd3-4aef-8549-27ae1030c6c0", 0, "491d29d5-83a5-4efe-a64d-770f50efaa30", "aa@aa.aa", true, false, null, "AA@AA.AA", "AA@AA.AA", "AQAAAAIAAYagAAAAEFfS8fWSfiuATFiTWj4hbC6MYFSO1EsQZvYnApFf62QqIxBVfpQ8RC8oZn/EDgYLDQ==", null, false, "cf51809a-a272-4fb4-a14e-8659f35ca373", false, "aa@aa.aa" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "9bbee4dd-86e9-4666-8bb8-4055ad20d2b3", "328ed5da-2bef-4ded-9128-8b3bea14d6a5" },
                    { "d48f1596-aec2-4276-8dfa-1495b0d04913", "8c862689-7bd3-4aef-8549-27ae1030c6c0" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9bbee4dd-86e9-4666-8bb8-4055ad20d2b3", "328ed5da-2bef-4ded-9128-8b3bea14d6a5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d48f1596-aec2-4276-8dfa-1495b0d04913", "8c862689-7bd3-4aef-8549-27ae1030c6c0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9bbee4dd-86e9-4666-8bb8-4055ad20d2b3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d48f1596-aec2-4276-8dfa-1495b0d04913");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "328ed5da-2bef-4ded-9128-8b3bea14d6a5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8c862689-7bd3-4aef-8549-27ae1030c6c0");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "TransactionType",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "TransactionType",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PaymentMethod",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "Notes",
                table: "Donation",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 256);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Contact",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "PostalCode",
                table: "Contact",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "Contact",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "Contact",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Contact",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Contact",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Contact",
                type: "TEXT",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "TEXT",
                oldMaxLength: 64);

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "AccountNo", "City", "Country", "Created", "CreatedBy", "Email", "FirstName", "LastName", "Modified", "ModifiedBy", "PostalCode", "Street" },
                values: new object[,]
                {
                    { 1, "Edmonton", "Canada", new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6597), "System", "connor@mcdavid.com", "Connor", "McDavid", new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6599), "System", "T5J 0H6", "10220 104 Ave NW" },
                    { 2, "Ottawa", "Canada", new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6604), "System", "thomas@chabot.com", "Thomas", "Chabot", new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6604), "System", "K2V 1A5", "1000 Palladium Dr" },
                    { 3, "Winnipeg", "Canada", new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6606), "System", "josh@morrisey.com", "Josh", "Morrissey", new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6606), "System", "R3C 5S4", "300 Portage Ave" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "PaymentMethodId", "Created", "CreatedBy", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6648), "System", new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6649), "System", "Direct Deposit" },
                    { 2, new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6651), "System", new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6651), "System", "Paypal" },
                    { 3, new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6653), "System", new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6653), "System", "Cheque" }
                });

            migrationBuilder.InsertData(
                table: "TransactionType",
                columns: new[] { "TransactionTypeId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6628), "System", "Donations made without any special purpose", new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6628), "System", "General Donation" },
                    { 2, new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6632), "System", "Donations made for homeless people", new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6632), "System", "Food for homeless" },
                    { 3, new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6634), "System", "Donations for the purpose of upgrading the gym", new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6634), "System", "Repair of Gym" }
                });

            migrationBuilder.InsertData(
                table: "Donation",
                columns: new[] { "TransId", "AccountNo", "Amount", "Created", "CreatedBy", "Date", "Modified", "ModifiedBy", "Notes", "PaymentMethodId", "TransactionTypeId" },
                values: new object[,]
                {
                    { 1, 1, 100f, new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6669), "System", new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6668), new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6670), "System", "Making a general donation using direct deposit", 1, 1 },
                    { 2, 2, 200f, new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6672), "System", new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6671), new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6673), "System", "Making a donation for food for homeless people using paypal", 2, 2 },
                    { 3, 3, 300f, new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6674), "System", new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6674), new DateTime(2023, 9, 29, 4, 16, 42, 486, DateTimeKind.Utc).AddTicks(6675), "System", "Making a donation for upgrading the gym using a cheque", 3, 3 }
                });
        }
    }
}
