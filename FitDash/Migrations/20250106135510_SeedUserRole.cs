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
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "MealDate" },
                values: new object[] { new DateTime(2025, 1, 6, 13, 55, 8, 930, DateTimeKind.Utc).AddTicks(1133), new DateTime(2025, 1, 6, 13, 55, 8, 930, DateTimeKind.Utc).AddTicks(1134), new DateTime(2025, 1, 6, 13, 55, 8, 930, DateTimeKind.Utc).AddTicks(1133) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "MealDate" },
                values: new object[] { new DateTime(2025, 1, 6, 13, 55, 8, 930, DateTimeKind.Utc).AddTicks(1141), new DateTime(2025, 1, 6, 13, 55, 8, 930, DateTimeKind.Utc).AddTicks(1141), new DateTime(2025, 1, 6, 13, 55, 8, 930, DateTimeKind.Utc).AddTicks(1140) });

            migrationBuilder.UpdateData(
                table: "ProgressTrackers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRecorded",
                value: new DateTime(2025, 1, 6, 13, 55, 8, 930, DateTimeKind.Utc).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "ProgressTrackers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateRecorded",
                value: new DateTime(2025, 1, 6, 13, 55, 8, 930, DateTimeKind.Utc).AddTicks(1346));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 6, 21, 55, 8, 930, DateTimeKind.Local).AddTicks(497), new DateTime(2025, 1, 6, 21, 55, 8, 930, DateTimeKind.Local).AddTicks(521) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 6, 21, 55, 8, 930, DateTimeKind.Local).AddTicks(526), new DateTime(2025, 1, 6, 21, 55, 8, 930, DateTimeKind.Local).AddTicks(528) });

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "WorkoutDate" },
                values: new object[] { new DateTime(2025, 1, 6, 13, 55, 8, 930, DateTimeKind.Utc).AddTicks(917), new DateTime(2025, 1, 6, 13, 55, 8, 930, DateTimeKind.Utc).AddTicks(918), new DateTime(2025, 1, 6, 13, 55, 8, 930, DateTimeKind.Utc).AddTicks(916) });

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "WorkoutDate" },
                values: new object[] { new DateTime(2025, 1, 6, 13, 55, 8, 930, DateTimeKind.Utc).AddTicks(922), new DateTime(2025, 1, 6, 13, 55, 8, 930, DateTimeKind.Utc).AddTicks(923), new DateTime(2025, 1, 6, 13, 55, 8, 930, DateTimeKind.Utc).AddTicks(921) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "MealDate" },
                values: new object[] { new DateTime(2025, 1, 6, 12, 37, 43, 442, DateTimeKind.Utc).AddTicks(4166), new DateTime(2025, 1, 6, 12, 37, 43, 442, DateTimeKind.Utc).AddTicks(4166), new DateTime(2025, 1, 6, 12, 37, 43, 442, DateTimeKind.Utc).AddTicks(4163) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "MealDate" },
                values: new object[] { new DateTime(2025, 1, 6, 12, 37, 43, 442, DateTimeKind.Utc).AddTicks(4173), new DateTime(2025, 1, 6, 12, 37, 43, 442, DateTimeKind.Utc).AddTicks(4173), new DateTime(2025, 1, 6, 12, 37, 43, 442, DateTimeKind.Utc).AddTicks(4172) });

            migrationBuilder.UpdateData(
                table: "ProgressTrackers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRecorded",
                value: new DateTime(2025, 1, 6, 12, 37, 43, 442, DateTimeKind.Utc).AddTicks(4374));

            migrationBuilder.UpdateData(
                table: "ProgressTrackers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateRecorded",
                value: new DateTime(2025, 1, 6, 12, 37, 43, 442, DateTimeKind.Utc).AddTicks(4380));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 6, 20, 37, 43, 442, DateTimeKind.Local).AddTicks(3537), new DateTime(2025, 1, 6, 20, 37, 43, 442, DateTimeKind.Local).AddTicks(3557) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 6, 20, 37, 43, 442, DateTimeKind.Local).AddTicks(3563), new DateTime(2025, 1, 6, 20, 37, 43, 442, DateTimeKind.Local).AddTicks(3564) });

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "WorkoutDate" },
                values: new object[] { new DateTime(2025, 1, 6, 12, 37, 43, 442, DateTimeKind.Utc).AddTicks(3944), new DateTime(2025, 1, 6, 12, 37, 43, 442, DateTimeKind.Utc).AddTicks(3945), new DateTime(2025, 1, 6, 12, 37, 43, 442, DateTimeKind.Utc).AddTicks(3943) });

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "WorkoutDate" },
                values: new object[] { new DateTime(2025, 1, 6, 12, 37, 43, 442, DateTimeKind.Utc).AddTicks(3949), new DateTime(2025, 1, 6, 12, 37, 43, 442, DateTimeKind.Utc).AddTicks(3950), new DateTime(2025, 1, 6, 12, 37, 43, 442, DateTimeKind.Utc).AddTicks(3948) });
        }
    }
}
