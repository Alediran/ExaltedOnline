using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ExaltedOnlineAPI.Models
{
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
    public partial class ExaltedDBContext : DbContext
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
    {
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ExaltedDBContext()
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public ExaltedDBContext(DbContextOptions<ExaltedDBContext> options)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
            : base(options)
        {
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual DbSet<AdditionalAbilities> AdditionalAbilities { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual DbSet<CharacterAttributes> CharacterAttributes { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual DbSet<CharacterCharms> CharacterCharms { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual DbSet<CharacterIntimacies> CharacterIntimacies { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual DbSet<Characters> Characters { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual DbSet<CharmCostTypes> CharmCostTypes { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual DbSet<CharmCosts> CharmCosts { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual DbSet<CharmDurationTypes> CharmDurationTypes { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual DbSet<CharmKeywordTypes> CharmKeywordTypes { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual DbSet<CharmKeywords> CharmKeywords { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual DbSet<CharmPrerequisites> CharmPrerequisites { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual DbSet<CharmTraits> CharmTraits { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual DbSet<CharmTypes> CharmTypes { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual DbSet<Charms> Charms { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual DbSet<Games> Games { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual DbSet<IntimaciesIntensity> IntimaciesIntensity { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual DbSet<TraitTypes> TraitTypes { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual DbSet<Traits> Traits { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        public virtual DbSet<Weapons> Weapons { get; set; }
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("");
            }
        }

#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
        protected override void OnModelCreating(ModelBuilder modelBuilder)
#pragma warning restore CS1591 // Missing XML comment for publicly visible type or member
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
                    .HasName("PK__Characte__C9635B3E5DA9D7EB");

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
                    .HasName("PK__Characte__1B6CA57AF937A3CE");

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
                    .HasName("PK__CharmKey__E20ADEF571BAFE44");

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
                    .HasName("PK__CharmPre__F5505C0D2DD5C076");

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
                    .HasName("PK__CharmTra__09A0D80B9E163D09");

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

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.InverseParent)
                    .HasForeignKey(d => d.ParentId)
                    .HasConstraintName("FK_Traits_ToParentTraits");

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
