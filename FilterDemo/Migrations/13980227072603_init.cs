using Microsoft.EntityFrameworkCore.Migrations;

namespace FilterDemo.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movies",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(nullable: true),
                    YearProduction = table.Column<int>(nullable: false),
                    Summary = table.Column<string>(nullable: true),
                    ViewCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movies", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Name", "Summary", "ViewCount", "YearProduction" },
                values: new object[] { 1, "Pulp Fiction", "folks guys..", 0, 1994 });

            migrationBuilder.InsertData(
                table: "Movies",
                columns: new[] { "Id", "Name", "Summary", "ViewCount", "YearProduction" },
                values: new object[] { 2, "Titanic", "big boat...", 0, 1997 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
        }
    }
}
