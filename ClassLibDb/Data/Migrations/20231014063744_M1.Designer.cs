﻿// <auto-generated />
using System;
using ClassLibDb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClassLibDb.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20231014063744_M1")]
    partial class M1
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.11");

            modelBuilder.Entity("ClassLibDb.Models.Contact", b =>
                {
                    b.Property<int>("AccountNo")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("PostalCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.HasKey("AccountNo");

                    b.ToTable("Contact", (string)null);

                    b.HasData(
                        new
                        {
                            AccountNo = 1,
                            City = "Edmonton",
                            Country = "Canada",
                            Created = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4104),
                            CreatedBy = "System",
                            Email = "connor@mcdavid.com",
                            FirstName = "Connor",
                            LastName = "McDavid",
                            Modified = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4104),
                            ModifiedBy = "System",
                            PostalCode = "T5J 0H6",
                            Street = "10220 104 Ave NW"
                        },
                        new
                        {
                            AccountNo = 2,
                            City = "Ottawa",
                            Country = "Canada",
                            Created = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4104),
                            CreatedBy = "System",
                            Email = "thomas@chabot.com",
                            FirstName = "Thomas",
                            LastName = "Chabot",
                            Modified = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4104),
                            ModifiedBy = "System",
                            PostalCode = "K2V 1A5",
                            Street = "1000 Palladium Dr"
                        },
                        new
                        {
                            AccountNo = 3,
                            City = "Winnipeg",
                            Country = "Canada",
                            Created = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4104),
                            CreatedBy = "System",
                            Email = "josh@morrisey.com",
                            FirstName = "Josh",
                            LastName = "Morrissey",
                            Modified = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4104),
                            ModifiedBy = "System",
                            PostalCode = "R3C 5S4",
                            Street = "300 Portage Ave"
                        });
                });

            modelBuilder.Entity("ClassLibDb.Models.Donation", b =>
                {
                    b.Property<int>("TransId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountNo")
                        .HasColumnType("INTEGER");

                    b.Property<double>("Amount")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Notes")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<int>("PaymentMethodId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TransactionTypeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("TransId");

                    b.HasIndex("AccountNo");

                    b.HasIndex("PaymentMethodId");

                    b.HasIndex("TransactionTypeId");

                    b.ToTable("Donation", (string)null);

                    b.HasData(
                        new
                        {
                            TransId = 1,
                            AccountNo = 1,
                            Amount = 100.0,
                            Created = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4175),
                            CreatedBy = "System",
                            Date = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4175),
                            Modified = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4175),
                            ModifiedBy = "System",
                            Notes = "Making a general donation using direct deposit",
                            PaymentMethodId = 1,
                            TransactionTypeId = 1
                        },
                        new
                        {
                            TransId = 2,
                            AccountNo = 2,
                            Amount = 200.0,
                            Created = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4175),
                            CreatedBy = "System",
                            Date = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4175),
                            Modified = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4175),
                            ModifiedBy = "System",
                            Notes = "Making a donation for food for homeless people using paypal",
                            PaymentMethodId = 2,
                            TransactionTypeId = 2
                        },
                        new
                        {
                            TransId = 3,
                            AccountNo = 3,
                            Amount = 300.0,
                            Created = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4175),
                            CreatedBy = "System",
                            Date = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4175),
                            Modified = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4175),
                            ModifiedBy = "System",
                            Notes = "Making a donation for upgrading the gym using a cheque",
                            PaymentMethodId = 3,
                            TransactionTypeId = 3
                        });
                });

            modelBuilder.Entity("ClassLibDb.Models.PaymentMethod", b =>
                {
                    b.Property<int>("PaymentMethodId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.HasKey("PaymentMethodId");

                    b.ToTable("PaymentMethod", (string)null);

                    b.HasData(
                        new
                        {
                            PaymentMethodId = 1,
                            Created = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4156),
                            CreatedBy = "System",
                            Modified = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4156),
                            ModifiedBy = "System",
                            Name = "Direct Deposit"
                        },
                        new
                        {
                            PaymentMethodId = 2,
                            Created = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4156),
                            CreatedBy = "System",
                            Modified = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4156),
                            ModifiedBy = "System",
                            Name = "Paypal"
                        },
                        new
                        {
                            PaymentMethodId = 3,
                            Created = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4156),
                            CreatedBy = "System",
                            Modified = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4156),
                            ModifiedBy = "System",
                            Name = "Cheque"
                        });
                });

            modelBuilder.Entity("ClassLibDb.Models.TransactionType", b =>
                {
                    b.Property<int>("TransactionTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Created")
                        .HasColumnType("TEXT");

                    b.Property<string>("CreatedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Modified")
                        .HasColumnType("TEXT");

                    b.Property<string>("ModifiedBy")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(64)
                        .HasColumnType("TEXT");

                    b.HasKey("TransactionTypeId");

                    b.ToTable("TransactionType", (string)null);

                    b.HasData(
                        new
                        {
                            TransactionTypeId = 1,
                            Created = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4135),
                            CreatedBy = "System",
                            Description = "Donations made without any special purpose",
                            Modified = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4135),
                            ModifiedBy = "System",
                            Name = "General Donation"
                        },
                        new
                        {
                            TransactionTypeId = 2,
                            Created = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4135),
                            CreatedBy = "System",
                            Description = "Donations made for homeless people",
                            Modified = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4135),
                            ModifiedBy = "System",
                            Name = "Food for homeless"
                        },
                        new
                        {
                            TransactionTypeId = 3,
                            Created = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4135),
                            CreatedBy = "System",
                            Description = "Donations for the purpose of upgrading the gym",
                            Modified = new DateTime(2023, 10, 14, 6, 37, 44, 228, DateTimeKind.Utc).AddTicks(4135),
                            ModifiedBy = "System",
                            Name = "Repair of Gym"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "945f0745-f8e1-4598-b295-555ac51f1dd3",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "b68005ba-2157-4c09-a439-84c1d8a3bfa8",
                            Name = "Finance",
                            NormalizedName = "FINANCE"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("TEXT");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("TEXT");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("TEXT");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("TEXT");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("TEXT");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = "96ee338d-bfc1-4b20-979f-12dc2d1cecae",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "2725da24-def2-45ad-a916-e627caccb00b",
                            Email = "a@a.a",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "A@A.A",
                            NormalizedUserName = "A@A.A",
                            PasswordHash = "AQAAAAIAAYagAAAAEByrhKcMkepDEvN976+exHIgdjTOZPhcy0njJGc1C6QeJcjKGAMlsJtX0TcSqnieuA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "e7e815d3-2bc1-4045-b5e8-e8804a69192b",
                            TwoFactorEnabled = false,
                            UserName = "a@a.a"
                        },
                        new
                        {
                            Id = "2acc1944-002d-4e48-929c-26573ba8728b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8eb7bb19-98b8-4dd7-b860-be0e46727b77",
                            Email = "f@f.f",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "F@F.F",
                            NormalizedUserName = "F@F.F",
                            PasswordHash = "AQAAAAIAAYagAAAAECz/GtwkEIlSPQDTSeQhVpMBoVAx8ibyQHVyuXXWu27xb5QNyd92fDv0hKa8ocUG7Q==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "1216fb31-ee04-44a2-a843-22637c08df63",
                            TwoFactorEnabled = false,
                            UserName = "f@f.f"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ClaimType")
                        .HasColumnType("TEXT");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("TEXT");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("RoleId")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = "96ee338d-bfc1-4b20-979f-12dc2d1cecae",
                            RoleId = "945f0745-f8e1-4598-b295-555ac51f1dd3"
                        },
                        new
                        {
                            UserId = "2acc1944-002d-4e48-929c-26573ba8728b",
                            RoleId = "b68005ba-2157-4c09-a439-84c1d8a3bfa8"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("TEXT");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Value")
                        .HasColumnType("TEXT");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("ClassLibDb.Models.Donation", b =>
                {
                    b.HasOne("ClassLibDb.Models.Contact", "Contact")
                        .WithMany("Donations")
                        .HasForeignKey("AccountNo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibDb.Models.PaymentMethod", "PaymentMethod")
                        .WithMany("Donations")
                        .HasForeignKey("PaymentMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ClassLibDb.Models.TransactionType", "TransactionType")
                        .WithMany("Donations")
                        .HasForeignKey("TransactionTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Contact");

                    b.Navigation("PaymentMethod");

                    b.Navigation("TransactionType");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ClassLibDb.Models.Contact", b =>
                {
                    b.Navigation("Donations");
                });

            modelBuilder.Entity("ClassLibDb.Models.PaymentMethod", b =>
                {
                    b.Navigation("Donations");
                });

            modelBuilder.Entity("ClassLibDb.Models.TransactionType", b =>
                {
                    b.Navigation("Donations");
                });
#pragma warning restore 612, 618
        }
    }
}
