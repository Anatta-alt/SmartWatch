using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartWatch.Migrations
{
    public partial class v7 : Migration
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
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                schema: "auth",
                table: "Role",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("29ec6943-e6f4-46bf-a7cb-a8abb72488a9"), "user" },
                    { new Guid("72314e6c-6581-494e-8833-71898e7d2bde"), "Manager" },
                    { new Guid("2287d2ea-7cf7-4542-a7d5-7c4522b44660"), "Admin" },
                    { new Guid("08440487-5527-49ef-9f63-438b2a46864e"), "Developer" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_DetailWatchs_BrandWatchs_BrandWatchId",
                table: "DetailWatchs",
                column: "BrandWatchId",
                principalTable: "BrandWatchs",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
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
                keyValue: new Guid("08440487-5527-49ef-9f63-438b2a46864e"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("2287d2ea-7cf7-4542-a7d5-7c4522b44660"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("29ec6943-e6f4-46bf-a7cb-a8abb72488a9"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("72314e6c-6581-494e-8833-71898e7d2bde"));

            migrationBuilder.AlterColumn<int>(
                name: "BrandWatchId",
                table: "DetailWatchs",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
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
    }
}
