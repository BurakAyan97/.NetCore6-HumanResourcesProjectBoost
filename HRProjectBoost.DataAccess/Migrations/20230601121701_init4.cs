using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRProjectBoost.DataAccess.Migrations
{
    public partial class init4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "AdvanceAnsweredTime",
                table: "Advance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AdvanceCreatedTime",
                table: "Advance",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "aa0b8b87-f2cd-4473-ba7d-a9a85ee79a1d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "b07f5c9a-d77d-4e53-ad59-f7c50c2ed6ee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "cb2b547e-75d7-48d8-b0d8-50376db479c4");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EndDate", "PasswordHash", "SecurityStamp", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5882), "5f08239e-fec3-48a1-b94c-451244f5d4bd", new DateTime(2023, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5884), "AQAAAAEAACcQAAAAECL+RXw+9T7TlE/AI69PeAwTcIGFp+wCgZvBNLnzF7ZP6cAAyP/CKEivK9HdlXeBvg==", "7246537d-3dbf-4052-93a9-5afc94e6a928", new DateTime(2023, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5883) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EndDate", "PasswordHash", "SecurityStamp", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5906), "42ec1bdb-b496-4ffa-ac4f-0ce699700974", new DateTime(2023, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5907), "AQAAAAEAACcQAAAAED6E5nWkMA9yhsKSGXvpN/0BJo0TAEvTPjfjEXAlVcMQDTkPEpCU9gIaFJdcWcbMGg==", "2724621e-d820-47f3-b885-5db82e49401e", new DateTime(2023, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5906) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EndDate", "PasswordHash", "SecurityStamp", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5949), "131ea33c-8829-4e2a-ab9f-3fba3b2a2b8f", new DateTime(2023, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5950), "AQAAAAEAACcQAAAAEMYzxXn2Wtl4iMDUmaiyVleZTborBh3xee+AwH2elBHtUYlbvzgjXml9wgsWeD943w==", "64ce57c7-e5d6-4e65-94dc-08188aa64520", new DateTime(2023, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5950) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyId",
                keyValue: 1,
                columns: new[] { "AgreementEndDate", "AgreementStartDate", "EstablishDate" },
                values: new object[] { new DateTime(2025, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5841), new DateTime(2023, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5840), new DateTime(2021, 6, 1, 15, 17, 0, 609, DateTimeKind.Local).AddTicks(5832) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AdvanceAnsweredTime",
                table: "Advance");

            migrationBuilder.DropColumn(
                name: "AdvanceCreatedTime",
                table: "Advance");

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
    }
}
