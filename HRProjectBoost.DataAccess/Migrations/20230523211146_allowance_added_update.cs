using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRProjectBoost.DataAccess.Migrations
{
    public partial class allowance_added_update : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DemandStatus",
                table: "Allowance",
                newName: "AllowanceStatus");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "8819198a-608a-4da2-84ff-98bc06837787");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "a0cb8ea9-b79d-414f-bf2d-63ea6a95c009");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "5224b1fd-6c82-4934-94bd-5b6a4bc67c4d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EndDate", "PasswordHash", "SecurityStamp", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 24, 0, 11, 45, 903, DateTimeKind.Local).AddTicks(4791), "8a1c7fe5-f345-4c6d-9355-19000ffd29b2", new DateTime(2023, 5, 24, 0, 11, 45, 903, DateTimeKind.Local).AddTicks(4799), "AQAAAAEAACcQAAAAEMZE10K/m/+Uih41XwnPedUVHfAcBxb4VlJSH9xsT7Yp4YvH+p4yNf4C/JIlBXxtPA==", "5601d49e-6a0a-4b15-9212-31a4252e858c", new DateTime(2023, 5, 24, 0, 11, 45, 903, DateTimeKind.Local).AddTicks(4798) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AllowanceStatus",
                table: "Allowance",
                newName: "DemandStatus");

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
        }
    }
}
