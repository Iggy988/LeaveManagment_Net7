using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagment.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUserRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "07e65fb7-2o67-4131-807b-db9c5578c15i", null, "User", "USER" },
                    { "07e65fb8-2o67-4912-807b-db9c5578c15i", null, "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "DateOfJoin", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "07e65fb8-2e67-4912-807b-db9c5578c15a", 0, "abeed07f-9e96-4aa0-8a20-2e283793a6e3", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "USER@LOCALHOST.COM", null, "AQAAAAIAAYagAAAAEKxVUsT/fBTjCtX7RHcCqpzmgWI4ueOZfqX1oDeuLpzOQIYqf0YSHZy/y57Rd29TeA==", null, false, "cefb85e9-f7c9-4140-b210-7a98bb3ddf37", null, false, null },
                    { "f52402a2-4558-4ec2-ac2f-81d33d5e55fd", 0, "a9e0f8ff-af86-44ae-bfb4-9e528d5deb25", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAIAAYagAAAAEGfzyIADWjoDDGbQRENYYZv7g6zHTP6rlINI+taJSvnQpyPB4TXnldbwGtwAMjXo+w==", null, false, "7ed4816c-056f-4cf9-8a2d-3291d0d16fef", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "07e65fb7-2o67-4131-807b-db9c5578c15i", "07e65fb8-2e67-4912-807b-db9c5578c15a" },
                    { "07e65fb8-2o67-4912-807b-db9c5578c15i", "f52402a2-4558-4ec2-ac2f-81d33d5e55fd" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "07e65fb7-2o67-4131-807b-db9c5578c15i", "07e65fb8-2e67-4912-807b-db9c5578c15a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "07e65fb8-2o67-4912-807b-db9c5578c15i", "f52402a2-4558-4ec2-ac2f-81d33d5e55fd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07e65fb7-2o67-4131-807b-db9c5578c15i");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07e65fb8-2o67-4912-807b-db9c5578c15i");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07e65fb8-2e67-4912-807b-db9c5578c15a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f52402a2-4558-4ec2-ac2f-81d33d5e55fd");
        }
    }
}
