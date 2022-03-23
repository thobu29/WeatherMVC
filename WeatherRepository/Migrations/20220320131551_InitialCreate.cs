using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeatherRepository.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Country = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Weathers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CityId = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    IconId = table.Column<int>(type: "INTEGER", nullable: false),
                    Temperature = table.Column<double>(type: "REAL", nullable: false),
                    MinTemperature = table.Column<double>(type: "REAL", nullable: false),
                    MaxTemperature = table.Column<double>(type: "REAL", nullable: false),
                    Pressure = table.Column<int>(type: "INTEGER", nullable: false),
                    Humidity = table.Column<int>(type: "INTEGER", nullable: false),
                    WindSpeed = table.Column<double>(type: "REAL", nullable: false),
                    WindDirection = table.Column<int>(type: "INTEGER", nullable: false),
                    CloudCoverage = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weathers", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Country", "Name" },
                values: new object[] { 1, "DE", "Erfurt" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Country", "Name" },
                values: new object[] { 2, "DE", "Berlin" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Country", "Name" },
                values: new object[] { 3, "DE", "Bremen" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Country", "Name" },
                values: new object[] { 4, "DE", "Leipzig" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Country", "Name" },
                values: new object[] { 5, "DE", "Hamburg" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Country", "Name" },
                values: new object[] { 6, "DE", "München" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Country", "Name" },
                values: new object[] { 7, "DE", "Hannover" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Country", "Name" },
                values: new object[] { 8, "DE", "Köln" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Country", "Name" },
                values: new object[] { 9, "DE", "Dresden" });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "Id", "Country", "Name" },
                values: new object[] { 10, "DE", "Stuttgart" });

            migrationBuilder.InsertData(
                table: "Weathers",
                columns: new[] { "Id", "CityId", "CloudCoverage", "Description", "Humidity", "IconId", "MaxTemperature", "MinTemperature", "Pressure", "Temperature", "WindDirection", "WindSpeed" },
                values: new object[] { 1, 1, 90, "bedeckt", 11, 1, 17.0, 8.0, 1003, 21.0, 158, 9.3794831268468464 });

            migrationBuilder.InsertData(
                table: "Weathers",
                columns: new[] { "Id", "CityId", "CloudCoverage", "Description", "Humidity", "IconId", "MaxTemperature", "MinTemperature", "Pressure", "Temperature", "WindDirection", "WindSpeed" },
                values: new object[] { 2, 2, 0, "sonnig", 40, 0, 34.0, 34.0, 1005, 51.0, 61, 4.5143023900553993 });

            migrationBuilder.InsertData(
                table: "Weathers",
                columns: new[] { "Id", "CityId", "CloudCoverage", "Description", "Humidity", "IconId", "MaxTemperature", "MinTemperature", "Pressure", "Temperature", "WindDirection", "WindSpeed" },
                values: new object[] { 3, 3, 27, "bedeckt", 94, 1, 23.0, 17.0, 1006, 31.5, 92, 3.7478184359168756 });

            migrationBuilder.InsertData(
                table: "Weathers",
                columns: new[] { "Id", "CityId", "CloudCoverage", "Description", "Humidity", "IconId", "MaxTemperature", "MinTemperature", "Pressure", "Temperature", "WindDirection", "WindSpeed" },
                values: new object[] { 4, 4, 56, "bedeckt", 37, 1, 28.0, 24.0, 1007, 40.0, 269, 4.1226409651278759 });

            migrationBuilder.InsertData(
                table: "Weathers",
                columns: new[] { "Id", "CityId", "CloudCoverage", "Description", "Humidity", "IconId", "MaxTemperature", "MinTemperature", "Pressure", "Temperature", "WindDirection", "WindSpeed" },
                values: new object[] { 5, 5, 45, "sonnig", 81, 0, 32.0, 24.0, 1011, 44.0, 111, 0.12418574304075891 });

            migrationBuilder.InsertData(
                table: "Weathers",
                columns: new[] { "Id", "CityId", "CloudCoverage", "Description", "Humidity", "IconId", "MaxTemperature", "MinTemperature", "Pressure", "Temperature", "WindDirection", "WindSpeed" },
                values: new object[] { 6, 6, 60, "regnerisch", 62, 2, 39.0, 30.0, 1010, 54.0, 114, 9.4264920763261539 });

            migrationBuilder.InsertData(
                table: "Weathers",
                columns: new[] { "Id", "CityId", "CloudCoverage", "Description", "Humidity", "IconId", "MaxTemperature", "MinTemperature", "Pressure", "Temperature", "WindDirection", "WindSpeed" },
                values: new object[] { 7, 7, 3, "sonnig", 19, 0, 15.0, 15.0, 1004, 22.5, 119, 3.2139106277734442 });

            migrationBuilder.InsertData(
                table: "Weathers",
                columns: new[] { "Id", "CityId", "CloudCoverage", "Description", "Humidity", "IconId", "MaxTemperature", "MinTemperature", "Pressure", "Temperature", "WindDirection", "WindSpeed" },
                values: new object[] { 8, 8, 65, "bedeckt", 94, 1, 48.0, 39.0, 1003, 67.5, 11, 9.0963352348100628 });

            migrationBuilder.InsertData(
                table: "Weathers",
                columns: new[] { "Id", "CityId", "CloudCoverage", "Description", "Humidity", "IconId", "MaxTemperature", "MinTemperature", "Pressure", "Temperature", "WindDirection", "WindSpeed" },
                values: new object[] { 9, 9, 28, "bedeckt", 71, 1, 23.0, 20.0, 1019, 33.0, 79, 3.4374587839576973 });

            migrationBuilder.InsertData(
                table: "Weathers",
                columns: new[] { "Id", "CityId", "CloudCoverage", "Description", "Humidity", "IconId", "MaxTemperature", "MinTemperature", "Pressure", "Temperature", "WindDirection", "WindSpeed" },
                values: new object[] { 10, 10, 86, "regnerisch", 40, 2, 12.0, 12.0, 1016, 18.0, 256, 6.9459530975075277 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Weathers");
        }
    }
}
