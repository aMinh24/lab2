using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab2.Migrations
{
    /// <inheritdoc />
    public partial class create_path : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Instructors_InstructorId",
                table: "Courses");

            migrationBuilder.AddColumn<int>(
                name: "PathId",
                table: "Courses",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "TypePaths",
                columns: table => new
                {
                    TypePathId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Path = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypePaths", x => x.TypePathId);
                });

            migrationBuilder.CreateTable(
                name: "Paths",
                columns: table => new
                {
                    PathId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TypePathId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paths", x => x.PathId);
                    table.ForeignKey(
                        name: "FK_Paths_TypePaths_TypePathId",
                        column: x => x.TypePathId,
                        principalTable: "TypePaths",
                        principalColumn: "TypePathId");
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Courses_PathId",
                table: "Courses",
                column: "PathId");

            migrationBuilder.CreateIndex(
                name: "IX_Paths_TypePathId",
                table: "Paths",
                column: "TypePathId");

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Instructors_InstructorId",
                table: "Courses",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "InstructorId",
                onDelete: ReferentialAction.NoAction);

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Paths_PathId",
                table: "Courses",
                column: "PathId",
                principalTable: "Paths",
                principalColumn: "PathId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Instructors_InstructorId",
                table: "Courses");

            migrationBuilder.DropForeignKey(
                name: "FK_Courses_Paths_PathId",
                table: "Courses");

            migrationBuilder.DropTable(
                name: "Paths");

            migrationBuilder.DropTable(
                name: "TypePaths");

            migrationBuilder.DropIndex(
                name: "IX_Courses_PathId",
                table: "Courses");

            migrationBuilder.DropColumn(
                name: "PathId",
                table: "Courses");

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9203));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9212));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9215));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9296));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9299));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 6,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9301));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 7,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9303));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 8,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9305));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 9,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9307));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 10,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9309));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 11,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9311));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 12,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9313));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 13,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9316));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 14,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9318));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 15,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9320));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 16,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9322));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 17,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9324));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 18,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9326));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 19,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9328));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 20,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9330));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 21,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 22,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9333));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 23,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 24,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9337));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 25,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 26,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9341));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 27,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 28,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9345));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 29,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9347));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 30,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9349));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 31,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9350));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 32,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 33,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9354));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 34,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 35,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9358));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 38,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 39,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9362));

            migrationBuilder.UpdateData(
                table: "Menus",
                keyColumn: "Id",
                keyValue: 40,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9363));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 3,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9022));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 4,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "ParentMenus",
                keyColumn: "Id",
                keyValue: 5,
                column: "DateBegin",
                value: new DateTime(2024, 11, 1, 11, 26, 22, 906, DateTimeKind.Local).AddTicks(9027));

            migrationBuilder.AddForeignKey(
                name: "FK_Courses_Instructors_InstructorId",
                table: "Courses",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "InstructorId");
        }
    }
}
