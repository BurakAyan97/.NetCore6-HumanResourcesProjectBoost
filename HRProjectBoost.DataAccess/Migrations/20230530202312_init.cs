using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRProjectBoost.DataAccess.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
<<<<<<<< HEAD:HRProjectBoost.DataAccess/Migrations/20230530202312_init.cs
                name: "Companies",
========
                name: "Company",
>>>>>>>> c56d897307e4544a5438e65a1cc9ddd6e45ee02b:HRProjectBoost.DataAccess/Migrations/20230601100509_init.cs
                columns: table => new
                {
                    CompanyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MersisNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxAdministration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CompanyPhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
<<<<<<<< HEAD:HRProjectBoost.DataAccess/Migrations/20230530202312_init.cs
                    PersonnelCount = table.Column<int>(type: "int", nullable: false),
                    EstablishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AgreementStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AgreementEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
========
                    PersonnelCount = table.Column<int>(type: "int", nullable: true),
                    EstablishDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AgreementStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AgreementEndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
>>>>>>>> c56d897307e4544a5438e65a1cc9ddd6e45ee02b:HRProjectBoost.DataAccess/Migrations/20230601100509_init.cs
                    CompanyStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
<<<<<<<< HEAD:HRProjectBoost.DataAccess/Migrations/20230530202312_init.cs
                    table.PrimaryKey("PK_Companies", x => x.CompanyId);
========
                    table.PrimaryKey("PK_Company", x => x.CompanyId);
>>>>>>>> c56d897307e4544a5438e65a1cc9ddd6e45ee02b:HRProjectBoost.DataAccess/Migrations/20230601100509_init.cs
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecondLastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirthCity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentityNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CompanyInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Job = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Department = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    ProfilePicture = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CompanyId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
<<<<<<<< HEAD:HRProjectBoost.DataAccess/Migrations/20230530202312_init.cs
                        name: "FK_AspNetUsers_Companies_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Companies",
========
                        name: "FK_AspNetUsers_Company_CompanyId",
                        column: x => x.CompanyId,
                        principalTable: "Company",
>>>>>>>> c56d897307e4544a5438e65a1cc9ddd6e45ee02b:HRProjectBoost.DataAccess/Migrations/20230601100509_init.cs
                        principalColumn: "CompanyId");
                });

            migrationBuilder.CreateTable(
<<<<<<<< HEAD:HRProjectBoost.DataAccess/Migrations/20230530202312_init.cs
                name: "Advances",
========
                name: "Advance",
>>>>>>>> c56d897307e4544a5438e65a1cc9ddd6e45ee02b:HRProjectBoost.DataAccess/Migrations/20230601100509_init.cs
                columns: table => new
                {
                    AdvanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Total = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AdvanceType = table.Column<int>(type: "int", nullable: false),
                    CurrencyType = table.Column<int>(type: "int", nullable: false),
                    AdvanceStatus = table.Column<int>(type: "int", nullable: false),
<<<<<<<< HEAD:HRProjectBoost.DataAccess/Migrations/20230530202312_init.cs
                    AppUserID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advances", x => x.AdvanceId);
                    table.ForeignKey(
                        name: "FK_Advances_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
========
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Advance", x => x.AdvanceId);
                    table.ForeignKey(
                        name: "FK_Advance_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
>>>>>>>> c56d897307e4544a5438e65a1cc9ddd6e45ee02b:HRProjectBoost.DataAccess/Migrations/20230601100509_init.cs
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Allowance",
                columns: table => new
                {
                    AllowanceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllowanceType = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    CurrencyType = table.Column<int>(type: "int", nullable: false),
                    AllowanceStatus = table.Column<int>(type: "int", nullable: false),
                    AllowanceCreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AllowanceAnswerTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppUserId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allowance", x => x.AllowanceId);
                    table.ForeignKey(
                        name: "FK_Allowance_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    RoleId = table.Column<int>(type: "int", nullable: false)
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
                    UserId = table.Column<int>(type: "int", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
<<<<<<<< HEAD:HRProjectBoost.DataAccess/Migrations/20230530202312_init.cs
                values: new object[] { 1, "446176d1-2ea5-4ead-ac0a-c6f8948bf92d", "Admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 2, "1bc79627-4f82-4183-8bc5-46b7b9f22049", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { 3, "00538063-0196-4ab7-8346-3418ded3cd80", "Personnel", "PERSONNEL" });
========
                values: new object[,]
                {
                    { 1, "d041a1bc-f0a7-4df8-9cee-fd67bdde9170", "Admin", "ADMIN" },
                    { 2, "606e20cc-5402-4605-b710-e7a1531e5ac8", "Manager", "MANAGER" },
                    { 3, "accdec24-9611-495d-9a12-7008bf96126f", "Personnel", "PERSONNEL" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthCity", "BirthDate", "CompanyId", "CompanyInfo", "ConcurrencyStamp", "Department", "Email", "EmailConfirmed", "EndDate", "IdentityNumber", "Job", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "Salary", "SecondLastName", "SecondName", "SecurityStamp", "StartDate", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { 1, 0, "İstanbul/Maltepe", "Admin", new DateTime(2023, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4654), null, "Admin", "e2ac1453-055d-4cf6-94bf-050f1018e3e4", 2, "admin.admin@bilgeadamboost.com", true, new DateTime(2023, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4656), "12345678998", "Admin", "Admin", false, null, "Admin", "ADMİN.ADMİN@BİLGEADAMBOOST.COM", "ADMİN", "123456aA-", "AQAAAAEAACcQAAAAEHBKUd6A+VUN7DNV0ZmWDr11yILBxzjCDmbaPP2yzlcyMpWGkKUh1IoJ/gQnuAmgdA==", "12345678901", true, null, 16500m, "Admin", "Admin", "ffbc0d17-267d-40dc-afd7-e7bdd73333e6", new DateTime(2023, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4655), 1, false, "Admin" });

            migrationBuilder.InsertData(
                table: "Company",
                columns: new[] { "CompanyId", "AgreementEndDate", "AgreementStartDate", "CompanyAddress", "CompanyEmail", "CompanyName", "CompanyPhoneNumber", "CompanyStatus", "CompanyTitle", "EstablishDate", "Logo", "MersisNo", "PersonnelCount", "TaxAdministration", "TaxNo" },
                values: new object[] { 1, new DateTime(2025, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4619), new DateTime(2023, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4618), "Adress Deneme", "test.company@test.com", "TestCompany", "+9050012312312", 1, "TC", new DateTime(2021, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4610), null, "123456", null, "DenemeVergiDairesi", "123456" });
>>>>>>>> c56d897307e4544a5438e65a1cc9ddd6e45ee02b:HRProjectBoost.DataAccess/Migrations/20230601100509_init.cs

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 1, 1 });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthCity", "BirthDate", "CompanyId", "CompanyInfo", "ConcurrencyStamp", "Department", "Email", "EmailConfirmed", "EndDate", "IdentityNumber", "Job", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "Salary", "SecondLastName", "SecondName", "SecurityStamp", "StartDate", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { 2, 0, "İstanbul/Maltepe", "Manager", new DateTime(2023, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4691), 1, "Manager", "3e981772-4602-4e7c-9aa3-877ab75f9d6f", 2, "manager.manager@bilgeadamboost.com", true, new DateTime(2023, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4692), "12345678998", "Manager", "Manager", false, null, "Manager", "MANAGER.MANAGER@BİLGEADAMBOOST.COM", "MANAGER", "123456aA-", "AQAAAAEAACcQAAAAEMYBnGF+Y1xU09VaYY/Duoml3burEjrYjsHR2BvibaTgqsvf+YfTJI7M0zYyLr2SSQ==", "12345678901", true, null, 16500m, "Manager", "Manager", "627c913c-433b-442e-85d4-d25e051d239e", new DateTime(2023, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4691), 1, false, "Manager" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "Address", "BirthCity", "BirthDate", "CompanyId", "CompanyInfo", "ConcurrencyStamp", "Department", "Email", "EmailConfirmed", "EndDate", "IdentityNumber", "Job", "LastName", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "Password", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "ProfilePicture", "Salary", "SecondLastName", "SecondName", "SecurityStamp", "StartDate", "Status", "TwoFactorEnabled", "UserName" },
                values: new object[] { 3, 0, "İstanbul/Maltepe", "Balıkesir", new DateTime(2023, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4703), 1, "IT", "7401feab-0152-464d-af91-48e83bb73eb0", 2, "burakayan@bilgeadamboost.com", true, new DateTime(2023, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4704), "41104925332", "Back End Developer", "Ayan", false, null, "Burak", "BURAKAYAN@BİLGEADAMBOOST.COM", "BURAK61", "123456aA-", "AQAAAAEAACcQAAAAENYH007Mw3N3eyl4bJhC4HP24qKlGAwag+Tsptkzf3RUK7XKejgxbqdXAms04FA0VA==", "905423985612", true, null, 16500m, "", "", "12c063c3-b568-4176-b7fe-081c9252fdb0", new DateTime(2023, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4703), 1, false, "Burak61" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 2, 2 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { 3, 3 });

            migrationBuilder.CreateIndex(
                name: "IX_Advance_AppUserId",
                table: "Advance",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Advances_AppUserID",
                table: "Advances",
                column: "AppUserID");

            migrationBuilder.CreateIndex(
                name: "IX_Allowance_AppUserId",
                table: "Allowance",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

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
                name: "IX_AspNetUsers_CompanyId",
                table: "AspNetUsers",
                column: "CompanyId");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
<<<<<<<< HEAD:HRProjectBoost.DataAccess/Migrations/20230530202312_init.cs
                name: "Advances");
========
                name: "Advance");
>>>>>>>> c56d897307e4544a5438e65a1cc9ddd6e45ee02b:HRProjectBoost.DataAccess/Migrations/20230601100509_init.cs

            migrationBuilder.DropTable(
                name: "Allowance");

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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
<<<<<<<< HEAD:HRProjectBoost.DataAccess/Migrations/20230530202312_init.cs
                name: "Companies");
========
                name: "Company");
>>>>>>>> c56d897307e4544a5438e65a1cc9ddd6e45ee02b:HRProjectBoost.DataAccess/Migrations/20230601100509_init.cs
        }
    }
}
