using AutoMapper;
using DOTNETRPG.Models;
using DOTNETRPG.Dtos.CharacterDto;
using DOTNETRPG.Dtos.WeaponDto;
using DOTNETRPG.Dtos.Skill;
using System.Linq;
using DOTNETRPG.Dtos.Fight;

namespace DOTNETRPG
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap <Character,GetCharacterDto>()
                .ForMember(dto => dto.Skills, c => c.MapFrom(c => c.CharacterSkills.Select(cs => cs.Skill)));
            CreateMap <AddCharacterDto,Character>();
            CreateMap <Weapon,GetWeaponDto>();
            CreateMap <Skill,GetSkillDto>();
            CreateMap <Character,HighScoreDto>();
        }
        
    }
}