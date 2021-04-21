using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartWatch.Migrations
{
    public partial class v6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailWatchs_BrandWatchs_BrandWatchId",
                table: "DetailWatchs");

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

            migrationBuilder.AlterColumn<int>(
                name: "BrandWatchId",
                table: "DetailWatchs",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("302637f9-7f18-4c4f-8c4f-cd065c5f8a82"), "user" },
                    { new Guid("9b7000b6-7bda-4ca4-a4f5-3ac4bb3b9643"), "Manager" },
                    { new Guid("94e20d01-3a87-4f90-b4c0-7376f0445be5"), "Admin" },
                    { new Guid("aedbb3ed-c300-4e05-baae-e06073d74808"), "Developer" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_DetailWatchs_BrandWatchs_BrandWatchId",
                table: "DetailWatchs",
                column: "BrandWatchId",
                principalTable: "BrandWatchs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DetailWatchs_BrandWatchs_BrandWatchId",
                table: "DetailWatchs");

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("302637f9-7f18-4c4f-8c4f-cd065c5f8a82"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("94e20d01-3a87-4f90-b4c0-7376f0445be5"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("9b7000b6-7bda-4ca4-a4f5-3ac4bb3b9643"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("aedbb3ed-c300-4e05-baae-e06073d74808"));

            migrationBuilder.AlterColumn<int>(
                name: "BrandWatchId",
                table: "DetailWatchs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "DetailWatchId",
                table: "BrandWatchs",
                type: "int",
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

            migrationBuilder.AddForeignKey(
                name: "FK_DetailWatchs_BrandWatchs_BrandWatchId",
                table: "DetailWatchs",
                column: "BrandWatchId",
                principalTable: "BrandWatchs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
