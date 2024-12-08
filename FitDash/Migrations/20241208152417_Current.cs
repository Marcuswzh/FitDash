using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitDash.Migrations
{
    /// <inheritdoc />
    public partial class Current : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Height = table.Column<float>(type: "real", nullable: true),
                    Weight = table.Column<float>(type: "real", nullable: true),
                    ActivityLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Meals",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    MealName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calories = table.Column<float>(type: "real", nullable: false),
                    Proteins = table.Column<float>(type: "real", nullable: true),
                    Fats = table.Column<float>(type: "real", nullable: true),
                    Carbs = table.Column<float>(type: "real", nullable: true),
                    MealDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Meals_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProgressTrackers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    DateRecorded = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Weight = table.Column<float>(type: "real", nullable: false),
                    BMI = table.Column<float>(type: "real", nullable: true),
                    BodyFatPercentage = table.Column<float>(type: "real", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgressTrackers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProgressTrackers_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Workouts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserID = table.Column<int>(type: "int", nullable: false),
                    WorkoutName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false),
                    CaloriesBurned = table.Column<float>(type: "real", nullable: true),
                    WorkoutDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workouts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Workouts_User_UserID",
                        column: x => x.UserID,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "ActivityLevel", "CreatedBy", "DateCreated", "DateOfBirth", "DateUpdated", "Email", "Gender", "Height", "Name", "Password", "UpdatedBy", "Weight" },
                values: new object[,]
                {
                    { 1, "Active", null, new DateTime(2024, 12, 8, 23, 24, 16, 471, DateTimeKind.Local).AddTicks(9138), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 23, 24, 16, 471, DateTimeKind.Local).AddTicks(9155), "johndoe@example.com", "Male", 175f, "John Doe", "P@ssword1", null, 70f },
                    { 2, "Active", null, new DateTime(2024, 12, 8, 23, 24, 16, 471, DateTimeKind.Local).AddTicks(9159), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 23, 24, 16, 471, DateTimeKind.Local).AddTicks(9159), "janedoe@example.com", "Male", 175f, "Jane Doe", "P@ssword1", null, 70f }
                });

            migrationBuilder.InsertData(
                table: "Meals",
                columns: new[] { "Id", "Calories", "Carbs", "CreatedBy", "DateCreated", "DateUpdated", "Fats", "MealDate", "MealName", "Proteins", "UpdatedBy", "UserID" },
                values: new object[,]
                {
                    { 1, 400f, 50f, "System", new DateTime(2024, 12, 8, 15, 24, 16, 471, DateTimeKind.Utc).AddTicks(9536), new DateTime(2024, 12, 8, 15, 24, 16, 471, DateTimeKind.Utc).AddTicks(9537), 10f, new DateTime(2024, 12, 8, 15, 24, 16, 471, DateTimeKind.Utc).AddTicks(9536), "Breakfast", 25f, "System", 1 },
                    { 2, 600f, 70f, "System", new DateTime(2024, 12, 8, 15, 24, 16, 471, DateTimeKind.Utc).AddTicks(9540), new DateTime(2024, 12, 8, 15, 24, 16, 471, DateTimeKind.Utc).AddTicks(9540), 15f, new DateTime(2024, 12, 8, 15, 24, 16, 471, DateTimeKind.Utc).AddTicks(9539), "Lunch", 40f, "System", 2 }
                });

            migrationBuilder.InsertData(
                table: "ProgressTrackers",
                columns: new[] { "Id", "BMI", "BodyFatPercentage", "CreatedBy", "DateCreated", "DateRecorded", "DateUpdated", "UpdatedBy", "UserID", "Weight" },
                values: new object[,]
                {
                    { 1, 24.5f, 20f, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 15, 24, 16, 471, DateTimeKind.Utc).AddTicks(9643), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 70f },
                    { 2, 22f, 18f, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 15, 24, 16, 471, DateTimeKind.Utc).AddTicks(9645), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 60f }
                });

            migrationBuilder.InsertData(
                table: "Workouts",
                columns: new[] { "Id", "CaloriesBurned", "CreatedBy", "DateCreated", "DateUpdated", "Duration", "UpdatedBy", "UserID", "WorkoutDate", "WorkoutName" },
                values: new object[,]
                {
                    { 1, 300f, null, new DateTime(2024, 12, 8, 15, 24, 16, 471, DateTimeKind.Utc).AddTicks(9409), new DateTime(2024, 12, 8, 15, 24, 16, 471, DateTimeKind.Utc).AddTicks(9409), 30, null, 1, new DateTime(2024, 12, 8, 15, 24, 16, 471, DateTimeKind.Utc).AddTicks(9408), "Cardio" },
                    { 2, 400f, null, new DateTime(2024, 12, 8, 15, 24, 16, 471, DateTimeKind.Utc).AddTicks(9411), new DateTime(2024, 12, 8, 15, 24, 16, 471, DateTimeKind.Utc).AddTicks(9412), 45, null, 2, new DateTime(2024, 12, 8, 15, 24, 16, 471, DateTimeKind.Utc).AddTicks(9411), "Strength Training" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Meals_UserID",
                table: "Meals",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_ProgressTrackers_UserID",
                table: "ProgressTrackers",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_Workouts_UserID",
                table: "Workouts",
                column: "UserID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meals");

            migrationBuilder.DropTable(
                name: "ProgressTrackers");

            migrationBuilder.DropTable(
                name: "Workouts");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
