using api.Models;
using Microsoft.EntityFrameworkCore;

namespace api;

public class PlanetsDb : DbContext
{
    public PlanetsDb(DbContextOptions options)
        : base(options) { }

    public DbSet<Planet> Planets { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder builder)
    {
        //Write Fluent API configurations here
        builder
            .Entity<Planet>()
            .HasData(
                new Planet
                {
                    Order = 1,
                    Name = "Mercury",
                    Description =
                        "Mercury—the smallest planet in our solar system and closest to the Sun—is only slightly larger than Earth's Moon. Mercury is the fastest planet, zipping around the Sun every 88 Earth days.",
                    PictureUrl =
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/4/4a/Mercury_in_true_color.jpg/1024px-Mercury_in_true_color.jpg",
                    SunDistance = 52.585,
                    Mass = "3.285 × 10^23 kg",
                    Diameter = 4879.4
                },
                new Planet
                {
                    Order = 2,
                    Name = "Venus",
                    Description =
                        "Venus spins slowly in the opposite direction from most planets. A thick atmosphere traps heat in a runaway greenhouse effect, making it the hottest planet in our solar system.",
                    PictureUrl =
                        "https://upload.wikimedia.org/wikipedia/commons/b/b2/Venus_2_Approach_Image.jpg",
                    SunDistance = 108.73,
                    Mass = "4.867 × 10^24 kg",
                    Diameter = 12104
                },
                new Planet
                {
                    Order = 3,
                    Name = "Earth",
                    Description =
                        "Earth—our home planet—is the only place we know of so far that’s inhabited by living things. It's also the only planet in our solar system with liquid water on the surface.",
                    PictureUrl =
                        "https://upload.wikimedia.org/wikipedia/commons/thumb/c/cb/The_Blue_Marble_%28remastered%29.jpg/1024px-The_Blue_Marble_%28remastered%29.jpg",
                    SunDistance = 152.09,
                    Mass = "5.972 × 10^24 kg",
                    Diameter = 12742
                },
                new Planet
                {
                    Order = 4,
                    Name = "Mars",
                    Description =
                        "Mars is a dusty, cold, desert world with a very thin atmosphere. There is strong evidence Mars was – billions of years ago – wetter and warmer, with a thicker atmosphere.",
                    PictureUrl =
                        "https://upload.wikimedia.org/wikipedia/commons/0/0c/Mars_-_August_30_2021_-_Flickr_-_Kevin_M._Gill.png",
                    SunDistance = 249.47,
                    Mass = "6.39 × 10^23 kg",
                    Diameter = 6779
                },
                new Planet
                {
                    Order = 5,
                    Name = "Jupiter",
                    Description =
                        "Jupiter is more than twice as massive than the other planets of our solar system combined. The giant planet's Great Red spot is a centuries-old storm bigger than Earth.",
                    PictureUrl =
                        "https://upload.wikimedia.org/wikipedia/commons/c/c1/Jupiter_New_Horizons.jpg",
                    SunDistance = 741.84,
                    Mass = "1.898 × 10^27 kg",
                    Diameter = 139820
                },
                new Planet
                {
                    Order = 6,
                    Name = "Saturn",
                    Description =
                        "Adorned with a dazzling, complex system of icy rings, Saturn is unique in our solar system. The other giant planets have rings, but none are as spectacular as Saturn's. ",
                    PictureUrl =
                        "https://upload.wikimedia.org/wikipedia/commons/c/c7/Saturn_during_Equinox.jpg",
                    SunDistance = 1462.3,
                    Mass = "5.683 × 10^26 kg",
                    Diameter = 116460
                },
                new Planet
                {
                    Order = 7,
                    Name = "Uranus",
                    Description =
                        "Uranus—seventh planet from the Sun—rotates at a nearly 90-degree angle from the plane of its orbit. This unique tilt makes Uranus appear to spin on its side.",
                    PictureUrl =
                        "https://upload.wikimedia.org/wikipedia/commons/c/c9/Uranus_as_seen_by_NASA%27s_Voyager_2_%28remastered%29_-_JPEG_converted.jpg",
                    SunDistance = 2937.1,
                    Mass = "8.681 × 10^25",
                    Diameter = 50724
                },
                new Planet
                {
                    Order = 8,
                    Name = "Neptune",
                    Description =
                        "Neptune—the eighth and most distant major planet orbiting our Sun—is dark, cold and whipped by supersonic winds. It was the first planet located through mathematical calculations. ",
                    PictureUrl =
                        "https://upload.wikimedia.org/wikipedia/commons/6/63/Neptune_-_Voyager_2_%2829347980845%29_flatten_crop.jpg",
                    SunDistance = 4473.0,
                    Mass = "1.024 × 10^26",
                    Diameter = 49244
                }
            );
    }
}
