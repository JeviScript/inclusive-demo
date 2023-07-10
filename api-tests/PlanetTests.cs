using api.Dtos;

namespace Tests;

public class PlanetTests : IClassFixture<TestWebApplicationFactory<Program>>
{
    private readonly HttpClient httpClient;

    public PlanetTests(TestWebApplicationFactory<Program> factory)
    {
        this.httpClient = factory.CreateClient();
    }

    [Fact]
    public async Task GetPlanets_Succuess()
    {
        var planets = await ApiHelper.Get<IList<GetPlanetsRes>>("planets", this.httpClient);

        Assert.Equal(8, planets.Count());

        // mercury
        var p1 = planets[0];
        Assert.Equal("Mercury", p1.Name);

        var p8 = planets[7];
        Assert.Equal("Neptune", p8.Name);
    }

    [Fact]
    public async Task GetPlanet_Succuess()
    {
        var response = await ApiHelper.Get<GetPlanetRes>("planets/Mercury", this.httpClient);

        // mercury
        Assert.Equal("Mercury", response.Name);
        
        Assert.Equal(4879.4, response.Diameter);
    }
}
