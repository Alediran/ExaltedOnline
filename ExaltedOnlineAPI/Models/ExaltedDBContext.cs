using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ExaltedOnlineAPI.Models
{
    public partial class ExaltedDBContext : DbContext
    {
        public ExaltedDBContext()
        {
        }

        public ExaltedDBContext(DbContextOptions<ExaltedDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AdditionalAbilities> AdditionalAbilities { get; set; }
        public virtual DbSet<CharacterAttributes> CharacterAttributes { get; set; }
        public virtual DbSet<CharacterCharms> CharacterCharms { get; set; }
        public virtual DbSet<CharacterIntimacies> CharacterIntimacies { get; set; }
        public virtual DbSet<Characters> Characters { get; set; }
        public virtual DbSet<CharmCostTypes> CharmCostTypes { get; set; }
        public virtual DbSet<CharmCosts> CharmCosts { get; set; }
        public virtual DbSet<CharmDurationTypes> CharmDurationTypes { get; set; }
        public virtual DbSet<CharmKeywordTypes> CharmKeywordTypes { get; set; }
        public virtual DbSet<CharmKeywords> CharmKeywords { get; set; }
        public virtual DbSet<CharmPrerequisites> CharmPrerequisites { get; set; }
        public virtual DbSet<CharmTraits> CharmTraits { get; set; }
        public virtual DbSet<CharmTypes> CharmTypes { get; set; }
        public virtual DbSet<Charms> Charms { get; set; }
        public virtual DbSet<Games> Games { get; set; }
        public virtual DbSet<IntimaciesIntensity> IntimaciesIntensity { get; set; }
        public virtual DbSet<TraitTypes> TraitTypes { get; set; }
        public virtual DbSet<Traits> Traits { get; set; }
        public virtual DbSet<Weapons> Weapons { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdditionalAbilities>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.AdditionalAbilities)
                    .HasForeignKey(d => d.CharacterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AdditionalAbilities_Character");
            });

            modelBuilder.Entity<CharacterAttributes>(entity =>
            {
                entity.HasKey(e => new { e.CharacterId, e.AttributeId })
                    .HasName("PK__Characte__C9635B3E70D874FA");

                entity.Property(e => e.IsFavored).HasDefaultValueSql("((0))");

                entity.Property(e => e.IsSupernal).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.CharacterAttributes)
                    .HasForeignKey(d => d.AttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharacterAttributes_Attributes");

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.CharacterAttributes)
                    .HasForeignKey(d => d.CharacterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharacterAttributes_Characters");
            });

            modelBuilder.Entity<CharacterCharms>(entity =>
            {
                entity.HasKey(e => new { e.CharacterId, e.CharmId })
                    .HasName("PK__Characte__1B6CA57A5BDC7068");

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.CharacterCharms)
                    .HasForeignKey(d => d.CharacterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharacterCharms_Characters");

                entity.HasOne(d => d.Charm)
                    .WithMany(p => p.CharacterCharms)
                    .HasForeignKey(d => d.CharmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharacterCharms_Charms");
            });

            modelBuilder.Entity<CharacterIntimacies>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.CharacterIntimacies)
                    .HasForeignKey(d => d.CharacterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharacterIntimacies_Characters");

                entity.HasOne(d => d.Intensity)
                    .WithMany(p => p.CharacterIntimacies)
                    .HasForeignKey(d => d.IntensityId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharacterIntimacies_IntimaciesIntensity");
            });

            modelBuilder.Entity<Characters>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Anima).HasMaxLength(50);

                entity.Property(e => e.Concept).HasMaxLength(50);

                entity.Property(e => e.EssenceCurrentPeripheral)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.LimitTrigger).HasMaxLength(50);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CharmCostTypes>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.DisplayFormat)
                    .IsRequired()
                    .HasMaxLength(5);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CharmCosts>(entity =>
            {
                entity.HasKey(e => new { e.CharmId, e.CostTypeId });

                entity.HasOne(d => d.Charm)
                    .WithMany(p => p.CharmCosts)
                    .HasForeignKey(d => d.CharmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Charms_CharmCosts");

                entity.HasOne(d => d.CostType)
                    .WithMany(p => p.CharmCosts)
                    .HasForeignKey(d => d.CostTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharmCostTypes_CharmCosts");
            });

            modelBuilder.Entity<CharmDurationTypes>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CharmKeywordTypes>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<CharmKeywords>(entity =>
            {
                entity.HasKey(e => new { e.CharmId, e.KeywordId })
                    .HasName("PK__CharmKey__E20ADEF54960D63C");

                entity.HasOne(d => d.Charm)
                    .WithMany(p => p.CharmKeywords)
                    .HasForeignKey(d => d.CharmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharmKeywords_Charms");

                entity.HasOne(d => d.Keyword)
                    .WithMany(p => p.CharmKeywords)
                    .HasForeignKey(d => d.KeywordId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharmKeywords_CharmKeywordTypes");
            });

            modelBuilder.Entity<CharmPrerequisites>(entity =>
            {
                entity.HasKey(e => new { e.CharmId, e.CharmPrerequisiteId })
                    .HasName("PK__CharmPre__F5505C0D0515B727");

                entity.HasOne(d => d.Charm)
                    .WithMany(p => p.CharmPrerequisitesCharm)
                    .HasForeignKey(d => d.CharmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharmPrerequisites_Charms");

                entity.HasOne(d => d.CharmPrerequisite)
                    .WithMany(p => p.CharmPrerequisitesCharmPrerequisite)
                    .HasForeignKey(d => d.CharmPrerequisiteId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharmPrerequisites_Charms1");
            });

            modelBuilder.Entity<CharmTraits>(entity =>
            {
                entity.HasKey(e => new { e.CharmId, e.TraitId })
                    .HasName("PK__CharmTra__09A0D80BB353B2A3");

                entity.HasOne(d => d.Charm)
                    .WithMany(p => p.CharmTraits)
                    .HasForeignKey(d => d.CharmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharmAtttributes_Charms");

                entity.HasOne(d => d.Trait)
                    .WithMany(p => p.CharmTraits)
                    .HasForeignKey(d => d.TraitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharmTraits_Traits");
            });

            modelBuilder.Entity<CharmTypes>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Charms>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Duration)
                    .WithMany(p => p.Charms)
                    .HasForeignKey(d => d.DurationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Charms_CharmDurationTypes");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Charms)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Charms_CharmTypes");
            });

            modelBuilder.Entity<Games>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<IntimaciesIntensity>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TraitTypes>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Traits>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.TraitType)
                    .WithMany(p => p.Traits)
                    .HasForeignKey(d => d.TraitTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Traits_TraitTypes");
            });

            modelBuilder.Entity<Weapons>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Character)
                    .WithMany(p => p.Weapons)
                    .HasForeignKey(d => d.CharacterId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Weapons_Characters");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
