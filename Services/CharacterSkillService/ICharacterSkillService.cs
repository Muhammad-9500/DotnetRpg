using System.Threading.Tasks;
using DOTNETRPG.Dtos.CharacterDto;
using DOTNETRPG.Dtos.CharacterSkill;
using DOTNETRPG.Models;

namespace DOTNETRPG.Services.CharacterSkillService
{
    public interface ICharacterSkillService
    {
         public Task<ServiceResponse<GetCharacterDto>> AddCharacterSkill(AddCharacterSkillDto newCharacterSkill);
    }
}