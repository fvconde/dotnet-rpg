using dotnet_rpg.Models.Enums;

namespace dotnet_rpg.Models
{
    public class Skill
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string? Descrition { get; set; }
        public virtual KeyEnum Key  { get; set; }
        public List<Character> Characters { get; set; } = new();
    }
}
