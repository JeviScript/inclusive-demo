using System.ComponentModel.DataAnnotations;

namespace api.Models;

public class Planet
{
    public int Order { get; set; } = 0;
    [Key]
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public string PictureUrl { get; set; } = "";
    public double SunDistance { get; set; } = 0; // in million km
    public string Mass { get; set; } = "";
    public double Diameter { get; set; } = 0; // in km
}
