using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRProjectBoost.DataAccess.Migrations
{
    public partial class init3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "8867fd84-363c-4f15-8181-b64248fb4405");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "21070a57-214a-437c-a8d7-2bd029327830");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "b38d3360-10c9-4a85-a9f2-d60d055a8f23");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EndDate", "PasswordHash", "SecurityStamp", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 1, 14, 12, 24, 333, DateTimeKind.Local).AddTicks(2362), "d88837e7-ca60-4e6d-a01e-14e8597c89a9", new DateTime(2023, 6, 1, 14, 12, 24, 333, DateTimeKind.Local).AddTicks(2364), "AQAAAAEAACcQAAAAEPBY/PseoGemowfoStiBKQdq3F5zvTcgIue+LCH/ToIMDYm23e9mZZDRznn05v6Ccg==", "66c911ed-5d7d-4293-93d3-87c2cf94cec4", new DateTime(2023, 6, 1, 14, 12, 24, 333, DateTimeKind.Local).AddTicks(2363) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EndDate", "PasswordHash", "SecurityStamp", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 1, 14, 12, 24, 333, DateTimeKind.Local).AddTicks(2397), "4bc49158-a395-4409-9278-3e4e98749d7c", new DateTime(2023, 6, 1, 14, 12, 24, 333, DateTimeKind.Local).AddTicks(2398), "AQAAAAEAACcQAAAAEHT3fNJH3tRG/R0emsjiG5m8Ze047p1iw/tueNcCWUN5gjmPdFgnCuQ6x7/3WDDnwQ==", "63831aa9-8dd7-4c4e-acd4-05f0bb457eda", new DateTime(2023, 6, 1, 14, 12, 24, 333, DateTimeKind.Local).AddTicks(2397) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EndDate", "PasswordHash", "SecurityStamp", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 1, 14, 12, 24, 333, DateTimeKind.Local).AddTicks(2410), "ce7e2f9f-75b3-4b2c-a0af-cfaff20e1f65", new DateTime(2023, 6, 1, 14, 12, 24, 333, DateTimeKind.Local).AddTicks(2411), "AQAAAAEAACcQAAAAEHpunQ6fauygKpFQY4xlV5XAxg7kIdGBqXlCTQiIpcVCk9l4WfZReoJIy9RAopd57g==", "948d2251-e5ba-4d7c-bf21-cce598eb43a7", new DateTime(2023, 6, 1, 14, 12, 24, 333, DateTimeKind.Local).AddTicks(2411) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyId",
                keyValue: 1,
                columns: new[] { "AgreementEndDate", "AgreementStartDate", "EstablishDate" },
                values: new object[] { new DateTime(2025, 6, 1, 14, 12, 24, 333, DateTimeKind.Local).AddTicks(2326), new DateTime(2023, 6, 1, 14, 12, 24, 333, DateTimeKind.Local).AddTicks(2325), new DateTime(2021, 6, 1, 14, 12, 24, 333, DateTimeKind.Local).AddTicks(2313) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "773a1050-cfcc-491a-a0e9-d220c425f1e0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "c55c947c-e1ff-4eca-809c-e9fb5568022a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "d4b25e6b-d8b6-4e21-82e9-25f1ee10c9a2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EndDate", "PasswordHash", "SecurityStamp", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 55, 20, 36, DateTimeKind.Local).AddTicks(9211), "12ea65c3-b79c-4020-9a01-f7de3c04ab6c", new DateTime(2023, 6, 1, 13, 55, 20, 36, DateTimeKind.Local).AddTicks(9213), "AQAAAAEAACcQAAAAEIAxnnYQesMG/Du4j26ITpJBhHkKYG2pxCvE+7a5V/e48I/fBWI7go4FqAjGL9V/tw==", "7c95880c-8d3c-4160-b396-6a76c3083e7a", new DateTime(2023, 6, 1, 13, 55, 20, 36, DateTimeKind.Local).AddTicks(9212) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EndDate", "PasswordHash", "SecurityStamp", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 55, 20, 36, DateTimeKind.Local).AddTicks(9254), "f5bba7a0-b752-41e1-93d4-6b07181cf420", new DateTime(2023, 6, 1, 13, 55, 20, 36, DateTimeKind.Local).AddTicks(9256), "AQAAAAEAACcQAAAAEDJLJGLfYTaTnnT/RO7H5XGx3rePBEEPRHydkNgSy9UqwpVC/wYFJ2StPNi6kY/Fnw==", "be28b5bd-e6ad-4e17-8e2e-b6e44cb23d0a", new DateTime(2023, 6, 1, 13, 55, 20, 36, DateTimeKind.Local).AddTicks(9255) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EndDate", "PasswordHash", "SecurityStamp", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 55, 20, 36, DateTimeKind.Local).AddTicks(9270), "98b647f6-a675-4c74-a303-ac04817e7cff", new DateTime(2023, 6, 1, 13, 55, 20, 36, DateTimeKind.Local).AddTicks(9272), "AQAAAAEAACcQAAAAEMLfIxt42EHQdEdM5A+iLLCfgkViNipRkV0pdj7Rx/0BF3Zqi0X1Olm+QA9uNyHGeA==", "f0fe5edc-ecfc-4871-99c7-afa00f0a8a22", new DateTime(2023, 6, 1, 13, 55, 20, 36, DateTimeKind.Local).AddTicks(9271) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyId",
                keyValue: 1,
                columns: new[] { "AgreementEndDate", "AgreementStartDate", "EstablishDate" },
                values: new object[] { new DateTime(2025, 6, 1, 13, 55, 20, 36, DateTimeKind.Local).AddTicks(9168), new DateTime(2023, 6, 1, 13, 55, 20, 36, DateTimeKind.Local).AddTicks(9167), new DateTime(2021, 6, 1, 13, 55, 20, 36, DateTimeKind.Local).AddTicks(9157) });
        }
    }
}
