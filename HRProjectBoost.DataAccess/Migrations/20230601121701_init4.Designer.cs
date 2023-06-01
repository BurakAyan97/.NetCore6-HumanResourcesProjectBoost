﻿// <auto-generated />
using System;
using HRProjectBoost.DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace HRProjectBoost.DataAccess.Migrations
{
    [DbContext(typeof(HRProjectContext))]
    [Migration("20230601121701_init4")]
    partial class init4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("HRProjectBoost.Entities.Domains.Advance", b =>
                {
                    b.Property<int>("AdvanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AdvanceId"), 1L, 1);

                    b.Property<DateTime>("AdvanceAnsweredTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("AdvanceCreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("AdvanceStatus")
                        .HasColumnType("int");

                    b.Property<int>("AdvanceType")
                        .HasColumnType("int");

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<int>("CurrencyType")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("AdvanceId");

                    b.HasIndex("AppUserId");

                    b.ToTable("Advance");
                });

            modelBuilder.Entity("HRProjectBoost.Entities.Domains.Allowance", b =>
                {
                    b.Property<int>("AllowanceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AllowanceId"), 1L, 1);

                    b.Property<DateTime>("AllowanceAnswerTime")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("AllowanceCreatedTime")
                        .HasColumnType("datetime2");

                    b.Property<int>("AllowanceStatus")
                        .HasColumnType("int");

                    b.Property<int>("AllowanceType")
                        .HasColumnType("int");

                    b.Property<int>("AppUserId")
                        .HasColumnType("int");

                    b.Property<int>("CurrencyType")
                        .HasColumnType("int");

                    b.Property<string>("Path")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Total")
                        .HasColumnType("int");

                    b.HasKey("AllowanceId");

                    b.HasIndex("AppUserId");

                    b.ToTable("Allowance");
                });

            modelBuilder.Entity("HRProjectBoost.Entities.Domains.AppRole", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ConcurrencyStamp = "aa0b8b87-f2cd-4473-ba7d-a9a85ee79a1d",
                            Name = "Admin",
                            NormalizedName = "ADMIN"
                        },
                        new
                        {
                            Id = 2,
                            ConcurrencyStamp = "b07f5c9a-d77d-4e53-ad59-f7c50c2ed6ee",
                            Name = "Manager",
                            NormalizedName = "MANAGER"
                        },
                        new
                        {
                            Id = 3,
                            ConcurrencyStamp = "cb2b547e-75d7-48d8-b0d8-50376db479c4",
                            Name = "Personnel",
                            NormalizedName = "PERSONNEL"
                        });
                });

            modelBuilder.Entity("HRProjectBoost.Entities.Domains.AppUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BirthCity")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("int");

                    b.Property<string>("CompanyInfo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdentityNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<byte[]>("ProfilePicture")
                        .HasColumnType("varbinary(max)");

                    b.Property<decimal>("Salary")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("SecondLastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AccessFailedCount = 0,
                            Address = "İstanbul/Maltepe",
                            BirthCity = "Admin",
                            BirthDate = new DateTime(2023, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5882),
                            CompanyInfo = "Admin",
                            ConcurrencyStamp = "5f08239e-fec3-48a1-b94c-451244f5d4bd",
                            Department = 2,
                            Email = "admin.admin@bilgeadamboost.com",
                            EmailConfirmed = true,
                            EndDate = new DateTime(2023, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5884),
                            IdentityNumber = "12345678998",
                            Job = "Admin",
                            LastName = "Admin",
                            LockoutEnabled = false,
                            Name = "Admin",
                            NormalizedEmail = "ADMİN.ADMİN@BİLGEADAMBOOST.COM",
                            NormalizedUserName = "ADMİN",
                            Password = "123456aA-",
                            PasswordHash = "AQAAAAEAACcQAAAAECL+RXw+9T7TlE/AI69PeAwTcIGFp+wCgZvBNLnzF7ZP6cAAyP/CKEivK9HdlXeBvg==",
                            PhoneNumber = "12345678901",
                            PhoneNumberConfirmed = true,
                            Salary = 16500m,
                            SecondLastName = "Admin",
                            SecondName = "Admin",
                            SecurityStamp = "7246537d-3dbf-4052-93a9-5afc94e6a928",
                            StartDate = new DateTime(2023, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5883),
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "Admin"
                        },
                        new
                        {
                            Id = 3,
                            AccessFailedCount = 0,
                            Address = "İstanbul/Maltepe",
                            BirthCity = "Balıkesir",
                            BirthDate = new DateTime(2023, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5949),
                            CompanyId = 1,
                            CompanyInfo = "IT",
                            ConcurrencyStamp = "131ea33c-8829-4e2a-ab9f-3fba3b2a2b8f",
                            Department = 2,
                            Email = "burakayan@bilgeadamboost.com",
                            EmailConfirmed = true,
                            EndDate = new DateTime(2023, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5950),
                            IdentityNumber = "41104925332",
                            Job = "Back End Developer",
                            LastName = "Ayan",
                            LockoutEnabled = false,
                            Name = "Burak",
                            NormalizedEmail = "BURAKAYAN@BİLGEADAMBOOST.COM",
                            NormalizedUserName = "BURAK61",
                            Password = "123456aA-",
                            PasswordHash = "AQAAAAEAACcQAAAAEMYzxXn2Wtl4iMDUmaiyVleZTborBh3xee+AwH2elBHtUYlbvzgjXml9wgsWeD943w==",
                            PhoneNumber = "905423985612",
                            PhoneNumberConfirmed = true,
                            Salary = 16500m,
                            SecondLastName = "",
                            SecondName = "",
                            SecurityStamp = "64ce57c7-e5d6-4e65-94dc-08188aa64520",
                            StartDate = new DateTime(2023, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5950),
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "Burak61"
                        },
                        new
                        {
                            Id = 2,
                            AccessFailedCount = 0,
                            Address = "İstanbul/Maltepe",
                            BirthCity = "Manager",
                            BirthDate = new DateTime(2023, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5906),
                            CompanyId = 1,
                            CompanyInfo = "Manager",
                            ConcurrencyStamp = "42ec1bdb-b496-4ffa-ac4f-0ce699700974",
                            Department = 2,
                            Email = "manager.manager@bilgeadamboost.com",
                            EmailConfirmed = true,
                            EndDate = new DateTime(2023, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5907),
                            IdentityNumber = "12345678998",
                            Job = "Manager",
                            LastName = "Manager",
                            LockoutEnabled = false,
                            Name = "Manager",
                            NormalizedEmail = "MANAGER.MANAGER@BİLGEADAMBOOST.COM",
                            NormalizedUserName = "MANAGER",
                            Password = "123456aA-",
                            PasswordHash = "AQAAAAEAACcQAAAAED6E5nWkMA9yhsKSGXvpN/0BJo0TAEvTPjfjEXAlVcMQDTkPEpCU9gIaFJdcWcbMGg==",
                            PhoneNumber = "12345678901",
                            PhoneNumberConfirmed = true,
                            Salary = 16500m,
                            SecondLastName = "Manager",
                            SecondName = "Manager",
                            SecurityStamp = "2724621e-d820-47f3-b885-5db82e49401e",
                            StartDate = new DateTime(2023, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5906),
                            Status = 1,
                            TwoFactorEnabled = false,
                            UserName = "Manager"
                        });
                });

            modelBuilder.Entity("HRProjectBoost.Entities.Domains.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CompanyId"), 1L, 1);

                    b.Property<DateTime>("AgreementEndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("AgreementStartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("CompanyAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CompanyPhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompanyStatus")
                        .HasColumnType("int");

                    b.Property<string>("CompanyTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("EstablishDate")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("Logo")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("MersisNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PersonnelCount")
                        .HasColumnType("int");

                    b.Property<string>("TaxAdministration")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaxNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CompanyId");

                    b.ToTable("Company");

                    b.HasData(
                        new
                        {
                            CompanyId = 1,
                            AgreementEndDate = new DateTime(2025, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5841),
                            AgreementStartDate = new DateTime(2023, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5840),
                            CompanyAddress = "Adress Deneme",
                            CompanyEmail = "test.company@test.com",
                            CompanyName = "TestCompany",
                            CompanyPhoneNumber = "+9050012312312",
                            CompanyStatus = 1,
                            CompanyTitle = "TC",
                            EstablishDate = new DateTime(2021, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5832),
                            MersisNo = "123456",
                            TaxAdministration = "DenemeVergiDairesi",
                            TaxNo = "123456"
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            RoleId = 1
                        },
                        new
                        {
                            UserId = 2,
                            RoleId = 2
                        },
                        new
                        {
                            UserId = 3,
                            RoleId = 3
                        });
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("HRProjectBoost.Entities.Domains.Advance", b =>
                {
                    b.HasOne("HRProjectBoost.Entities.Domains.AppUser", "AppUser")
                        .WithMany("Advances")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("HRProjectBoost.Entities.Domains.Allowance", b =>
                {
                    b.HasOne("HRProjectBoost.Entities.Domains.AppUser", "AppUser")
                        .WithMany("Allowances")
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AppUser");
                });

            modelBuilder.Entity("HRProjectBoost.Entities.Domains.AppUser", b =>
                {
                    b.HasOne("HRProjectBoost.Entities.Domains.Company", "Company")
                        .WithMany("AppUser")
                        .HasForeignKey("CompanyId");

                    b.Navigation("Company");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<int>", b =>
                {
                    b.HasOne("HRProjectBoost.Entities.Domains.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<int>", b =>
                {
                    b.HasOne("HRProjectBoost.Entities.Domains.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<int>", b =>
                {
                    b.HasOne("HRProjectBoost.Entities.Domains.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<int>", b =>
                {
                    b.HasOne("HRProjectBoost.Entities.Domains.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("HRProjectBoost.Entities.Domains.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<int>", b =>
                {
                    b.HasOne("HRProjectBoost.Entities.Domains.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("HRProjectBoost.Entities.Domains.AppUser", b =>
                {
                    b.Navigation("Advances");

                    b.Navigation("Allowances");
                });

            modelBuilder.Entity("HRProjectBoost.Entities.Domains.Company", b =>
                {
                    b.Navigation("AppUser");
                });
#pragma warning restore 612, 618
        }
    }
}
