using System.Threading.Tasks;
using DOTNETRPG.Models;
using DOTNETRPG.Dtos.CharacterDto;
using DOTNETRPG.Dtos.WeaponDto;

namespace DOTNETRPG.Services.WeaponService
{
    public interface IWeaponService
    {
         Task<ServiceResponse<GetCharacterDto>> AddWeapon(AddWeaponDto newWeapon);
    }
}