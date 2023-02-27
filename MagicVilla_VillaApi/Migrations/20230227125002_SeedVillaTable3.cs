using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2023, 2, 27, 15, 50, 2, 112, DateTimeKind.Local).AddTicks(2097), "Master bedroom of 480 m2 with open air bathroom including separated rain shower, bath tub for 5 and completed wardrobe · 4 suites built and designed" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2023, 2, 27, 15, 50, 2, 112, DateTimeKind.Local).AddTicks(2098), "Master bedroom of 580 m2 with open air bathroom including separated rain shower, bath tub for 7 and completed wardrobe · 4 suites built and designed" });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 2, 27, 15, 50, 2, 112, DateTimeKind.Local).AddTicks(2082), "Master bedroom of 230 m2 with open air bathroom including separated rain shower, bath tub for 2 and completed wardrobe · 4 suites built and designed", "https://www.houzz.ru/foto/castellina-1272-model-home-phvw-vp~22592068", "Royal villa", 5, 200.0, 350, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(2023, 2, 27, 15, 50, 2, 112, DateTimeKind.Local).AddTicks(2094), "Master bedroom of 280 m2 with open air bathroom including separated rain shower, bath tub for 3 and completed wardrobe · 5 suites built and designed", "https://www.houzz.ru/foto/private-residence-the-estuary-naples-fl-phvw-vp~6599751", "Viki villa", 7, 450.0, 570, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", new DateTime(2023, 2, 27, 15, 50, 2, 112, DateTimeKind.Local).AddTicks(2096), "Master bedroom of 370 m2 with open air bathroom including separated rain shower, bath tub for 4 and completed wardrobe · 4 suites built and designed", "https://www.google.com/search?q=Details+for+Villa&rlz=1C1GCEA_enBY909BY909&oq=Details+for+Villa&aqs=chrome..69i57j0i15i22i30i625j0i15i22i30j0i22i30j0i15i22i30.5191j0j7&sourceid=chrome&ie=UTF-8#imgrc=t_-GUyvZjXGWBM", "Golden Sand villa", 11, 550.0, 750, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2023, 2, 27, 15, 9, 50, 32, DateTimeKind.Local).AddTicks(3927), "Master bedroom of 230 m2 with open air bathroom including separated rain shower, bath tub for 2 and completed wardrobe · 4 suites built and designed" });

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Details" },
                values: new object[] { new DateTime(2023, 2, 27, 15, 9, 50, 32, DateTimeKind.Local).AddTicks(3938), "Master bedroom of 380 m2 with open air bathroom including separated rain shower, bath tub for 3 and completed wardrobe · 4 suites built and designed" });
        }
    }
}
