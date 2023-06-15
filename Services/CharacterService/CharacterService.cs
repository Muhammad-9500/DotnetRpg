using System.Collections.Generic;
using DOTNETRPG.Models;
using DOTNETRPG.Dtos.CharacterDto;
using AutoMapper;
using System.Threading;
using DOTNETRPG.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace DOTNETRPG.Services
{
    public class CharacterService : ICharacterService
    {
        List<Character> characters = new List<Character>()
        {
            new Character(),
            new Character{Id=2,Name="Hassan"}
        };

        private readonly IMapper _mapper;
        private readonly DataContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CharacterService(IMapper mapper,DataContext context,IHttpContextAccessor httpContextAccessor)
        {
            _mapper = mapper;
            _context = context;
            _httpContextAccessor =  httpContextAccessor;
        }

        private int GetUserId() => int.Parse(_httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier));

        public async Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters()
        {
            ServiceResponse<List<GetCharacterDto>> response = new ServiceResponse<List<GetCharacterDto>>();
            List<Character> dbCharacters = await _context.Characters.Where(c => c.User.Id == GetUserId()).ToListAsync();
            if(dbCharacters != null)
            {
                response.Data = (dbCharacters.Select(c => _mapper.Map<GetCharacterDto>(c))).ToList();
                response.Message = dbCharacters.Count+" Characters Found";
            }
            else
                response.Message = "No Characters Found";
            return response;
        }

        public async Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id)
        {
            ServiceResponse<GetCharacterDto> response = new ServiceResponse<GetCharacterDto>();
            Character dbCharacter = await _context.Characters
                .Include(c => c.Weapon)
                .Include(c => c.CharacterSkills).ThenInclude(cs => cs.Skill)
                .FirstOrDefaultAsync(x => x.Id == id && x.User.Id == GetUserId());
            if(dbCharacter == null)
            {
                response.Message = "You don't own the Character with the given Id or it does not Exists";
                response.Success =  false;
            }
            response.Message = "You are the owner of the Character with the given Id";
            response.Data = _mapper.Map<GetCharacterDto>(dbCharacter);
            return response;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter)
        {
            ServiceResponse<List<GetCharacterDto>> response = new ServiceResponse<List<GetCharacterDto>>();
            Character character = _mapper.Map<Character>(newCharacter);
            character.User = await _context.Users.FirstOrDefaultAsync(u => u.Id == GetUserId());
            await _context.Characters.AddAsync(character);
            await _context.SaveChangesAsync();
            List<Character> dbCharacters = await _context.Characters.Where(u => u.User.Id == GetUserId()).ToListAsync();
            response.Data = (dbCharacters.Select(c => _mapper.Map<GetCharacterDto>(c))).ToList();
            return response;
        }

        public async Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter)
        {
            ServiceResponse<GetCharacterDto> response = new ServiceResponse<GetCharacterDto>();
            try 
            {
                Character c = await _context.Characters.Include(c=> c.User).FirstOrDefaultAsync(x => x.Id == updatedCharacter.Id);
                if(c.User.Id == GetUserId())
                {
                    c.Name = updatedCharacter.Name;
                    c.Strength = updatedCharacter.Strength;
                    c.Class = updatedCharacter.Class;
                    c.HitPoints = updatedCharacter.HitPoints;
                    c.Defense = updatedCharacter.Defense;
                    c.Intelligence = updatedCharacter.Intelligence;
                    await _context.SaveChangesAsync();
                
                    //List<Character> dbCharacters = await _context.Characters.ToListAsync();
                    response.Data = _mapper.Map<GetCharacterDto>(c);
                }
                else
                {
                    response.Success = false;
                    response.Message = "Character not found!";
                }
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }

        public async Task<ServiceResponse<List<GetCharacterDto>>> RemoveCharacter(int id)
        {
            ServiceResponse<List<GetCharacterDto>> response = new ServiceResponse<List<GetCharacterDto>>();
            try
            {
                Character c = await _context.Characters
                    .FirstOrDefaultAsync(x => x.Id == id && x.User.Id == GetUserId());
                if(c != null)
                {
                    _context.Characters.Remove(c);
                    await _context.SaveChangesAsync();
                    response.Data = (_context.Characters.Where(c => c.User.Id == GetUserId())
                    .Select(c => _mapper.Map<GetCharacterDto>(c))).ToList();
                }
                else
                {
                    response.Success = false;
                    response.Message = "You do not own this Character or it does not Exists";
                }
                
            }
            catch(Exception ex)
            {
                response.Success = false;
                response.Message = ex.Message;
            }
            return response;
        }
    }
}