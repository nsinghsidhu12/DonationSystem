﻿// <auto-generated />
using System;
using ClassLibDb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClassLibDb.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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
                });

            modelBuilder.Entity("ClassLibDb.Models.Donation", b =>
                {
                    b.Property<int>("TransId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AccountNo")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Amount")
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
                            Id = "d479b39e-7ff1-4cf2-9c91-dced1dedaf13",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = "d8a6e6fb-04e8-41b4-bc8d-e2ef572ebd45",
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
                            Id = "f4a2131e-d6c2-4dbe-baf4-2a44998da264",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8c5681fe-131f-4ab6-a085-99f32ff93b8a",
                            Email = "aa@aa.aa",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "AA@AA.AA",
                            NormalizedUserName = "AA@AA.AA",
                            PasswordHash = "AQAAAAIAAYagAAAAEHPL9Jav69yTUtulR91VmD5rzWz7FyN83GqTeBq7wDHYtvaUT7DJLbM1DL1BnY37RA==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "c25d13d4-c7e5-4815-a5ca-f6c8a84db3da",
                            TwoFactorEnabled = false,
                            UserName = "aa@aa.aa"
                        },
                        new
                        {
                            Id = "84e27cee-85fc-4617-baa0-09a819bed38b",
                            AccessFailedCount = 0,
                            ConcurrencyStamp = "8b9dfe51-35bf-4840-b848-73a05bbe36ca",
                            Email = "f@f.f",
                            EmailConfirmed = true,
                            LockoutEnabled = false,
                            NormalizedEmail = "F@F.F",
                            NormalizedUserName = "F@F.F",
                            PasswordHash = "AQAAAAIAAYagAAAAELUMAR/v1VCl4FypWe+uSiunwM6TyDlqPmDnm0gqMMTlwZq5IzB4AOXJKBI8wpo3SQ==",
                            PhoneNumberConfirmed = false,
                            SecurityStamp = "aa541cdb-daec-4a6a-927b-6e2fd6c9e0dc",
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
                            UserId = "f4a2131e-d6c2-4dbe-baf4-2a44998da264",
                            RoleId = "d479b39e-7ff1-4cf2-9c91-dced1dedaf13"
                        },
                        new
                        {
                            UserId = "84e27cee-85fc-4617-baa0-09a819bed38b",
                            RoleId = "d8a6e6fb-04e8-41b4-bc8d-e2ef572ebd45"
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
