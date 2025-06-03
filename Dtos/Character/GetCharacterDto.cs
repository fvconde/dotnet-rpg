using dotnet_rpg.Dtos.Skill;
using dotnet_rpg.Models.Enums;

namespace dotnet_rpg.Dtos.Character
{
    public class GetCharacterDto : Models.Character
    {
        public override int Id { get => base.Id; set => base.Id = value; }
        public override string Name { get => base.Name; set => base.Name = value; }
        public override int HitPoints { get => base.HitPoints; set => base.HitPoints = value; }
        public override int Strength { get => base.Strength; set => base.Strength = value; }
        public override int Defense { get => base.Defense; set => base.Defense = value; }
        public override int Intelligence { get => base.Intelligence; set => base.Intelligence = value; }
        public override RpgClass Class { get => base.Class; set => base.Class = value; }
        public new List<GetSkillDto> Skills
        {
            get => base.Skills.Cast<GetSkillDto>().ToList();
            set => base.Skills = value.Cast<Models.Skill>().ToList();
        }
    }
}