using DOTNETRPG.Dtos.Fight;
using DOTNETRPG.Models;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace DOTNETRPG.Services.FightService
{
    public interface IFightService
    {
         public Task<ServiceResponse<AttackResultDto>> WeaponAttack(WeaponAttackDto request);
         public Task<ServiceResponse<AttackResultDto>> SkillAttack(SkillAttackDto request);
         public Task<ServiceResponse<FightResultDto>> Fight(FightRequestDto request);
         public Task<ServiceResponse<List<HighScoreDto>>>  GetHighScore();
    }
}