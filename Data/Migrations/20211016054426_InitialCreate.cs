using Microsoft.EntityFrameworkCore.Migrations;

namespace Code1st.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    ProvinceCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    ProvinceName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.ProvinceCode);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Population = table.Column<int>(type: "int", maxLength: 8, nullable: false),
                    Province = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: true),
                    ProvinceCode = table.Column<string>(type: "nvarchar(2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityID);
                    table.ForeignKey(
                        name: "FK_Cities_Provinces_ProvinceCode",
                        column: x => x.ProvinceCode,
                        principalTable: "Provinces",
                        principalColumn: "ProvinceCode",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityID", "CityName", "Population", "Province", "ProvinceCode" },
                values: new object[,]
                {
                    { 1, "Vancouver", 500000, "BC", null },
                    { 2, "Victoria", 300000, "BC", null },
                    { 3, "Port Coquitlam", 80000, "BC", null },
                    { 4, "Calgary", 700000, "AB", null },
                    { 5, "Edmonton", 800000, "AB", null },
                    { 6, "Banff", 50000, "AB", null },
                    { 7, "Moose Jaw", 50000, "SK", null },
                    { 8, "Regina", 400000, "SK", null },
                    { 9, "Saskatoon", 350000, "SK", null }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[,]
                {
                    { "BC", "British Columbia" },
                    { "AB", "Alberta" },
                    { "SK", "Saskatchewan" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ProvinceCode",
                table: "Cities",
                column: "ProvinceCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Provinces");
        }
    }
}
