using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WeatherAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clouds",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    All = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clouds", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Main",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Temp = table.Column<double>(type: "REAL", nullable: false),
                    Temp_min = table.Column<double>(type: "REAL", nullable: false),
                    Temp_max = table.Column<double>(type: "REAL", nullable: false),
                    Pressure = table.Column<int>(type: "INTEGER", nullable: false),
                    Humidity = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Main", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sys",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Country = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sys", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Wind",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Speed = table.Column<double>(type: "REAL", nullable: false),
                    Deg = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wind", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roots",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MainId = table.Column<int>(type: "INTEGER", nullable: false),
                    WindId = table.Column<int>(type: "INTEGER", nullable: false),
                    CloudsId = table.Column<int>(type: "INTEGER", nullable: false),
                    SysId = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Dt = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roots", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roots_Clouds_CloudsId",
                        column: x => x.CloudsId,
                        principalTable: "Clouds",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Roots_Main_MainId",
                        column: x => x.MainId,
                        principalTable: "Main",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Roots_Sys_SysId",
                        column: x => x.SysId,
                        principalTable: "Sys",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Roots_Wind_WindId",
                        column: x => x.WindId,
                        principalTable: "Wind",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Weather",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    RootId = table.Column<int>(type: "INTEGER", nullable: false),
                    Main = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    Icon = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weather", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Weather_Roots_RootId",
                        column: x => x.RootId,
                        principalTable: "Roots",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clouds",
                columns: new[] { "Id", "All" },
                values: new object[] { 1, 29 });

            migrationBuilder.InsertData(
                table: "Clouds",
                columns: new[] { "Id", "All" },
                values: new object[] { 2, 31 });

            migrationBuilder.InsertData(
                table: "Clouds",
                columns: new[] { "Id", "All" },
                values: new object[] { 3, 0 });

            migrationBuilder.InsertData(
                table: "Clouds",
                columns: new[] { "Id", "All" },
                values: new object[] { 4, 50 });

            migrationBuilder.InsertData(
                table: "Clouds",
                columns: new[] { "Id", "All" },
                values: new object[] { 5, 97 });

            migrationBuilder.InsertData(
                table: "Clouds",
                columns: new[] { "Id", "All" },
                values: new object[] { 6, 50 });

            migrationBuilder.InsertData(
                table: "Clouds",
                columns: new[] { "Id", "All" },
                values: new object[] { 7, 85 });

            migrationBuilder.InsertData(
                table: "Clouds",
                columns: new[] { "Id", "All" },
                values: new object[] { 8, 67 });

            migrationBuilder.InsertData(
                table: "Clouds",
                columns: new[] { "Id", "All" },
                values: new object[] { 9, 54 });

            migrationBuilder.InsertData(
                table: "Clouds",
                columns: new[] { "Id", "All" },
                values: new object[] { 10, 84 });

            migrationBuilder.InsertData(
                table: "Main",
                columns: new[] { "Id", "Humidity", "Pressure", "Temp", "Temp_max", "Temp_min" },
                values: new object[] { 1, 54, 1019, 17.5, 17.0, 18.0 });

            migrationBuilder.InsertData(
                table: "Main",
                columns: new[] { "Id", "Humidity", "Pressure", "Temp", "Temp_max", "Temp_min" },
                values: new object[] { 2, 50, 1014, 15.5, 12.0, 19.0 });

            migrationBuilder.InsertData(
                table: "Main",
                columns: new[] { "Id", "Humidity", "Pressure", "Temp", "Temp_max", "Temp_min" },
                values: new object[] { 3, 81, 1017, 25.5, 22.0, 29.0 });

            migrationBuilder.InsertData(
                table: "Main",
                columns: new[] { "Id", "Humidity", "Pressure", "Temp", "Temp_max", "Temp_min" },
                values: new object[] { 4, 58, 1016, 16.0, 18.0, 14.0 });

            migrationBuilder.InsertData(
                table: "Main",
                columns: new[] { "Id", "Humidity", "Pressure", "Temp", "Temp_max", "Temp_min" },
                values: new object[] { 5, 5, 1005, 8.0, 8.0, 8.0 });

            migrationBuilder.InsertData(
                table: "Main",
                columns: new[] { "Id", "Humidity", "Pressure", "Temp", "Temp_max", "Temp_min" },
                values: new object[] { 6, 84, 1004, 13.0, 15.0, 11.0 });

            migrationBuilder.InsertData(
                table: "Main",
                columns: new[] { "Id", "Humidity", "Pressure", "Temp", "Temp_max", "Temp_min" },
                values: new object[] { 7, 84, 1008, 1.5, 1.0, 2.0 });

            migrationBuilder.InsertData(
                table: "Main",
                columns: new[] { "Id", "Humidity", "Pressure", "Temp", "Temp_max", "Temp_min" },
                values: new object[] { 8, 38, 1011, 28.5, 29.0, 28.0 });

            migrationBuilder.InsertData(
                table: "Main",
                columns: new[] { "Id", "Humidity", "Pressure", "Temp", "Temp_max", "Temp_min" },
                values: new object[] { 9, 50, 1003, 3.5, 2.0, 5.0 });

            migrationBuilder.InsertData(
                table: "Main",
                columns: new[] { "Id", "Humidity", "Pressure", "Temp", "Temp_max", "Temp_min" },
                values: new object[] { 10, 73, 1007, 7.0, 2.0, 12.0 });

            migrationBuilder.InsertData(
                table: "Sys",
                columns: new[] { "Id", "Country" },
                values: new object[] { 1, "DE" });

            migrationBuilder.InsertData(
                table: "Wind",
                columns: new[] { "Id", "Deg", "Speed" },
                values: new object[] { 1, 224, 9.7899999999999991 });

            migrationBuilder.InsertData(
                table: "Wind",
                columns: new[] { "Id", "Deg", "Speed" },
                values: new object[] { 2, 343, 6.8200000000000003 });

            migrationBuilder.InsertData(
                table: "Wind",
                columns: new[] { "Id", "Deg", "Speed" },
                values: new object[] { 3, 304, 3.6800000000000002 });

            migrationBuilder.InsertData(
                table: "Wind",
                columns: new[] { "Id", "Deg", "Speed" },
                values: new object[] { 4, 331, 8.4199999999999999 });

            migrationBuilder.InsertData(
                table: "Wind",
                columns: new[] { "Id", "Deg", "Speed" },
                values: new object[] { 5, 47, 8.0899999999999999 });

            migrationBuilder.InsertData(
                table: "Wind",
                columns: new[] { "Id", "Deg", "Speed" },
                values: new object[] { 6, 350, 7.25 });

            migrationBuilder.InsertData(
                table: "Wind",
                columns: new[] { "Id", "Deg", "Speed" },
                values: new object[] { 7, 84, 8.0600000000000005 });

            migrationBuilder.InsertData(
                table: "Wind",
                columns: new[] { "Id", "Deg", "Speed" },
                values: new object[] { 8, 353, 1.5600000000000001 });

            migrationBuilder.InsertData(
                table: "Wind",
                columns: new[] { "Id", "Deg", "Speed" },
                values: new object[] { 9, 339, 7.9400000000000004 });

            migrationBuilder.InsertData(
                table: "Wind",
                columns: new[] { "Id", "Deg", "Speed" },
                values: new object[] { 10, 170, 2.8799999999999999 });

            migrationBuilder.InsertData(
                table: "Roots",
                columns: new[] { "Id", "CloudsId", "Dt", "MainId", "Name", "SysId", "WindId" },
                values: new object[] { 1, 1, "1648044203", 1, "Erfurt", 1, 1 });

            migrationBuilder.InsertData(
                table: "Roots",
                columns: new[] { "Id", "CloudsId", "Dt", "MainId", "Name", "SysId", "WindId" },
                values: new object[] { 2, 2, "1648044203", 2, "Berlin", 1, 2 });

            migrationBuilder.InsertData(
                table: "Roots",
                columns: new[] { "Id", "CloudsId", "Dt", "MainId", "Name", "SysId", "WindId" },
                values: new object[] { 3, 3, "1648044203", 3, "Bremen", 1, 3 });

            migrationBuilder.InsertData(
                table: "Roots",
                columns: new[] { "Id", "CloudsId", "Dt", "MainId", "Name", "SysId", "WindId" },
                values: new object[] { 4, 4, "1648044203", 4, "Leipzig", 1, 4 });

            migrationBuilder.InsertData(
                table: "Roots",
                columns: new[] { "Id", "CloudsId", "Dt", "MainId", "Name", "SysId", "WindId" },
                values: new object[] { 5, 5, "1648044203", 5, "Hamburg", 1, 5 });

            migrationBuilder.InsertData(
                table: "Roots",
                columns: new[] { "Id", "CloudsId", "Dt", "MainId", "Name", "SysId", "WindId" },
                values: new object[] { 6, 6, "1648044203", 6, "Rostock", 1, 6 });

            migrationBuilder.InsertData(
                table: "Roots",
                columns: new[] { "Id", "CloudsId", "Dt", "MainId", "Name", "SysId", "WindId" },
                values: new object[] { 7, 7, "1648044203", 7, "Hannover", 1, 7 });

            migrationBuilder.InsertData(
                table: "Roots",
                columns: new[] { "Id", "CloudsId", "Dt", "MainId", "Name", "SysId", "WindId" },
                values: new object[] { 8, 8, "1648044203", 8, "Magdeburg", 1, 8 });

            migrationBuilder.InsertData(
                table: "Roots",
                columns: new[] { "Id", "CloudsId", "Dt", "MainId", "Name", "SysId", "WindId" },
                values: new object[] { 9, 9, "1648044203", 9, "Dresden", 1, 9 });

            migrationBuilder.InsertData(
                table: "Roots",
                columns: new[] { "Id", "CloudsId", "Dt", "MainId", "Name", "SysId", "WindId" },
                values: new object[] { 10, 10, "1648044203", 10, "Stuttgart", 1, 10 });

            migrationBuilder.InsertData(
                table: "Weather",
                columns: new[] { "Id", "Description", "Icon", "Main", "RootId" },
                values: new object[] { 1, "regnerisch", "2", "regnerisch", 1 });

            migrationBuilder.InsertData(
                table: "Weather",
                columns: new[] { "Id", "Description", "Icon", "Main", "RootId" },
                values: new object[] { 2, "sonnig", "0", "sonnig", 2 });

            migrationBuilder.InsertData(
                table: "Weather",
                columns: new[] { "Id", "Description", "Icon", "Main", "RootId" },
                values: new object[] { 3, "bedeckt", "1", "bedeckt", 3 });

            migrationBuilder.InsertData(
                table: "Weather",
                columns: new[] { "Id", "Description", "Icon", "Main", "RootId" },
                values: new object[] { 4, "sonnig", "0", "sonnig", 4 });

            migrationBuilder.InsertData(
                table: "Weather",
                columns: new[] { "Id", "Description", "Icon", "Main", "RootId" },
                values: new object[] { 5, "bedeckt", "1", "bedeckt", 5 });

            migrationBuilder.InsertData(
                table: "Weather",
                columns: new[] { "Id", "Description", "Icon", "Main", "RootId" },
                values: new object[] { 6, "regnerisch", "2", "regnerisch", 6 });

            migrationBuilder.InsertData(
                table: "Weather",
                columns: new[] { "Id", "Description", "Icon", "Main", "RootId" },
                values: new object[] { 7, "bedeckt", "1", "bedeckt", 7 });

            migrationBuilder.InsertData(
                table: "Weather",
                columns: new[] { "Id", "Description", "Icon", "Main", "RootId" },
                values: new object[] { 8, "regnerisch", "2", "regnerisch", 8 });

            migrationBuilder.InsertData(
                table: "Weather",
                columns: new[] { "Id", "Description", "Icon", "Main", "RootId" },
                values: new object[] { 9, "regnerisch", "2", "regnerisch", 9 });

            migrationBuilder.InsertData(
                table: "Weather",
                columns: new[] { "Id", "Description", "Icon", "Main", "RootId" },
                values: new object[] { 10, "bedeckt", "1", "bedeckt", 10 });

            migrationBuilder.CreateIndex(
                name: "IX_Roots_CloudsId",
                table: "Roots",
                column: "CloudsId");

            migrationBuilder.CreateIndex(
                name: "IX_Roots_MainId",
                table: "Roots",
                column: "MainId");

            migrationBuilder.CreateIndex(
                name: "IX_Roots_SysId",
                table: "Roots",
                column: "SysId");

            migrationBuilder.CreateIndex(
                name: "IX_Roots_WindId",
                table: "Roots",
                column: "WindId");

            migrationBuilder.CreateIndex(
                name: "IX_Weather_RootId",
                table: "Weather",
                column: "RootId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Weather");

            migrationBuilder.DropTable(
                name: "Roots");

            migrationBuilder.DropTable(
                name: "Clouds");

            migrationBuilder.DropTable(
                name: "Main");

            migrationBuilder.DropTable(
                name: "Sys");

            migrationBuilder.DropTable(
                name: "Wind");
        }
    }
}
