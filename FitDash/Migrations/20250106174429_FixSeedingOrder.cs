using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitDash.Migrations
{
    /// <inheritdoc />
    public partial class FixSeedingOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b46a5376-878a-4832-9658-8b20718c3308", "AQAAAAIAAYagAAAAEOU5E+RSVD8L2DP4A8H4irH//Ad1hS9ZrzaGu5PPvo+AqnZ/99X+dW32DuoFK9b8/w==", "e31906f1-a494-4fe6-80a9-0e09677daa0f" });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "MealDate" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 44, 27, 729, DateTimeKind.Utc).AddTicks(6692), new DateTime(2025, 1, 6, 17, 44, 27, 729, DateTimeKind.Utc).AddTicks(6693), new DateTime(2025, 1, 6, 17, 44, 27, 729, DateTimeKind.Utc).AddTicks(6691) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "MealDate" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 44, 27, 729, DateTimeKind.Utc).AddTicks(6699), new DateTime(2025, 1, 6, 17, 44, 27, 729, DateTimeKind.Utc).AddTicks(6700), new DateTime(2025, 1, 6, 17, 44, 27, 729, DateTimeKind.Utc).AddTicks(6698) });

            migrationBuilder.UpdateData(
                table: "ProgressTrackers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRecorded",
                value: new DateTime(2025, 1, 6, 17, 44, 27, 729, DateTimeKind.Utc).AddTicks(6931));

            migrationBuilder.UpdateData(
                table: "ProgressTrackers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateRecorded",
                value: new DateTime(2025, 1, 6, 17, 44, 27, 729, DateTimeKind.Utc).AddTicks(6936));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 7, 1, 44, 27, 729, DateTimeKind.Local).AddTicks(6189), new DateTime(2025, 1, 7, 1, 44, 27, 729, DateTimeKind.Local).AddTicks(6226) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 7, 1, 44, 27, 729, DateTimeKind.Local).AddTicks(6233), new DateTime(2025, 1, 7, 1, 44, 27, 729, DateTimeKind.Local).AddTicks(6235) });

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "WorkoutDate" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 44, 27, 729, DateTimeKind.Utc).AddTicks(6461), new DateTime(2025, 1, 6, 17, 44, 27, 729, DateTimeKind.Utc).AddTicks(6462), new DateTime(2025, 1, 6, 17, 44, 27, 729, DateTimeKind.Utc).AddTicks(6460) });

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "WorkoutDate" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 44, 27, 729, DateTimeKind.Utc).AddTicks(6466), new DateTime(2025, 1, 6, 17, 44, 27, 729, DateTimeKind.Utc).AddTicks(6467), new DateTime(2025, 1, 6, 17, 44, 27, 729, DateTimeKind.Utc).AddTicks(6465) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b90cb17a-4e8b-49f7-a0a6-6a00a78a3e5f", "AQAAAAIAAYagAAAAEDcP9fk9hpBiZtHC7skNy8pW5gYj47cTwzDWoNXKmPdSN5Da/tq1jFtuiRS+K2xyoA==", "8e3ff207-28c1-4eda-b959-07e624cd2113" });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "MealDate" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 43, 20, 601, DateTimeKind.Utc).AddTicks(7862), new DateTime(2025, 1, 6, 17, 43, 20, 601, DateTimeKind.Utc).AddTicks(7863), new DateTime(2025, 1, 6, 17, 43, 20, 601, DateTimeKind.Utc).AddTicks(7860) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "MealDate" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 43, 20, 601, DateTimeKind.Utc).AddTicks(7874), new DateTime(2025, 1, 6, 17, 43, 20, 601, DateTimeKind.Utc).AddTicks(7875), new DateTime(2025, 1, 6, 17, 43, 20, 601, DateTimeKind.Utc).AddTicks(7873) });

            migrationBuilder.UpdateData(
                table: "ProgressTrackers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRecorded",
                value: new DateTime(2025, 1, 6, 17, 43, 20, 601, DateTimeKind.Utc).AddTicks(8110));

            migrationBuilder.UpdateData(
                table: "ProgressTrackers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateRecorded",
                value: new DateTime(2025, 1, 6, 17, 43, 20, 601, DateTimeKind.Utc).AddTicks(8119));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 7, 1, 43, 20, 601, DateTimeKind.Local).AddTicks(7290), new DateTime(2025, 1, 7, 1, 43, 20, 601, DateTimeKind.Local).AddTicks(7324) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 7, 1, 43, 20, 601, DateTimeKind.Local).AddTicks(7332), new DateTime(2025, 1, 7, 1, 43, 20, 601, DateTimeKind.Local).AddTicks(7334) });

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "WorkoutDate" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 43, 20, 601, DateTimeKind.Utc).AddTicks(7597), new DateTime(2025, 1, 6, 17, 43, 20, 601, DateTimeKind.Utc).AddTicks(7597), new DateTime(2025, 1, 6, 17, 43, 20, 601, DateTimeKind.Utc).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "WorkoutDate" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 43, 20, 601, DateTimeKind.Utc).AddTicks(7602), new DateTime(2025, 1, 6, 17, 43, 20, 601, DateTimeKind.Utc).AddTicks(7603), new DateTime(2025, 1, 6, 17, 43, 20, 601, DateTimeKind.Utc).AddTicks(7601) });
        }
    }
}
