using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassLibDb.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddDonations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "TEXT", nullable: false),
                    UserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "TEXT", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    PasswordHash = table.Column<string>(type: "TEXT", nullable: true),
                    SecurityStamp = table.Column<string>(type: "TEXT", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumber = table.Column<string>(type: "TEXT", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "INTEGER", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "TEXT", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "INTEGER", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    AccountNo = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FirstName = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    LastName = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Street = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    City = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Modified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.AccountNo);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethod",
                columns: table => new
                {
                    PaymentMethodId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Modified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethod", x => x.PaymentMethodId);
                });

            migrationBuilder.CreateTable(
                name: "TransactionType",
                columns: table => new
                {
                    TransactionTypeId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 64, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
                    Created = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Modified = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CreatedBy = table.Column<string>(type: "TEXT", nullable: true),
                    ModifiedBy = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TransactionType", x => x.TransactionTypeId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    ClaimType = table.Column<string>(type: "TEXT", nullable: true),
                    ClaimValue = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderKey = table.Column<string>(type: "TEXT", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "TEXT", nullable: true),
                    UserId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    RoleId = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "TEXT", nullable: false),
                    LoginProvider = table.Column<string>(type: "TEXT", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Value = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Donation",
                columns: table => new
                {
                    TransId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AccountNo = table.Column<int>(type: "INTEGER", nullable: false),
                    TransactionTypeId = table.Column<int>(type: "INTEGER", nullable: false),
                    Amount = table.Column<double>(type: "REAL", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "INTEGER", nullable: false),
                    Notes = table.Column<string>(type: "TEXT", maxLength: 256, nullable: false),
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "182242f0-3a0f-4c00-a02f-8abb64c283fd", null, "Admin", "ADMIN" },
                    { "6a938f3a-7215-4729-8bc2-c9831e559290", null, "Finance", "FINANCE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1d294f85-ea04-4fcc-bb25-d50a15173364", 0, "486f5f67-554a-466f-9a39-3acc9c6aedae", "a@a.a", true, false, null, "A@A.A", "A@A.A", "AQAAAAIAAYagAAAAEEdshW8/Jq6jKykImq2GZmeKObMurdbzqlhtQTiFY2UHIq/wG/RYWBjoMePPTmkUQA==", null, false, "1fc4cc18-0efd-4ef2-b4a7-2551996906cb", false, "a@a.a" },
                    { "444f7b12-aeb0-419d-80f5-8420d976782f", 0, "a045c2a9-0fb3-4aa2-b796-ffb1ce647707", "f@f.f", true, false, null, "F@F.F", "F@F.F", "AQAAAAIAAYagAAAAEAmhr857g+V99z2TRpjY+4FV9jeAcCh93rM8neRWTJHRNnw7TlQMLLG8qTpPfGI3Vw==", null, false, "34f7f94a-5e4c-4989-ac7c-09602e497463", false, "f@f.f" }
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "AccountNo", "City", "Country", "Created", "CreatedBy", "Email", "FirstName", "LastName", "Modified", "ModifiedBy", "PostalCode", "Street" },
                values: new object[,]
                {
                    { 1, "Edmonton", "Canada", new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8320), "System", "connor@mcdavid.com", "Connor", "McDavid", new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8320), "System", "T5J 0H6", "10220 104 Ave NW" },
                    { 2, "Ottawa", "Canada", new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8320), "System", "thomas@chabot.com", "Thomas", "Chabot", new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8320), "System", "K2V 1A5", "1000 Palladium Dr" },
                    { 3, "Winnipeg", "Canada", new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8320), "System", "josh@morrisey.com", "Josh", "Morrissey", new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8320), "System", "R3C 5S4", "300 Portage Ave" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "PaymentMethodId", "Created", "CreatedBy", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8380), "System", new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8380), "System", "Direct Deposit" },
                    { 2, new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8380), "System", new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8380), "System", "Paypal" },
                    { 3, new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8380), "System", new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8380), "System", "Cheque" }
                });

            migrationBuilder.InsertData(
                table: "TransactionType",
                columns: new[] { "TransactionTypeId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8350), "System", "Donations made without any special purpose", new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8350), "System", "General Donation" },
                    { 2, new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8350), "System", "Donations made for homeless people", new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8350), "System", "Food for homeless" },
                    { 3, new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8350), "System", "Donations for the purpose of upgrading the gym", new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8350), "System", "Repair of Gym" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "182242f0-3a0f-4c00-a02f-8abb64c283fd", "1d294f85-ea04-4fcc-bb25-d50a15173364" },
                    { "6a938f3a-7215-4729-8bc2-c9831e559290", "444f7b12-aeb0-419d-80f5-8420d976782f" }
                });

            migrationBuilder.InsertData(
                table: "Donation",
                columns: new[] { "TransId", "AccountNo", "Amount", "Created", "CreatedBy", "Date", "Modified", "ModifiedBy", "Notes", "PaymentMethodId", "TransactionTypeId" },
                values: new object[,]
                {
                    { 1, 1, 100.0, new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8400), "System", new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8400), new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8400), "System", "Making a general donation using direct deposit", 1, 1 },
                    { 2, 2, 200.0, new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8400), "System", new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8400), new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8400), "System", "Making a donation for food for homeless people using paypal", 2, 2 },
                    { 3, 3, 300.0, new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8400), "System", new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8400), new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8400), "System", "Making a donation for upgrading the gym using a cheque", 3, 3 },
                    { 4, 1, 150.0, new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8400), "System", new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8400), new DateTime(2023, 10, 12, 21, 5, 34, 728, DateTimeKind.Utc).AddTicks(8400), "System", "Additional donation from the same person", 2, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true);

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
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Donation");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "PaymentMethod");

            migrationBuilder.DropTable(
                name: "TransactionType");
        }
    }
}
