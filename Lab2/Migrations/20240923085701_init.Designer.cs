﻿// <auto-generated />
using System;
using Lab2.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Lab2.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240923085701_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Lab2.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Badge")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<DateTime>("DateBegin")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Hide")
                        .HasColumnType("bit");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Meta")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<int?>("ParentMenuId")
                        .HasColumnType("int");

                    b.Property<string>("Span")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.HasIndex("ParentMenuId");

                    b.ToTable("Menus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3454),
                            Hide = false,
                            Icon = "home",
                            Link = "index.html",
                            Meta = "home_meta",
                            Name = "Home",
                            Order = 1,
                            ParentMenuId = 1,
                            Span = "Home"
                        },
                        new
                        {
                            Id = 2,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3459),
                            Hide = false,
                            Icon = "local_library",
                            Link = "courses.html",
                            Meta = "courses_meta",
                            Name = "Browse Courses",
                            Order = 2,
                            ParentMenuId = 1,
                            Span = "Browse Courses"
                        },
                        new
                        {
                            Id = 3,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3461),
                            Hide = false,
                            Icon = "style",
                            Link = "paths.html",
                            Meta = "paths_meta",
                            Name = "Browse Paths",
                            Order = 3,
                            ParentMenuId = 1,
                            Span = "Browse Paths"
                        },
                        new
                        {
                            Id = 4,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3463),
                            Hide = false,
                            Icon = "account_box",
                            Link = "student-dashboard.html",
                            Meta = "dashboard_meta",
                            Name = "Student Dashboard",
                            Order = 4,
                            ParentMenuId = 1,
                            Span = "Student Dashboard"
                        },
                        new
                        {
                            Id = 5,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3464),
                            Hide = false,
                            Icon = "search",
                            Link = "student-my-courses.html",
                            Meta = "my_courses_meta",
                            Name = "My Courses",
                            Order = 5,
                            ParentMenuId = 1,
                            Span = "My Courses"
                        },
                        new
                        {
                            Id = 6,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3466),
                            Hide = false,
                            Icon = "timeline",
                            Link = "student-paths.html",
                            Meta = "my_paths_meta",
                            Name = "My Paths",
                            Order = 6,
                            ParentMenuId = 1,
                            Span = "My Paths"
                        },
                        new
                        {
                            Id = 7,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3468),
                            Hide = false,
                            Icon = "change_history",
                            Link = "student-path.html",
                            Meta = "path_details_meta",
                            Name = "Path Details",
                            Order = 7,
                            ParentMenuId = 1,
                            Span = "Path Details"
                        },
                        new
                        {
                            Id = 8,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3470),
                            Hide = false,
                            Icon = "face",
                            Link = "student-course.html",
                            Meta = "course_preview_meta",
                            Name = "Course Preview",
                            Order = 8,
                            ParentMenuId = 1,
                            Span = "Course Preview"
                        },
                        new
                        {
                            Id = 9,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3471),
                            Hide = false,
                            Icon = "panorama_fish_eye",
                            Link = "student-lesson.html",
                            Meta = "lesson_preview_meta",
                            Name = "Lesson Preview",
                            Order = 9,
                            ParentMenuId = 1,
                            Span = "Lesson Preview"
                        },
                        new
                        {
                            Id = 10,
                            Badge = "PRO",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3473),
                            Hide = false,
                            Icon = "class",
                            Link = "student-take-course.html",
                            Meta = "take_course_meta",
                            Name = "Take Course",
                            Order = 10,
                            ParentMenuId = 1,
                            Span = "Take Course"
                        },
                        new
                        {
                            Id = 11,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3475),
                            Hide = false,
                            Icon = "import_contacts",
                            Link = "student-take-lesson.html",
                            Meta = "take_lesson_meta",
                            Name = "Take Lesson",
                            Order = 11,
                            ParentMenuId = 1,
                            Span = "Take Lesson"
                        },
                        new
                        {
                            Id = 12,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3477),
                            Hide = false,
                            Icon = "dvr",
                            Link = "student-take-quiz.html",
                            Meta = "take_quiz_meta",
                            Name = "Take Quiz",
                            Order = 12,
                            ParentMenuId = 1,
                            Span = "Take Quiz"
                        },
                        new
                        {
                            Id = 13,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3479),
                            Hide = false,
                            Icon = "poll",
                            Link = "student-quiz-results.html",
                            Meta = "my_quizzes_meta",
                            Name = "My Quizzes",
                            Order = 13,
                            ParentMenuId = 1,
                            Span = "My Quizzes"
                        },
                        new
                        {
                            Id = 14,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3480),
                            Hide = false,
                            Icon = "live_help",
                            Link = "student-quiz-result-details.html",
                            Meta = "quiz_result_meta",
                            Name = "Quiz Result",
                            Order = 14,
                            ParentMenuId = 1,
                            Span = "Quiz Result"
                        },
                        new
                        {
                            Id = 15,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3482),
                            Hide = false,
                            Icon = "layers",
                            Link = "student-path-assessment.html",
                            Meta = "skill_assessment_meta",
                            Name = "Skill Assessment",
                            Order = 15,
                            ParentMenuId = 1,
                            Span = "Skill Assessment"
                        },
                        new
                        {
                            Id = 16,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3484),
                            Hide = false,
                            Icon = "assignment_turned_in",
                            Link = "student-path-assessment-result.html",
                            Meta = "skill_result_meta",
                            Name = "Skill Result",
                            Order = 16,
                            ParentMenuId = 1,
                            Span = "Skill Result"
                        },
                        new
                        {
                            Id = 17,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3485),
                            Hide = false,
                            Icon = "school",
                            Link = "instructor-dashboard.html",
                            Meta = "instructor_dashboard_meta",
                            Name = "Instructor Dashboard",
                            Order = 1,
                            ParentMenuId = 2,
                            Span = "Instructor Dashboard"
                        },
                        new
                        {
                            Id = 18,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3487),
                            Hide = false,
                            Icon = "import_contacts",
                            Link = "instructor-courses.html",
                            Meta = "manage_courses_meta",
                            Name = "Manage Courses",
                            Order = 2,
                            ParentMenuId = 2,
                            Span = "Manage Courses"
                        },
                        new
                        {
                            Id = 19,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3488),
                            Hide = false,
                            Icon = "help",
                            Link = "instructor-quizzes.html",
                            Meta = "manage_quizzes_meta",
                            Name = "Manage Quizzes",
                            Order = 3,
                            ParentMenuId = 2,
                            Span = "Manage Quizzes"
                        },
                        new
                        {
                            Id = 20,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3490),
                            Hide = false,
                            Icon = "trending_up",
                            Link = "instructor-earnings.html",
                            Meta = "earnings_meta",
                            Name = "Earnings",
                            Order = 4,
                            ParentMenuId = 2,
                            Span = "Earnings"
                        },
                        new
                        {
                            Id = 21,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3491),
                            Hide = false,
                            Icon = "receipt",
                            Link = "instructor-statement.html",
                            Meta = "statement_meta",
                            Name = "Statement",
                            Order = 5,
                            ParentMenuId = 2,
                            Span = "Statement"
                        },
                        new
                        {
                            Id = 22,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3493),
                            Hide = false,
                            Icon = "post_add",
                            Link = "instructor-edit-course.html",
                            Meta = "edit_course_meta",
                            Name = "Edit Course",
                            Order = 6,
                            ParentMenuId = 2,
                            Span = "Edit Course"
                        },
                        new
                        {
                            Id = 23,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3494),
                            Hide = false,
                            Icon = "format_shapes",
                            Link = "instructor-edit-quiz.html",
                            Meta = "edit_quiz_meta",
                            Name = "Edit Quiz",
                            Order = 7,
                            ParentMenuId = 2,
                            Span = "Edit Quiz"
                        },
                        new
                        {
                            Id = 24,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3497),
                            Hide = false,
                            Icon = "",
                            Link = "pricing.html",
                            Meta = "pricing_meta",
                            Name = "Pricing",
                            Order = 1,
                            ParentMenuId = 5,
                            Span = "Pricing"
                        },
                        new
                        {
                            Id = 25,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3498),
                            Hide = false,
                            Icon = "",
                            Link = "login.html",
                            Meta = "login_meta",
                            Name = "Login",
                            Order = 2,
                            ParentMenuId = 5,
                            Span = "Login"
                        },
                        new
                        {
                            Id = 26,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3500),
                            Hide = false,
                            Icon = "",
                            Link = "signup.html",
                            Meta = "signup_meta",
                            Name = "Signup",
                            Order = 3,
                            ParentMenuId = 5,
                            Span = "Signup"
                        },
                        new
                        {
                            Id = 27,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3502),
                            Hide = false,
                            Icon = "",
                            Link = "signup-payment.html",
                            Meta = "payment_meta",
                            Name = "Payment",
                            Order = 4,
                            ParentMenuId = 5,
                            Span = "Payment"
                        },
                        new
                        {
                            Id = 28,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3503),
                            Hide = false,
                            Icon = "",
                            Link = "reset-password.html",
                            Meta = "reset_password_meta",
                            Name = "Reset Password",
                            Order = 5,
                            ParentMenuId = 5,
                            Span = "Reset Password"
                        },
                        new
                        {
                            Id = 29,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3505),
                            Hide = false,
                            Icon = "",
                            Link = "change-password.html",
                            Meta = "change_password_meta",
                            Name = "Change Password",
                            Order = 6,
                            ParentMenuId = 5,
                            Span = "Change Password"
                        },
                        new
                        {
                            Id = 30,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3506),
                            Hide = false,
                            Icon = "",
                            Link = "edit-account.html",
                            Meta = "edit_account_meta",
                            Name = "Edit Account",
                            Order = 7,
                            ParentMenuId = 5,
                            Span = "Edit Account"
                        },
                        new
                        {
                            Id = 31,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3508),
                            Hide = false,
                            Icon = "",
                            Link = "edit-account-profile.html",
                            Meta = "profile_privacy_meta",
                            Name = "Profile & Privacy",
                            Order = 8,
                            ParentMenuId = 5,
                            Span = "Profile & Privacy"
                        },
                        new
                        {
                            Id = 32,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3509),
                            Hide = false,
                            Icon = "",
                            Link = "edit-account-notifications.html",
                            Meta = "email_notifications_meta",
                            Name = "Email Notifications",
                            Order = 9,
                            ParentMenuId = 5,
                            Span = "Email Notifications"
                        },
                        new
                        {
                            Id = 33,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3511),
                            Hide = false,
                            Icon = "",
                            Link = "edit-account-password.html",
                            Meta = "account_password_meta",
                            Name = "Account Password",
                            Order = 10,
                            ParentMenuId = 5,
                            Span = "Account Password"
                        },
                        new
                        {
                            Id = 34,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3512),
                            Hide = false,
                            Icon = "",
                            Link = "billing.html",
                            Meta = "subscription_meta",
                            Name = "Subscription",
                            Order = 11,
                            ParentMenuId = 5,
                            Span = "Subscription"
                        },
                        new
                        {
                            Id = 35,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3514),
                            Hide = false,
                            Icon = "",
                            Link = "billing-upgrade.html",
                            Meta = "upgrade_account_meta",
                            Name = "Upgrade Account",
                            Order = 12,
                            ParentMenuId = 5,
                            Span = "Upgrade Account"
                        },
                        new
                        {
                            Id = 38,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3515),
                            Hide = false,
                            Icon = "",
                            Link = "billing-invoice.html",
                            Meta = "invoice_meta",
                            Name = "Invoice",
                            Order = 8,
                            ParentMenuId = 5,
                            Span = "Invoice"
                        },
                        new
                        {
                            Id = 39,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3517),
                            Hide = false,
                            Icon = "",
                            Link = "messages.html",
                            Meta = "messages_meta",
                            Name = "Messages",
                            Order = 1,
                            ParentMenuId = 4,
                            Span = "Messages"
                        },
                        new
                        {
                            Id = 40,
                            Badge = "",
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3518),
                            Hide = false,
                            Icon = "",
                            Link = "email.html",
                            Meta = "email_meta",
                            Name = "Email",
                            Order = 2,
                            ParentMenuId = 4,
                            Span = "Email"
                        });
                });

            modelBuilder.Entity("Lab2.Models.ParentMenu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("DateBegin")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Hide")
                        .HasColumnType("bit");

                    b.Property<string>("Icon")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Link")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Meta")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("Order")
                        .HasColumnType("int");

                    b.Property<string>("Span")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("ParentMenus");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3334),
                            Hide = false,
                            Icon = "school",
                            Link = "sm_student",
                            Meta = "student",
                            Name = "Student",
                            Order = 1,
                            Span = "Student"
                        },
                        new
                        {
                            Id = 2,
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3337),
                            Hide = false,
                            Icon = "format_shapes",
                            Link = "sm_instructor",
                            Meta = "instructor",
                            Name = "Instructor",
                            Order = 2,
                            Span = "Instructor"
                        },
                        new
                        {
                            Id = 3,
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3339),
                            Hide = false,
                            Icon = "apps",
                            Link = "sm_apps",
                            Meta = "apps",
                            Name = "Apps",
                            Order = 3,
                            Span = "Apps"
                        },
                        new
                        {
                            Id = 4,
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3341),
                            Hide = false,
                            Icon = "message",
                            Link = "sm_messaging",
                            Meta = "messaging",
                            Name = "Messaging",
                            Order = 4,
                            Span = "Messaging"
                        },
                        new
                        {
                            Id = 5,
                            DateBegin = new DateTime(2024, 9, 23, 15, 56, 59, 937, DateTimeKind.Local).AddTicks(3343),
                            Hide = false,
                            Icon = "account_box",
                            Link = "sm_account",
                            Meta = "account",
                            Name = "Account",
                            Order = 5,
                            Span = "Account"
                        });
                });

            modelBuilder.Entity("Lab2.Models.Menu", b =>
                {
                    b.HasOne("Lab2.Models.ParentMenu", "ParentMenu")
                        .WithMany("Menus")
                        .HasForeignKey("ParentMenuId");

                    b.Navigation("ParentMenu");
                });

            modelBuilder.Entity("Lab2.Models.ParentMenu", b =>
                {
                    b.Navigation("Menus");
                });
#pragma warning restore 612, 618
        }
    }
}