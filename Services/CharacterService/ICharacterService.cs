using DOTNETRPG.Models;
using DOTNETRPG.Dtos.CharacterDto;
using System.Threading;

namespace DOTNETRPG.Services
{
    public interface ICharacterService
    {
         public Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
         public Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
         public Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
         public Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);
         public Task<ServiceResponse<List<GetCharacterDto>>> RemoveCharacter(int id);
    }
}