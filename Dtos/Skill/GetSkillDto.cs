using dotnet_rpg.Models.Enums;

namespace dotnet_rpg.Dtos.Skill
{
    public class GetSkillDto : Models.Skill
    {
        public override int Id { get => base.Id; set => base.Id = value; }
        public override string Name { get => base.Name; set => base.Name = value; }
        public override string? Descrition { get => base.Descrition; set => base.Descrition = value; }
        public override KeyEnum Key { get => base.Key; set => base.Key = value; }

        public string[] NameSplit { get => Name.Split(); }
    }
}
