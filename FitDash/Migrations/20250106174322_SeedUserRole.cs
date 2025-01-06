using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitDash.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce57435f-b513-4f87-9694-7fbd21cdf4ce", "AQAAAAIAAYagAAAAELeF1Pf/AneV0ueaWwWQMo+4i366vlKkov0j4vtQE3Qjv9nEfg7yX0NTq5Sy3vDXYQ==", "755a31ec-f01a-42fd-b63b-65207ab0ff96" });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "MealDate" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 42, 39, 521, DateTimeKind.Utc).AddTicks(4582), new DateTime(2025, 1, 6, 17, 42, 39, 521, DateTimeKind.Utc).AddTicks(4583), new DateTime(2025, 1, 6, 17, 42, 39, 521, DateTimeKind.Utc).AddTicks(4581) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "MealDate" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 42, 39, 521, DateTimeKind.Utc).AddTicks(4593), new DateTime(2025, 1, 6, 17, 42, 39, 521, DateTimeKind.Utc).AddTicks(4594), new DateTime(2025, 1, 6, 17, 42, 39, 521, DateTimeKind.Utc).AddTicks(4592) });

            migrationBuilder.UpdateData(
                table: "ProgressTrackers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRecorded",
                value: new DateTime(2025, 1, 6, 17, 42, 39, 521, DateTimeKind.Utc).AddTicks(5159));

            migrationBuilder.UpdateData(
                table: "ProgressTrackers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateRecorded",
                value: new DateTime(2025, 1, 6, 17, 42, 39, 521, DateTimeKind.Utc).AddTicks(5163));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 7, 1, 42, 39, 521, DateTimeKind.Local).AddTicks(4023), new DateTime(2025, 1, 7, 1, 42, 39, 521, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 7, 1, 42, 39, 521, DateTimeKind.Local).AddTicks(4060), new DateTime(2025, 1, 7, 1, 42, 39, 521, DateTimeKind.Local).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "WorkoutDate" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 42, 39, 521, DateTimeKind.Utc).AddTicks(4320), new DateTime(2025, 1, 6, 17, 42, 39, 521, DateTimeKind.Utc).AddTicks(4321), new DateTime(2025, 1, 6, 17, 42, 39, 521, DateTimeKind.Utc).AddTicks(4318) });

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "WorkoutDate" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 42, 39, 521, DateTimeKind.Utc).AddTicks(4325), new DateTime(2025, 1, 6, 17, 42, 39, 521, DateTimeKind.Utc).AddTicks(4326), new DateTime(2025, 1, 6, 17, 42, 39, 521, DateTimeKind.Utc).AddTicks(4324) });
        }
    }
}
