using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FitDash.Migrations
{
    /// <inheritdoc />
    public partial class AddIdentity : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62be0a8f-7d4d-496a-b32f-2472d33219b2", "AQAAAAIAAYagAAAAEHQRlOo85FUyKSxF7KenDQYJ7tmiBkos9BHhFzV2wYH10mRDwOr6ZisaiZOrNJ3Ajg==", "dcda2e7d-0e51-42e9-bed5-13e3da8629e2" });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "MealDate" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 34, 55, 142, DateTimeKind.Utc).AddTicks(4129), new DateTime(2025, 1, 6, 17, 34, 55, 142, DateTimeKind.Utc).AddTicks(4150), new DateTime(2025, 1, 6, 17, 34, 55, 142, DateTimeKind.Utc).AddTicks(4127) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "MealDate" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 34, 55, 142, DateTimeKind.Utc).AddTicks(4159), new DateTime(2025, 1, 6, 17, 34, 55, 142, DateTimeKind.Utc).AddTicks(4160), new DateTime(2025, 1, 6, 17, 34, 55, 142, DateTimeKind.Utc).AddTicks(4158) });

            migrationBuilder.UpdateData(
                table: "ProgressTrackers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRecorded",
                value: new DateTime(2025, 1, 6, 17, 34, 55, 142, DateTimeKind.Utc).AddTicks(4515));

            migrationBuilder.UpdateData(
                table: "ProgressTrackers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateRecorded",
                value: new DateTime(2025, 1, 6, 17, 34, 55, 142, DateTimeKind.Utc).AddTicks(4520));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 7, 1, 34, 55, 10, DateTimeKind.Local).AddTicks(48), new DateTime(2025, 1, 7, 1, 34, 55, 10, DateTimeKind.Local).AddTicks(74) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 7, 1, 34, 55, 10, DateTimeKind.Local).AddTicks(81), new DateTime(2025, 1, 7, 1, 34, 55, 10, DateTimeKind.Local).AddTicks(82) });

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "WorkoutDate" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 34, 55, 142, DateTimeKind.Utc).AddTicks(3398), new DateTime(2025, 1, 6, 17, 34, 55, 142, DateTimeKind.Utc).AddTicks(3400), new DateTime(2025, 1, 6, 17, 34, 55, 142, DateTimeKind.Utc).AddTicks(3386) });

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "WorkoutDate" },
                values: new object[] { new DateTime(2025, 1, 6, 17, 34, 55, 142, DateTimeKind.Utc).AddTicks(3408), new DateTime(2025, 1, 6, 17, 34, 55, 142, DateTimeKind.Utc).AddTicks(3409), new DateTime(2025, 1, 6, 17, 34, 55, 142, DateTimeKind.Utc).AddTicks(3407) });
        }
    }
}
