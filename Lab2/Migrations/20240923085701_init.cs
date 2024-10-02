using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab2.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ParentMenus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Link = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Meta = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Hide = table.Column<bool>(type: "bit", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    DateBegin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Span = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParentMenus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Menus",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Link = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Meta = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Hide = table.Column<bool>(type: "bit", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    Span = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    DateBegin = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Icon = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Badge = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ParentMenuId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Menus", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Menus_ParentMenus_ParentMenuId",
                        column: x => x.ParentMenuId,
                        principalTable: "ParentMenus",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "ParentMenus",
                columns: new[] { "Id", "DateBegin", "Hide", "Icon", "Link", "Meta", "Name", "Order", "Span" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3334), false, "school", "sm_student", "student", "Student", 1, "Student" },
                    { 2, new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3337), false, "format_shapes", "sm_instructor", "instructor", "Instructor", 2, "Instructor" },
                    { 3, new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3339), false, "apps", "sm_apps", "apps", "Apps", 3, "Apps" },
                    { 4, new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3341), false, "message", "sm_messaging", "messaging", "Messaging", 4, "Messaging" },
                    { 5, new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3343), false, "account_box", "sm_account", "account", "Account", 5, "Account" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Badge", "DateBegin", "Hide", "Icon", "Link", "Meta", "Name", "Order", "ParentMenuId", "Span" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3454), false, "home", "index.html", "home_meta", "Home", 1, 1, "Home" },
                    { 2, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3459), false, "local_library", "courses.html", "courses_meta", "Browse Courses", 2, 1, "Browse Courses" },
                    { 3, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3461), false, "style", "paths.html", "paths_meta", "Browse Paths", 3, 1, "Browse Paths" },
                    { 4, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3463), false, "account_box", "student-dashboard.html", "dashboard_meta", "Student Dashboard", 4, 1, "Student Dashboard" },
                    { 5, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3464), false, "search", "student-my-courses.html", "my_courses_meta", "My Courses", 5, 1, "My Courses" },
                    { 6, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3466), false, "timeline", "student-paths.html", "my_paths_meta", "My Paths", 6, 1, "My Paths" },
                    { 7, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3468), false, "change_history", "student-path.html", "path_details_meta", "Path Details", 7, 1, "Path Details" },
                    { 8, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3470), false, "face", "student-course.html", "course_preview_meta", "Course Preview", 8, 1, "Course Preview" },
                    { 9, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3471), false, "panorama_fish_eye", "student-lesson.html", "lesson_preview_meta", "Lesson Preview", 9, 1, "Lesson Preview" },
                    { 10, "PRO", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3473), false, "class", "student-take-course.html", "take_course_meta", "Take Course", 10, 1, "Take Course" },
                    { 11, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3475), false, "import_contacts", "student-take-lesson.html", "take_lesson_meta", "Take Lesson", 11, 1, "Take Lesson" },
                    { 12, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3477), false, "dvr", "student-take-quiz.html", "take_quiz_meta", "Take Quiz", 12, 1, "Take Quiz" },
                    { 13, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3479), false, "poll", "student-quiz-results.html", "my_quizzes_meta", "My Quizzes", 13, 1, "My Quizzes" },
                    { 14, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3480), false, "live_help", "student-quiz-result-details.html", "quiz_result_meta", "Quiz Result", 14, 1, "Quiz Result" },
                    { 15, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3482), false, "layers", "student-path-assessment.html", "skill_assessment_meta", "Skill Assessment", 15, 1, "Skill Assessment" },
                    { 16, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3484), false, "assignment_turned_in", "student-path-assessment-result.html", "skill_result_meta", "Skill Result", 16, 1, "Skill Result" },
                    { 17, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3485), false, "school", "instructor-dashboard.html", "instructor_dashboard_meta", "Instructor Dashboard", 1, 2, "Instructor Dashboard" },
                    { 18, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3487), false, "import_contacts", "instructor-courses.html", "manage_courses_meta", "Manage Courses", 2, 2, "Manage Courses" },
                    { 19, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3488), false, "help", "instructor-quizzes.html", "manage_quizzes_meta", "Manage Quizzes", 3, 2, "Manage Quizzes" },
                    { 20, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3490), false, "trending_up", "instructor-earnings.html", "earnings_meta", "Earnings", 4, 2, "Earnings" },
                    { 21, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3491), false, "receipt", "instructor-statement.html", "statement_meta", "Statement", 5, 2, "Statement" },
                    { 22, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3493), false, "post_add", "instructor-edit-course.html", "edit_course_meta", "Edit Course", 6, 2, "Edit Course" },
                    { 23, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3494), false, "format_shapes", "instructor-edit-quiz.html", "edit_quiz_meta", "Edit Quiz", 7, 2, "Edit Quiz" },
                    { 24, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3497), false, "", "pricing.html", "pricing_meta", "Pricing", 1, 5, "Pricing" },
                    { 25, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3498), false, "", "login.html", "login_meta", "Login", 2, 5, "Login" },
                    { 26, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3500), false, "", "signup.html", "signup_meta", "Signup", 3, 5, "Signup" },
                    { 27, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3502), false, "", "signup-payment.html", "payment_meta", "Payment", 4, 5, "Payment" },
                    { 28, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3503), false, "", "reset-password.html", "reset_password_meta", "Reset Password", 5, 5, "Reset Password" },
                    { 29, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3505), false, "", "change-password.html", "change_password_meta", "Change Password", 6, 5, "Change Password" },
                    { 30, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3506), false, "", "edit-account.html", "edit_account_meta", "Edit Account", 7, 5, "Edit Account" },
                    { 31, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3508), false, "", "edit-account-profile.html", "profile_privacy_meta", "Profile & Privacy", 8, 5, "Profile & Privacy" },
                    { 32, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3509), false, "", "edit-account-notifications.html", "email_notifications_meta", "Email Notifications", 9, 5, "Email Notifications" },
                    { 33, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3511), false, "", "edit-account-password.html", "account_password_meta", "Account Password", 10, 5, "Account Password" },
                    { 34, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3512), false, "", "billing.html", "subscription_meta", "Subscription", 11, 5, "Subscription" },
                    { 35, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3514), false, "", "billing-upgrade.html", "upgrade_account_meta", "Upgrade Account", 12, 5, "Upgrade Account" },
                    { 38, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3515), false, "", "billing-invoice.html", "invoice_meta", "Invoice", 8, 5, "Invoice" },
                    { 39, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3517), false, "", "messages.html", "messages_meta", "Messages", 1, 4, "Messages" },
                    { 40, "", new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3518), false, "", "email.html", "email_meta", "Email", 2, 4, "Email" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Menus_ParentMenuId",
                table: "Menus",
                column: "ParentMenuId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "ParentMenus");
        }
    }
}
