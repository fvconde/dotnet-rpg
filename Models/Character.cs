using dotnet_rpg.Models.Enums;

namespace dotnet_rpg.Models
{
    public class Character
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; } = "Frodo";
        public virtual int HitPoints { get; set; } = 100;
        public virtual int Strength { get; set; } = 10;
        public virtual int Defense { get; set; } = 10;
        public virtual int Intelligence { get; set; } = 10;
        public virtual RpgClass Class { get; set; } = RpgClass.Knight;
        public virtual List<Skill> Skills { get; set; } = new();
    }
}