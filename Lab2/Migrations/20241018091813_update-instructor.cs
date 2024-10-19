using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab2.Migrations
{
    /// <inheritdoc />
    public partial class updateinstructor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    InstructorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    About = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkFacebook = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkTwitter = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.InstructorId);
                    table.ForeignKey(
                        name: "FK_Instructors_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "TopicId");
                    table.ForeignKey(
                        name: "FK_Instructors_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8164), "" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8173), "courses" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8176), "paths" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8181), "dashboard" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8183), "mycourse" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8185), "mypaths" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8187), "pathdetail" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8189), "courseprview" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8191), "lesson" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8202));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8209));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8211));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8213));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8215));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8217));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8219));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8222));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8224));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8226));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8231));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8272));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8276));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8280));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8014));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8018));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8020));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8023));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 10, 18, 16, 18, 12, 686, DateTimeKind.Local).AddTicks(8025));

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_TopicId",
                table: "Instructors",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_UserId",
                table: "Instructors",
                column: "UserId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2682), "index.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2689), "courses.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2691), "paths.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2692), "student-dashboard.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2694), "student-my-courses.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2696), "student-paths.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2699), "student-path.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2701), "student-course.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 11, 22, 26, 36, 737, DateTimeKind.Local).AddTicks(2703), "student-lesson.html" });

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
    }
}
