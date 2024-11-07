using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab2.Migrations
{
    /// <inheritdoc />
    public partial class create_student_path : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Instructors_InstructorId",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "DifficultCourse",
                table: "Courses",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "StudentPaths",
                columns: table => new
                {
                    StudentPathId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StudentId = table.Column<int>(type: "int", nullable: false),
                    PathId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StudentPaths", x => x.StudentPathId);
                    table.ForeignKey(
                        name: "FK_StudentPaths_Paths_PathId",
                        column: x => x.PathId,
                        principalTable: "Paths",
                        principalColumn: "PathId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StudentPaths_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(609));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(618));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2313));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2343));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2346));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2349));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2359));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2365));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2371));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2402));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2427));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2433));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2435));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2444));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2450));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2453));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2461));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2466));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2469));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(2478));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(21));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(25));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(29));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 11, 6, 20, 18, 37, 250, DateTimeKind.Local).AddTicks(33));

            migrationBuilder.CreateIndex(
                name: "IX_StudentPaths_PathId",
                table: "StudentPaths",
                column: "PathId");

            migrationBuilder.CreateIndex(
                name: "IX_StudentPaths_StudentId",
                table: "StudentPaths",
                column: "StudentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Instructors_InstructorId",
                table: "Courses",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "InstructorId",
                onDelete: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Instructors_InstructorId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "StudentPaths");

            migrationBuilder.DropColumn(
                name: "DifficultCourse",
                table: "Courses");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8794));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8797));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8800));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8808));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8810));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8812));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8817));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8822));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8830));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8864));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8868));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8871));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8876));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8878));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8883));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 117, DateTimeKind.Local).AddTicks(748));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 117, DateTimeKind.Local).AddTicks(775));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 117, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 117, DateTimeKind.Local).AddTicks(781));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 117, DateTimeKind.Local).AddTicks(919));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 117, DateTimeKind.Local).AddTicks(1232));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 117, DateTimeKind.Local).AddTicks(1239));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8378));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8382));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8386));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 11, 5, 9, 43, 2, 116, DateTimeKind.Local).AddTicks(8389));

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Instructors_InstructorId",
                table: "Courses",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "InstructorId");
        }
    }
}
