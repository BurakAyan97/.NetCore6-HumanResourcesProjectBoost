using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRProjectBoost.DataAccess.Migrations
{
    public partial class init2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUserAllowance_Allowance_AllowanceID",
                table: "AppUserAllowance");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUserAllowance_AspNetUsers_AppUserID",
                table: "AppUserAllowance");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUserAllowance",
                table: "AppUserAllowance");

            migrationBuilder.DropColumn(
                name: "AllowanceFile",
                table: "Allowance");

            migrationBuilder.RenameTable(
                name: "AppUserAllowance",
                newName: "AppUsersAllowances");

            migrationBuilder.RenameIndex(
                name: "IX_AppUserAllowance_AppUserID",
                table: "AppUsersAllowances",
                newName: "IX_AppUsersAllowances_AppUserID");

            migrationBuilder.RenameIndex(
                name: "IX_AppUserAllowance_AllowanceID",
                table: "AppUsersAllowances",
                newName: "IX_AppUsersAllowances_AllowanceID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUsersAllowances",
                table: "AppUsersAllowances",
                column: "AppUserAllowanceID");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "95ca1192-0dc5-49b9-8a95-4e551f154d1f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2,
                column: "ConcurrencyStamp",
                value: "7c2a317f-258f-427e-8633-0082fc0d0167");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 3,
                column: "ConcurrencyStamp",
                value: "3c02cf82-48f4-4c36-96da-1c80468c137d");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDate", "ConcurrencyStamp", "EndDate", "PasswordHash", "SecurityStamp", "StartDate" },
                values: new object[] { new DateTime(2023, 5, 26, 16, 42, 18, 30, DateTimeKind.Local).AddTicks(92), "0761bedd-9e38-41c2-bc68-622537fce954", new DateTime(2023, 5, 26, 16, 42, 18, 30, DateTimeKind.Local).AddTicks(103), "AQAAAAEAACcQAAAAEAZjtnIR0WLGenvkwBtvTjSOPo1hLBqktE2oaOKKjIQZk91gKs7UEsOZQzPPMrsJ3g==", "811b99a6-a401-4f62-9768-a49a73de4d6c", new DateTime(2023, 5, 26, 16, 42, 18, 30, DateTimeKind.Local).AddTicks(102) });

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsersAllowances_Allowance_AllowanceID",
                table: "AppUsersAllowances",
                column: "AllowanceID",
                principalTable: "Allowance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUsersAllowances_AspNetUsers_AppUserID",
                table: "AppUsersAllowances",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AppUsersAllowances_Allowance_AllowanceID",
                table: "AppUsersAllowances");

            migrationBuilder.DropForeignKey(
                name: "FK_AppUsersAllowances_AspNetUsers_AppUserID",
                table: "AppUsersAllowances");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AppUsersAllowances",
                table: "AppUsersAllowances");

            migrationBuilder.RenameTable(
                name: "AppUsersAllowances",
                newName: "AppUserAllowance");

            migrationBuilder.RenameIndex(
                name: "IX_AppUsersAllowances_AppUserID",
                table: "AppUserAllowance",
                newName: "IX_AppUserAllowance_AppUserID");

            migrationBuilder.RenameIndex(
                name: "IX_AppUsersAllowances_AllowanceID",
                table: "AppUserAllowance",
                newName: "IX_AppUserAllowance_AllowanceID");

            migrationBuilder.AddColumn<byte[]>(
                name: "AllowanceFile",
                table: "Allowance",
                type: "varbinary(max)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_AppUserAllowance",
                table: "AppUserAllowance",
                column: "AppUserAllowanceID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserAllowance_Allowance_AllowanceID",
                table: "AppUserAllowance",
                column: "AllowanceID",
                principalTable: "Allowance",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_AppUserAllowance_AspNetUsers_AppUserID",
                table: "AppUserAllowance",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
