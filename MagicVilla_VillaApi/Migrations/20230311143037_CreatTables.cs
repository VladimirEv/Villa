using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_VillaApi.Migrations
{
    /// <inheritdoc />
    public partial class CreatTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Villas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Details = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rate = table.Column<double>(type: "float", nullable: false),
                    Occupancy = table.Column<int>(type: "int", nullable: false),
                    Sqft = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Amenity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Villas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "VillaNumbers",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    VillaID = table.Column<int>(type: "int", nullable: false),
                    SpecialDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VillaNumbers", x => x.VillaNo);
                    table.ForeignKey(
                        name: "FK_VillaNumbers_Villas_VillaID",
                        column: x => x.VillaID,
                        principalTable: "Villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "Amenity", "CreatedDate", "Details", "ImageUrl", "Name", "Occupancy", "Rate", "Sqft", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, "", new DateTime(2023, 3, 11, 17, 30, 37, 902, DateTimeKind.Local).AddTicks(6426), "Master bedroom of 230 m2 with open air bathroom including separated rain shower, bath tub for 2 and completed wardrobe · 4 suites built and designed", "https://www.houzz.ru/foto/castellina-1272-model-home-phvw-vp~22592068", "Royal villa", 5, 200.0, 350, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, "", new DateTime(2023, 3, 11, 17, 30, 37, 902, DateTimeKind.Local).AddTicks(6440), "Master bedroom of 280 m2 with open air bathroom including separated rain shower, bath tub for 3 and completed wardrobe · 5 suites built and designed", "https://www.houzz.ru/foto/private-residence-the-estuary-naples-fl-phvw-vp~6599751", "Viki villa", 7, 450.0, 570, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, "", new DateTime(2023, 3, 11, 17, 30, 37, 902, DateTimeKind.Local).AddTicks(6442), "Master bedroom of 370 m2 with open air bathroom including separated rain shower, bath tub for 4 and completed wardrobe · 4 suites built and designed", "https://www.google.com/search?q=Details+for+Villa&rlz=1C1GCEA_enBY909BY909&oq=Details+for+Villa&aqs=chrome..69i57j0i15i22i30i625j0i15i22i30j0i22i30j0i15i22i30.5191j0j7&sourceid=chrome&ie=UTF-8#imgrc=t_-GUyvZjXGWBM", "Golden Sand villa", 11, 550.0, 750, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, "", new DateTime(2023, 3, 11, 17, 30, 37, 902, DateTimeKind.Local).AddTicks(6444), "Master bedroom of 480 m2 with open air bathroom including separated rain shower, bath tub for 5 and completed wardrobe · 4 suites built and designed", "https://www.google.com/search?q=Details+for+Villa&rlz=1C1GCEA_enBY909BY909&oq=Details+for+Villa&aqs=chrome..69i57j0i15i22i30i625j0i15i22i30j0i22i30j0i15i22i30.5191j0j7&sourceid=chrome&ie=UTF-8#imgrc=t_-GUyvZjXGWBM", "Viliam villa", 15, 800.0, 1050, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, "", new DateTime(2023, 3, 11, 17, 30, 37, 902, DateTimeKind.Local).AddTicks(6445), "Master bedroom of 580 m2 with open air bathroom including separated rain shower, bath tub for 7 and completed wardrobe · 4 suites built and designed", "https://www.google.com/search?q=Details+for+Villa&rlz=1C1GCEA_enBY909BY909&oq=Details+for+Villa&aqs=chrome..69i57j0i15i22i30i625j0i15i22i30j0i22i30j0i15i22i30.5191j0j7&sourceid=chrome&ie=UTF-8#imgrc=t_-GUyvZjXGWBM", "Teritorial villa", 25, 1250.0, 1650, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_VillaNumbers_VillaID",
                table: "VillaNumbers",
                column: "VillaID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VillaNumbers");

            migrationBuilder.DropTable(
                name: "Villas");
        }
    }
}
