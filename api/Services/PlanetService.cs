using api.Dtos;
using api.Repositories;

namespace api.Services;

public interface IPlanetService
{
    Task<IEnumerable<GetPlanetsRes>> GetPlanets();
    Task<GetPlanetRes?> GetPlanet(string name);
}

public class PlanetService : IPlanetService
{
    private readonly IPlanetRepository planetRepository;

    public PlanetService(IPlanetRepository planetRepository)
    {
        this.planetRepository = planetRepository;
    }

    public Task<GetPlanetRes?> GetPlanet(string name)
    {
      return this.planetRepository.GetPlanet(name);
    }

    public async Task<IEnumerable<GetPlanetsRes>> GetPlanets()
    {
      var planets = await this.planetRepository.GetPlanets();
      return planets;
    }
}
