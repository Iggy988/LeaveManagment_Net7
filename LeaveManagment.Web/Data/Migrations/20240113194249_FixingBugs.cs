using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixingBugs : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07e65fb8-2e67-4912-807b-db9c5578c15a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e91b1826-5665-473f-b37d-c186b0adb05b", "AQAAAAIAAYagAAAAEDByO6pIWQxE73LIa/YDwjKTrVoKuBPTNTXmInZbNgIpilTuZEQVJIDWpBMzWnuNqw==", "f9ed5833-206a-49fb-9ec3-d65e6aa9598a" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f52402a2-4558-4ec2-ac2f-81d33d5e55fd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74843998-699a-4e0b-a2c7-37eb5a65573d", "AQAAAAIAAYagAAAAEPQHnIQqv3fH9QW+1k6HPc8+ejWLATsu0wTJma8cP0ngZL2oN95dCl4s0b4x2e7fiQ==", "d1e0924a-93c9-40f1-8375-70311bcd90c0" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07e65fb8-2e67-4912-807b-db9c5578c15a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "76c84e15-9f47-4954-8b9c-317ccff24330", "AQAAAAIAAYagAAAAEIx9Q5oWXplvfmNtipofNV5/xbzha8PVf87++A7NjrpBLaTfXaTE7ggTPh1Ry4vypw==", "8a02c391-a4b4-4cc3-aebb-3cb35b056a4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f52402a2-4558-4ec2-ac2f-81d33d5e55fd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21932ff2-42d2-44e0-8285-0df3aa24f4b5", "AQAAAAIAAYagAAAAEHjTn3lQEnJ3ozEuS+zE1Xw5sm5Mypj6zgkR8rIOsx8EyDHFEIS+zieH/MRMUeQejQ==", "9b8642c6-6596-4160-9055-7b88addf9c13" });
        }
    }
}
