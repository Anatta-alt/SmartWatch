using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartWatch.Migrations
{
    public partial class v4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("6b643a46-be2d-4b0d-b270-d15f968359a8"), "user" },
                    { new Guid("b75997b0-80a0-4e0f-be6c-bf9396ded0d9"), "Manager" },
                    { new Guid("ca78857f-bc71-41bf-bddb-65291210c33d"), "Admin" },
                    { new Guid("aa75e24b-5188-4012-8cb8-6e2703231ce1"), "Developer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("6b643a46-be2d-4b0d-b270-d15f968359a8"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("aa75e24b-5188-4012-8cb8-6e2703231ce1"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("b75997b0-80a0-4e0f-be6c-bf9396ded0d9"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("ca78857f-bc71-41bf-bddb-65291210c33d"));

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
    }
}
