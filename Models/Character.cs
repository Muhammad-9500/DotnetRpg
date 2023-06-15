using System.Collections.Generic;

namespace DOTNETRPG.Models
{
    public class Character
    {
        public int Id {get; set;}
        public string Name {get; set;} = "Aslam";
        public int Strength {get; set;} = 10;
        public int Defense {get; set;} = 10;
        public int HitPoints {get; set;} = 10;
        public int Intelligence {get; set;} = 10;
        public RPGClass Class {get; set;} = RPGClass.Knight;
        public User User {get; set;}
        public Weapon Weapon {get; set;}
        public List<CharacterSkill> CharacterSkills{get; set;}
        public int Fights {get; set;}
        public int Victories {get; set;}
        public int Defeats {get; set;}
    }
}