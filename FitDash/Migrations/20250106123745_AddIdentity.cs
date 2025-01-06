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
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
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
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
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
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "MealDate" },
                values: new object[] { new DateTime(2025, 1, 6, 3, 45, 21, 222, DateTimeKind.Utc).AddTicks(833), new DateTime(2025, 1, 6, 3, 45, 21, 222, DateTimeKind.Utc).AddTicks(834), new DateTime(2025, 1, 6, 3, 45, 21, 222, DateTimeKind.Utc).AddTicks(831) });

            migrationBuilder.UpdateData(
                table: "Meals",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "MealDate" },
                values: new object[] { new DateTime(2025, 1, 6, 3, 45, 21, 222, DateTimeKind.Utc).AddTicks(840), new DateTime(2025, 1, 6, 3, 45, 21, 222, DateTimeKind.Utc).AddTicks(841), new DateTime(2025, 1, 6, 3, 45, 21, 222, DateTimeKind.Utc).AddTicks(840) });

            migrationBuilder.UpdateData(
                table: "ProgressTrackers",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateRecorded",
                value: new DateTime(2025, 1, 6, 3, 45, 21, 222, DateTimeKind.Utc).AddTicks(1006));

            migrationBuilder.UpdateData(
                table: "ProgressTrackers",
                keyColumn: "Id",
                keyValue: 2,
                column: "DateRecorded",
                value: new DateTime(2025, 1, 6, 3, 45, 21, 222, DateTimeKind.Utc).AddTicks(1011));

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 6, 11, 45, 21, 222, DateTimeKind.Local).AddTicks(200), new DateTime(2025, 1, 6, 11, 45, 21, 222, DateTimeKind.Local).AddTicks(222) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 1, 6, 11, 45, 21, 222, DateTimeKind.Local).AddTicks(228), new DateTime(2025, 1, 6, 11, 45, 21, 222, DateTimeKind.Local).AddTicks(229) });

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated", "WorkoutDate" },
                values: new object[] { new DateTime(2025, 1, 6, 3, 45, 21, 222, DateTimeKind.Utc).AddTicks(605), new DateTime(2025, 1, 6, 3, 45, 21, 222, DateTimeKind.Utc).AddTicks(606), new DateTime(2025, 1, 6, 3, 45, 21, 222, DateTimeKind.Utc).AddTicks(604) });

            migrationBuilder.UpdateData(
                table: "Workouts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated", "WorkoutDate" },
                values: new object[] { new DateTime(2025, 1, 6, 3, 45, 21, 222, DateTimeKind.Utc).AddTicks(612), new DateTime(2025, 1, 6, 3, 45, 21, 222, DateTimeKind.Utc).AddTicks(612), new DateTime(2025, 1, 6, 3, 45, 21, 222, DateTimeKind.Utc).AddTicks(611) });
        }
    }
}
