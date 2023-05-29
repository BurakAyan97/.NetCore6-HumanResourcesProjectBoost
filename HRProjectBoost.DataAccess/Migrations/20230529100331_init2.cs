using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRProjectBoost.DataAccess.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "8dcbb959-acb1-4f05-a00f-168919f8e08f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "5aea7124-c26c-4b8c-bca7-0501f47d3a14");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "c1c038d7-a711-4adf-b802-38aec195ac7b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EndDate", "PasswordHash", "SecurityStamp", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 29, 13, 3, 31, 35, DateTimeKind.Local).AddTicks(5541), "adda88cf-59d9-4b8d-a673-d9e3895b515a", new DateTime(2023, 5, 29, 13, 3, 31, 35, DateTimeKind.Local).AddTicks(5549), "AQAAAAEAACcQAAAAEGl4+G10N2ZWQIWRsyoxvFoxje+wnYHXQAT9t6s23CYQ3tBg36xKhZ2gntIjRUiQ5A==", "949c2ef9-3012-4cd7-8191-dbf2b3b63411", new DateTime(2023, 5, 29, 13, 3, 31, 35, DateTimeKind.Local).AddTicks(5549) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EndDate", "PasswordHash", "SecurityStamp", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 29, 13, 3, 31, 35, DateTimeKind.Local).AddTicks(5571), "f054e9bd-8d67-4468-97c1-88cade3d33f4", new DateTime(2023, 5, 29, 13, 3, 31, 35, DateTimeKind.Local).AddTicks(5573), "AQAAAAEAACcQAAAAEO/vz6VQEWCRcCJLTUhWQHenwoOWH3/0btm4wbodjHa2z9J2vTP9jlnlAPfoJMMfZA==", "7b23b8e9-43db-4946-9f55-689429694360", new DateTime(2023, 5, 29, 13, 3, 31, 35, DateTimeKind.Local).AddTicks(5572) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "7d6630f6-e7b9-468f-8a73-232a860bd403");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "0fc92d33-98b8-4ca5-9ccb-53cbd3990ab5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "aa57ef90-8684-4bdd-b6cb-020ce52937c1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EndDate", "PasswordHash", "SecurityStamp", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 29, 12, 47, 17, 309, DateTimeKind.Local).AddTicks(3265), "b61a43df-788c-4709-9407-db6558044f32", new DateTime(2023, 5, 29, 12, 47, 17, 309, DateTimeKind.Local).AddTicks(3272), "AQAAAAEAACcQAAAAEPF7ey24j0Fs10/YiGd1C34K/bB277jwXYiKgSAX/1n5SAcg+VPy3DQZev2RDGrPjw==", "e2fa5389-8e01-4a7f-a56e-44fbcd627176", new DateTime(2023, 5, 29, 12, 47, 17, 309, DateTimeKind.Local).AddTicks(3271) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EndDate", "PasswordHash", "SecurityStamp", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 29, 12, 47, 17, 309, DateTimeKind.Local).AddTicks(3291), "01cffcaa-f569-4af5-8066-5d1108327654", new DateTime(2023, 5, 29, 12, 47, 17, 309, DateTimeKind.Local).AddTicks(3292), "AQAAAAEAACcQAAAAEMRVM69v/YkAqu2INSn7jPqCQLkCITtntqhi7ZaKnUNtFA68CeUsxOtu1ZRuve5yYA==", "d382fd62-0216-4ebf-ac06-9c17889d1cea", new DateTime(2023, 5, 29, 12, 47, 17, 309, DateTimeKind.Local).AddTicks(3292) });
        }
    }
}
