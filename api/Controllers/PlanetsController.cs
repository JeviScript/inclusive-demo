using api.Dtos;
using api.Services;
using Microsoft.AspNetCore.Mvc;

namespace api.Controllers;

[ApiController]
[Route("planets")]
public class PlanetsController : ControllerBase
{
    private readonly IPlanetService planetService;

    public PlanetsController(IPlanetService planetService)
    {
        this.planetService = planetService;
    }

    [HttpGet]
    public Task<IEnumerable<GetPlanetsRes>> GetPlanets()
    {
        return this.planetService.GetPlanets();
    }

    [HttpGet("{name}")]
    public async Task<ActionResult<GetPlanetRes>> GetPlanet(string name)
    {
        var planet = await this.planetService.GetPlanet(name);

        if (planet == null)
        {
            return NotFound();
        }
        else
        {
            return planet;
        }
    }
}
