using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations.ApplicationIdentity
{
    /// <inheritdoc />
    public partial class SeedRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "138e8e76-4d1a-4097-83d3-1e4f9f1c2e6b", null, "Manager", "MANAGER" },
                    { "21ba7501-d5b1-4011-8e3b-9f6aeb6c8fc2", null, "Admin", "ADMIN" },
                    { "60fb36d8-ad54-4043-88be-3dcac7ffa861", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "138e8e76-4d1a-4097-83d3-1e4f9f1c2e6b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21ba7501-d5b1-4011-8e3b-9f6aeb6c8fc2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "60fb36d8-ad54-4043-88be-3dcac7ffa861");
        }
    }
}
