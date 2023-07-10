using api.Dtos;
using Microsoft.EntityFrameworkCore;

namespace api.Repositories;

public interface IPlanetRepository
{
    Task<IList<GetPlanetsRes>> GetPlanets();
    Task<GetPlanetRes?> GetPlanet(string name);
}

public class PlanetRepository : IPlanetRepository
{
    private readonly PlanetsDb dbContext;

    public PlanetRepository(PlanetsDb dbContext)
    {
        this.dbContext = dbContext;
    }

    public async Task<GetPlanetRes?> GetPlanet(string name)
    {
        var planet = await this.dbContext.Planets.FindAsync(name);
        if (planet == null)
        {
            return null;
        }

        return new GetPlanetRes
        {
            Name = planet.Name,
            Description = planet.Description,
            Mass = planet.Mass,
            Diameter = planet.Diameter,
            PictureUrl = planet.PictureUrl,
            SunDistance = planet.SunDistance
        };
    }

    public async Task<IList<GetPlanetsRes>> GetPlanets()
    {
        var planets =
            await this.dbContext.Planets
                .OrderBy(p => p.Order)
                .Select(p => new GetPlanetsRes { PictureUrl = p.PictureUrl, Name = p.Name })
                .ToListAsync() ?? new List<GetPlanetsRes>();

        return planets;
    }
}
