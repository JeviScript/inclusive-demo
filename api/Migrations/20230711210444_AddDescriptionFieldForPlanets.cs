using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace api.Migrations
{
    /// <inheritdoc />
    public partial class AddDescriptionFieldForPlanets : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Planets",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Name",
                keyValue: "Earth",
                column: "Description",
                value: "Earth—our home planet—is the only place we know of so far that’s inhabited by living things. It's also the only planet in our solar system with liquid water on the surface.");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Name",
                keyValue: "Jupiter",
                column: "Description",
                value: "Jupiter is more than twice as massive than the other planets of our solar system combined. The giant planet's Great Red spot is a centuries-old storm bigger than Earth.");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Name",
                keyValue: "Mars",
                column: "Description",
                value: "Mars is a dusty, cold, desert world with a very thin atmosphere. There is strong evidence Mars was – billions of years ago – wetter and warmer, with a thicker atmosphere.");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Name",
                keyValue: "Mercury",
                column: "Description",
                value: "Mercury—the smallest planet in our solar system and closest to the Sun—is only slightly larger than Earth's Moon. Mercury is the fastest planet, zipping around the Sun every 88 Earth days.");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Name",
                keyValue: "Neptune",
                column: "Description",
                value: "Neptune—the eighth and most distant major planet orbiting our Sun—is dark, cold and whipped by supersonic winds. It was the first planet located through mathematical calculations. ");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Name",
                keyValue: "Saturn",
                column: "Description",
                value: "Adorned with a dazzling, complex system of icy rings, Saturn is unique in our solar system. The other giant planets have rings, but none are as spectacular as Saturn's. ");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Name",
                keyValue: "Uranus",
                column: "Description",
                value: "Uranus—seventh planet from the Sun—rotates at a nearly 90-degree angle from the plane of its orbit. This unique tilt makes Uranus appear to spin on its side.");

            migrationBuilder.UpdateData(
                table: "Planets",
                keyColumn: "Name",
                keyValue: "Venus",
                column: "Description",
                value: "Venus spins slowly in the opposite direction from most planets. A thick atmosphere traps heat in a runaway greenhouse effect, making it the hottest planet in our solar system.");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Planets");
        }
    }
}
