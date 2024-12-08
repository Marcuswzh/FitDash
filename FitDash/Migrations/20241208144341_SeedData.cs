using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FitDash.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "User",
                columns: new[] { "Id", "ActivityLevel", "CreatedBy", "DateCreated", "DateOfBirth", "DateUpdated", "Email", "Gender", "Height", "Name", "Password", "UpdatedBy", "Weight" },
                values: new object[,]
                {
                    { 1, "Active", null, new DateTime(2024, 12, 8, 22, 43, 41, 250, DateTimeKind.Local).AddTicks(5979), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 22, 43, 41, 250, DateTimeKind.Local).AddTicks(5993), "johndoe@example.com", "Male", 175f, "John Doe", "P@ssword1", null, 70f },
                    { 2, "Active", null, new DateTime(2024, 12, 8, 22, 43, 41, 250, DateTimeKind.Local).AddTicks(5996), new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 22, 43, 41, 250, DateTimeKind.Local).AddTicks(5997), "janedoe@example.com", "Male", 175f, "Jane Doe", "P@ssword1", null, 70f }
                });

            migrationBuilder.InsertData(
                table: "Meal",
                columns: new[] { "Id", "Calories", "Carbs", "CreatedBy", "DateCreated", "DateUpdated", "Fats", "MealDate", "MealName", "Proteins", "UpdatedBy", "UserID" },
                values: new object[,]
                {
                    { 1, 400f, 50f, "System", new DateTime(2024, 12, 8, 14, 43, 41, 250, DateTimeKind.Utc).AddTicks(6327), new DateTime(2024, 12, 8, 14, 43, 41, 250, DateTimeKind.Utc).AddTicks(6327), 10f, new DateTime(2024, 12, 8, 14, 43, 41, 250, DateTimeKind.Utc).AddTicks(6326), "Breakfast", 25f, "System", 1 },
                    { 2, 600f, 70f, "System", new DateTime(2024, 12, 8, 14, 43, 41, 250, DateTimeKind.Utc).AddTicks(6330), new DateTime(2024, 12, 8, 14, 43, 41, 250, DateTimeKind.Utc).AddTicks(6330), 15f, new DateTime(2024, 12, 8, 14, 43, 41, 250, DateTimeKind.Utc).AddTicks(6330), "Lunch", 40f, "System", 2 }
                });

            migrationBuilder.InsertData(
                table: "ProgressTracker",
                columns: new[] { "Id", "BMI", "BodyFatPercentage", "CreatedBy", "DateCreated", "DateRecorded", "DateUpdated", "UpdatedBy", "UserID", "Weight" },
                values: new object[,]
                {
                    { 1, 24.5f, 20f, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 14, 43, 41, 250, DateTimeKind.Utc).AddTicks(6443), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1, 70f },
                    { 2, 22f, 18f, null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 14, 43, 41, 250, DateTimeKind.Utc).AddTicks(6445), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2, 60f }
                });

            migrationBuilder.InsertData(
                table: "Workout",
                columns: new[] { "Id", "CaloriesBurned", "CreatedBy", "DateCreated", "DateUpdated", "Duration", "UpdatedBy", "UserID", "WorkoutDate", "WorkoutName" },
                values: new object[,]
                {
                    { 1, 300f, null, new DateTime(2024, 12, 8, 14, 43, 41, 250, DateTimeKind.Utc).AddTicks(6207), new DateTime(2024, 12, 8, 14, 43, 41, 250, DateTimeKind.Utc).AddTicks(6208), 30, null, 1, new DateTime(2024, 12, 8, 14, 43, 41, 250, DateTimeKind.Utc).AddTicks(6207), "Cardio" },
                    { 2, 400f, null, new DateTime(2024, 12, 8, 14, 43, 41, 250, DateTimeKind.Utc).AddTicks(6210), new DateTime(2024, 12, 8, 14, 43, 41, 250, DateTimeKind.Utc).AddTicks(6211), 45, null, 2, new DateTime(2024, 12, 8, 14, 43, 41, 250, DateTimeKind.Utc).AddTicks(6210), "Strength Training" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Meal",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProgressTracker",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProgressTracker",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Workout",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "User",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
