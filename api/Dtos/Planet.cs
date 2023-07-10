namespace api.Dtos;

public class GetPlanetsRes
{
    public string Name { get; set; } = "";
    public string PictureUrl { get; set; } = "";
}

public class GetPlanetRes
{
    public string Name { get; set; } = "";
    public string Description { get; set; } = "";
    public string PictureUrl { get; set; } = "";
    public double SunDistance { get; set; } = 0; // in million km
    public string Mass { get; set; } = "";
    public double Diameter { get; set; } = 0; // in km
}
