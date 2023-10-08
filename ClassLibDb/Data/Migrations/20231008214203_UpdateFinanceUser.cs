using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassLibDb.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateFinanceUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d479b39e-7ff1-4cf2-9c91-dced1dedaf13", null, "Admin", "ADMIN" },
                    { "d8a6e6fb-04e8-41b4-bc8d-e2ef572ebd45", null, "Finance", "FINANCE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "84e27cee-85fc-4617-baa0-09a819bed38b", 0, "8b9dfe51-35bf-4840-b848-73a05bbe36ca", "f@f.f", true, false, null, "F@F.F", "F@F.F", "AQAAAAIAAYagAAAAELUMAR/v1VCl4FypWe+uSiunwM6TyDlqPmDnm0gqMMTlwZq5IzB4AOXJKBI8wpo3SQ==", null, false, "aa541cdb-daec-4a6a-927b-6e2fd6c9e0dc", false, "f@f.f" },
                    { "f4a2131e-d6c2-4dbe-baf4-2a44998da264", 0, "8c5681fe-131f-4ab6-a085-99f32ff93b8a", "aa@aa.aa", true, false, null, "AA@AA.AA", "AA@AA.AA", "AQAAAAIAAYagAAAAEHPL9Jav69yTUtulR91VmD5rzWz7FyN83GqTeBq7wDHYtvaUT7DJLbM1DL1BnY37RA==", null, false, "c25d13d4-c7e5-4815-a5ca-f6c8a84db3da", false, "aa@aa.aa" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "d8a6e6fb-04e8-41b4-bc8d-e2ef572ebd45", "84e27cee-85fc-4617-baa0-09a819bed38b" },
                    { "d479b39e-7ff1-4cf2-9c91-dced1dedaf13", "f4a2131e-d6c2-4dbe-baf4-2a44998da264" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d8a6e6fb-04e8-41b4-bc8d-e2ef572ebd45", "84e27cee-85fc-4617-baa0-09a819bed38b" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d479b39e-7ff1-4cf2-9c91-dced1dedaf13", "f4a2131e-d6c2-4dbe-baf4-2a44998da264" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d479b39e-7ff1-4cf2-9c91-dced1dedaf13");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d8a6e6fb-04e8-41b4-bc8d-e2ef572ebd45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84e27cee-85fc-4617-baa0-09a819bed38b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4a2131e-d6c2-4dbe-baf4-2a44998da264");

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
    }
}
