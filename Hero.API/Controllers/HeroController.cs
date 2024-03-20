using Hero.API.DTOs;
using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace Hero.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {

        private readonly IHeroService _heroService;

        public HeroController(IHeroService heroService) => _heroService = heroService;

        [HttpPost]
        [Route("HeroAPI")]
        public async Task<IActionResult> Hero([FromBody] HeroDto heroDto)
        {
            if (string.IsNullOrEmpty(heroDto.Name) || string.IsNullOrEmpty(heroDto.Power))
                return BadRequest("Invalid hero");

            // Esta com erro no Hero, nao esta reconhecendo de onde vem
            return Ok(await _heroService.InsertHero(new Domain.Model.Hero(heroDto.Name, heroDto.Power)));
        }
    }
}
