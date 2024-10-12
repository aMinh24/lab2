using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab2.Migrations
{
    /// <inheritdoc />
    public partial class addpaymentinfor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PaymentInformations",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CreditNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AutoRenew = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentInformations", x => x.UserId);
                    table.ForeignKey(
                        name: "FK_PaymentInformations_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2682));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2692));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2694));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2699));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2703));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2704));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2707));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2710));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2713));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2716));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2718));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2721));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2724));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2728));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2750));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2754));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2757));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2758));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2761));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2763));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2765));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2767));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2769));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2770));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2548));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2554));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2556));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PaymentInformations");

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
    }
}
