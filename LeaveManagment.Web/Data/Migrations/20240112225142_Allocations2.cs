using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagment.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class Allocations2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07e65fb8-2e67-4912-807b-db9c5578c15a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "189cb2b8-9323-4813-ba33-5e154163190f", "AQAAAAIAAYagAAAAEIpQCmPZYAb3FnjRGKbhtBC53GCHmzHQfO+xhp1M819vtDQT3sUqS9xyhpzmY+3MDg==", "26dbb82f-4ba2-4175-9838-0d34df2d41ab" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f52402a2-4558-4ec2-ac2f-81d33d5e55fd",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15eaaeb9-5dc6-4586-b12c-7de8d04d6b3a", "AQAAAAIAAYagAAAAELDAdrke31ZYblRhenvwbvR6upHquOum2diCmR0LX7QmGJw/A+0ERiN9weoiw+WlgA==", "9234d927-88b0-4bf9-8e01-c3804f8fbab7" });
        }
    }
}
