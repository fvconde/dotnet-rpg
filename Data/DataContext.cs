
using System.Reflection;

namespace dotnet_rpg.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }
        public DbSet<Character> Characters => Set<Character>();
        public DbSet<Skill> Skill => Set<Skill>();

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("dbo");
            modelBuilder.Entity<Character>().HasKey(x => x.Id);
            modelBuilder.Entity<Skill>().HasKey(x => x.Id);
            modelBuilder.Entity<Skill>().Property(x => x.Name).IsRequired();
            modelBuilder.Entity<Character>()
                .HasMany(x => x.Skills)
                .WithMany(x => x.Characters)
                .UsingEntity<CharacterSkill>(
                c => c.HasOne<Skill>().WithMany().HasForeignKey(e => e.SkillId).HasConstraintName("SkillId"),
                s => s.HasOne<Character>().WithMany().HasForeignKey(e => e.CharacterId).HasConstraintName("CharacterId"));

            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}