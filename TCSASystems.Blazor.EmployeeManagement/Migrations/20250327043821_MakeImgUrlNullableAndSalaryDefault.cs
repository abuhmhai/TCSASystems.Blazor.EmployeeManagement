using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TCSASystems.Blazor.EmployeeManagement.Migrations
{
    /// <inheritdoc />
    public partial class MakeImgUrlNullableAndSalaryDefault : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "Employees",
                type: "decimal(65,30)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ImgUrl",
                table: "Employees",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 19, 0), new TimeOnly(18, 51, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "Date" },
                values: new object[] { new TimeOnly(8, 4, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 37, 0), new TimeOnly(18, 15, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 56, 0), new TimeOnly(18, 46, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 58, 0), new TimeOnly(18, 39, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 7, 0), new TimeOnly(17, 44, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 36, 0), new TimeOnly(16, 3, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 11, 0), new TimeOnly(18, 29, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 23, 0), new TimeOnly(18, 17, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 9, 0), new TimeOnly(18, 41, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 23, 0), new TimeOnly(16, 33, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 6, 0), new TimeOnly(17, 8, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 11, 0), new TimeOnly(17, 22, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 57, 0), new TimeOnly(17, 30, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 12, 0), new TimeOnly(16, 53, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 3, 0), new TimeOnly(18, 40, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 10, 0), new TimeOnly(18, 40, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 47, 0), new TimeOnly(16, 0, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 55, 0), new TimeOnly(17, 50, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 17, 0), new TimeOnly(16, 42, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 6, 0), new TimeOnly(18, 48, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 45, 0), new TimeOnly(16, 11, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 28, 0), new TimeOnly(18, 50, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 41, 0), new TimeOnly(18, 28, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 45, 0), new TimeOnly(16, 36, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 47, 0), new TimeOnly(18, 19, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 16, 0), new TimeOnly(18, 47, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 46, 0), new TimeOnly(17, 29, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 53, 0), new TimeOnly(17, 15, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 20, 0), new TimeOnly(16, 5, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 27, 0), new TimeOnly(17, 25, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 8, 0), new TimeOnly(17, 5, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 11, 0), new TimeOnly(18, 2, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 13, 0), new TimeOnly(16, 50, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 25, 0), new TimeOnly(17, 8, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 22, 0), new TimeOnly(16, 27, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 18, 0), new TimeOnly(17, 34, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 44, 0), new TimeOnly(16, 8, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 45, 0), new TimeOnly(17, 45, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 48, 0), new TimeOnly(16, 22, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 59, 0), new TimeOnly(17, 52, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 37, 0), new TimeOnly(18, 10, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 56, 0), new TimeOnly(16, 40, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 34, 0), new TimeOnly(18, 27, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 19, 0), new TimeOnly(16, 43, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 49, 0), new TimeOnly(18, 35, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 8, 0), new TimeOnly(18, 22, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 2, 0), new TimeOnly(18, 39, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 31, 0), new TimeOnly(18, 1, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 22, 0), new TimeOnly(16, 48, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 12, 0), new TimeOnly(17, 24, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 14, 0), new TimeOnly(16, 57, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 40, 0), new TimeOnly(17, 22, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 41, 0), new TimeOnly(18, 22, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 58, 0), new TimeOnly(16, 31, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 18, 0), new TimeOnly(17, 53, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 25, 0), new TimeOnly(17, 22, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 43, 0), new TimeOnly(18, 22, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 25, 0), new TimeOnly(16, 25, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 57, 0), new TimeOnly(17, 35, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 50, 0), new TimeOnly(16, 31, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 14, 0), new TimeOnly(16, 53, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 4, 0), new TimeOnly(16, 47, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 42, 0), new TimeOnly(18, 58, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 13, 0), new TimeOnly(17, 45, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 6, 0), new TimeOnly(18, 53, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 8, 0), new TimeOnly(17, 44, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 6, 0), new TimeOnly(17, 13, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CheckIn", "Date" },
                values: new object[] { new TimeOnly(8, 49, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 24, 0), new TimeOnly(17, 6, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 32, 0), new TimeOnly(18, 45, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 40, 0), new TimeOnly(18, 55, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 12, 0), new TimeOnly(18, 7, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 26, 0), new TimeOnly(16, 47, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 42, 0), new TimeOnly(17, 44, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 33, 0), new TimeOnly(18, 46, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 10, 0), new TimeOnly(17, 19, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 21, 0), new TimeOnly(17, 3, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 15, 0), new TimeOnly(17, 47, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 19, 0), new TimeOnly(18, 40, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 8, 0), new TimeOnly(18, 41, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 33, 0), new TimeOnly(18, 1, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 47, 0), new TimeOnly(17, 33, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 42, 0), new TimeOnly(17, 20, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 53, 0), new TimeOnly(18, 8, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 41, 0), new TimeOnly(18, 6, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 20, 0), new TimeOnly(18, 45, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 27, 0), new TimeOnly(16, 32, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 46, 0), new TimeOnly(16, 21, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 37, 0), new TimeOnly(17, 51, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 15, 0), new TimeOnly(16, 0, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 55, 0), new TimeOnly(17, 46, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 2, 0), new TimeOnly(17, 26, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 53, 0), new TimeOnly(16, 32, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 48, 0), new TimeOnly(17, 16, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 23, 0), new TimeOnly(18, 58, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 42, 0), new TimeOnly(17, 49, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 2, 0), new TimeOnly(18, 20, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 19, 0), new TimeOnly(18, 40, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 0, 0), new TimeOnly(18, 14, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 14, 0), new TimeOnly(16, 34, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 37, 0), new TimeOnly(16, 42, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 48, 0), new TimeOnly(17, 29, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 34, 0), new TimeOnly(17, 20, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 26, 0), new TimeOnly(18, 1, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 13, 0), new TimeOnly(17, 13, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 8, 0), new TimeOnly(18, 11, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 55, 0), new TimeOnly(17, 14, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 10, 0), new TimeOnly(17, 14, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 10, 0), new TimeOnly(18, 16, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 10, 0), new TimeOnly(18, 7, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 16, 0), new TimeOnly(18, 14, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 17, 0), new TimeOnly(17, 19, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 49, 0), new TimeOnly(16, 40, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 13, 0), new TimeOnly(17, 45, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 40, 0), new TimeOnly(16, 4, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 35, 0), new TimeOnly(16, 26, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 51, 0), new TimeOnly(17, 39, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 34, 0), new TimeOnly(17, 21, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 11, 0), new TimeOnly(17, 33, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 45, 0), new TimeOnly(16, 46, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 37, 0), new TimeOnly(18, 30, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 3, 0), new TimeOnly(16, 11, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 2, 0), new TimeOnly(18, 47, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 46, 0), new TimeOnly(18, 10, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 30, 0), new TimeOnly(16, 51, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 32, 0), new TimeOnly(17, 18, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 38, 0), new TimeOnly(17, 59, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 14, 0), new TimeOnly(18, 18, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 8, 0), new TimeOnly(18, 32, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 3, 0), new TimeOnly(17, 51, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 5, 0), new TimeOnly(16, 49, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 5, 0), new TimeOnly(18, 24, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 1, 0), new TimeOnly(18, 42, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 10, 0), new TimeOnly(16, 14, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 44, 0), new TimeOnly(16, 17, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 1, 0), new TimeOnly(16, 52, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 33, 0), new TimeOnly(18, 57, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 17, 0), new TimeOnly(16, 41, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 40, 0), new TimeOnly(16, 55, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 4, 0), new TimeOnly(17, 28, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 49, 0), new TimeOnly(16, 39, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 12, 0), new TimeOnly(17, 8, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 31, 0), new TimeOnly(16, 0, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 24, 0), new TimeOnly(17, 20, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 40, 0), new TimeOnly(18, 33, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 38, 0), new TimeOnly(16, 2, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 27, 0), new TimeOnly(16, 9, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 37, 0), new TimeOnly(16, 23, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 45, 0), new TimeOnly(16, 0, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 43, 0), new TimeOnly(17, 35, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 11, 0), new TimeOnly(18, 40, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 45, 0), new TimeOnly(17, 12, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 58, 0), new TimeOnly(16, 4, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 26, 0), new TimeOnly(16, 48, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 55, 0), new TimeOnly(16, 36, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 53, 0), new TimeOnly(16, 15, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 35, 0), new TimeOnly(16, 33, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 40, 0), new TimeOnly(17, 52, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 36, 0), new TimeOnly(18, 31, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 13, 0), new TimeOnly(16, 52, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 27, 0), new TimeOnly(17, 17, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 58, 0), new TimeOnly(16, 25, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 22, 0), new TimeOnly(18, 23, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(8, 15, 0), new TimeOnly(16, 30, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 34, 0), new TimeOnly(16, 0, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 10, 0), new TimeOnly(16, 1, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 52, 0), new TimeOnly(16, 30, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 42, 0), new TimeOnly(17, 20, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 18, 0), new TimeOnly(17, 5, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 51, 0), new TimeOnly(16, 0, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 15, 0), new TimeOnly(18, 20, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 37, 0), new TimeOnly(16, 20, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 1, 0), new TimeOnly(16, 6, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 51, 0), new TimeOnly(17, 7, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 16, 0), new TimeOnly(16, 51, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 16, 0), new TimeOnly(17, 3, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 8, 0), new TimeOnly(17, 6, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 16, 0), new TimeOnly(16, 52, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 27, 0), new TimeOnly(16, 44, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 58, 0), new TimeOnly(16, 13, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 53, 0), new TimeOnly(18, 51, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 32, 0), new TimeOnly(16, 31, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 21, 0), new TimeOnly(18, 0, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 46, 0), new TimeOnly(17, 16, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 21, 0), new TimeOnly(17, 53, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 6, 0), new TimeOnly(16, 38, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 12, 0), new TimeOnly(17, 15, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 11, 0), new TimeOnly(17, 44, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 24, 0), new TimeOnly(18, 35, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 50, 0), new TimeOnly(17, 0, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 26, 0), new TimeOnly(16, 15, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 49, 0), new TimeOnly(17, 37, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 47, 0), new TimeOnly(17, 4, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 5, 0), new TimeOnly(17, 23, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 9, 0), new TimeOnly(16, 51, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 17, 0), new TimeOnly(16, 41, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 18, 0), new TimeOnly(17, 41, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 38, 0), new TimeOnly(16, 6, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 56, 0), new TimeOnly(18, 4, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 31, 0), new TimeOnly(16, 12, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 19, 0), new TimeOnly(17, 3, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 41, 0), new TimeOnly(18, 23, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 58, 0), new TimeOnly(16, 3, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 59, 0), new TimeOnly(18, 33, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 16, 0), new TimeOnly(18, 45, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 27, 0), new TimeOnly(17, 10, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 37, 0), new TimeOnly(17, 50, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 22, 0), new TimeOnly(16, 38, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 38, 0), new TimeOnly(16, 57, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 14, 0), new TimeOnly(18, 5, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 31, 0), new TimeOnly(17, 59, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 53, 0), new TimeOnly(18, 8, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 14, 0), new TimeOnly(17, 57, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 30, 0), new TimeOnly(16, 47, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 34, 0), new TimeOnly(18, 50, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 41, 0), new TimeOnly(16, 2, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 1, 0), new TimeOnly(17, 6, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 28, 0), new TimeOnly(16, 56, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 41, 0), new TimeOnly(17, 24, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 30, 0), new TimeOnly(16, 4, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 3, 0), new TimeOnly(16, 10, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 32, 0), new TimeOnly(16, 24, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 34, 0), new TimeOnly(17, 20, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 6, 0), new TimeOnly(18, 4, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 20, 0), new TimeOnly(18, 39, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 44, 0), new TimeOnly(17, 34, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 45, 0), new TimeOnly(16, 43, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 0, 0), new TimeOnly(16, 7, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 49, 0), new TimeOnly(16, 47, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 1, 0), new TimeOnly(17, 9, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 59, 0), new TimeOnly(18, 26, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 55, 0), new TimeOnly(17, 31, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 12, 0), new TimeOnly(18, 0, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 4, 0), new TimeOnly(18, 4, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 23, 0), new TimeOnly(18, 19, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 27, 0), new TimeOnly(17, 35, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 14, 0), new TimeOnly(17, 38, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 57, 0), new TimeOnly(17, 44, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 51, 0), new TimeOnly(16, 10, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 7, 0), new TimeOnly(17, 3, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 50, 0), new TimeOnly(16, 26, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 2, 0), new TimeOnly(18, 34, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 52, 0), new TimeOnly(18, 2, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 9, 0), new TimeOnly(18, 25, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 27, 0), new TimeOnly(17, 21, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 25, 0), new TimeOnly(17, 36, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 22, 0), new TimeOnly(18, 8, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 58, 0), new TimeOnly(18, 20, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 57, 0), new TimeOnly(16, 14, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 55, 0), new TimeOnly(18, 30, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 29, 0), new TimeOnly(18, 22, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 51, 0), new TimeOnly(16, 35, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 4, 0), new TimeOnly(18, 58, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 44, 0), new TimeOnly(17, 32, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 43, 0), new TimeOnly(17, 5, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 37, 0), new TimeOnly(17, 8, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 41, 0), new TimeOnly(18, 42, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 27, 0), new TimeOnly(18, 14, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 57, 0), new TimeOnly(17, 4, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 9, 0), new TimeOnly(18, 54, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 51, 0), new TimeOnly(16, 23, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 33, 0), new TimeOnly(16, 6, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CheckIn", "Date" },
                values: new object[] { new TimeOnly(8, 31, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 11, 0), new TimeOnly(16, 31, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 3, 0), new TimeOnly(18, 5, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 34, 0), new TimeOnly(17, 19, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 33, 0), new TimeOnly(17, 5, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 9, 0), new TimeOnly(18, 29, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 41, 0), new TimeOnly(16, 39, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 47, 0), new TimeOnly(17, 41, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 45, 0), new TimeOnly(17, 10, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 47, 0), new TimeOnly(16, 10, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 25, 0), new TimeOnly(16, 50, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 7, 0), new TimeOnly(16, 7, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 34, 0), new TimeOnly(17, 39, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 10, 0), new TimeOnly(17, 41, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 49, 0), new TimeOnly(18, 58, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 44, 0), new TimeOnly(16, 34, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 17, 0), new TimeOnly(18, 47, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 9, 0), new TimeOnly(18, 48, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 23, 0), new TimeOnly(17, 11, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 9, 0), new TimeOnly(18, 54, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 48, 0), new TimeOnly(18, 15, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 59, 0), new TimeOnly(16, 14, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 29, 0), new TimeOnly(16, 29, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 14, 0), new TimeOnly(18, 4, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 58, 0), new TimeOnly(16, 54, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 52, 0), new TimeOnly(16, 31, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 49, 0), new TimeOnly(18, 31, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 38, 0), new TimeOnly(16, 56, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 48, 0), new TimeOnly(16, 0, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 48, 0), new TimeOnly(17, 24, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 52, 0), new TimeOnly(16, 50, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 36, 0), new TimeOnly(17, 27, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 55, 0), new TimeOnly(18, 59, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 27, 0), new TimeOnly(18, 35, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 41, 0), new TimeOnly(17, 35, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 59, 0), new TimeOnly(16, 58, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 9, 0), new TimeOnly(16, 9, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CheckIn", "Date" },
                values: new object[] { new TimeOnly(8, 21, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 27, 0), new TimeOnly(18, 55, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 33, 0), new TimeOnly(18, 42, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 33, 0), new TimeOnly(16, 47, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 4, 0), new TimeOnly(17, 50, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 19, 0), new TimeOnly(18, 13, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 33, 0), new TimeOnly(16, 38, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 0, 0), new TimeOnly(16, 56, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 1, 0), new TimeOnly(17, 35, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 24, 0), new TimeOnly(17, 54, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 13, 0), new TimeOnly(16, 1, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 48, 0), new TimeOnly(18, 44, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 31, 0), new TimeOnly(16, 0, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 59, 0), new TimeOnly(17, 29, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 5, 0), new TimeOnly(17, 37, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 5, 0), new TimeOnly(16, 18, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 51, 0), new TimeOnly(16, 16, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 13, 0), new TimeOnly(18, 43, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 55, 0), new TimeOnly(18, 43, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 42, 0), new TimeOnly(18, 54, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 7, 0), new TimeOnly(16, 34, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 3, 0), new TimeOnly(18, 33, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 38, 0), new TimeOnly(16, 56, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 3, 0), new TimeOnly(18, 39, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 7, 0), new TimeOnly(18, 4, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 49, 0), new TimeOnly(18, 58, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 12, 0), new TimeOnly(18, 49, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 44, 0), new TimeOnly(16, 47, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 24, 0), new TimeOnly(18, 46, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 2, 0), new TimeOnly(17, 25, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 25, 0), new TimeOnly(16, 9, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 29, 0), new TimeOnly(17, 47, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 0, 0), new TimeOnly(16, 48, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 4, 0), new TimeOnly(16, 34, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 19, 0), new TimeOnly(18, 14, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 30, 0), new TimeOnly(18, 1, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 43, 0), new TimeOnly(18, 22, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 49, 0), new TimeOnly(18, 59, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 0, 0), new TimeOnly(18, 6, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(8, 5, 0), new TimeOnly(17, 48, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 59, 0), new TimeOnly(16, 39, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 15, 0), new TimeOnly(17, 16, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 11, 0), new TimeOnly(17, 0, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 58, 0), new TimeOnly(16, 45, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 54, 0), new TimeOnly(18, 9, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 6, 0), new TimeOnly(17, 48, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 58, 0), new TimeOnly(17, 27, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 43, 0), new TimeOnly(18, 4, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 10, 0), new TimeOnly(16, 43, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 23, 0), new TimeOnly(17, 3, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 7, 0), new TimeOnly(16, 5, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 20, 0), new TimeOnly(17, 12, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 34, 0), new TimeOnly(18, 3, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 1, 0), new TimeOnly(17, 55, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 42, 0), new TimeOnly(17, 45, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(8, 51, 0), new TimeOnly(16, 17, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CheckOut", "Date" },
                values: new object[] { new TimeOnly(18, 22, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 31, 0), new TimeOnly(17, 11, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 3, 0), new TimeOnly(16, 35, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 42, 0), new TimeOnly(17, 50, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 54, 0), new TimeOnly(16, 45, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 50, 0), new TimeOnly(18, 13, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 44, 0), new TimeOnly(17, 50, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 14, 0), new TimeOnly(18, 28, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 45, 0), new TimeOnly(17, 9, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 40, 0), new TimeOnly(18, 55, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 0, 0), new TimeOnly(18, 41, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 51, 0), new TimeOnly(16, 30, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 16, 0), new TimeOnly(16, 33, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 58, 0), new TimeOnly(17, 19, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 8, 0), new TimeOnly(16, 2, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 52, 0), new TimeOnly(18, 58, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 54, 0), new TimeOnly(18, 49, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 26, 0), new TimeOnly(17, 43, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 22, 0), new TimeOnly(17, 59, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 48, 0), new TimeOnly(16, 29, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 30, 0), new TimeOnly(17, 19, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 40, 0), new TimeOnly(17, 11, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 38, 0), new TimeOnly(17, 24, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 16, 0), new TimeOnly(16, 9, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 33, 0), new TimeOnly(18, 11, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 45, 0), new TimeOnly(18, 18, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 13, 0), new TimeOnly(18, 12, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 55, 0), new TimeOnly(16, 27, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 31, 0), new TimeOnly(18, 2, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 56, 0), new TimeOnly(17, 4, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 8, 0), new TimeOnly(17, 58, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 55, 0), new TimeOnly(17, 35, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 52, 0), new TimeOnly(18, 51, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 27, 0), new TimeOnly(18, 15, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 38, 0), new TimeOnly(18, 54, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 53, 0), new TimeOnly(18, 21, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 19, 0), new TimeOnly(18, 2, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 18, 0), new TimeOnly(16, 37, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 45, 0), new TimeOnly(18, 31, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 58, 0), new TimeOnly(17, 6, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 55, 0), new TimeOnly(16, 9, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 18, 0), new TimeOnly(18, 44, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 14, 0), new TimeOnly(16, 37, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 18, 0), new TimeOnly(17, 33, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 47, 0), new TimeOnly(18, 30, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 7, 0), new TimeOnly(16, 4, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 34, 0), new TimeOnly(17, 57, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 15, 0), new TimeOnly(16, 27, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 1, 0), new TimeOnly(18, 13, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 20, 0), new TimeOnly(18, 46, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 57, 0), new TimeOnly(17, 33, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 15, 0), new TimeOnly(17, 26, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 47, 0), new TimeOnly(17, 29, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 9, 0), new TimeOnly(18, 3, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 31, 0), new TimeOnly(18, 22, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 19, 0), new TimeOnly(18, 27, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 51, 0), new TimeOnly(18, 23, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 17, 0), new TimeOnly(18, 53, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 27, 0), new TimeOnly(16, 35, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 44, 0), new TimeOnly(17, 1, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 2, 0), new TimeOnly(16, 53, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 52, 0), new TimeOnly(17, 53, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 40, 0), new TimeOnly(18, 16, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 39, 0), new TimeOnly(18, 20, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 2, 0), new TimeOnly(17, 34, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 22, 0), new TimeOnly(18, 4, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 2, 0), new TimeOnly(16, 42, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 50, 0), new TimeOnly(18, 29, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 26, 0), new TimeOnly(16, 57, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 42, 0), new TimeOnly(18, 42, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 25, 0), new TimeOnly(17, 40, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 52, 0), new TimeOnly(16, 34, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 33, 0), new TimeOnly(16, 34, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 39, 0), new TimeOnly(18, 35, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 12, 0), new TimeOnly(17, 30, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 3, 0), new TimeOnly(16, 20, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 34, 0), new TimeOnly(18, 28, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 27, 0), new TimeOnly(16, 20, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 21, 0), new TimeOnly(18, 7, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 9, 0), new TimeOnly(18, 53, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 31, 0), new TimeOnly(18, 43, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 56, 0), new TimeOnly(17, 8, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 9, 0), new TimeOnly(16, 46, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 36, 0), new TimeOnly(17, 15, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 47, 0), new TimeOnly(17, 43, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 13, 0), new TimeOnly(18, 33, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 41, 0), new TimeOnly(16, 57, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 19, 0), new TimeOnly(16, 25, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 56, 0), new TimeOnly(17, 1, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 39, 0), new TimeOnly(16, 7, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 35, 0), new TimeOnly(18, 36, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 41, 0), new TimeOnly(18, 22, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 34, 0), new TimeOnly(18, 19, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 19, 0), new TimeOnly(18, 10, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 43, 0), new TimeOnly(16, 18, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 41, 0), new TimeOnly(16, 52, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 55, 0), new TimeOnly(17, 54, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 2, 0), new TimeOnly(17, 28, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 37, 0), new TimeOnly(18, 8, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 49, 0), new TimeOnly(18, 12, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 35, 0), new TimeOnly(18, 2, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 4, 0), new TimeOnly(16, 54, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 29, 0), new TimeOnly(18, 23, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 35, 0), new TimeOnly(18, 50, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 1, 0), new TimeOnly(16, 55, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 33, 0), new TimeOnly(18, 10, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 39, 0), new TimeOnly(18, 35, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 29, 0), new TimeOnly(16, 49, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 31, 0), new TimeOnly(16, 38, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 24, 0), new TimeOnly(17, 23, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 2, 0), new TimeOnly(18, 32, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 4, 0), new TimeOnly(18, 56, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(8, 14, 0), new TimeOnly(17, 19, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 11, 0), new TimeOnly(18, 31, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 8, 0), new TimeOnly(17, 47, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 11, 0), new TimeOnly(18, 28, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 24, 0), new TimeOnly(17, 50, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 48, 0), new TimeOnly(16, 38, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 41, 0), new TimeOnly(18, 5, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 15, 0), new TimeOnly(18, 33, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 33, 0), new TimeOnly(18, 23, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 35, 0), new TimeOnly(18, 35, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 50, 0), new TimeOnly(16, 14, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 22, 0), new TimeOnly(18, 29, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 25, 0), new TimeOnly(17, 22, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 59, 0), new TimeOnly(18, 58, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 28, 0), new TimeOnly(16, 9, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 52, 0), new TimeOnly(16, 9, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(8, 49, 0), new TimeOnly(16, 35, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 33, 0), new TimeOnly(17, 59, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 59, 0), new TimeOnly(16, 38, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 27, 0), new TimeOnly(17, 16, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 15, 0), new TimeOnly(16, 12, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 43, 0), new TimeOnly(18, 22, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 49, 0), new TimeOnly(16, 0, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 18, 0), new TimeOnly(17, 30, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 1, 0), new TimeOnly(18, 35, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 11, 0), new TimeOnly(17, 56, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 26, 0), new TimeOnly(16, 22, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 20, 0), new TimeOnly(18, 44, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 2, 0), new TimeOnly(18, 23, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "CheckIn", "Date" },
                values: new object[] { new TimeOnly(8, 33, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 59, 0), new TimeOnly(17, 39, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 1, 0), new TimeOnly(18, 33, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 12, 0), new TimeOnly(17, 24, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 26, 0), new TimeOnly(16, 31, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 46, 0), new TimeOnly(17, 8, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 3, 0), new TimeOnly(16, 3, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 37, 0), new TimeOnly(18, 52, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 22, 0), new TimeOnly(18, 35, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 53, 0), new TimeOnly(16, 52, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 57, 0), new TimeOnly(17, 42, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 56, 0), new TimeOnly(17, 53, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "CheckOut", "Date" },
                values: new object[] { new TimeOnly(17, 45, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 34, 0), new TimeOnly(16, 1, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 23, 0), new TimeOnly(18, 9, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 52, 0), new TimeOnly(18, 9, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 47, 0), new TimeOnly(17, 9, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 59, 0), new TimeOnly(16, 16, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 13, 0), new TimeOnly(16, 18, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 34, 0), new TimeOnly(18, 31, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 31, 0), new TimeOnly(18, 28, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 59, 0), new TimeOnly(17, 38, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 48, 0), new TimeOnly(18, 44, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 9, 0), new TimeOnly(16, 43, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 17, 0), new TimeOnly(18, 50, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 10, 0), new TimeOnly(17, 1, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 47, 0), new TimeOnly(17, 10, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 24, 0), new TimeOnly(17, 57, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 46, 0), new TimeOnly(17, 21, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 25, 0), new TimeOnly(16, 17, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 4, 0), new TimeOnly(16, 4, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 47, 0), new TimeOnly(17, 33, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 20, 0), new TimeOnly(17, 6, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 3, 0), new TimeOnly(18, 14, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 29, 0), new TimeOnly(18, 0, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 5, 0), new TimeOnly(17, 48, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 5, 0), new TimeOnly(17, 13, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 41, 0), new TimeOnly(17, 48, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 12, 0), new TimeOnly(17, 39, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 56, 0), new TimeOnly(17, 46, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 44, 0), new TimeOnly(18, 6, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 29, 0), new TimeOnly(18, 52, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 34, 0), new TimeOnly(18, 24, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 18, 0), new TimeOnly(18, 12, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 43, 0), new TimeOnly(17, 4, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 17, 0), new TimeOnly(18, 20, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 57, 0), new TimeOnly(17, 22, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 47, 0), new TimeOnly(16, 11, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 15, 0), new TimeOnly(18, 47, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 12, 0), new TimeOnly(17, 59, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "CheckIn", "Date" },
                values: new object[] { new TimeOnly(9, 19, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 32, 0), new TimeOnly(18, 48, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 11, 0), new TimeOnly(16, 36, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 3, 0), new TimeOnly(17, 54, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 17, 0), new TimeOnly(16, 40, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 28, 0), new TimeOnly(17, 10, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 36, 0), new TimeOnly(18, 26, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 39, 0), new TimeOnly(16, 2, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 1, 0), new TimeOnly(18, 22, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 49, 0), new TimeOnly(16, 15, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 42, 0), new TimeOnly(17, 13, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 0, 0), new TimeOnly(16, 28, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 42, 0), new TimeOnly(17, 24, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 5, 0), new TimeOnly(18, 13, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 23, 0), new TimeOnly(17, 48, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 19, 0), new TimeOnly(17, 0, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 50, 0), new TimeOnly(16, 8, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 26, 0), new TimeOnly(18, 5, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 42, 0), new TimeOnly(17, 7, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 14, 0), new TimeOnly(18, 29, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 44, 0), new TimeOnly(17, 4, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 28, 0), new TimeOnly(18, 54, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 56, 0), new TimeOnly(18, 25, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "CheckIn", "Date" },
                values: new object[] { new TimeOnly(9, 16, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 29, 0), new TimeOnly(18, 43, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 48, 0), new TimeOnly(16, 9, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 45, 0), new TimeOnly(18, 7, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 59, 0), new TimeOnly(18, 44, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 1, 0), new TimeOnly(17, 11, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 55, 0), new TimeOnly(17, 46, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 39, 0), new TimeOnly(18, 56, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 21, 0), new TimeOnly(18, 12, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 56, 0), new TimeOnly(16, 40, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 52, 0), new TimeOnly(16, 51, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 51, 0), new TimeOnly(17, 45, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 9, 0), new TimeOnly(17, 9, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 24, 0), new TimeOnly(17, 51, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 5, 0), new TimeOnly(18, 11, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 2, 0), new TimeOnly(17, 36, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 18, 0), new TimeOnly(17, 20, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 53, 0), new TimeOnly(16, 51, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 46, 0), new TimeOnly(17, 20, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 17, 0), new TimeOnly(17, 6, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 15, 0), new TimeOnly(18, 19, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 52, 0), new TimeOnly(16, 45, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 15, 0), new TimeOnly(17, 10, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 32, 0), new TimeOnly(17, 10, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 55, 0), new TimeOnly(16, 59, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 34, 0), new TimeOnly(17, 57, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 45, 0), new TimeOnly(18, 36, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 41, 0), new TimeOnly(16, 21, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 44, 0), new TimeOnly(17, 43, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 15, 0), new TimeOnly(18, 18, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 16, 0), new TimeOnly(17, 37, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 55, 0), new TimeOnly(18, 13, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 23, 0), new TimeOnly(16, 59, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 30, 0), new TimeOnly(17, 32, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 48, 0), new TimeOnly(16, 53, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 12, 0), new TimeOnly(17, 54, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 5, 0), new TimeOnly(17, 31, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 27, 0), new TimeOnly(17, 1, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 58, 0), new TimeOnly(17, 32, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 47, 0), new TimeOnly(18, 21, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 33, 0), new TimeOnly(18, 24, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 52, 0), new TimeOnly(17, 14, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 38, 0), new TimeOnly(17, 17, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 52, 0), new TimeOnly(17, 29, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "CheckIn", "Date" },
                values: new object[] { new TimeOnly(7, 39, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 6, 0), new TimeOnly(16, 19, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 44, 0), new TimeOnly(17, 39, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 18, 0), new TimeOnly(18, 52, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 16, 0), new TimeOnly(18, 54, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 43, 0), new TimeOnly(17, 28, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 10, 0), new TimeOnly(16, 47, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 53, 0), new TimeOnly(18, 23, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 47, 0), new TimeOnly(16, 36, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 55, 0), new TimeOnly(17, 17, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 39, 0), new TimeOnly(18, 28, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(8, 16, 0), new TimeOnly(18, 1, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 59, 0), new TimeOnly(18, 8, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 57, 0), new TimeOnly(17, 26, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 23, 0), new TimeOnly(18, 5, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 12, 0), new TimeOnly(16, 0, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 45, 0), new TimeOnly(16, 44, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 24, 0), new TimeOnly(16, 21, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 17, 0), new TimeOnly(18, 43, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 11, 0), new TimeOnly(18, 48, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 26, 0), new TimeOnly(16, 35, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 14, 0), new TimeOnly(17, 40, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 28, 0), new TimeOnly(18, 59, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 36, 0), new TimeOnly(18, 12, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 45, 0), new TimeOnly(17, 54, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 33, 0), new TimeOnly(18, 44, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 11, 0), new TimeOnly(18, 2, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 10, 0), new TimeOnly(18, 2, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 11, 0), new TimeOnly(16, 55, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 52, 0), new TimeOnly(16, 9, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 50, 0), new TimeOnly(17, 26, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 27, 0), new TimeOnly(16, 42, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 21, 0), new TimeOnly(16, 21, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 14, 0), new TimeOnly(16, 42, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 56, 0), new TimeOnly(18, 28, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 59, 0), new TimeOnly(18, 45, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 17, 0), new TimeOnly(17, 25, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 13, 0), new TimeOnly(16, 1, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 20, 0), new TimeOnly(17, 45, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 35, 0), new TimeOnly(16, 19, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "CheckIn", "Date" },
                values: new object[] { new TimeOnly(8, 32, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 53, 0), new TimeOnly(18, 30, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 59, 0), new TimeOnly(17, 5, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 47, 0), new TimeOnly(16, 46, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 29, 0), new TimeOnly(18, 58, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 30, 0), new TimeOnly(16, 47, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 40, 0), new TimeOnly(18, 49, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 0, 0), new TimeOnly(17, 22, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 10, 0), new TimeOnly(17, 59, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 19, 0), new TimeOnly(17, 42, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 45, 0), new TimeOnly(18, 25, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 38, 0), new TimeOnly(17, 1, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 46, 0), new TimeOnly(16, 45, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 7, 0), new TimeOnly(16, 22, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 43, 0), new TimeOnly(18, 18, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 45, 0), new TimeOnly(17, 45, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 10, 0), new TimeOnly(16, 38, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 10, 0), new TimeOnly(17, 17, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 34, 0), new TimeOnly(17, 32, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 19, 0), new TimeOnly(17, 21, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 13, 0), new TimeOnly(16, 26, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 12, 0), new TimeOnly(16, 24, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 33, 0), new TimeOnly(18, 43, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 28, 0), new TimeOnly(17, 12, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 58, 0), new TimeOnly(17, 27, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 11, 0), new TimeOnly(17, 19, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 8, 0), new TimeOnly(18, 29, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 39, 0), new TimeOnly(17, 20, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 1, 0), new TimeOnly(18, 49, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 42, 0), new TimeOnly(18, 55, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 24, 0), new TimeOnly(18, 14, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 37, 0), new TimeOnly(16, 25, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 19, 0), new TimeOnly(18, 42, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 57, 0), new TimeOnly(18, 33, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 20, 0), new TimeOnly(18, 3, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 21, 0), new TimeOnly(17, 10, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 13, 0), new TimeOnly(18, 45, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 37, 0), new TimeOnly(18, 1, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 32, 0), new TimeOnly(17, 57, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 19, 0), new TimeOnly(18, 49, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 50, 0), new TimeOnly(16, 49, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 27, 0), new TimeOnly(17, 57, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 17, 0), new TimeOnly(17, 17, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 50, 0), new TimeOnly(16, 6, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 21, 0), new TimeOnly(17, 20, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 35, 0), new TimeOnly(18, 3, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 58, 0), new TimeOnly(18, 11, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 17, 0), new TimeOnly(17, 43, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 35, 0), new TimeOnly(18, 18, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 25, 0), new TimeOnly(18, 20, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 7, 0), new TimeOnly(18, 25, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 52, 0), new TimeOnly(17, 31, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 40, 0), new TimeOnly(16, 11, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 43, 0), new TimeOnly(17, 57, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 12, 0), new TimeOnly(17, 56, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 30, 0), new TimeOnly(17, 41, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 57, 0), new TimeOnly(16, 47, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 59, 0), new TimeOnly(16, 18, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 7, 0), new TimeOnly(16, 43, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 49, 0), new TimeOnly(18, 13, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 9, 0), new TimeOnly(17, 55, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 8, 0), new TimeOnly(17, 18, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 51, 0), new TimeOnly(16, 17, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 40, 0), new TimeOnly(17, 57, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 42, 0), new TimeOnly(18, 19, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 35, 0), new TimeOnly(16, 26, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 48, 0), new TimeOnly(17, 30, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 52, 0), new TimeOnly(18, 47, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 45, 0), new TimeOnly(17, 14, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 58, 0), new TimeOnly(17, 10, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 48, 0), new TimeOnly(16, 52, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 44, 0), new TimeOnly(18, 30, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 55, 0), new TimeOnly(16, 4, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 20, 0), new TimeOnly(17, 39, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 46, 0), new TimeOnly(18, 5, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 42, 0), new TimeOnly(16, 44, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "CheckOut", "Date" },
                values: new object[] { new TimeOnly(16, 58, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 49, 0), new TimeOnly(17, 52, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 12, 0), new TimeOnly(17, 35, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 59, 0), new TimeOnly(18, 3, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 47, 0), new TimeOnly(18, 2, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 32, 0), new TimeOnly(17, 22, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 39, 0), new TimeOnly(17, 56, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 32, 0), new TimeOnly(17, 6, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 44, 0), new TimeOnly(18, 19, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 13, 0), new TimeOnly(16, 50, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 17, 0), new TimeOnly(16, 2, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 28, 0), new TimeOnly(17, 52, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 28, 0), new TimeOnly(18, 18, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 51, 0), new TimeOnly(17, 14, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 0, 0), new TimeOnly(18, 14, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 25, 0), new TimeOnly(17, 4, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 40, 0), new TimeOnly(17, 2, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 30, 0), new TimeOnly(18, 22, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 1, 0), new TimeOnly(18, 52, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 28, 0), new TimeOnly(18, 12, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 0, 0), new TimeOnly(17, 26, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 34, 0), new TimeOnly(16, 45, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 28, 0), new TimeOnly(16, 19, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 40, 0), new TimeOnly(16, 59, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 24, 0), new TimeOnly(18, 45, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 58, 0), new TimeOnly(18, 49, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 47, 0), new TimeOnly(17, 53, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 25, 0), new TimeOnly(18, 9, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 45, 0), new TimeOnly(16, 7, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 18, 0), new TimeOnly(16, 55, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 48, 0), new TimeOnly(17, 27, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 29, 0), new TimeOnly(18, 35, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 19, 0), new TimeOnly(17, 11, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 21, 0), new TimeOnly(16, 51, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 1, 0), new TimeOnly(18, 41, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 11, 0), new TimeOnly(18, 50, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 21, 0), new TimeOnly(18, 51, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 8, 0), new TimeOnly(18, 23, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 15, 0), new TimeOnly(18, 49, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 22, 0), new TimeOnly(18, 18, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 43, 0), new TimeOnly(16, 37, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 3, 0), new TimeOnly(18, 57, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 4, 0), new TimeOnly(17, 27, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 24, 0), new TimeOnly(16, 10, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 59, 0), new TimeOnly(16, 46, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 36, 0), new TimeOnly(16, 46, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 14, 0), new TimeOnly(18, 15, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 43, 0), new TimeOnly(18, 20, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 59, 0), new TimeOnly(18, 4, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 42, 0), new TimeOnly(16, 38, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 38, 0), new TimeOnly(18, 31, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 37, 0), new TimeOnly(17, 10, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 1, 0), new TimeOnly(17, 24, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 48, 0), new TimeOnly(16, 51, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 57, 0), new TimeOnly(16, 13, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 29, 0), new TimeOnly(16, 51, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 51, 0), new TimeOnly(16, 0, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 28, 0), new TimeOnly(17, 13, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 48, 0), new TimeOnly(18, 48, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 51, 0), new TimeOnly(18, 17, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 12, 0), new TimeOnly(18, 22, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 33, 0), new TimeOnly(17, 0, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 2, 0), new TimeOnly(17, 10, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 36, 0), new TimeOnly(16, 54, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 16, 0), new TimeOnly(18, 45, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 26, 0), new TimeOnly(18, 27, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 6, 0), new TimeOnly(17, 16, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 25, 0), new TimeOnly(16, 23, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 13, 0), new TimeOnly(17, 40, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 39, 0), new TimeOnly(16, 41, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 19, 0), new TimeOnly(17, 42, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 23, 0), new TimeOnly(16, 32, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 52, 0), new TimeOnly(16, 55, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 26, 0), new TimeOnly(17, 14, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 59, 0), new TimeOnly(18, 45, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 25, 0), new TimeOnly(17, 56, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 29, 0), new TimeOnly(16, 49, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 49, 0), new TimeOnly(17, 8, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(8, 13, 0), new TimeOnly(18, 36, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 49, 0), new TimeOnly(17, 22, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 31, 0), new TimeOnly(18, 29, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 6, 0), new TimeOnly(18, 34, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 24, 0), new TimeOnly(16, 16, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 56, 0), new TimeOnly(16, 40, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 18, 0), new TimeOnly(17, 46, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 9, 0), new TimeOnly(16, 47, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 28, 0), new TimeOnly(17, 32, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 21, 0), new TimeOnly(16, 33, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 15, 0), new TimeOnly(16, 45, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 29, 0), new TimeOnly(18, 42, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 21, 0), new TimeOnly(17, 17, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 19, 0), new TimeOnly(18, 27, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 26, 0), new TimeOnly(16, 17, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 59, 0), new TimeOnly(17, 8, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 30, 0), new TimeOnly(16, 51, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 52, 0), new TimeOnly(18, 54, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 58, 0), new TimeOnly(18, 26, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 21, 0), new TimeOnly(17, 29, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 7, 0), new TimeOnly(17, 27, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 46, 0), new TimeOnly(18, 23, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 25, 0), new TimeOnly(16, 25, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 52, 0), new TimeOnly(16, 44, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 41, 0), new TimeOnly(16, 55, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 25, 0), new TimeOnly(17, 12, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 9, 0), new TimeOnly(18, 57, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 25, 0), new TimeOnly(16, 27, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 19, 0), new TimeOnly(16, 35, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 18, 0), new TimeOnly(18, 18, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 23, 0), new TimeOnly(16, 33, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 42, 0), new TimeOnly(17, 38, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 24, 0), new TimeOnly(17, 8, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 50, 0), new TimeOnly(18, 12, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 16, 0), new TimeOnly(18, 46, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 36, 0), new TimeOnly(17, 30, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 32, 0), new TimeOnly(18, 51, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 16, 0), new TimeOnly(17, 0, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 45, 0), new TimeOnly(18, 14, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 17, 0), new TimeOnly(17, 7, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 18, 0), new TimeOnly(18, 23, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 54, 0), new TimeOnly(18, 37, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 25, 0), new TimeOnly(17, 4, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 6, 0), new TimeOnly(17, 2, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 35, 0), new TimeOnly(18, 35, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 5, 0), new TimeOnly(18, 25, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 48, 0), new TimeOnly(16, 28, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 55, 0), new TimeOnly(16, 44, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 51, 0), new TimeOnly(16, 46, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 3, 0), new TimeOnly(16, 13, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 18, 0), new TimeOnly(17, 41, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 29, 0), new TimeOnly(17, 24, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 24, 0), new TimeOnly(16, 46, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 7, 0), new TimeOnly(16, 40, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 21, 0), new TimeOnly(16, 22, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 47, 0), new TimeOnly(18, 10, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 17, 0), new TimeOnly(16, 54, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 43, 0), new TimeOnly(17, 22, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 33, 0), new TimeOnly(16, 35, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 11, 0), new TimeOnly(18, 31, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 58, 0), new TimeOnly(18, 55, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 47, 0), new TimeOnly(18, 43, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 17, 0), new TimeOnly(18, 3, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 4, 0), new TimeOnly(18, 5, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 43, 0), new TimeOnly(16, 30, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 43, 0), new TimeOnly(18, 4, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 24, 0), new TimeOnly(17, 26, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 35, 0), new TimeOnly(16, 28, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 49, 0), new TimeOnly(16, 25, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 59, 0), new TimeOnly(16, 48, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 19, 0), new TimeOnly(17, 0, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 55, 0), new TimeOnly(17, 56, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 14, 0), new TimeOnly(18, 55, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 24, 0), new TimeOnly(17, 19, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 51, 0), new TimeOnly(17, 41, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 49, 0), new TimeOnly(16, 0, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 40, 0), new TimeOnly(16, 59, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 37, 0), new TimeOnly(18, 55, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 1, 0), new TimeOnly(16, 6, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 21, 0), new TimeOnly(18, 25, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 49, 0), new TimeOnly(16, 57, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 39, 0), new TimeOnly(17, 20, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 21, 0), new TimeOnly(16, 21, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 33, 0), new TimeOnly(18, 14, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 50, 0), new TimeOnly(16, 53, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 21, 0), new TimeOnly(17, 21, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 47, 0), new TimeOnly(18, 28, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 36, 0), new TimeOnly(17, 55, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 12, 0), new TimeOnly(17, 44, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 51, 0), new TimeOnly(18, 50, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 26, 0), new TimeOnly(17, 29, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 7, 0), new TimeOnly(17, 44, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 36, 0), new TimeOnly(18, 12, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 37, 0), new TimeOnly(18, 37, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 44, 0), new TimeOnly(17, 46, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 58, 0), new TimeOnly(18, 22, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 5, 0), new TimeOnly(16, 26, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 46, 0), new TimeOnly(17, 50, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 31, 0), new TimeOnly(18, 39, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 13, 0), new TimeOnly(16, 8, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 40, 0), new TimeOnly(17, 38, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 31, 0), new TimeOnly(18, 50, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 49, 0), new TimeOnly(18, 29, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 12, 0), new TimeOnly(18, 47, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 0, 0), new TimeOnly(18, 26, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 33, 0), new TimeOnly(18, 33, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 16, 0), new TimeOnly(16, 17, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 32, 0), new TimeOnly(16, 30, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 24, 0), new TimeOnly(16, 8, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 58, 0), new TimeOnly(16, 4, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 4, 0), new TimeOnly(17, 13, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 18, 0), new TimeOnly(18, 28, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 11, 0), new TimeOnly(18, 35, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 21, 0), new TimeOnly(16, 41, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 38, 0), new TimeOnly(18, 48, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 0, 0), new TimeOnly(16, 40, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 10, 0), new TimeOnly(18, 0, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 35, 0), new TimeOnly(16, 10, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 54, 0), new TimeOnly(16, 55, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 57, 0), new TimeOnly(18, 32, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 43, 0), new TimeOnly(17, 36, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 6, 0), new TimeOnly(17, 17, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 20, 0), new TimeOnly(16, 1, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 3, 0), new TimeOnly(17, 14, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 30, 0), new TimeOnly(16, 12, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 2, 0), new TimeOnly(17, 13, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 38, 0), new TimeOnly(16, 27, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 25, 0), new TimeOnly(16, 9, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 5, 0), new TimeOnly(18, 58, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 5, 0), new TimeOnly(16, 23, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 51, 0), new TimeOnly(16, 32, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 42, 0), new TimeOnly(17, 53, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 22, 0), new TimeOnly(17, 52, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 40, 0), new TimeOnly(16, 20, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 2, 0), new TimeOnly(16, 11, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 0, 0), new TimeOnly(16, 48, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 55, 0), new TimeOnly(16, 19, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 37, 0), new TimeOnly(17, 29, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 18, 0), new TimeOnly(16, 58, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 48, 0), new TimeOnly(16, 3, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 31, 0), new TimeOnly(16, 1, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 4, 0), new TimeOnly(18, 39, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 43, 0), new TimeOnly(16, 55, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 25, 0), new TimeOnly(18, 51, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 49, 0), new TimeOnly(17, 13, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 7, 0), new TimeOnly(18, 32, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 55, 0), new TimeOnly(17, 14, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 12, 0), new TimeOnly(18, 7, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 1, 0), new TimeOnly(16, 35, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 7, 0), new TimeOnly(16, 8, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 13, 0), new TimeOnly(16, 59, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 38, 0), new TimeOnly(17, 55, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 39, 0), new TimeOnly(18, 13, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 46, 0), new TimeOnly(17, 43, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 12, 0), new TimeOnly(17, 2, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 7, 0), new TimeOnly(17, 25, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 29, 0), new TimeOnly(18, 3, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 11, 0), new TimeOnly(17, 32, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 27, 0), new TimeOnly(17, 13, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 34, 0), new TimeOnly(17, 18, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 36, 0), new TimeOnly(17, 18, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 20, 0), new TimeOnly(17, 42, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 57, 0), new TimeOnly(17, 25, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 32, 0), new TimeOnly(16, 54, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 15, 0), new TimeOnly(16, 27, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 13, 0), new TimeOnly(16, 25, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 5, 0), new TimeOnly(18, 29, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 18, 0), new TimeOnly(17, 41, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 10, 0), new TimeOnly(17, 43, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 1, 0), new TimeOnly(16, 16, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 46, 0), new TimeOnly(17, 48, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 53, 0), new TimeOnly(17, 7, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 30, 0), new TimeOnly(16, 46, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 12, 0), new TimeOnly(17, 55, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 5, 0), new TimeOnly(17, 18, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 8, 0), new TimeOnly(18, 46, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 58, 0), new TimeOnly(18, 43, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 40, 0), new TimeOnly(17, 19, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 50, 0), new TimeOnly(17, 31, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 51, 0), new TimeOnly(18, 18, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 3, 0), new TimeOnly(17, 59, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 47, 0), new TimeOnly(16, 45, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 47, 0), new TimeOnly(18, 38, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 0, 0), new TimeOnly(17, 47, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 28, 0), new TimeOnly(16, 41, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 28, 0), new TimeOnly(17, 45, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 43, 0), new TimeOnly(18, 46, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 52, 0), new TimeOnly(18, 4, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 59, 0), new TimeOnly(17, 48, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 40, 0), new TimeOnly(18, 4, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 49, 0), new TimeOnly(18, 6, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 55, 0), new TimeOnly(17, 24, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImgUrl", "Name", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/202.jpg", "Chasity Fadel", 72721m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/939.jpg", "Leola Kuhlman", 5, 36384m, 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/140.jpg", "Fred Cole", 2, 94318m, 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/777.jpg", "Hannah Hartmann", 0, 70924m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/277.jpg", "Virgie Farrell", 8, 76290m, 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/217.jpg", "Liam Oberbrunner", 9, 35758m, 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/629.jpg", "Leola Bailey", 3, 65390m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/265.jpg", "Leopoldo Tromp", 4, 44190m, 3 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/415.jpg", "Lloyd Kuhlman", 9, 86140m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/244.jpg", "Jazmin Nitzsche", 7, 35250m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/742.jpg", "Trenton Gulgowski", 8, 90808m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImgUrl", "Name", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/714.jpg", "Tracy Miller", 44728m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImgUrl", "Name", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/45.jpg", "Briana Zulauf", 44660m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1114.jpg", "Lacey Pouros", 2, 35971m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/198.jpg", "Max Mueller", 6, 43294m, 3 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1047.jpg", "Arne Mosciski", 5, 98532m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/651.jpg", "Delpha Rowe", 4, 43267m, 3 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/796.jpg", "Christa Harber", 9, 47760m, 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/129.jpg", "Precious Beier", 0, 87113m, 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ImgUrl", "Name", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/10.jpg", "Cassandre Hahn", 77955m, 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/795.jpg", "Marquis McLaughlin", 3, 89536m, 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/601.jpg", "Jennie Torp", 1, 54678m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/446.jpg", "Anabel Daugherty", 0, 32924m, 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/286.jpg", "Cale Kshlerin", 7, 89617m, 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/200.jpg", "Franz Pollich", 5, 80179m, 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/341.jpg", "Everardo Bashirian", 0, 43245m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/544.jpg", "Aleen Thiel", 2, 81521m, 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ImgUrl", "Name", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/154.jpg", "Ruthe Pagac", 76981m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/214.jpg", "Jennifer Fahey", 0, 58747m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/823.jpg", "Leonard Marks", 3, 95157m, 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/329.jpg", "Cale Daniel", 9, 76790m, 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1041.jpg", "Rachael Fahey", 2, 65581m, 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/887.jpg", "Garrett Waelchi", 7, 96251m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/655.jpg", "Lydia Lakin", 6, 81369m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/39.jpg", "Esperanza Beahan", 1, 36846m, 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/307.jpg", "Lorna Wuckert", 6, 76328m, 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/702.jpg", "Kiley Christiansen", 4, 44703m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/262.jpg", "Dorcas Muller", 6, 43079m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/691.jpg", "Jarrett Wisoky", 0, 37243m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/627.jpg", "Ariel Stoltenberg", 2, 63072m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1078.jpg", "Shania Weissnat", 8, 64270m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/711.jpg", "Lexus Ankunding", 7, 74402m, 3 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/296.jpg", "Hope Klein", 4, 32447m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1208.jpg", "Jaunita Bogisich", 5, 43927m, 3 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/667.jpg", "Aniya Yundt", 8, 98880m, 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/524.jpg", "Fletcher Nienow", 5, 82634m, 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1003.jpg", "Kayla West", 3, 45450m, 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/516.jpg", "Arturo Heaney", 0, 86541m, 3 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/108.jpg", "Loy Mraz", 8, 43342m, 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1101.jpg", "Waylon Mann", 1, 50212m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "Employees",
                type: "decimal(65,30)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(65,30)");

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "ImgUrl",
                keyValue: null,
                column: "ImgUrl",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "ImgUrl",
                table: "Employees",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 51, 0), new TimeOnly(17, 13, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CheckIn", "Date" },
                values: new object[] { new TimeOnly(8, 34, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 54, 0), new TimeOnly(17, 43, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 1, 0), new TimeOnly(17, 47, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 53, 0), new TimeOnly(18, 13, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 50, 0), new TimeOnly(17, 43, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 37, 0), new TimeOnly(17, 47, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 38, 0), new TimeOnly(18, 53, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 44, 0), new TimeOnly(17, 31, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 4, 0), new TimeOnly(18, 18, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(8, 12, 0), new TimeOnly(16, 4, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 4, 0), new TimeOnly(16, 11, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 34, 0), new TimeOnly(16, 49, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 0, 0), new TimeOnly(16, 30, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 14, 0), new TimeOnly(17, 17, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 27, 0), new TimeOnly(18, 53, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 29, 0), new TimeOnly(16, 12, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 51, 0), new TimeOnly(18, 47, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 57, 0), new TimeOnly(17, 0, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 58, 0), new TimeOnly(16, 57, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 59, 0), new TimeOnly(17, 6, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 11, 0), new TimeOnly(16, 27, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 53, 0), new TimeOnly(17, 2, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 32, 0), new TimeOnly(18, 34, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 3, 0), new TimeOnly(18, 42, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 51, 0), new TimeOnly(17, 34, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 9, 0), new TimeOnly(16, 4, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 29, 0), new TimeOnly(16, 48, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 11, 0), new TimeOnly(16, 6, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 14, 0), new TimeOnly(17, 54, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 22, 0), new TimeOnly(18, 5, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 30, 0), new TimeOnly(16, 23, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 34, 0), new TimeOnly(17, 29, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 31, 0), new TimeOnly(17, 21, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 34, 0), new TimeOnly(17, 38, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 47, 0), new TimeOnly(16, 34, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 14, 0), new TimeOnly(18, 22, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 0, 0), new TimeOnly(16, 52, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 58, 0), new TimeOnly(16, 5, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 30, 0), new TimeOnly(18, 57, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 28, 0), new TimeOnly(18, 47, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 3, 0), new TimeOnly(16, 18, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 55, 0), new TimeOnly(17, 47, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 49, 0), new TimeOnly(16, 7, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 45, 0), new TimeOnly(16, 1, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 0, 0), new TimeOnly(17, 59, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 59, 0), new TimeOnly(18, 26, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 50, 0), new TimeOnly(17, 31, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 4, 0), new TimeOnly(16, 27, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 41, 0), new TimeOnly(18, 29, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 54, 0), new TimeOnly(16, 21, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 27, 0), new TimeOnly(17, 50, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 17, 0), new TimeOnly(18, 24, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 41, 0), new TimeOnly(17, 42, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 31, 0), new TimeOnly(17, 19, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 33, 0), new TimeOnly(17, 2, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 49, 0), new TimeOnly(18, 19, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 29, 0), new TimeOnly(18, 54, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 32, 0), new TimeOnly(17, 17, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 55, 0), new TimeOnly(17, 2, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 14, 0), new TimeOnly(17, 27, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 3, 0), new TimeOnly(17, 48, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 55, 0), new TimeOnly(18, 54, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 13, 0), new TimeOnly(16, 42, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 41, 0), new TimeOnly(18, 26, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 15, 0), new TimeOnly(16, 19, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 26, 0), new TimeOnly(16, 38, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 39, 0), new TimeOnly(17, 23, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "CheckIn", "Date" },
                values: new object[] { new TimeOnly(9, 57, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 45, 0), new TimeOnly(18, 9, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 14, 0), new TimeOnly(17, 50, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 8, 0), new TimeOnly(18, 52, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 34, 0), new TimeOnly(16, 50, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 51, 0), new TimeOnly(18, 5, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 38, 0), new TimeOnly(17, 41, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 52, 0), new TimeOnly(16, 15, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 55, 0), new TimeOnly(18, 38, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 34, 0), new TimeOnly(16, 43, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 54, 0), new TimeOnly(18, 57, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 8, 0), new TimeOnly(18, 7, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 7, 0), new TimeOnly(18, 19, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 9, 0), new TimeOnly(17, 53, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 6, 0), new TimeOnly(18, 17, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 19, 0), new TimeOnly(17, 58, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 52, 0), new TimeOnly(17, 58, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 14, 0), new TimeOnly(17, 19, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 47, 0), new TimeOnly(16, 10, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 44, 0), new TimeOnly(17, 26, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 29, 0), new TimeOnly(17, 54, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 29, 0), new TimeOnly(16, 45, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 91,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 39, 0), new TimeOnly(18, 59, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 92,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 47, 0), new TimeOnly(18, 54, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 93,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 57, 0), new TimeOnly(17, 27, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 94,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 48, 0), new TimeOnly(16, 8, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 95,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 18, 0), new TimeOnly(18, 18, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 96,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 18, 0), new TimeOnly(18, 10, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 97,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 48, 0), new TimeOnly(18, 13, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 98,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 6, 0), new TimeOnly(18, 55, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 99,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 29, 0), new TimeOnly(17, 20, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 100,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 33, 0), new TimeOnly(16, 21, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 17, 0), new TimeOnly(17, 55, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 54, 0), new TimeOnly(17, 7, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 24, 0), new TimeOnly(16, 10, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 13, 0), new TimeOnly(17, 47, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 3, 0), new TimeOnly(18, 7, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 52, 0), new TimeOnly(17, 56, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 7, 0), new TimeOnly(17, 57, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 19, 0), new TimeOnly(18, 48, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 24, 0), new TimeOnly(17, 19, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 47, 0), new TimeOnly(16, 18, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 59, 0), new TimeOnly(18, 23, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 38, 0), new TimeOnly(17, 47, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 40, 0), new TimeOnly(16, 23, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 40, 0), new TimeOnly(16, 8, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 53, 0), new TimeOnly(18, 26, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 21, 0), new TimeOnly(17, 44, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 38, 0), new TimeOnly(17, 2, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 26, 0), new TimeOnly(17, 37, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 11, 0), new TimeOnly(17, 35, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 24, 0), new TimeOnly(17, 7, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 4, 0), new TimeOnly(18, 5, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 41, 0), new TimeOnly(18, 8, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 43, 0), new TimeOnly(16, 20, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 51, 0), new TimeOnly(17, 5, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 31, 0), new TimeOnly(18, 28, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 56, 0), new TimeOnly(16, 26, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 42, 0), new TimeOnly(17, 56, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 10, 0), new TimeOnly(16, 53, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 44, 0), new TimeOnly(18, 20, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 25, 0), new TimeOnly(17, 40, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 12, 0), new TimeOnly(18, 54, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 54, 0), new TimeOnly(18, 14, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 23, 0), new TimeOnly(17, 39, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 59, 0), new TimeOnly(18, 34, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 6, 0), new TimeOnly(16, 47, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 44, 0), new TimeOnly(18, 1, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 45, 0), new TimeOnly(17, 11, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 4, 0), new TimeOnly(18, 10, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 24, 0), new TimeOnly(17, 54, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 37, 0), new TimeOnly(17, 43, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 0, 0), new TimeOnly(18, 19, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 29, 0), new TimeOnly(17, 42, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 46, 0), new TimeOnly(18, 11, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 8, 0), new TimeOnly(18, 51, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 42, 0), new TimeOnly(16, 23, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 36, 0), new TimeOnly(17, 14, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 34, 0), new TimeOnly(18, 35, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 2, 0), new TimeOnly(18, 35, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 56, 0), new TimeOnly(18, 9, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 30, 0), new TimeOnly(16, 10, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(8, 17, 0), new TimeOnly(18, 37, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 0, 0), new TimeOnly(17, 5, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 58, 0), new TimeOnly(16, 25, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 47, 0), new TimeOnly(17, 49, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 36, 0), new TimeOnly(16, 17, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 2, 0), new TimeOnly(18, 10, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 5, 0), new TimeOnly(16, 22, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 2, 0), new TimeOnly(16, 35, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 9, 0), new TimeOnly(16, 5, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 4, 0), new TimeOnly(17, 34, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 46, 0), new TimeOnly(18, 39, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 25, 0), new TimeOnly(16, 17, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 33, 0), new TimeOnly(17, 39, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 9, 0), new TimeOnly(17, 59, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(8, 33, 0), new TimeOnly(16, 8, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 57, 0), new TimeOnly(18, 38, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 16, 0), new TimeOnly(18, 16, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 6, 0), new TimeOnly(17, 6, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 32, 0), new TimeOnly(16, 47, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 23, 0), new TimeOnly(16, 58, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 55, 0), new TimeOnly(17, 36, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 30, 0), new TimeOnly(18, 19, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 14, 0), new TimeOnly(17, 50, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 34, 0), new TimeOnly(16, 1, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 33, 0), new TimeOnly(18, 23, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 0, 0), new TimeOnly(18, 22, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 22, 0), new TimeOnly(16, 25, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 5, 0), new TimeOnly(16, 26, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 35, 0), new TimeOnly(16, 11, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 15, 0), new TimeOnly(18, 11, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 42, 0), new TimeOnly(16, 6, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 3, 0), new TimeOnly(18, 50, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 38, 0), new TimeOnly(18, 26, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 34, 0), new TimeOnly(16, 14, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 43, 0), new TimeOnly(16, 52, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 7, 0), new TimeOnly(18, 56, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 53, 0), new TimeOnly(17, 5, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 2, 0), new TimeOnly(18, 37, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 14, 0), new TimeOnly(17, 12, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 30, 0), new TimeOnly(16, 24, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 26, 0), new TimeOnly(18, 6, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 19, 0), new TimeOnly(16, 17, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 26, 0), new TimeOnly(17, 40, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 19, 0), new TimeOnly(16, 24, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 27, 0), new TimeOnly(16, 33, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 4, 0), new TimeOnly(16, 4, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 12, 0), new TimeOnly(16, 14, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 50, 0), new TimeOnly(17, 31, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 41, 0), new TimeOnly(16, 41, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 51, 0), new TimeOnly(18, 43, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 2, 0), new TimeOnly(18, 58, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 33, 0), new TimeOnly(17, 42, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 51, 0), new TimeOnly(16, 54, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 58, 0), new TimeOnly(18, 55, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 36, 0), new TimeOnly(16, 58, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 57, 0), new TimeOnly(17, 29, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 45, 0), new TimeOnly(16, 36, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 7, 0), new TimeOnly(18, 1, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 41, 0), new TimeOnly(18, 47, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 15, 0), new TimeOnly(16, 19, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 42, 0), new TimeOnly(16, 42, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 55, 0), new TimeOnly(18, 49, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 6, 0), new TimeOnly(16, 7, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 58, 0), new TimeOnly(18, 23, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 52, 0), new TimeOnly(18, 17, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 14, 0), new TimeOnly(16, 31, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 26, 0), new TimeOnly(17, 52, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 11, 0), new TimeOnly(17, 50, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 49, 0), new TimeOnly(18, 8, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 28, 0), new TimeOnly(18, 25, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 53, 0), new TimeOnly(18, 54, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 29, 0), new TimeOnly(18, 20, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 56, 0), new TimeOnly(18, 53, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 57, 0), new TimeOnly(18, 12, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 56, 0), new TimeOnly(16, 57, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 10, 0), new TimeOnly(18, 40, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 34, 0), new TimeOnly(17, 40, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 54, 0), new TimeOnly(18, 14, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 22, 0), new TimeOnly(17, 3, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 52, 0), new TimeOnly(18, 42, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 52, 0), new TimeOnly(17, 28, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 16, 0), new TimeOnly(17, 42, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 46, 0), new TimeOnly(17, 6, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 22, 0), new TimeOnly(18, 48, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 46, 0), new TimeOnly(17, 35, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 4, 0), new TimeOnly(17, 11, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 23, 0), new TimeOnly(18, 0, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 23, 0), new TimeOnly(18, 19, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 18, 0), new TimeOnly(17, 22, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 21, 0), new TimeOnly(18, 2, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 3, 0), new TimeOnly(18, 36, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 5, 0), new TimeOnly(18, 10, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 58, 0), new TimeOnly(18, 20, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 7, 0), new TimeOnly(16, 29, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 33, 0), new TimeOnly(16, 45, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 57, 0), new TimeOnly(17, 40, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 6, 0), new TimeOnly(16, 37, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 11, 0), new TimeOnly(17, 57, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 50, 0), new TimeOnly(16, 43, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 25, 0), new TimeOnly(18, 12, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 7, 0), new TimeOnly(17, 41, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 42, 0), new TimeOnly(17, 31, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 27, 0), new TimeOnly(17, 10, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 45, 0), new TimeOnly(16, 19, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 24, 0), new TimeOnly(17, 17, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 14, 0), new TimeOnly(16, 43, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 5, 0), new TimeOnly(16, 18, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 55, 0), new TimeOnly(18, 4, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 9, 0), new TimeOnly(18, 16, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 43, 0), new TimeOnly(18, 55, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 10, 0), new TimeOnly(16, 17, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 40, 0), new TimeOnly(16, 0, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 35, 0), new TimeOnly(18, 12, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "CheckIn", "Date" },
                values: new object[] { new TimeOnly(9, 30, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 58, 0), new TimeOnly(17, 4, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 11, 0), new TimeOnly(16, 59, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 24, 0), new TimeOnly(16, 26, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 39, 0), new TimeOnly(17, 39, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 54, 0), new TimeOnly(17, 14, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 11, 0), new TimeOnly(17, 31, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 54, 0), new TimeOnly(17, 48, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 8, 0), new TimeOnly(17, 55, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 26, 0), new TimeOnly(16, 11, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 36, 0), new TimeOnly(18, 3, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 48, 0), new TimeOnly(18, 17, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 23, 0), new TimeOnly(16, 28, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 30, 0), new TimeOnly(18, 40, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 30, 0), new TimeOnly(18, 16, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 15, 0), new TimeOnly(16, 28, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 34, 0), new TimeOnly(16, 35, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 59, 0), new TimeOnly(17, 6, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 25, 0), new TimeOnly(17, 28, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 50, 0), new TimeOnly(16, 43, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 35, 0), new TimeOnly(17, 56, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 27, 0), new TimeOnly(16, 37, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 54, 0), new TimeOnly(16, 37, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 52, 0), new TimeOnly(16, 57, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 40, 0), new TimeOnly(16, 27, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 54, 0), new TimeOnly(17, 37, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 24, 0), new TimeOnly(18, 20, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 21, 0), new TimeOnly(16, 27, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 10, 0), new TimeOnly(18, 14, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 42, 0), new TimeOnly(18, 30, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 35, 0), new TimeOnly(16, 17, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 10, 0), new TimeOnly(18, 7, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 16, 0), new TimeOnly(17, 15, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 56, 0), new TimeOnly(17, 42, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 27, 0), new TimeOnly(17, 40, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 22, 0), new TimeOnly(18, 8, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 45, 0), new TimeOnly(18, 15, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "CheckIn", "Date" },
                values: new object[] { new TimeOnly(9, 2, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 36, 0), new TimeOnly(17, 9, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 1, 0), new TimeOnly(17, 43, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 16, 0), new TimeOnly(18, 18, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 45, 0), new TimeOnly(16, 2, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 57, 0), new TimeOnly(17, 38, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 40, 0), new TimeOnly(17, 38, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 53, 0), new TimeOnly(16, 25, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 35, 0), new TimeOnly(18, 28, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 54, 0), new TimeOnly(18, 9, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 27, 0), new TimeOnly(16, 13, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 55, 0), new TimeOnly(16, 56, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 46, 0), new TimeOnly(18, 38, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 23, 0), new TimeOnly(18, 25, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 30, 0), new TimeOnly(16, 50, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 33, 0), new TimeOnly(16, 59, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 31, 0), new TimeOnly(17, 18, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 23, 0), new TimeOnly(17, 31, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 52, 0), new TimeOnly(17, 45, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 41, 0), new TimeOnly(16, 33, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 32, 0), new TimeOnly(17, 50, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 54, 0), new TimeOnly(16, 42, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 36, 0), new TimeOnly(16, 35, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 20, 0), new TimeOnly(18, 23, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 22, 0), new TimeOnly(18, 15, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 21, 0), new TimeOnly(18, 55, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 21, 0), new TimeOnly(17, 10, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 42, 0), new TimeOnly(18, 25, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 7, 0), new TimeOnly(16, 4, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 41, 0), new TimeOnly(18, 46, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 35, 0), new TimeOnly(18, 34, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(8, 38, 0), new TimeOnly(17, 8, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 3, 0), new TimeOnly(17, 44, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 51, 0), new TimeOnly(16, 41, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 16, 0), new TimeOnly(17, 42, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 43, 0), new TimeOnly(16, 24, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 39, 0), new TimeOnly(17, 26, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 19, 0), new TimeOnly(16, 36, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 54, 0), new TimeOnly(17, 48, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(8, 8, 0), new TimeOnly(18, 0, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 0, 0), new TimeOnly(18, 15, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(8, 55, 0), new TimeOnly(16, 18, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 49, 0), new TimeOnly(18, 57, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 35, 0), new TimeOnly(17, 22, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 24, 0), new TimeOnly(16, 36, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 22, 0), new TimeOnly(18, 17, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 7, 0), new TimeOnly(18, 34, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 6, 0), new TimeOnly(17, 4, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 27, 0), new TimeOnly(16, 27, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 5, 0), new TimeOnly(17, 13, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 43, 0), new TimeOnly(18, 17, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 11, 0), new TimeOnly(18, 58, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 38, 0), new TimeOnly(18, 45, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 16, 0), new TimeOnly(17, 22, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 14, 0), new TimeOnly(18, 39, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 34, 0), new TimeOnly(16, 9, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "CheckOut", "Date" },
                values: new object[] { new TimeOnly(17, 59, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 41, 0), new TimeOnly(16, 24, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 55, 0), new TimeOnly(16, 44, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(8, 12, 0), new TimeOnly(17, 1, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 45, 0), new TimeOnly(18, 54, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 24, 0), new TimeOnly(18, 48, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 47, 0), new TimeOnly(17, 5, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 39, 0), new TimeOnly(18, 35, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 42, 0), new TimeOnly(16, 20, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 40, 0), new TimeOnly(17, 56, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 42, 0), new TimeOnly(17, 59, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 31, 0), new TimeOnly(16, 12, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 41, 0), new TimeOnly(17, 51, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 46, 0), new TimeOnly(16, 52, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 53, 0), new TimeOnly(18, 3, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 31, 0), new TimeOnly(16, 55, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 57, 0), new TimeOnly(16, 9, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 38, 0), new TimeOnly(16, 30, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 44, 0), new TimeOnly(18, 35, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 36, 0), new TimeOnly(16, 3, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 17, 0), new TimeOnly(17, 23, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 47, 0), new TimeOnly(18, 0, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 54, 0), new TimeOnly(16, 12, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 31, 0), new TimeOnly(18, 25, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 3, 0), new TimeOnly(18, 58, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 53, 0), new TimeOnly(16, 43, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 22, 0), new TimeOnly(16, 54, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 35, 0), new TimeOnly(18, 40, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 25, 0), new TimeOnly(16, 30, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 5, 0), new TimeOnly(16, 59, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 21, 0), new TimeOnly(17, 3, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 56, 0), new TimeOnly(16, 56, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 29, 0), new TimeOnly(18, 33, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 15, 0), new TimeOnly(17, 42, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 49, 0), new TimeOnly(17, 37, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 44, 0), new TimeOnly(16, 55, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 5, 0), new TimeOnly(17, 49, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 20, 0), new TimeOnly(16, 45, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 37, 0), new TimeOnly(17, 46, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 57, 0), new TimeOnly(16, 31, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 35, 0), new TimeOnly(18, 53, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 45, 0), new TimeOnly(18, 55, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 49, 0), new TimeOnly(16, 9, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 11, 0), new TimeOnly(17, 32, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 401,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 28, 0), new TimeOnly(18, 58, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 402,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 55, 0), new TimeOnly(17, 1, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 403,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 23, 0), new TimeOnly(18, 7, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 404,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 48, 0), new TimeOnly(18, 16, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 405,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 29, 0), new TimeOnly(16, 47, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 406,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 34, 0), new TimeOnly(17, 45, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 407,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 9, 0), new TimeOnly(18, 42, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 408,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 23, 0), new TimeOnly(16, 48, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 409,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 40, 0), new TimeOnly(18, 2, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 410,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 15, 0), new TimeOnly(18, 1, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 411,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 42, 0), new TimeOnly(17, 14, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 412,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 13, 0), new TimeOnly(18, 9, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 413,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 0, 0), new TimeOnly(18, 56, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 414,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 38, 0), new TimeOnly(18, 26, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 415,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 52, 0), new TimeOnly(18, 6, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 416,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 0, 0), new TimeOnly(18, 37, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 417,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 31, 0), new TimeOnly(18, 36, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 418,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 51, 0), new TimeOnly(18, 45, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 419,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 49, 0), new TimeOnly(18, 38, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 420,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 52, 0), new TimeOnly(16, 0, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 421,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 44, 0), new TimeOnly(18, 30, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 422,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 39, 0), new TimeOnly(16, 18, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 423,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 46, 0), new TimeOnly(18, 47, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 424,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 26, 0), new TimeOnly(16, 23, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 425,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 29, 0), new TimeOnly(16, 50, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 426,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 23, 0), new TimeOnly(16, 13, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 427,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 29, 0), new TimeOnly(16, 39, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 428,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 41, 0), new TimeOnly(16, 45, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 429,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 26, 0), new TimeOnly(17, 42, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 430,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 19, 0), new TimeOnly(17, 33, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 431,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 22, 0), new TimeOnly(17, 58, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 432,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 12, 0), new TimeOnly(17, 48, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 433,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 11, 0), new TimeOnly(16, 16, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 434,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 25, 0), new TimeOnly(18, 46, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 435,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 16, 0), new TimeOnly(16, 43, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 436,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 40, 0), new TimeOnly(17, 44, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 437,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 23, 0), new TimeOnly(16, 5, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 438,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 8, 0), new TimeOnly(18, 18, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 439,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 3, 0), new TimeOnly(17, 47, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 440,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 40, 0), new TimeOnly(17, 24, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 441,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 55, 0), new TimeOnly(18, 8, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 442,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 46, 0), new TimeOnly(17, 7, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 443,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 46, 0), new TimeOnly(16, 11, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 444,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 35, 0), new TimeOnly(18, 18, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 445,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 22, 0), new TimeOnly(17, 33, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 446,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 34, 0), new TimeOnly(18, 26, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 447,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 54, 0), new TimeOnly(16, 4, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 448,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 37, 0), new TimeOnly(16, 44, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 449,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 57, 0), new TimeOnly(18, 53, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 450,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 34, 0), new TimeOnly(18, 17, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 451,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 24, 0), new TimeOnly(17, 51, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 452,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 21, 0), new TimeOnly(17, 9, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 453,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 7, 0), new TimeOnly(17, 13, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 454,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 17, 0), new TimeOnly(17, 10, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 455,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 7, 0), new TimeOnly(17, 33, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 456,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 35, 0), new TimeOnly(16, 42, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 457,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 17, 0), new TimeOnly(17, 14, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 458,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 41, 0), new TimeOnly(17, 5, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 459,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 11, 0), new TimeOnly(18, 27, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 460,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 6, 0), new TimeOnly(18, 1, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 461,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 1, 0), new TimeOnly(18, 44, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 462,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 49, 0), new TimeOnly(17, 34, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 463,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 35, 0), new TimeOnly(17, 45, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 464,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 40, 0), new TimeOnly(17, 28, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 465,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 36, 0), new TimeOnly(16, 30, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 466,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 18, 0), new TimeOnly(16, 7, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 467,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 35, 0), new TimeOnly(18, 40, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 468,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 57, 0), new TimeOnly(17, 28, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 469,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(8, 55, 0), new TimeOnly(18, 42, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 470,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 14, 0), new TimeOnly(18, 50, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 471,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 2, 0), new TimeOnly(17, 19, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 472,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 53, 0), new TimeOnly(18, 22, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 473,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 15, 0), new TimeOnly(16, 27, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 474,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 7, 0), new TimeOnly(18, 47, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 475,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 5, 0), new TimeOnly(16, 54, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 476,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 21, 0), new TimeOnly(16, 29, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 477,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 34, 0), new TimeOnly(17, 18, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 478,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 52, 0), new TimeOnly(16, 51, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 479,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 46, 0), new TimeOnly(16, 48, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 480,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 37, 0), new TimeOnly(17, 8, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 481,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 52, 0), new TimeOnly(16, 59, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 482,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 37, 0), new TimeOnly(18, 21, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 483,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 23, 0), new TimeOnly(18, 25, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 484,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 28, 0), new TimeOnly(18, 25, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 485,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(8, 20, 0), new TimeOnly(17, 16, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 486,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 35, 0), new TimeOnly(17, 12, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 487,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 45, 0), new TimeOnly(18, 13, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 488,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 25, 0), new TimeOnly(18, 25, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 489,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(8, 44, 0), new TimeOnly(17, 2, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 490,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 31, 0), new TimeOnly(17, 44, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 491,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 38, 0), new TimeOnly(17, 23, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 492,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 9, 0), new TimeOnly(18, 9, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 493,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 27, 0), new TimeOnly(17, 11, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 494,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 57, 0), new TimeOnly(18, 43, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 495,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 56, 0), new TimeOnly(18, 18, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 496,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 35, 0), new TimeOnly(16, 24, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 497,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 6, 0), new TimeOnly(16, 56, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 498,
                columns: new[] { "CheckIn", "Date" },
                values: new object[] { new TimeOnly(9, 31, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 499,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 2, 0), new TimeOnly(17, 45, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 500,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 10, 0), new TimeOnly(16, 50, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 501,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 4, 0), new TimeOnly(18, 53, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 502,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 21, 0), new TimeOnly(16, 37, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 503,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 34, 0), new TimeOnly(18, 46, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 504,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 8, 0), new TimeOnly(16, 16, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 505,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 26, 0), new TimeOnly(17, 41, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 506,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 14, 0), new TimeOnly(16, 33, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 507,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 58, 0), new TimeOnly(18, 5, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 508,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 57, 0), new TimeOnly(16, 17, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 509,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 39, 0), new TimeOnly(17, 59, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 510,
                columns: new[] { "CheckOut", "Date" },
                values: new object[] { new TimeOnly(18, 19, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 511,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 22, 0), new TimeOnly(17, 32, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 512,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 54, 0), new TimeOnly(18, 2, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 513,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 55, 0), new TimeOnly(18, 20, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 514,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 42, 0), new TimeOnly(16, 3, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 515,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 20, 0), new TimeOnly(16, 19, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 516,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 47, 0), new TimeOnly(16, 4, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 517,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 5, 0), new TimeOnly(16, 58, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 518,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 0, 0), new TimeOnly(16, 13, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 519,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 50, 0), new TimeOnly(16, 36, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 520,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 32, 0), new TimeOnly(16, 8, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 521,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 35, 0), new TimeOnly(18, 17, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 522,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 49, 0), new TimeOnly(18, 5, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 523,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 27, 0), new TimeOnly(16, 45, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 524,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 6, 0), new TimeOnly(16, 46, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 525,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 53, 0), new TimeOnly(16, 36, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 526,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 27, 0), new TimeOnly(16, 0, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 527,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 27, 0), new TimeOnly(16, 35, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 528,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 51, 0), new TimeOnly(17, 1, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 529,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 12, 0), new TimeOnly(18, 35, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 530,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 5, 0), new TimeOnly(17, 40, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 531,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 9, 0), new TimeOnly(16, 3, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 532,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 25, 0), new TimeOnly(16, 44, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 533,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 27, 0), new TimeOnly(17, 6, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 534,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 34, 0), new TimeOnly(18, 50, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 535,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 50, 0), new TimeOnly(18, 34, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 536,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 35, 0), new TimeOnly(18, 58, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 537,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 11, 0), new TimeOnly(16, 50, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 538,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 15, 0), new TimeOnly(16, 11, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 539,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 6, 0), new TimeOnly(17, 52, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 540,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 35, 0), new TimeOnly(16, 18, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 541,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 3, 0), new TimeOnly(18, 45, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 542,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 56, 0), new TimeOnly(17, 30, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 543,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 45, 0), new TimeOnly(18, 30, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 544,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 15, 0), new TimeOnly(17, 24, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 545,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 0, 0), new TimeOnly(18, 22, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 546,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 49, 0), new TimeOnly(16, 54, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 547,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 40, 0), new TimeOnly(16, 20, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 548,
                columns: new[] { "CheckIn", "Date" },
                values: new object[] { new TimeOnly(9, 38, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 549,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 47, 0), new TimeOnly(17, 57, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 550,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 4, 0), new TimeOnly(17, 7, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 551,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 20, 0), new TimeOnly(17, 28, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 552,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 1, 0), new TimeOnly(16, 55, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 553,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 33, 0), new TimeOnly(17, 47, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 554,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 0, 0), new TimeOnly(17, 22, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 555,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 38, 0), new TimeOnly(16, 35, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 556,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 1, 0), new TimeOnly(18, 43, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 557,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 20, 0), new TimeOnly(17, 13, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 558,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 47, 0), new TimeOnly(18, 55, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 559,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 39, 0), new TimeOnly(17, 5, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 560,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 26, 0), new TimeOnly(16, 18, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 14, 0), new TimeOnly(17, 55, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 562,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 8, 0), new TimeOnly(16, 59, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 563,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 40, 0), new TimeOnly(16, 19, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 564,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 30, 0), new TimeOnly(17, 57, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 565,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 28, 0), new TimeOnly(17, 13, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 566,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 57, 0), new TimeOnly(18, 28, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 567,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 44, 0), new TimeOnly(17, 53, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 568,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 17, 0), new TimeOnly(16, 11, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 569,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 41, 0), new TimeOnly(16, 14, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 570,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 11, 0), new TimeOnly(18, 31, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 571,
                columns: new[] { "CheckIn", "Date" },
                values: new object[] { new TimeOnly(7, 14, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 572,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 4, 0), new TimeOnly(17, 54, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 573,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 20, 0), new TimeOnly(16, 55, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 574,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 19, 0), new TimeOnly(18, 30, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 575,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 54, 0), new TimeOnly(16, 7, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 576,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 32, 0), new TimeOnly(16, 30, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 577,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 3, 0), new TimeOnly(18, 22, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 578,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 29, 0), new TimeOnly(17, 44, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 579,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 17, 0), new TimeOnly(16, 32, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 580,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 59, 0), new TimeOnly(18, 7, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 581,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 32, 0), new TimeOnly(18, 4, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 582,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 34, 0), new TimeOnly(16, 57, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 583,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 16, 0), new TimeOnly(18, 33, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 584,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 27, 0), new TimeOnly(18, 44, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 585,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 35, 0), new TimeOnly(16, 22, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 586,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 6, 0), new TimeOnly(16, 16, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 587,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 25, 0), new TimeOnly(17, 25, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 588,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 28, 0), new TimeOnly(16, 24, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 589,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 36, 0), new TimeOnly(16, 10, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 590,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 31, 0), new TimeOnly(16, 29, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 591,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 41, 0), new TimeOnly(18, 33, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 592,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 25, 0), new TimeOnly(16, 3, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 593,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 35, 0), new TimeOnly(17, 28, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 594,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 34, 0), new TimeOnly(16, 20, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 595,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 30, 0), new TimeOnly(17, 20, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 596,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 40, 0), new TimeOnly(17, 37, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 597,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 30, 0), new TimeOnly(18, 17, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 598,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 55, 0), new TimeOnly(18, 50, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 599,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 38, 0), new TimeOnly(16, 30, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 600,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 1, 0), new TimeOnly(18, 5, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 601,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 33, 0), new TimeOnly(17, 54, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 602,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 31, 0), new TimeOnly(17, 37, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 603,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 30, 0), new TimeOnly(18, 30, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 604,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 12, 0), new TimeOnly(16, 10, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 605,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 29, 0), new TimeOnly(16, 7, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 606,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 0, 0), new TimeOnly(18, 3, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 607,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 11, 0), new TimeOnly(18, 57, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 608,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 15, 0), new TimeOnly(18, 34, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 609,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 16, 0), new TimeOnly(17, 13, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 610,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 34, 0), new TimeOnly(17, 31, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 611,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 31, 0), new TimeOnly(16, 30, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 612,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 50, 0), new TimeOnly(17, 37, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 613,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 35, 0), new TimeOnly(17, 52, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 614,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 55, 0), new TimeOnly(16, 59, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 615,
                columns: new[] { "CheckIn", "Date" },
                values: new object[] { new TimeOnly(9, 54, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 616,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 59, 0), new TimeOnly(17, 38, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 617,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 38, 0), new TimeOnly(17, 30, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 618,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 1, 0), new TimeOnly(18, 3, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 619,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 47, 0), new TimeOnly(17, 4, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 620,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 47, 0), new TimeOnly(16, 57, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 621,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 13, 0), new TimeOnly(16, 1, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 622,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 19, 0), new TimeOnly(18, 58, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 623,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 21, 0), new TimeOnly(16, 4, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 624,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 6, 0), new TimeOnly(18, 30, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 625,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 28, 0), new TimeOnly(17, 43, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 626,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(8, 9, 0), new TimeOnly(16, 16, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 627,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 46, 0), new TimeOnly(16, 36, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 628,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(8, 48, 0), new TimeOnly(18, 49, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 629,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 25, 0), new TimeOnly(17, 51, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 630,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 24, 0), new TimeOnly(18, 18, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 631,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 20, 0), new TimeOnly(16, 45, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 632,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 21, 0), new TimeOnly(18, 27, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 633,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 0, 0), new TimeOnly(18, 30, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 634,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 45, 0), new TimeOnly(17, 42, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 635,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 45, 0), new TimeOnly(18, 47, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 636,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 18, 0), new TimeOnly(18, 1, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 637,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 45, 0), new TimeOnly(17, 56, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 638,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 14, 0), new TimeOnly(18, 52, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 639,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 44, 0), new TimeOnly(17, 48, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 640,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 2, 0), new TimeOnly(17, 31, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 641,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 14, 0), new TimeOnly(18, 9, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 642,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 29, 0), new TimeOnly(18, 34, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 643,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 4, 0), new TimeOnly(18, 44, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 644,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 31, 0), new TimeOnly(16, 22, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 645,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 18, 0), new TimeOnly(16, 21, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 646,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 26, 0), new TimeOnly(16, 59, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 647,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 14, 0), new TimeOnly(18, 34, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 648,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 4, 0), new TimeOnly(17, 6, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 649,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 56, 0), new TimeOnly(16, 24, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 650,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(8, 32, 0), new TimeOnly(17, 48, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 651,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 44, 0), new TimeOnly(16, 47, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 652,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 24, 0), new TimeOnly(16, 3, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 653,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 6, 0), new TimeOnly(16, 56, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 654,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 18, 0), new TimeOnly(16, 43, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 655,
                columns: new[] { "CheckIn", "Date" },
                values: new object[] { new TimeOnly(7, 19, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 656,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 29, 0), new TimeOnly(16, 59, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 657,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 14, 0), new TimeOnly(17, 17, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 658,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 58, 0), new TimeOnly(16, 11, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 659,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 32, 0), new TimeOnly(17, 47, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 660,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 58, 0), new TimeOnly(17, 44, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 661,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 31, 0), new TimeOnly(18, 50, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 662,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 55, 0), new TimeOnly(16, 59, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 663,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 28, 0), new TimeOnly(18, 12, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 664,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 53, 0), new TimeOnly(16, 29, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 665,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 54, 0), new TimeOnly(18, 34, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 666,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 5, 0), new TimeOnly(17, 17, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 667,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 58, 0), new TimeOnly(17, 58, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 668,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 58, 0), new TimeOnly(17, 40, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 669,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 8, 0), new TimeOnly(16, 32, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 670,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 11, 0), new TimeOnly(16, 26, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 671,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 6, 0), new TimeOnly(17, 30, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 672,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 41, 0), new TimeOnly(17, 43, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 673,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 58, 0), new TimeOnly(18, 46, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 674,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 36, 0), new TimeOnly(18, 37, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 675,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 6, 0), new TimeOnly(17, 59, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 676,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 19, 0), new TimeOnly(18, 29, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 677,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 41, 0), new TimeOnly(16, 29, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 678,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 18, 0), new TimeOnly(17, 15, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 679,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 57, 0), new TimeOnly(17, 2, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 680,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 0, 0), new TimeOnly(17, 0, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 681,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 55, 0), new TimeOnly(16, 19, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 682,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 4, 0), new TimeOnly(18, 41, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 683,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 17, 0), new TimeOnly(17, 1, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 684,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 14, 0), new TimeOnly(16, 36, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 685,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 40, 0), new TimeOnly(17, 11, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 686,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 10, 0), new TimeOnly(18, 46, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 687,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 29, 0), new TimeOnly(18, 35, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 688,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 33, 0), new TimeOnly(18, 13, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 689,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 50, 0), new TimeOnly(16, 41, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 690,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 46, 0), new TimeOnly(17, 5, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 691,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 18, 0), new TimeOnly(18, 39, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 692,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 53, 0), new TimeOnly(17, 30, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 693,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 31, 0), new TimeOnly(16, 21, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 694,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 56, 0), new TimeOnly(16, 4, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 695,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 34, 0), new TimeOnly(16, 44, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 696,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 15, 0), new TimeOnly(17, 41, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 697,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 11, 0), new TimeOnly(16, 45, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 698,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 19, 0), new TimeOnly(17, 43, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 699,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 5, 0), new TimeOnly(18, 20, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 700,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 5, 0), new TimeOnly(18, 38, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 701,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 43, 0), new TimeOnly(17, 11, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 702,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 50, 0), new TimeOnly(17, 39, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 703,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 22, 0), new TimeOnly(17, 37, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 704,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 1, 0), new TimeOnly(16, 26, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 705,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 26, 0), new TimeOnly(18, 52, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 706,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 14, 0), new TimeOnly(18, 17, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 707,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 20, 0), new TimeOnly(16, 33, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 708,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 59, 0), new TimeOnly(17, 10, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 709,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 54, 0), new TimeOnly(17, 8, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 710,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 6, 0), new TimeOnly(17, 7, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 711,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 7, 0), new TimeOnly(16, 54, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 712,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 54, 0), new TimeOnly(18, 44, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 713,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 30, 0), new TimeOnly(17, 43, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 714,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 46, 0), new TimeOnly(16, 3, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 715,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 15, 0), new TimeOnly(17, 46, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 716,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 3, 0), new TimeOnly(17, 10, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 717,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 16, 0), new TimeOnly(17, 0, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 718,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 37, 0), new TimeOnly(18, 47, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 719,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 33, 0), new TimeOnly(17, 40, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 720,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 5, 0), new TimeOnly(18, 42, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 721,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 26, 0), new TimeOnly(18, 16, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 722,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 24, 0), new TimeOnly(16, 39, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 723,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 19, 0), new TimeOnly(18, 0, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 724,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 8, 0), new TimeOnly(18, 34, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 725,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 2, 0), new TimeOnly(17, 42, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 726,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 13, 0), new TimeOnly(16, 56, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 727,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 10, 0), new TimeOnly(18, 2, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 728,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 46, 0), new TimeOnly(16, 20, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 729,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 7, 0), new TimeOnly(16, 29, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 730,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 21, 0), new TimeOnly(18, 58, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 731,
                columns: new[] { "CheckOut", "Date" },
                values: new object[] { new TimeOnly(16, 49, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 732,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 50, 0), new TimeOnly(18, 41, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 733,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 7, 0), new TimeOnly(16, 36, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 734,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 23, 0), new TimeOnly(18, 51, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 735,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 23, 0), new TimeOnly(16, 42, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 736,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 43, 0), new TimeOnly(16, 10, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 737,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 47, 0), new TimeOnly(18, 12, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 738,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 10, 0), new TimeOnly(18, 9, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 739,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 53, 0), new TimeOnly(17, 43, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 740,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 27, 0), new TimeOnly(16, 30, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 741,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 27, 0), new TimeOnly(18, 55, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 742,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 30, 0), new TimeOnly(17, 14, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 743,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 35, 0), new TimeOnly(16, 36, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 744,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 31, 0), new TimeOnly(18, 47, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 745,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 10, 0), new TimeOnly(16, 37, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 746,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 59, 0), new TimeOnly(18, 51, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 747,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 51, 0), new TimeOnly(17, 23, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 748,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 25, 0), new TimeOnly(17, 56, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 749,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 2, 0), new TimeOnly(17, 53, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 750,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 41, 0), new TimeOnly(18, 54, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 751,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 11, 0), new TimeOnly(18, 12, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 752,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 2, 0), new TimeOnly(18, 28, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 753,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 51, 0), new TimeOnly(17, 16, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 754,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 54, 0), new TimeOnly(17, 5, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 755,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 56, 0), new TimeOnly(17, 48, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 756,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 33, 0), new TimeOnly(16, 23, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 757,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 18, 0), new TimeOnly(17, 54, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 758,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 21, 0), new TimeOnly(16, 20, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 759,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 17, 0), new TimeOnly(17, 48, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 760,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 13, 0), new TimeOnly(18, 58, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 761,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 23, 0), new TimeOnly(16, 58, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 762,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 21, 0), new TimeOnly(17, 47, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 763,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 37, 0), new TimeOnly(16, 50, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 764,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 35, 0), new TimeOnly(16, 39, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 765,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 7, 0), new TimeOnly(17, 4, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 766,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 22, 0), new TimeOnly(18, 37, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 767,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 39, 0), new TimeOnly(17, 9, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 768,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 44, 0), new TimeOnly(18, 21, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 769,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 22, 0), new TimeOnly(17, 40, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 770,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 33, 0), new TimeOnly(17, 51, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 771,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 9, 0), new TimeOnly(17, 1, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 772,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 39, 0), new TimeOnly(16, 23, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 773,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 54, 0), new TimeOnly(16, 21, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 774,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 8, 0), new TimeOnly(17, 13, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 775,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 13, 0), new TimeOnly(17, 4, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 776,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 42, 0), new TimeOnly(18, 25, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 777,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 48, 0), new TimeOnly(17, 26, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 778,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 40, 0), new TimeOnly(17, 4, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 779,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 52, 0), new TimeOnly(16, 56, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 780,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 21, 0), new TimeOnly(18, 20, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 781,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 42, 0), new TimeOnly(17, 13, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 782,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 49, 0), new TimeOnly(18, 22, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 783,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 6, 0), new TimeOnly(16, 9, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 784,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 18, 0), new TimeOnly(17, 24, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 785,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 25, 0), new TimeOnly(17, 4, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 786,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 1, 0), new TimeOnly(16, 29, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 787,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 30, 0), new TimeOnly(18, 7, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 788,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 26, 0), new TimeOnly(17, 57, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 789,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 42, 0), new TimeOnly(16, 42, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 790,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 14, 0), new TimeOnly(17, 42, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 32, 0), new TimeOnly(17, 57, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 792,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 13, 0), new TimeOnly(17, 53, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 793,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 17, 0), new TimeOnly(16, 51, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 794,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 49, 0), new TimeOnly(18, 12, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 795,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 5, 0), new TimeOnly(18, 38, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 796,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 40, 0), new TimeOnly(16, 40, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 797,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 0, 0), new TimeOnly(18, 7, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 798,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 13, 0), new TimeOnly(16, 41, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 799,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 30, 0), new TimeOnly(16, 55, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 800,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 8, 0), new TimeOnly(18, 9, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 801,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 59, 0), new TimeOnly(17, 32, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 802,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 5, 0), new TimeOnly(17, 57, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 803,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 37, 0), new TimeOnly(18, 21, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 804,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 44, 0), new TimeOnly(18, 23, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 805,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 4, 0), new TimeOnly(18, 53, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 806,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 13, 0), new TimeOnly(17, 37, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 807,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 4, 0), new TimeOnly(18, 55, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 808,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 52, 0), new TimeOnly(18, 2, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 809,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(8, 14, 0), new TimeOnly(18, 46, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 810,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(7, 29, 0), new TimeOnly(17, 2, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 811,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 51, 0), new TimeOnly(17, 44, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 812,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 30, 0), new TimeOnly(17, 47, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 813,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 19, 0), new TimeOnly(16, 33, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 814,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 22, 0), new TimeOnly(17, 23, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 815,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(8, 0, 0), new TimeOnly(17, 26, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 816,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 8, 0), new TimeOnly(17, 34, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 817,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 41, 0), new TimeOnly(18, 47, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 818,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 50, 0), new TimeOnly(18, 26, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 819,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 17, 0), new TimeOnly(17, 50, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 820,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 3, 0), new TimeOnly(16, 7, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 821,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 32, 0), new TimeOnly(18, 52, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 822,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 6, 0), new TimeOnly(16, 58, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 823,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 9, 0), new TimeOnly(16, 48, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 824,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 59, 0), new TimeOnly(16, 18, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 825,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 42, 0), new TimeOnly(17, 27, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 826,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 1, 0), new TimeOnly(17, 45, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 827,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 34, 0), new TimeOnly(17, 57, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 828,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 35, 0), new TimeOnly(18, 44, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 829,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 40, 0), new TimeOnly(18, 29, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 830,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 23, 0), new TimeOnly(16, 46, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 831,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 57, 0), new TimeOnly(17, 16, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 832,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 36, 0), new TimeOnly(16, 32, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 833,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 7, 0), new TimeOnly(16, 57, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 834,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 45, 0), new TimeOnly(17, 53, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 835,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 0, 0), new TimeOnly(16, 28, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 836,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 45, 0), new TimeOnly(17, 17, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 837,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 53, 0), new TimeOnly(17, 59, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 838,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 13, 0), new TimeOnly(17, 29, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 839,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 35, 0), new TimeOnly(16, 40, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 840,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 21, 0), new TimeOnly(16, 58, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 841,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 24, 0), new TimeOnly(17, 11, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 842,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 4, 0), new TimeOnly(18, 45, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 843,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 7, 0), new TimeOnly(17, 52, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 844,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 49, 0), new TimeOnly(16, 41, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 845,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 4, 0), new TimeOnly(16, 42, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 846,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 26, 0), new TimeOnly(16, 32, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 847,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 6, 0), new TimeOnly(16, 35, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 848,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 21, 0), new TimeOnly(16, 49, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 849,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 0, 0), new TimeOnly(17, 39, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 850,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 4, 0), new TimeOnly(17, 23, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 851,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 4, 0), new TimeOnly(17, 50, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 852,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 7, 0), new TimeOnly(16, 54, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 853,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 5, 0), new TimeOnly(18, 37, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 854,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 38, 0), new TimeOnly(16, 48, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 855,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 40, 0), new TimeOnly(17, 34, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 856,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 44, 0), new TimeOnly(16, 38, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 857,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 27, 0), new TimeOnly(18, 52, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 858,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 23, 0), new TimeOnly(16, 39, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 859,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 35, 0), new TimeOnly(17, 4, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 860,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 43, 0), new TimeOnly(18, 32, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 861,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 7, 0), new TimeOnly(17, 33, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 862,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 25, 0), new TimeOnly(16, 5, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 863,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 16, 0), new TimeOnly(18, 52, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 864,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 16, 0), new TimeOnly(17, 54, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 865,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 49, 0), new TimeOnly(17, 27, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 866,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 3, 0), new TimeOnly(18, 13, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 867,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 3, 0), new TimeOnly(18, 12, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 868,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 46, 0), new TimeOnly(17, 43, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 869,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 20, 0), new TimeOnly(17, 40, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 870,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 58, 0), new TimeOnly(18, 54, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 871,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 26, 0), new TimeOnly(16, 1, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 872,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 26, 0), new TimeOnly(18, 6, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 873,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 19, 0), new TimeOnly(17, 51, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 874,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 42, 0), new TimeOnly(17, 3, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 875,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 42, 0), new TimeOnly(17, 0, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 876,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 31, 0), new TimeOnly(16, 35, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 877,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 26, 0), new TimeOnly(17, 20, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 878,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 0, 0), new TimeOnly(17, 42, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 879,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 36, 0), new TimeOnly(18, 46, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 880,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 54, 0), new TimeOnly(16, 50, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 881,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 45, 0), new TimeOnly(17, 6, 0), new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 882,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 20, 0), new TimeOnly(17, 44, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 883,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 16, 0), new TimeOnly(16, 8, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 884,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 0, 0), new TimeOnly(18, 20, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 885,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 56, 0), new TimeOnly(17, 20, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 886,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 25, 0), new TimeOnly(17, 41, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 887,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 7, 0), new TimeOnly(18, 3, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 888,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 55, 0), new TimeOnly(16, 55, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 889,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 46, 0), new TimeOnly(18, 44, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 890,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 23, 0), new TimeOnly(16, 6, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 891,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 12, 0), new TimeOnly(18, 24, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 892,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 47, 0), new TimeOnly(17, 36, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 893,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 2, 0), new TimeOnly(16, 45, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 894,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 9, 0), new TimeOnly(16, 39, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 895,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 45, 0), new TimeOnly(16, 23, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 896,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 48, 0), new TimeOnly(18, 51, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 897,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 23, 0), new TimeOnly(16, 27, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 898,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 14, 0), new TimeOnly(16, 38, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 899,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 51, 0), new TimeOnly(16, 15, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 900,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 35, 0), new TimeOnly(18, 36, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 901,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 39, 0), new TimeOnly(17, 17, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 902,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 15, 0), new TimeOnly(18, 10, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 903,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 12, 0), new TimeOnly(18, 35, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 904,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 3, 0), new TimeOnly(17, 49, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 905,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 37, 0), new TimeOnly(17, 3, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 906,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 59, 0), new TimeOnly(16, 20, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 907,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 26, 0), new TimeOnly(18, 46, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 908,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 16, 0), new TimeOnly(18, 58, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 909,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 9, 0), new TimeOnly(18, 48, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 910,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 13, 0), new TimeOnly(18, 16, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 911,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 31, 0), new TimeOnly(17, 58, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 912,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 45, 0), new TimeOnly(18, 29, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 913,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 5, 0), new TimeOnly(17, 48, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 914,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 57, 0), new TimeOnly(18, 58, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 915,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 26, 0), new TimeOnly(17, 31, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 916,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 23, 0), new TimeOnly(17, 43, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 917,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 50, 0), new TimeOnly(16, 45, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 918,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 47, 0), new TimeOnly(16, 1, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 919,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 10, 0), new TimeOnly(16, 43, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 920,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 43, 0), new TimeOnly(18, 58, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 921,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 26, 0), new TimeOnly(17, 23, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 922,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 8, 0), new TimeOnly(17, 38, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 923,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 2, 0), new TimeOnly(17, 0, 0), new DateTime(2025, 3, 11, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 924,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 43, 0), new TimeOnly(16, 17, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 925,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 11, 0), new TimeOnly(17, 29, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 926,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 41, 0), new TimeOnly(17, 42, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 927,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 50, 0), new TimeOnly(17, 40, 0), new DateTime(2025, 3, 18, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 928,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 37, 0), new TimeOnly(17, 54, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 929,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 13, 0), new TimeOnly(18, 41, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 930,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 6, 0), new TimeOnly(17, 7, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 931,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 50, 0), new TimeOnly(17, 30, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 932,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 32, 0), new TimeOnly(16, 46, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 933,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 41, 0), new TimeOnly(17, 39, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 934,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 13, 0), new TimeOnly(18, 21, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 935,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 15, 0), new TimeOnly(17, 17, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 936,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 7, 0), new TimeOnly(18, 17, 0), new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 937,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 57, 0), new TimeOnly(17, 15, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 938,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 47, 0), new TimeOnly(17, 25, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 939,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 1, 0), new TimeOnly(17, 11, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 940,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 46, 0), new TimeOnly(17, 0, 0), new DateTime(2025, 3, 7, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 941,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 1, 0), new TimeOnly(16, 0, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 942,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 9, 0), new TimeOnly(17, 17, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 943,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 11, 0), new TimeOnly(17, 6, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 944,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 23, 0), new TimeOnly(18, 58, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 945,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 55, 0), new TimeOnly(18, 9, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 946,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 55, 0), new TimeOnly(17, 5, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 947,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 2, 0), new TimeOnly(18, 38, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 948,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 0, 0), new TimeOnly(18, 46, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 949,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 42, 0), new TimeOnly(16, 47, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 950,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 52, 0), new TimeOnly(18, 15, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 951,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 17, 0), new TimeOnly(17, 40, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 952,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 30, 0), new TimeOnly(16, 31, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 953,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 49, 0), new TimeOnly(16, 16, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 954,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 28, 0), new TimeOnly(17, 8, 0), new DateTime(2025, 3, 6, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 955,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 51, 0), new TimeOnly(16, 33, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 956,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 26, 0), new TimeOnly(17, 22, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 957,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 40, 0), new TimeOnly(17, 43, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 958,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 13, 0), new TimeOnly(16, 37, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 959,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(9, 22, 0), new TimeOnly(16, 11, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 960,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 20, 0), new TimeOnly(17, 27, 0), new DateTime(2025, 3, 20, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 961,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 46, 0), new TimeOnly(16, 51, 0), new DateTime(2025, 3, 14, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 962,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 23, 0), new TimeOnly(17, 57, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 963,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 42, 0), new TimeOnly(16, 23, 0), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 964,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 13, 0), new TimeOnly(18, 48, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 965,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 52, 0), new TimeOnly(18, 34, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 966,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 14, 0), new TimeOnly(16, 54, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 967,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 56, 0), new TimeOnly(17, 42, 0), new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 968,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 0, 0), new TimeOnly(17, 9, 0), new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 969,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 56, 0), new TimeOnly(17, 12, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 970,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 35, 0), new TimeOnly(16, 3, 0), new DateTime(2025, 3, 17, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 971,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 8, 0), new TimeOnly(16, 36, 0), new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 972,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 43, 0), new TimeOnly(17, 35, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 973,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 46, 0), new TimeOnly(17, 22, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 974,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 0, 0), new TimeOnly(18, 6, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 975,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 22, 0), new TimeOnly(18, 0, 0), new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 976,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 55, 0), new TimeOnly(16, 45, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 977,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 34, 0), new TimeOnly(16, 0, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 978,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 43, 0), new TimeOnly(18, 2, 0), new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 979,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 2, 0), new TimeOnly(17, 51, 0), new DateTime(2025, 3, 9, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 980,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 45, 0), new TimeOnly(17, 6, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 981,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 30, 0), new TimeOnly(16, 36, 0), new DateTime(2025, 3, 16, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 982,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 48, 0), new TimeOnly(16, 36, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 983,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 32, 0), new TimeOnly(16, 4, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 984,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 32, 0), new TimeOnly(18, 52, 0), new DateTime(2025, 3, 15, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 985,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 29, 0), new TimeOnly(16, 48, 0), new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 986,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 27, 0), new TimeOnly(17, 47, 0), new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 987,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 32, 0), new TimeOnly(17, 10, 0), new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 988,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 26, 0), new TimeOnly(17, 36, 0), new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 989,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(8, 23, 0), new TimeOnly(16, 17, 0), new DateTime(2025, 3, 4, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 990,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 49, 0), new TimeOnly(16, 24, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 991,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 32, 0), new TimeOnly(18, 58, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 992,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 48, 0), new TimeOnly(18, 1, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 993,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 9, 0), new TimeOnly(18, 28, 0), new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 994,
                columns: new[] { "CheckIn", "CheckOut" },
                values: new object[] { new TimeOnly(8, 47, 0), new TimeOnly(16, 30, 0) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 995,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(7, 37, 0), new TimeOnly(16, 44, 0), new DateTime(2025, 3, 3, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 996,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 51, 0), new TimeOnly(16, 51, 0), new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 997,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 41, 0), new TimeOnly(17, 36, 0), new DateTime(2025, 2, 28, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 998,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 16, 0), new TimeOnly(17, 44, 0), new DateTime(2025, 3, 2, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 999,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 56, 0), new TimeOnly(16, 9, 0), new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Attendances",
                keyColumn: "Id",
                keyValue: 1000,
                columns: new[] { "CheckIn", "CheckOut", "Date" },
                values: new object[] { new TimeOnly(9, 22, 0), new TimeOnly(17, 54, 0), new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Local) });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ImgUrl", "Name", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/956.jpg", "Rachel Ernser", 31969m, 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/591.jpg", "Sheila Powlowski", 6, 64205m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1097.jpg", "Sammie Jacobson", 5, 33039m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/458.jpg", "Vincenza Shanahan", 3, 51526m, 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/284.jpg", "Rosemarie Rohan", 7, 49282m, 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/943.jpg", "Reed McDermott", 1, 45344m, 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/46.jpg", "Hettie Heathcote", 2, 74565m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/795.jpg", "Freddy O'Conner", 7, 38731m, 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/69.jpg", "Era Langworth", 1, 77897m, 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/612.jpg", "Betsy Blanda", 8, 64576m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/727.jpg", "Ronny Schmidt", 3, 56639m, 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ImgUrl", "Name", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1147.jpg", "Shea Sipes", 46337m, 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ImgUrl", "Name", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/250.jpg", "Corine Hahn", 99837m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/660.jpg", "Oda Paucek", 3, 85365m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/431.jpg", "Reyes Gottlieb", 2, 76789m, 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1114.jpg", "Lavonne Gerlach", 3, 82597m, 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/542.jpg", "Rod Bergstrom", 8, 63840m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1217.jpg", "Deontae Pouros", 4, 66813m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/780.jpg", "Freeda Gottlieb", 2, 31779m, 3 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "ImgUrl", "Name", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/619.jpg", "Thaddeus Auer", 38023m, 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/991.jpg", "Ross Yundt", 8, 46663m, 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1134.jpg", "Gerda Abbott", 6, 65979m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/170.jpg", "Angus Nienow", 8, 96987m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/460.jpg", "Jammie Ledner", 5, 75612m, 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/946.jpg", "Karolann Aufderhar", 3, 70235m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/100.jpg", "Holden Weimann", 6, 33360m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1071.jpg", "Darrell Schamberger", 6, 48772m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "ImgUrl", "Name", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/461.jpg", "Titus Dickinson", 62949m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/662.jpg", "Ocie Ratke", 1, 71553m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1241.jpg", "Johnathon Mayert", 0, 92759m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/738.jpg", "Lavonne Rempel", 6, 99930m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/575.jpg", "Rosina Huels", 3, 61540m, 3 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1185.jpg", "Marlen Altenwerth", 9, 33607m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/298.jpg", "Wanda Runolfsdottir", 0, 80328m, 3 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/957.jpg", "Theresia Abernathy", 7, 82404m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/972.jpg", "Arvel Wolff", 5, 64264m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/397.jpg", "Ewell Koss", 7, 65416m, 3 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/146.jpg", "Jovanny Schimmel", 9, 64374m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1126.jpg", "Amalia Buckridge", 9, 68584m });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/664.jpg", "Parker Armstrong", 7, 57498m, 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/809.jpg", "Estella Wyman", 1, 35399m, 3 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/795.jpg", "Nolan Miller", 3, 90520m, 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/429.jpg", "Nicolette Kihn", 5, 77209m, 2 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/122.jpg", "Daija Torp", 9, 45021m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/1067.jpg", "Arnold Herman", 2, 89932m, 0 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/57.jpg", "Nadia Okuneva", 8, 63508m, 3 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/611.jpg", "Viva Krajcik", 8, 81774m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/817.jpg", "Maverick Olson", 4, 96156m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary", "Type" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/437.jpg", "Kory Spinka", 2, 75392m, 1 });

            migrationBuilder.UpdateData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "ImgUrl", "Name", "Position", "Salary" },
                values: new object[] { "https://cloudflare-ipfs.com/ipfs/Qmd3W5DuhgHirLHGVixi6V76LhCkZUz6pnFt5AJBiyvHye/avatar/534.jpg", "Claude Dooley", 5, 93182m });
        }
    }
}
