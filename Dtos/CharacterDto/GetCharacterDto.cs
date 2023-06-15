using DOTNETRPG.Models;
using DOTNETRPG.Dtos.WeaponDto;
using DOTNETRPG.Dtos.Skill;
using System.Collections.Generic;

namespace DOTNETRPG.Dtos.CharacterDto
{
    public class GetCharacterDto
    {
        public int Id {get; set;}
        public string Name {get; set;} = "Aslam";
        public int Strength {get; set;} = 10;
        public int Defense {get; set;} = 10;
        public int HitPoints {get; set;} = 10;
        public int Intelligence {get; set;} = 10;
        public RPGClass Class {get; set;} = RPGClass.Knight;
        public GetWeaponDto Weapon {get; set;}
        public List<GetSkillDto> Skills {get; set;}
        public int Fights {get; set;}
        public int Victories {get; set;}
        public int Defeats {get; set;}
    }
}