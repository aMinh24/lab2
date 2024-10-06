using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab2.Migrations
{
    /// <inheritdoc />
    public partial class lessontime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "EstimateTime",
                table: "Lessons",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(406));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(413));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(420));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(425));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(426));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(428));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(437));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(439));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(442));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(445));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(447));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(450));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(165));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(168));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(170));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(172));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 10, 6, 10, 8, 37, 212, DateTimeKind.Local).AddTicks(174));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "EstimateTime",
                table: "Lessons");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(993));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(995));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(997));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(998));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1003));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1005));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1009));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1048));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1050));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1052));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1055));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1056));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1062));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1064));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1067));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1068));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1072));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1075));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1076));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1080));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1083));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1085));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1088));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1089));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(1091));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(809));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(812));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(815));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 10, 1, 14, 11, 12, 218, DateTimeKind.Local).AddTicks(817));
        }
    }
}
