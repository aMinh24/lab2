using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab2.Migrations
{
    /// <inheritdoc />
    public partial class fixsubcription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PaymentStatus",
                table: "Subscriptions");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4455));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4460));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4461));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4463));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4465));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4466));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4469));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4472));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4473));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4477));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4480));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4483));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4487));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4488));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4490));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4491));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4495));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4496));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4604));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4606));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4608));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4610));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4612));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4613));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4615));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4617));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4618));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4620));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4622));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4625));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4627));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4629));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4193));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4197));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4201));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 11, 3, 231, DateTimeKind.Local).AddTicks(4204));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PaymentStatus",
                table: "Subscriptions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5638));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5647));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5649));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5651));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5653));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5654));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5656));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5657));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5659));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5660));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5662));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5663));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5665));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5667));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5669));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5670));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5672));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5673));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5675));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5676));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5678));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5681));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5683));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5684));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5688));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5690));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5693));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5694));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5696));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5697));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5699));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5701));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5704));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5705));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5708));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5417));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5420));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5424));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 7, 29, 17, 783, DateTimeKind.Local).AddTicks(5425));
        }
    }
}
