using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class Data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DiaryItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 7, 14, 6, 17, 7, 64, DateTimeKind.Local).AddTicks(7982));

            migrationBuilder.UpdateData(
                table: "DiaryItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 7, 14, 6, 17, 7, 64, DateTimeKind.Local).AddTicks(7985));

            migrationBuilder.InsertData(
                table: "DiaryItems",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[] { 3, "Noce", new DateTime(2024, 7, 14, 6, 17, 7, 64, DateTimeKind.Local).AddTicks(7988), "C#" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryItems",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "DiaryItems",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2024, 7, 14, 4, 58, 41, 452, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "DiaryItems",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2024, 7, 14, 4, 58, 41, 452, DateTimeKind.Local).AddTicks(9932));
        }
    }
}
