using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ClassLibDb.Data.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
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
                    { "945f0745-f8e1-4598-b295-555ac51f1dd3", null, "Admin", "ADMIN" },
                    { "b68005ba-2157-4c09-a439-84c1d8a3bfa8", null, "Finance", "FINANCE" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2acc1944-002d-4e48-929c-26573ba8728b", 0, "8eb7bb19-98b8-4dd7-b860-be0e46727b77", "f@f.f", true, false, null, "F@F.F", "F@F.F", "AQAAAAIAAYagAAAAECz/GtwkEIlSPQDTSeQhVpMBoVAx8ibyQHVyuXXWu27xb5QNyd92fDv0hKa8ocUG7Q==", null, false, "1216fb31-ee04-44a2-a843-22637c08df63", false, "f@f.f" },
                    { "96ee338d-bfc1-4b20-979f-12dc2d1cecae", 0, "2725da24-def2-45ad-a916-e627caccb00b", "a@a.a", true, false, null, "A@A.A", "A@A.A", "AQAAAAIAAYagAAAAEByrhKcMkepDEvN976+exHIgdjTOZPhcy0njJGc1C6QeJcjKGAMlsJtX0TcSqnieuA==", null, false, "e7e815d3-2bc1-4045-b5e8-e8804a69192b", false, "a@a.a" }
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "AccountNo", "City", "Country", "Created", "CreatedBy", "Email", "FirstName", "LastName", "Modified", "ModifiedBy", "PostalCode", "Street" },
                values: new object[,]
                {
                    { 1, "Edmonton", "Canada", new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4104), "System", "connor@mcdavid.com", "Connor", "McDavid", new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4104), "System", "T5J 0H6", "10220 104 Ave NW" },
                    { 2, "Ottawa", "Canada", new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4104), "System", "thomas@chabot.com", "Thomas", "Chabot", new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4104), "System", "K2V 1A5", "1000 Palladium Dr" },
                    { 3, "Winnipeg", "Canada", new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4104), "System", "josh@morrisey.com", "Josh", "Morrissey", new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4104), "System", "R3C 5S4", "300 Portage Ave" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "PaymentMethodId", "Created", "CreatedBy", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4156), "System", new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4156), "System", "Direct Deposit" },
                    { 2, new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4156), "System", new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4156), "System", "Paypal" },
                    { 3, new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4156), "System", new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4156), "System", "Cheque" }
                });

            migrationBuilder.InsertData(
                table: "TransactionType",
                columns: new[] { "TransactionTypeId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4135), "System", "Donations made without any special purpose", new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4135), "System", "General Donation" },
                    { 2, new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4135), "System", "Donations made for homeless people", new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4135), "System", "Food for homeless" },
                    { 3, new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4135), "System", "Donations for the purpose of upgrading the gym", new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4135), "System", "Repair of Gym" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b68005ba-2157-4c09-a439-84c1d8a3bfa8", "2acc1944-002d-4e48-929c-26573ba8728b" },
                    { "945f0745-f8e1-4598-b295-555ac51f1dd3", "96ee338d-bfc1-4b20-979f-12dc2d1cecae" }
                });

            migrationBuilder.InsertData(
                table: "Donation",
                columns: new[] { "TransId", "AccountNo", "Amount", "Created", "CreatedBy", "Date", "Modified", "ModifiedBy", "Notes", "PaymentMethodId", "TransactionTypeId" },
                values: new object[,]
                {
                    { 1, 1, 100.0, new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4175), "System", new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4175), new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4175), "System", "Making a general donation using direct deposit", 1, 1 },
                    { 2, 2, 200.0, new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4175), "System", new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4175), new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4175), "System", "Making a donation for food for homeless people using paypal", 2, 2 },
                    { 3, 3, 300.0, new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4175), "System", new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4175), new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4175), "System", "Making a donation for upgrading the gym using a cheque", 3, 3 }
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
