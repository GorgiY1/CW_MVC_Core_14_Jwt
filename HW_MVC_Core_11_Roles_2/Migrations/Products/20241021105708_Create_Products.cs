using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HW_MVC_Core_11_Roles_2.Migrations.Products
{
    /// <inheritdoc />
    public partial class Create_Products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "products");

            migrationBuilder.CreateTable(
                name: "Products",
                schema: "products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                schema: "products",
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("19bc4394-0a11-488e-aa56-19197159760e"), "10-inch tablet with high-resolution display", "Tablet", 299.99m },
                    { new Guid("2462991a-af65-4aa1-afb8-378dca7ea7cf"), "1TB external hard drive for data backup", "External Hard Drive", 89.99m },
                    { new Guid("38ec0de2-ffbf-44df-ab3c-c02ddf1b4013"), "All-in-one color printer with Wi-Fi support", "Printer", 149.99m },
                    { new Guid("40ab9282-07da-48c7-9425-71e456adcd4b"), "Noise-cancelling over-ear headphones", "Headphones", 79.99m },
                    { new Guid("62dbb15e-dee8-4c49-b710-7b70d6d8b655"), "Mechanical keyboard with RGB backlight", "Keyboard", 49.99m },
                    { new Guid("8807c933-f3bc-4243-81ae-8fea13f469f5"), "1080p HD webcam with built-in microphone", "Webcam", 59.99m },
                    { new Guid("ac6dbf0c-753b-441d-8a9c-add7843a9d02"), "High performance laptop for gaming and work", "Laptop", 999.99m },
                    { new Guid("aca44239-cb31-4b33-9190-f59a5ab88018"), "Wireless optical mouse with ergonomic design", "Mouse", 29.99m },
                    { new Guid("e80c0dcc-10d0-40c6-89dd-d55d988fe6e6"), "Latest smartphone with 5G connectivity", "Smartphone", 599.99m },
                    { new Guid("eac29f27-c2d2-4986-9bba-d23d85ca2e02"), "27-inch 4K UHD monitor for professional use", "Monitor", 199.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products",
                schema: "products");
        }
    }
}
