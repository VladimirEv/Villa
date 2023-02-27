using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedVillaTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 2, 27, 15, 6, 28, 534, DateTimeKind.Local).AddTicks(3594), "Master bedroom of 130 m2 with open air bathroom including separated rain shower, bath tub for 2 and completed wardrobe · 4 suites built and designed", "https://www.google.com/search?q=Details+for+Villa&rlz=1C1GCEA_enBY909BY909&oq=Details+for+Villa&aqs=chrome..69i57j0i15i22i30i625j0i15i22i30j0i22i30j0i15i22i30.5191j0j7&sourceid=chrome&ie=UTF-8#imgrc=t_-GUyvZjXGWBM", "Royal villa", 5, 200.0, 550, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(2023, 2, 27, 15, 6, 28, 534, DateTimeKind.Local).AddTicks(3604), "Master bedroom of 180 m2 with open air bathroom including separated rain shower, bath tub for 3 and completed wardrobe · 4 suites built and designed", "https://www.google.com/search?q=Details+for+Villa&rlz=1C1GCEA_enBY909BY909&oq=Details+for+Villa&aqs=chrome..69i57j0i15i22i30i625j0i15i22i30j0i22i30j0i15i22i30.5191j0j7&sourceid=chrome&ie=UTF-8#imgrc=t_-GUyvZjXGWBM", "Jordan villa", 7, 250.0, 650, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", new DateTime(2023, 2, 27, 15, 6, 28, 534, DateTimeKind.Local).AddTicks(3606), "Master bedroom of 180 m2 with open air bathroom including separated rain shower, bath tub for 5 and completed wardrobe · 7 suites built and designed", "https://www.google.com/search?q=Details+for+Villa&rlz=1C1GCEA_enBY909BY909&oq=Details+for+Villa&aqs=chrome..69i57j0i15i22i30i625j0i15i22i30j0i22i30j0i15i22i30.5191j0j7&sourceid=chrome&ie=UTF-8#imgrc=t_-GUyvZjXGWBM", "Golden Sands villa", 12, 450.0, 850, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
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
        }
    }
}
