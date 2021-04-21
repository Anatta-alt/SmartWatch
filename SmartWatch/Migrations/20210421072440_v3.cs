using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartWatch.Migrations
{
    public partial class v3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("342f5414-1c29-44ce-abff-2bbd8ea21d0f"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("7d90b808-6a4f-4d1e-9d26-290db4c7fab9"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("93258f2b-b086-478a-b021-47d353c4e63c"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("dbd378bb-78b7-4c9a-b494-ce3012f14ae1"));

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("1b9b698e-6142-4767-88df-7333bb2c7abf"), "user" },
                    { new Guid("4d7ecbda-db3d-4ca5-a23b-82faf2b8cb90"), "Manager" },
                    { new Guid("46737cc7-297d-41d9-9a98-66b72392bce0"), "Admin" },
                    { new Guid("a32f1be2-fc4b-4c39-8db8-a8d5be1b03ea"), "Developer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("1b9b698e-6142-4767-88df-7333bb2c7abf"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("46737cc7-297d-41d9-9a98-66b72392bce0"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("4d7ecbda-db3d-4ca5-a23b-82faf2b8cb90"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("a32f1be2-fc4b-4c39-8db8-a8d5be1b03ea"));

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("7d90b808-6a4f-4d1e-9d26-290db4c7fab9"), "user" },
                    { new Guid("342f5414-1c29-44ce-abff-2bbd8ea21d0f"), "Manager" },
                    { new Guid("93258f2b-b086-478a-b021-47d353c4e63c"), "Admin" },
                    { new Guid("dbd378bb-78b7-4c9a-b494-ce3012f14ae1"), "Developer" }
                });
        }
    }
}
