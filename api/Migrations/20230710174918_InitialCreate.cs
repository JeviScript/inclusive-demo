using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Planets",
                columns: table => new
                {
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Order = table.Column<int>(type: "int", nullable: false),
                    PictureUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SunDistance = table.Column<double>(type: "float", nullable: false),
                    Mass = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diameter = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Planets", x => x.Name);
                });

            migrationBuilder.InsertData(
                table: "Planets",
                columns: new[] { "Name", "Diameter", "Mass", "Order", "PictureUrl", "SunDistance" },
                values: new object[,]
                {
                    { "Earth", 12742.0, "5.972 × 10^24 kg", 3, "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/The_Blue_Marble_%28remastered%29.jpg/1024px-The_Blue_Marble_%28remastered%29.jpg", 152.09 },
                    { "Jupiter", 139820.0, "1.898 × 10^27 kg", 5, "https://upload.wikimedia.org/wikipedia/commons/c/c1/Jupiter_New_Horizons.jpg", 741.84000000000003 },
                    { "Mars", 6779.0, "6.39 × 10^23 kg", 4, "https://upload.wikimedia.org/wikipedia/commons/0/0c/Mars_-_August_30_2021_-_Flickr_-_Kevin_M._Gill.png", 249.47 },
                    { "Mercury", 4879.3999999999996, "3.285 × 10^23 kg", 1, "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4a/Mercury_in_true_color.jpg/1024px-Mercury_in_true_color.jpg", 52.585000000000001 },
                    { "Neptune", 49244.0, "1.024 × 10^26", 8, "https://upload.wikimedia.org/wikipedia/commons/6/63/Neptune_-_Voyager_2_%2829347980845%29_flatten_crop.jpg", 4473.0 },
                    { "Saturn", 116460.0, "5.683 × 10^26 kg", 6, "https://upload.wikimedia.org/wikipedia/commons/c/c7/Saturn_during_Equinox.jpg", 1462.3 },
                    { "Uranus", 50724.0, "8.681 × 10^25", 7, "https://upload.wikimedia.org/wikipedia/commons/c/c9/Uranus_as_seen_by_NASA%27s_Voyager_2_%28remastered%29_-_JPEG_converted.jpg", 2937.0999999999999 },
                    { "Venus", 12104.0, "4.867 × 10^24 kg", 2, "https://upload.wikimedia.org/wikipedia/commons/b/b2/Venus_2_Approach_Image.jpg", 108.73 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Planets");
        }
    }
}
