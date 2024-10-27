using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab2.Migrations
{
    /// <inheritdoc />
    public partial class Update_link_menu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 235, DateTimeKind.Local).AddTicks(9957));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 235, DateTimeKind.Local).AddTicks(9967));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 27, 18, 13, 18, 235, DateTimeKind.Local).AddTicks(9971), "student/path" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 235, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 235, DateTimeKind.Local).AddTicks(9978));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 235, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 235, DateTimeKind.Local).AddTicks(9983));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 235, DateTimeKind.Local).AddTicks(9986));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 27, 18, 13, 18, 235, DateTimeKind.Local).AddTicks(9989), "student/takelesson" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 235, DateTimeKind.Local).AddTicks(9991));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 235, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 235, DateTimeKind.Local).AddTicks(9996));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 27, 18, 13, 18, 235, DateTimeKind.Local).AddTicks(9998), "student/quizresult" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local), "student/quizresultdetail" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(3));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(5), "student/pathassessmentresult" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(7));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(10));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(12));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(14), "instructor/earning" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(18));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(20));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(22));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(24));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(26), "login" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(28), "signup" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(32));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(35));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(39));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(41));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(45));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(47), "billing" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(49), "billing/upgrade" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(51), "billing/invoice" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(55), "message" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 236, DateTimeKind.Local).AddTicks(57));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 235, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 235, DateTimeKind.Local).AddTicks(9741));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 235, DateTimeKind.Local).AddTicks(9745));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 235, DateTimeKind.Local).AddTicks(9747));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 10, 27, 18, 13, 18, 235, DateTimeKind.Local).AddTicks(9750));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(319));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(333), "paths" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(338));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(343));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(346));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(348), "student/lesson" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(351));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(356));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(358));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(361), "student/quizresults" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(363), "student/quizresultdetails" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(368), "student/pathassessmentresul" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(375));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(377), "instructor/earnings" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(379));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(381));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(387));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(389), "login.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(392), "signup.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(396));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(399));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(401));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(403));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(405));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(410), "billing.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(414), "billing-upgrade.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(417), "billing-invoice.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(419), "messages.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(421));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(26));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(30));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(34));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(37));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(95));
        }
    }
}
