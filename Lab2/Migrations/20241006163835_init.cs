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
                name: "Platforms",
                columns: table => new
                {
                    PlatformId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Platforms", x => x.PlatformId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubscriptionTypes",
                columns: table => new
                {
                    SubscriptionTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubscriptionTypes", x => x.SubscriptionTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Topics",
                columns: table => new
                {
                    TopicId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Topics", x => x.TopicId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id"
                        );
                });

            migrationBuilder.CreateTable(
                name: "BlogPosts",
                columns: table => new
                {
                    BlogPostId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BlogPosts", x => x.BlogPostId);
                    table.ForeignKey(
                        name: "FK_BlogPosts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
                        );
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrailerUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InstructorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TopicId = table.Column<int>(type: "int", nullable: false),
                    PlatformId = table.Column<int>(type: "int", nullable: false),
                    Thumbnail = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CourseId);
                    table.ForeignKey(
                        name: "FK_Courses_Platforms_PlatformId",
                        column: x => x.PlatformId,
                        principalTable: "Platforms",
                        principalColumn: "PlatformId"
                        );
                    table.ForeignKey(
                        name: "FK_Courses_Topics_TopicId",
                        column: x => x.TopicId,
                        principalTable: "Topics",
                        principalColumn: "TopicId"
                        );
                    table.ForeignKey(
                        name: "FK_Courses_Users_InstructorId",
                        column: x => x.InstructorId,
                        principalTable: "Users",
                        principalColumn: "Id"
                        );
                });

            migrationBuilder.CreateTable(
                name: "Subscriptions",
                columns: table => new
                {
                    SubscriptionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SubscriptionTypeId = table.Column<int>(type: "int", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Subscriptions", x => x.SubscriptionId);
                    table.ForeignKey(
                        name: "FK_Subscriptions_SubscriptionTypes_SubscriptionTypeId",
                        column: x => x.SubscriptionTypeId,
                        principalTable: "SubscriptionTypes",
                        principalColumn: "SubscriptionTypeId"
                        );
                    table.ForeignKey(
                        name: "FK_Subscriptions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
                        );
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
                        );
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
                        );
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id"
                        );
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
                        );
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
                        );
                });

            migrationBuilder.CreateTable(
                name: "Chapters",
                columns: table => new
                {
                    ChapterId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    OrderChap = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Chapters", x => x.ChapterId);
                    table.ForeignKey(
                        name: "FK_Chapters_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId"
                        );
                });

            migrationBuilder.CreateTable(
                name: "UserCourses",
                columns: table => new
                {
                    UserCourseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: true),
                    Feedback = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCourses", x => x.UserCourseId);
                    table.ForeignKey(
                        name: "FK_UserCourses_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId"
                        );
                    table.ForeignKey(
                        name: "FK_UserCourses_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
                        );
                });

            migrationBuilder.CreateTable(
                name: "Lessons",
                columns: table => new
                {
                    LessonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ChapterId = table.Column<int>(type: "int", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    VideoUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderLesson = table.Column<int>(type: "int", nullable: false),
                    EstimateTime = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Lessons", x => x.LessonId);
                    table.ForeignKey(
                        name: "FK_Lessons_Chapters_ChapterId",
                        column: x => x.ChapterId,
                        principalTable: "Chapters",
                        principalColumn: "ChapterId"
                        );
                });

            migrationBuilder.CreateTable(
                name: "Discussions",
                columns: table => new
                {
                    DiscussionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    CourseId = table.Column<int>(type: "int", nullable: true),
                    LessonId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Discussions", x => x.DiscussionId);
                    table.ForeignKey(
                        name: "FK_Discussions_Courses_CourseId",
                        column: x => x.CourseId,
                        principalTable: "Courses",
                        principalColumn: "CourseId");
                    table.ForeignKey(
                        name: "FK_Discussions_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "LessonId");
                    table.ForeignKey(
                        name: "FK_Discussions_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
                        );
                });

            migrationBuilder.CreateTable(
                name: "UserLessons",
                columns: table => new
                {
                    UserLessonId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LessonId = table.Column<int>(type: "int", nullable: false),
                    Completed = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLessons", x => x.UserLessonId);
                    table.ForeignKey(
                        name: "FK_UserLessons_Lessons_LessonId",
                        column: x => x.LessonId,
                        principalTable: "Lessons",
                        principalColumn: "LessonId"
                        );
                    table.ForeignKey(
                        name: "FK_UserLessons_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
                        );
                });

            migrationBuilder.CreateTable(
                name: "DiscussionReplies",
                columns: table => new
                {
                    DiscussionReplyId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DiscussionId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DiscussionReplies", x => x.DiscussionReplyId);
                    table.ForeignKey(
                        name: "FK_DiscussionReplies_Discussions_DiscussionId",
                        column: x => x.DiscussionId,
                        principalTable: "Discussions",
                        principalColumn: "DiscussionId"
                        );
                    table.ForeignKey(
                        name: "FK_DiscussionReplies_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id"
                        );
                });

            migrationBuilder.InsertData(
                table: "ParentMenus",
                columns: new[] { "Id", "DateBegin", "Hide", "Icon", "Link", "Meta", "Name", "Order", "Span" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5437), false, "school", "sm_student", "student", "Student", 1, "Student" },
                    { 2, new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5440), false, "format_shapes", "sm_instructor", "instructor", "Instructor", 2, "Instructor" },
                    { 3, new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5442), false, "apps", "sm_apps", "apps", "Apps", 3, "Apps" },
                    { 4, new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5444), false, "message", "sm_messaging", "messaging", "Messaging", 4, "Messaging" },
                    { 5, new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5446), false, "account_box", "sm_account", "account", "Account", 5, "Account" }
                });

            migrationBuilder.InsertData(
                table: "Menus",
                columns: new[] { "Id", "Badge", "DateBegin", "Hide", "Icon", "Link", "Meta", "Name", "Order", "ParentMenuId", "Span" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5626), false, "home", "index.html", "home_meta", "Home", 1, 1, "Home" },
                    { 2, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5633), false, "local_library", "courses.html", "courses_meta", "Browse Courses", 2, 1, "Browse Courses" },
                    { 3, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5635), false, "style", "paths.html", "paths_meta", "Browse Paths", 3, 1, "Browse Paths" },
                    { 4, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5637), false, "account_box", "student-dashboard.html", "dashboard_meta", "Student Dashboard", 4, 1, "Student Dashboard" },
                    { 5, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5639), false, "search", "student-my-courses.html", "my_courses_meta", "My Courses", 5, 1, "My Courses" },
                    { 6, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5641), false, "timeline", "student-paths.html", "my_paths_meta", "My Paths", 6, 1, "My Paths" },
                    { 7, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5643), false, "change_history", "student-path.html", "path_details_meta", "Path Details", 7, 1, "Path Details" },
                    { 8, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5644), false, "face", "student-course.html", "course_preview_meta", "Course Preview", 8, 1, "Course Preview" },
                    { 9, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5646), false, "panorama_fish_eye", "student-lesson.html", "lesson_preview_meta", "Lesson Preview", 9, 1, "Lesson Preview" },
                    { 10, "PRO", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5647), false, "class", "student-take-course.html", "take_course_meta", "Take Course", 10, 1, "Take Course" },
                    { 11, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5649), false, "import_contacts", "student-take-lesson.html", "take_lesson_meta", "Take Lesson", 11, 1, "Take Lesson" },
                    { 12, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5650), false, "dvr", "student-take-quiz.html", "take_quiz_meta", "Take Quiz", 12, 1, "Take Quiz" },
                    { 13, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5652), false, "poll", "student-quiz-results.html", "my_quizzes_meta", "My Quizzes", 13, 1, "My Quizzes" },
                    { 14, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5653), false, "live_help", "student-quiz-result-details.html", "quiz_result_meta", "Quiz Result", 14, 1, "Quiz Result" },
                    { 15, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5655), false, "layers", "student-path-assessment.html", "skill_assessment_meta", "Skill Assessment", 15, 1, "Skill Assessment" },
                    { 16, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5656), false, "assignment_turned_in", "student-path-assessment-result.html", "skill_result_meta", "Skill Result", 16, 1, "Skill Result" },
                    { 17, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5658), false, "school", "instructor-dashboard.html", "instructor_dashboard_meta", "Instructor Dashboard", 1, 2, "Instructor Dashboard" },
                    { 18, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5660), false, "import_contacts", "instructor-courses.html", "manage_courses_meta", "Manage Courses", 2, 2, "Manage Courses" },
                    { 19, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5662), false, "help", "instructor-quizzes.html", "manage_quizzes_meta", "Manage Quizzes", 3, 2, "Manage Quizzes" },
                    { 20, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5663), false, "trending_up", "instructor-earnings.html", "earnings_meta", "Earnings", 4, 2, "Earnings" },
                    { 21, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5665), false, "receipt", "instructor-statement.html", "statement_meta", "Statement", 5, 2, "Statement" },
                    { 22, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5666), false, "post_add", "instructor-edit-course.html", "edit_course_meta", "Edit Course", 6, 2, "Edit Course" },
                    { 23, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5668), false, "format_shapes", "instructor-edit-quiz.html", "edit_quiz_meta", "Edit Quiz", 7, 2, "Edit Quiz" },
                    { 24, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5669), false, "", "pricing.html", "pricing_meta", "Pricing", 1, 5, "Pricing" },
                    { 25, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5671), false, "", "login.html", "login_meta", "Login", 2, 5, "Login" },
                    { 26, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5672), false, "", "signup.html", "signup_meta", "Signup", 3, 5, "Signup" },
                    { 27, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5674), false, "", "signup-payment.html", "payment_meta", "Payment", 4, 5, "Payment" },
                    { 28, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5675), false, "", "reset-password.html", "reset_password_meta", "Reset Password", 5, 5, "Reset Password" },
                    { 29, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5677), false, "", "change-password.html", "change_password_meta", "Change Password", 6, 5, "Change Password" },
                    { 30, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5679), false, "", "edit-account.html", "edit_account_meta", "Edit Account", 7, 5, "Edit Account" },
                    { 31, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5681), false, "", "edit-account-profile.html", "profile_privacy_meta", "Profile & Privacy", 8, 5, "Profile & Privacy" },
                    { 32, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5682), false, "", "edit-account-notifications.html", "email_notifications_meta", "Email Notifications", 9, 5, "Email Notifications" },
                    { 33, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5683), false, "", "edit-account-password.html", "account_password_meta", "Account Password", 10, 5, "Account Password" },
                    { 34, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5685), false, "", "billing.html", "subscription_meta", "Subscription", 11, 5, "Subscription" },
                    { 35, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5686), false, "", "billing-upgrade.html", "upgrade_account_meta", "Upgrade Account", 12, 5, "Upgrade Account" },
                    { 38, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5713), false, "", "billing-invoice.html", "invoice_meta", "Invoice", 8, 5, "Invoice" },
                    { 39, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5714), false, "", "messages.html", "messages_meta", "Messages", 1, 4, "Messages" },
                    { 40, "", new DateTime(2024, 10, 6, 23, 38, 35, 70, DateTimeKind.Local).AddTicks(5716), false, "", "email.html", "email_meta", "Email", 2, 4, "Email" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BlogPosts_UserId",
                table: "BlogPosts",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Chapters_CourseId",
                table: "Chapters",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_InstructorId",
                table: "Courses",
                column: "InstructorId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_PlatformId",
                table: "Courses",
                column: "PlatformId");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_TopicId",
                table: "Courses",
                column: "TopicId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscussionReplies_DiscussionId",
                table: "DiscussionReplies",
                column: "DiscussionId");

            migrationBuilder.CreateIndex(
                name: "IX_DiscussionReplies_UserId",
                table: "DiscussionReplies",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Discussions_CourseId",
                table: "Discussions",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_Discussions_LessonId",
                table: "Discussions",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_Discussions_UserId",
                table: "Discussions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Lessons_ChapterId",
                table: "Lessons",
                column: "ChapterId");

            migrationBuilder.CreateIndex(
                name: "IX_Menus_ParentMenuId",
                table: "Menus",
                column: "ParentMenuId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "Roles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_SubscriptionTypeId",
                table: "Subscriptions",
                column: "SubscriptionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Subscriptions_UserId",
                table: "Subscriptions",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCourses_CourseId",
                table: "UserCourses",
                column: "CourseId");

            migrationBuilder.CreateIndex(
                name: "IX_UserCourses_UserId",
                table: "UserCourses",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLessons_LessonId",
                table: "UserLessons",
                column: "LessonId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLessons_UserId",
                table: "UserLessons",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserLogins_UserId",
                table: "UserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "Users",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "Users",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BlogPosts");

            migrationBuilder.DropTable(
                name: "DiscussionReplies");

            migrationBuilder.DropTable(
                name: "Menus");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "Subscriptions");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserCourses");

            migrationBuilder.DropTable(
                name: "UserLessons");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "Discussions");

            migrationBuilder.DropTable(
                name: "ParentMenus");

            migrationBuilder.DropTable(
                name: "SubscriptionTypes");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Lessons");

            migrationBuilder.DropTable(
                name: "Chapters");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Platforms");

            migrationBuilder.DropTable(
                name: "Topics");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
