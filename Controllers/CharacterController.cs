using DOTNETRPG.Models;
using Microsoft.AspNetCore.Mvc;
using DOTNETRPG.Services;
using DOTNETRPG.Dtos.CharacterDto;
using Microsoft.AspNetCore.Authorization;
using System.Security.Claims;

namespace DOTNETRPG.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[Controller]")]
    public class CharacterController: ControllerBase
    {
        private readonly ICharacterService _characterService;
        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }


        //[AllowAnonymous]
        [HttpGet("GetAll")]
        public async Task<IActionResult> GetAllCharacters()
        {
            //int id = int.Parse(User.Claims.FirstOrDefault(x => x.Type == ClaimTypes.NameIdentifier).Value);
            return Ok(await _characterService.GetAllCharacters());
        }

        [HttpGet("GetCharacterById/{id}")]
        public async Task<IActionResult> GetCharacterById(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost("AddNewCharacter")]
        public async Task<IActionResult> AddCharacter(AddCharacterDto newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

        [HttpPut("UpdateCharacter")]
        public async Task<IActionResult> UpdateCharacter(UpdateCharacterDto updatedCharacter)
        {
            return Ok(await _characterService.UpdateCharacter(updatedCharacter));
        }

        [HttpDelete("RemoveCharacter/{id}")]
        public async Task<IActionResult> RemoveCharacter(int id)
        {
            return Ok(await _characterService.RemoveCharacter(id));
        }

    }
}