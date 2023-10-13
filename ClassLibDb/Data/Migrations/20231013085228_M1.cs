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
                    { "428fd76f-aee2-45ba-97db-4914a1c56235", null, "Finance", "FINANCE" },
                    { "5ee4e3bc-bcf1-4591-88c7-b6c5e30748dc", null, "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "9d42785b-fa7d-4213-ae3e-0aa27994b04f", 0, "2b82ba1d-1a7e-415b-a4d2-3fb57d91e1d7", "f@f.f", true, false, null, "F@F.F", "F@F.F", "AQAAAAIAAYagAAAAEKQ1fhmfNFj/R6N5cmI8qKGsnItRd1dkhXWfjMtws6Uv5UMhZuXl1oI7plQYcWWUlg==", null, false, "6789cc44-9406-4106-a685-8f7636672cb1", false, "f@f.f" },
                    { "b4492509-39cc-4fb3-a456-7c4c625e46fb", 0, "ad0b876d-e7e2-4f3a-a71e-0270726e93c1", "a@a.a", true, false, null, "A@A.A", "A@A.A", "AQAAAAIAAYagAAAAEOjb8jI761vgISukmuZDeezOtoL9BaOUem63b7gWuQekL4TK6vDrxQDUtlV/nq6Hng==", null, false, "a0050bea-afe2-4f50-9dcc-c5f7ec61d46d", false, "a@a.a" }
                });

            migrationBuilder.InsertData(
                table: "Contact",
                columns: new[] { "AccountNo", "City", "Country", "Created", "CreatedBy", "Email", "FirstName", "LastName", "Modified", "ModifiedBy", "PostalCode", "Street" },
                values: new object[,]
                {
                    { 1, "Edmonton", "Canada", new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7277), "System", "connor@mcdavid.com", "Connor", "McDavid", new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7277), "System", "T5J 0H6", "10220 104 Ave NW" },
                    { 2, "Ottawa", "Canada", new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7277), "System", "thomas@chabot.com", "Thomas", "Chabot", new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7277), "System", "K2V 1A5", "1000 Palladium Dr" },
                    { 3, "Winnipeg", "Canada", new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7277), "System", "josh@morrisey.com", "Josh", "Morrissey", new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7277), "System", "R3C 5S4", "300 Portage Ave" }
                });

            migrationBuilder.InsertData(
                table: "PaymentMethod",
                columns: new[] { "PaymentMethodId", "Created", "CreatedBy", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7324), "System", new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7324), "System", "Direct Deposit" },
                    { 2, new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7324), "System", new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7324), "System", "Paypal" },
                    { 3, new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7324), "System", new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7324), "System", "Cheque" }
                });

            migrationBuilder.InsertData(
                table: "TransactionType",
                columns: new[] { "TransactionTypeId", "Created", "CreatedBy", "Description", "Modified", "ModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7306), "System", "Donations made without any special purpose", new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7306), "System", "General Donation" },
                    { 2, new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7306), "System", "Donations made for homeless people", new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7306), "System", "Food for homeless" },
                    { 3, new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7306), "System", "Donations for the purpose of upgrading the gym", new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7306), "System", "Repair of Gym" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "428fd76f-aee2-45ba-97db-4914a1c56235", "9d42785b-fa7d-4213-ae3e-0aa27994b04f" },
                    { "5ee4e3bc-bcf1-4591-88c7-b6c5e30748dc", "b4492509-39cc-4fb3-a456-7c4c625e46fb" }
                });

            migrationBuilder.InsertData(
                table: "Donation",
                columns: new[] { "TransId", "AccountNo", "Amount", "Created", "CreatedBy", "Date", "Modified", "ModifiedBy", "Notes", "PaymentMethodId", "TransactionTypeId" },
                values: new object[,]
                {
                    { 1, 1, 100.0, new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7348), "System", new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7348), new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7348), "System", "Making a general donation using direct deposit", 1, 1 },
                    { 2, 2, 200.0, new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7348), "System", new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7348), new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7348), "System", "Making a donation for food for homeless people using paypal", 2, 2 },
                    { 3, 3, 300.0, new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7348), "System", new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7348), new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7348), "System", "Making a donation for upgrading the gym using a cheque", 3, 3 },
                    { 4, 1, 150.0, new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7348), "System", new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7348), new DateTime(2023, 10, 13, 8, 52, 28, 465, DateTimeKind.Utc).AddTicks(7348), "System", "General donation using paypal", 2, 1 }
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
