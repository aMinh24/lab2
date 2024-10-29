using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab2.Migrations
{
    /// <inheritdoc />
    public partial class update_student_model : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_Users_UserId",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCourses_Users_UserId",
                table: "UserCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLessons_Users_UserId",
                table: "UserLessons");

            migrationBuilder.DropColumn(
                name: "Feedback",
                table: "UserCourses");

            migrationBuilder.RenameColumn(
                name: "Rating",
                table: "UserCourses",
                newName: "LessonId");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserLessons",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "UserCourses",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<int>(
                name: "ChapterId",
                table: "UserCourses",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Subscriptions",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<double>(
                name: "Duration",
                table: "Courses",
                type: "float",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LinkFacebook = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LinkTwitter = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    School = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                    table.ForeignKey(
                        name: "FK_Students_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FeedBacks",
                columns: table => new
                {
                    FeedBackId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeedBacks", x => x.FeedBackId);
                    table.ForeignKey(
                        name: "FK_FeedBacks_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FeedBacks_Students_UserId",
                        column: x => x.UserId,
                        principalTable: "Students",
                        principalColumn: "StudentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(645));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(648), "paths" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(650));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(654));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(659));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(661), "student/lesson" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(663));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(667));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(669), "student/quizresults" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(671), "student/quizresultdetails" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(675), "student/pathassessmentresul" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(679));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(683), "instructor/earnings" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(688));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(692), "login.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(695), "signup.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(699));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(701));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(703));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(705));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(708));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(710), "billing.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(712), "billing-upgrade.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(714), "billing-invoice.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "DateBegin", "Link" },
                values: new object[] { new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(716), "messages.html" });

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(449));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(458));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 10, 29, 17, 39, 1, 197, DateTimeKind.Local).AddTicks(460));

            migrationBuilder.CreateIndex(
                name: "IX_UserCourses_ChapterId",
                table: "UserCourses",
                column: "ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCourses_LessonId",
                table: "UserCourses",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedBacks_CourseId",
                table: "FeedBacks",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_FeedBacks_UserId",
                table: "FeedBacks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_UserId",
                table: "Students",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Students_UserId",
                table: "Subscriptions",
                column: "UserId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCourses_Chapters_ChapterId",
                table: "UserCourses",
                column: "ChapterId",
                principalTable: "Chapters",
                principalColumn: "ChapterId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCourses_Lessons_LessonId",
                table: "UserCourses",
                column: "LessonId",
                principalTable: "Lessons",
                principalColumn: "LessonId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserCourses_Students_UserId",
                table: "UserCourses",
                column: "UserId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLessons_Students_UserId",
                table: "UserLessons",
                column: "UserId",
                principalTable: "Students",
                principalColumn: "StudentId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Subscriptions_Students_UserId",
                table: "Subscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCourses_Chapters_ChapterId",
                table: "UserCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCourses_Lessons_LessonId",
                table: "UserCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_UserCourses_Students_UserId",
                table: "UserCourses");

            migrationBuilder.DropForeignKey(
                name: "FK_UserLessons_Students_UserId",
                table: "UserLessons");

            migrationBuilder.DropTable(
                name: "FeedBacks");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropIndex(
                name: "IX_UserCourses_ChapterId",
                table: "UserCourses");

            migrationBuilder.DropIndex(
                name: "IX_UserCourses_LessonId",
                table: "UserCourses");

            migrationBuilder.DropColumn(
                name: "ChapterId",
                table: "UserCourses");

            migrationBuilder.DropColumn(
                name: "Duration",
                table: "Courses");

            migrationBuilder.RenameColumn(
                name: "LessonId",
                table: "UserCourses",
                newName: "Rating");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserLessons",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "UserCourses",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Feedback",
                table: "UserCourses",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Subscriptions",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Subscriptions_Users_UserId",
                table: "Subscriptions",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserCourses_Users_UserId",
                table: "UserCourses",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_UserLessons_Users_UserId",
                table: "UserLessons",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
