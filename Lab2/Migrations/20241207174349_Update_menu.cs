using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab2.Migrations
{
    /// <inheritdoc />
    public partial class Update_menu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8623), "path" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8625));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8627));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8631));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8636), "ManageCourse" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8638));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8640));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8644));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8646));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8648));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8652));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8655));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8665));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8667));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8669));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8359));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8364));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8413));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 12, 8, 0, 43, 46, 176, DateTimeKind.Local).AddTicks(8416));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7025), "paths" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7027));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7029));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7078), "instructor/mycourses" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7084));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7089));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7093));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7097));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7103));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7107));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7109));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7111));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7114));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7116));

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Badge", "DateBegin", "Hide", "Icon", "Link", "Meta", "Name", "Order", "ParentMenuId", "Span" },
                values: new object[,]
                {
                    { 9, "", new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7060), false, "panorama_fish_eye", "student/lesson", "lesson_preview_meta", "Lesson Preview", 9, 1, "Lesson Preview" },
                    { 10, "PRO", new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7062), false, "class", "student/takecourse", "take_course_meta", "Take Course", 10, 1, "Take Course" },
                    { 11, "", new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7064), false, "import_contacts", "student/takelesson", "take_lesson_meta", "Take Lesson", 11, 1, "Take Lesson" },
                    { 12, "", new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7066), false, "dvr", "student/takequiz", "take_quiz_meta", "Take Quiz", 12, 1, "Take Quiz" },
                    { 13, "", new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7068), false, "poll", "student/quizresults", "my_quizzes_meta", "My Quizzes", 13, 1, "My Quizzes" },
                    { 14, "", new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7070), false, "live_help", "student/quizresultdetails", "quiz_result_meta", "Quiz Result", 14, 1, "Quiz Result" },
                    { 15, "", new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7072), false, "layers", "student/pathassessment", "skill_assessment_meta", "Skill Assessment", 15, 1, "Skill Assessment" },
                    { 16, "", new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7074), false, "assignment_turned_in", "student/pathassessmentresul", "skill_result_meta", "Skill Result", 16, 1, "Skill Result" },
                    { 19, "", new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7080), false, "help", "instructor/quizz", "manage_quizzes_meta", "Manage Quizzes", 3, 2, "Manage Quizzes" },
                    { 22, "", new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7086), false, "post_add", "instructor/editcourse", "edit_course_meta", "Edit Course", 6, 2, "Edit Course" },
                    { 23, "", new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(7087), false, "format_shapes", "instructor/editquiz", "edit_quiz_meta", "Edit Quiz", 7, 2, "Edit Quiz" }
                });

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(6853));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(6861));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.InsertData(
                table: "ParentMenus",
                columns: new[] { "Id", "DateBegin", "Hide", "Icon", "Link", "Meta", "Name", "Order", "Span" },
                values: new object[] { 3, new DateTime(2024, 12, 6, 21, 54, 47, 747, DateTimeKind.Local).AddTicks(6858), false, "apps", "sm_apps", "apps", "Apps", 3, "Apps" });
        }
    }
}
