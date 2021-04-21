using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartWatch.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("531e713a-f058-4797-94d5-f16285f30502"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("57e0bf9f-4625-4e39-a35a-a29d6bf7c910"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("62bfb6f0-98b7-43ec-a1ec-0db49dbbad03"));

            migrationBuilder.DeleteData(
                schema: "auth",
                table: "Role",
                keyColumn: "Id",
                keyValue: new Guid("f5d39aee-3f36-4436-9aba-ec42628928f1"));

            migrationBuilder.CreateTable(
                name: "BrandWatchs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WatchName = table.Column<string>(maxLength: 50, nullable: false),
                    Price = table.Column<int>(nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    UpdateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrandWatchs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ColorWatchs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Color = table.Column<string>(maxLength: 50, nullable: false),
                    CreateDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColorWatchs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DetailWatchs",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ColorId = table.Column<int>(nullable: false),
                    ColorWatchId = table.Column<int>(nullable: true),
                    CreateDate = table.Column<DateTime>(nullable: false),
                    BrandWatchId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DetailWatchs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DetailWatchs_BrandWatchs_BrandWatchId",
                        column: x => x.BrandWatchId,
                        principalTable: "BrandWatchs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DetailWatchs_ColorWatchs_ColorWatchId",
                        column: x => x.ColorWatchId,
                        principalTable: "ColorWatchs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_DetailWatchs_BrandWatchId",
                table: "DetailWatchs",
                column: "BrandWatchId");

            migrationBuilder.CreateIndex(
                name: "IX_DetailWatchs_ColorWatchId",
                table: "DetailWatchs",
                column: "ColorWatchId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DetailWatchs");

            migrationBuilder.DropTable(
                name: "BrandWatchs");

            migrationBuilder.DropTable(
                name: "ColorWatchs");

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
                    { new Guid("57e0bf9f-4625-4e39-a35a-a29d6bf7c910"), "user" },
                    { new Guid("f5d39aee-3f36-4436-9aba-ec42628928f1"), "Manager" },
                    { new Guid("531e713a-f058-4797-94d5-f16285f30502"), "Admin" },
                    { new Guid("62bfb6f0-98b7-43ec-a1ec-0db49dbbad03"), "Developer" }
                });
        }
    }
}
