using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class SeededData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryItems",
                columns: new[] { "Id", "Content", "Created", "Title" },
                values: new object[,]
                {
                    { 1, "Noice", new DateTime(2024, 7, 14, 4, 58, 41, 452, DateTimeKind.Local).AddTicks(9928), "Went Hiking with Joe" },
                    { 2, "Noce", new DateTime(2024, 7, 14, 4, 58, 41, 452, DateTimeKind.Local).AddTicks(9932), "Went Hiking wh Joe" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryItems",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryItems",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
