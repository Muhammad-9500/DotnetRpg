using DOTNETRPG.Models;
namespace DOTNETRPG.Dtos.CharacterDto
{
    public class UpdateCharacterDto
    {
        public int Id {get; set;} = 10;
        public string Name {get; set;} = "Aslam";
        public int Strength {get; set;} = 10;
        public int Defense {get; set;} = 10;
        public int HitPoints {get; set;} = 10;
        public int Intelligence {get; set;} = 10;
        public RPGClass Class {get; set;} = RPGClass.Knight;
    }
}