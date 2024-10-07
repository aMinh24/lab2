using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab2.Migrations
{
    /// <inheritdoc />
    public partial class avataruser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Avatar",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6849));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6857));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6859));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6867));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6869));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6870));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6873));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6875));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6877));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6882));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6883));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6885));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6889));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6891));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6894));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6895));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6900));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6901));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6903));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6904));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6906));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6907));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6930));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6933));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6938));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6939));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6681));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6685));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 10, 7, 20, 13, 0, 679, DateTimeKind.Local).AddTicks(6688));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Avatar",
                table: "Users");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5626));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5635));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5637));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5639));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5641));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5643));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5644));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5646));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5650));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5652));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5655));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5658));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5666));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5671));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5674));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5677));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5679));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5682));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5685));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5686));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5713));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5716));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5437));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5440));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5442));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5444));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5446));
        }
    }
}
