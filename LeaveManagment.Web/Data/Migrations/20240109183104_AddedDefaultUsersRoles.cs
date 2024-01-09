using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddedDefaultUsersRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07e65fb8-2e67-4912-807b-db9c5578c15a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9238e0d6-3045-48af-bc99-3187054f2edd", true, "USER@LOCALHOST.COM", "AQAAAAIAAYagAAAAEIN38klMS48sG7o/AWL2PdKa9cC9qSn6HSvWqHXZf1tlXT6N0Z93DPFck8d4ogRMhg==", "3f867227-1352-4f4c-a43f-30bd6c4334b0", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f52402a2-4558-4ec2-ac2f-81d33d5e55fd",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "9379ba94-16c4-4340-a531-96ce2e19bd30", true, "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEEaI8FIbiMee3bTiC4gZYPPhQg44VY3shcomYxSE94n9kmfeXhoz1KPmtlzslknLAA==", "83a2e39e-3d84-4578-a565-116e21d82fb9", "admin@localhost.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07e65fb8-2e67-4912-807b-db9c5578c15a",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "abeed07f-9e96-4aa0-8a20-2e283793a6e3", false, null, "AQAAAAIAAYagAAAAEKxVUsT/fBTjCtX7RHcCqpzmgWI4ueOZfqX1oDeuLpzOQIYqf0YSHZy/y57Rd29TeA==", "cefb85e9-f7c9-4140-b210-7a98bb3ddf37", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f52402a2-4558-4ec2-ac2f-81d33d5e55fd",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a9e0f8ff-af86-44ae-bfb4-9e528d5deb25", false, null, "AQAAAAIAAYagAAAAEGfzyIADWjoDDGbQRENYYZv7g6zHTP6rlINI+taJSvnQpyPB4TXnldbwGtwAMjXo+w==", "7ed4816c-056f-4cf9-8a2d-3291d0d16fef", null });
        }
    }
}
