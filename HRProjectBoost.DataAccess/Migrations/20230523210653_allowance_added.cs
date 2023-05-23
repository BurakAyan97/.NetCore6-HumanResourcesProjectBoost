using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRProjectBoost.DataAccess.Migrations
{
    public partial class allowance_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Allowance",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AllowanceType = table.Column<int>(type: "int", nullable: false),
                    Total = table.Column<int>(type: "int", nullable: false),
                    CurrencyType = table.Column<int>(type: "int", nullable: false),
                    DemandStatus = table.Column<int>(type: "int", nullable: false),
                    AllowanceCreatedTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AllowanceAnswerTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AllowanceFile = table.Column<byte[]>(type: "varbinary(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Allowance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserAllowance",
                columns: table => new
                {
                    AppUserAllowanceID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AppUserID = table.Column<int>(type: "int", nullable: false),
                    AllowanceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserAllowance", x => x.AppUserAllowanceID);
                    table.ForeignKey(
                        name: "FK_AppUserAllowance_Allowance_AllowanceID",
                        column: x => x.AllowanceID,
                        principalTable: "Allowance",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AppUserAllowance_AspNetUsers_AppUserID",
                        column: x => x.AppUserID,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "605afe7a-b952-4069-b0e8-fa587e2092ea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "cc49adbf-8197-428a-8842-162799ab0f77");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "7f8f7bc7-314e-4276-800e-7eb400a40894");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EndDate", "PasswordHash", "SecurityStamp", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 24, 0, 6, 53, 354, DateTimeKind.Local).AddTicks(4401), "9f2000ad-f9fa-45fa-944e-3f828830470f", new DateTime(2023, 5, 24, 0, 6, 53, 354, DateTimeKind.Local).AddTicks(4409), "AQAAAAEAACcQAAAAENeSsCfR35BE1lDOP/E4HPvRgwLfcfx5oGdjgL0gdf5+G2brLNpU4KF4be5gYi6VmQ==", "c5278f4d-4cb4-489a-ae27-4db68920d67e", new DateTime(2023, 5, 24, 0, 6, 53, 354, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.CreateIndex(
                name: "IX_AppUserAllowance_AllowanceID",
                table: "AppUserAllowance",
                column: "AllowanceID");

            migrationBuilder.CreateIndex(
                name: "IX_AppUserAllowance_AppUserID",
                table: "AppUserAllowance",
                column: "AppUserID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppUserAllowance");

            migrationBuilder.DropTable(
                name: "Allowance");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "71f14845-0106-4dbd-8b74-cf92ff28759d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "4ba36e68-5b64-4c13-bbb2-f7adadfb20c3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "1a9af3b7-81af-439f-b10e-17699ce52671");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EndDate", "PasswordHash", "SecurityStamp", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 22, 10, 50, 46, 181, DateTimeKind.Local).AddTicks(5621), "93f68e2b-f225-4a6d-8db6-a16c6766f8b5", new DateTime(2023, 5, 22, 10, 50, 46, 181, DateTimeKind.Local).AddTicks(5629), "AQAAAAEAACcQAAAAEDaXsUYI7mDC4OJ5z4BMwUfOTefsH6vHNyonvTLB/J9gZL/08Jbtn3v99MVlXDWK6A==", "b38ad386-11a4-4c6a-80f7-cc2355a8c8d2", new DateTime(2023, 5, 22, 10, 50, 46, 181, DateTimeKind.Local).AddTicks(5628) });
        }
    }
}
