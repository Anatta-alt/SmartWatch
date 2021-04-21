using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartWatch.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "DetailWatchId",
                table: "BrandWatchs",
                nullable: true);

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("38194538-113e-4d2f-8cbe-121a8bcdf6ee"), "user" },
                    { new Guid("463aaab0-3c9d-4bc3-977f-b08a81770290"), "Manager" },
                    { new Guid("0441d1e2-9a0c-44b9-a376-167c6837b271"), "Admin" },
                    { new Guid("759e8c33-a24b-40ff-9d55-e6e238a9328e"), "Developer" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("0441d1e2-9a0c-44b9-a376-167c6837b271"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("38194538-113e-4d2f-8cbe-121a8bcdf6ee"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("463aaab0-3c9d-4bc3-977f-b08a81770290"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("759e8c33-a24b-40ff-9d55-e6e238a9328e"));

            migrationBuilder.DropColumn(
                name: "DetailWatchId",
                table: "BrandWatchs");

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
    }
}
