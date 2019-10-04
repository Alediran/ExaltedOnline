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

        public virtual DbSet<AttributeTypes> AttributeTypes { get; set; }
        public virtual DbSet<Attributes> Attributes { get; set; }
        public virtual DbSet<CharmAttributes> CharmAttributes { get; set; }
        public virtual DbSet<CharmCostTypes> CharmCostTypes { get; set; }
        public virtual DbSet<CharmCosts> CharmCosts { get; set; }
        public virtual DbSet<CharmDurationTypes> CharmDurationTypes { get; set; }
        public virtual DbSet<CharmKeywordTypes> CharmKeywordTypes { get; set; }
        public virtual DbSet<CharmKeywords> CharmKeywords { get; set; }
        public virtual DbSet<CharmPrerequisites> CharmPrerequisites { get; set; }
        public virtual DbSet<CharmTypes> CharmTypes { get; set; }
        public virtual DbSet<Charms> Charms { get; set; }
        public virtual DbSet<TreeTypes> TreeTypes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=(localdb)\\MSSQLLocalDB;Database=ExaltedDB;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AttributeTypes>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Attributes>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.AttributeType)
                    .WithMany(p => p.Attributes)
                    .HasForeignKey(d => d.AttributeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Attributes_AttributeTypes");
            });

            modelBuilder.Entity<CharmAttributes>(entity =>
            {
                entity.HasKey(e => new { e.CharmId, e.AttributeId })
                    .HasName("PK__CharmAtt__5D6E5F3957359286");

                entity.HasOne(d => d.Attribute)
                    .WithMany(p => p.CharmAttributes)
                    .HasForeignKey(d => d.AttributeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharmAttributes_Attributes");

                entity.HasOne(d => d.Charm)
                    .WithMany(p => p.CharmAttributes)
                    .HasForeignKey(d => d.CharmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_CharmAtttributes_Charms");
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
                    .HasName("PK__CharmKey__E20ADEF5B41697E1");

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
                    .HasName("PK__CharmPre__F5505C0D6418C41A");

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

                entity.HasOne(d => d.TreeType)
                    .WithMany(p => p.Charms)
                    .HasForeignKey(d => d.TreeTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Charms_TreeTypes");

                entity.HasOne(d => d.Type)
                    .WithMany(p => p.Charms)
                    .HasForeignKey(d => d.TypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Charms_CharmTypes");
            });

            modelBuilder.Entity<TreeTypes>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedNever();

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
