using DOTNETRPG.Models;
namespace DOTNETRPG.Dtos.CharacterDto
{
    public class AddCharacterDto
    {
        public string Name {get; set;} = "Aslam";
        public int Strength {get; set;} = 10;
        public int Defense {get; set;} = 10;
        public int HitPoints {get; set;} = 10;
        public int Intelligence {get; set;} = 10;
        public RPGClass CLass {get; set;} = RPGClass.Knight;
    }
}