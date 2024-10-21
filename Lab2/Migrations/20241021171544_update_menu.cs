using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab2.Migrations
{
    /// <inheritdoc />
    public partial class update_menu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(336), "student/dashboard" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(338), "student/mycourse" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(341), "student/mypath" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(343), "student/pathdetail" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(346), "student/courseprview" });

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
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(351), "student/takecourse" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(356), "student/takelesson" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(358), "student/takequiz" });

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
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(365), "student/pathassessment" });

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
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(370), "instructor" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(372), "instructor/mycourses" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(375), "instructor/quizz" });

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
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(379), "instructor/statement" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(381), "instructor/editcourse" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(385), "instructor/editquiz" });

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
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(389));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(392));

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
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(410));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(414));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(417));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateBegin",
                value: new DateTime(2024, 10, 22, 0, 15, 40, 35, DateTimeKind.Local).AddTicks(419));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(827));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(834), "dashboard" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(836), "mycourse" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(839), "mypaths" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(842), "pathdetail" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(846), "courseprview" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(849), "lesson" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(851), "student-take-course.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(855), "student-take-lesson.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(858), "student-take-quiz.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(860), "student-quiz-results.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(862), "student-quiz-result-details.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(864), "student-path-assessment.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(867), "student-path-assessment-result.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(869), "instructor-dashboard.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(872), "instructor-courses.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(874), "instructor-quizzes.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(877), "instructor-earnings.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(879), "instructor-statement.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(882), "instructor-edit-course.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(885), "instructor-edit-quiz.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateBegin",
                value: new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(887));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateBegin",
                value: new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(889));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateBegin",
                value: new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(891));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateBegin",
                value: new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(894));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateBegin",
                value: new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(896));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateBegin",
                value: new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(898));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateBegin",
                value: new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(900));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateBegin",
                value: new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(902));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateBegin",
                value: new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(904));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateBegin",
                value: new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(907));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateBegin",
                value: new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(909));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateBegin",
                value: new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(912));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateBegin",
                value: new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(914));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateBegin",
                value: new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(916));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateBegin",
                value: new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(921));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 10, 19, 14, 32, 24, 241, DateTimeKind.Local).AddTicks(622));
        }
    }
}
