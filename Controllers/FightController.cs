using DOTNETRPG.Models;
using Microsoft.AspNetCore.Mvc;
using DOTNETRPG.Services;
using DOTNETRPG.Dtos.CharacterDto;
using DOTNETRPG.Dtos.Fight;
using System.Security.Claims;
using System.Threading.Tasks;
using DOTNETRPG.Services.FightService;

namespace DOTNETRPG.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class FightController : ControllerBase
    {
        private readonly IFightService _fightService;
        public FightController(IFightService fightService)
        {
            _fightService = fightService;
        }

        [HttpPost("Weapon")]
        public async Task<IActionResult> WeaponAttack(WeaponAttackDto request)
        {
            return Ok(await _fightService.WeaponAttack(request));
        }

        [HttpPost("Skill")]
        public async Task<IActionResult> SkillAttack(SkillAttackDto request)
        {
            return Ok(await _fightService.SkillAttack(request));
        }

        [HttpPost]
        public async Task<IActionResult> Fight(FightRequestDto request)
        {
            return Ok(await _fightService.Fight(request));
        }

        public async Task<IActionResult> GetHighScore()
        {
            return Ok(await _fightService.GetHighScore());
        }
    }
}