using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRProjectBoost.DataAccess.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Advance",
                type: "int",
                nullable: false,
                defaultValue: 0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Status",
                table: "Advance");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "d041a1bc-f0a7-4df8-9cee-fd67bdde9170");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "606e20cc-5402-4605-b710-e7a1531e5ac8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "accdec24-9611-495d-9a12-7008bf96126f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EndDate", "PasswordHash", "SecurityStamp", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4654), "e2ac1453-055d-4cf6-94bf-050f1018e3e4", new DateTime(2023, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4656), "AQAAAAEAACcQAAAAEHBKUd6A+VUN7DNV0ZmWDr11yILBxzjCDmbaPP2yzlcyMpWGkKUh1IoJ/gQnuAmgdA==", "ffbc0d17-267d-40dc-afd7-e7bdd73333e6", new DateTime(2023, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4655) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EndDate", "PasswordHash", "SecurityStamp", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4691), "3e981772-4602-4e7c-9aa3-877ab75f9d6f", new DateTime(2023, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4692), "AQAAAAEAACcQAAAAEMYBnGF+Y1xU09VaYY/Duoml3burEjrYjsHR2BvibaTgqsvf+YfTJI7M0zYyLr2SSQ==", "627c913c-433b-442e-85d4-d25e051d239e", new DateTime(2023, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4691) });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EndDate", "PasswordHash", "SecurityStamp", "StartDate" },
                values: new object[] { new DateTime(2023, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4703), "7401feab-0152-464d-af91-48e83bb73eb0", new DateTime(2023, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4704), "AQAAAAEAACcQAAAAENYH007Mw3N3eyl4bJhC4HP24qKlGAwag+Tsptkzf3RUK7XKejgxbqdXAms04FA0VA==", "12c063c3-b568-4176-b7fe-081c9252fdb0", new DateTime(2023, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "Company",
                keyColumn: "CompanyId",
                keyValue: 1,
                columns: new[] { "AgreementEndDate", "AgreementStartDate", "EstablishDate" },
                values: new object[] { new DateTime(2025, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4619), new DateTime(2023, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4618), new DateTime(2021, 6, 1, 13, 5, 8, 969, DateTimeKind.Local).AddTicks(4610) });
        }
    }
}
