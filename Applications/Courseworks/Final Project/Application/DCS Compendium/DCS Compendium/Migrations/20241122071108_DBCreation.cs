using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DCS_Compendium.Migrations
{
    /// <inheritdoc />
    public partial class DBCreation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    VehicleID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleClass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleImagePath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleWeakness = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.VehicleID);
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "VehicleID", "VehicleClass", "VehicleDescription", "VehicleImagePath", "VehicleName", "VehicleType", "VehicleWeakness" },
                values: new object[,]
                {
                    { 1, "Ground", "Russian Anti-Air Platform with no self radar, but uses radar from external sources to be guided.", "Resources\\SA-3 Goa", "SA-3 Goa", "Anti-Air", "Chaff, Terrain, Notching" },
                    { 2, "Ground", "Russian Anti-Air Vehicle with a SARH system.", "Resources\\SA-6 Kub", "SA-6 Kub", "Anti-Air", "Chaff, Terrain, Notching" },
                    { 3, "Ground", "Amphibious Russian Wheeled Anti-Air Vehicle with SARH radar.", "Resources\\SA-8 OSA", "SA-8 OSA", "Anti-Air", "Chaff, Terrain, Notching" },
                    { 4, "Ground", "Russian short-range wheeled Anti-Air system.", "Resources\\SA-9 Strela", "SA-9 Strela", "Anti-Air", "Flares" },
                    { 5, "Ground", "Russian Anti-Air Vehicle with 30mm cannons and Anti-Air Missiles.", "Resources\\SA-19 Tunguska", "SA-19 Tunguska", "Anti-Air", "Chaff, Terrain, Notching" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicles");
        }
    }
}
