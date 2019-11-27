using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaltedOnlineAPI.Models
{
    public partial class Charms
    {
        public Charms()
        {
            CharacterCharms = new HashSet<CharacterCharms>();
            CharmCosts = new HashSet<CharmCosts>();
            CharmKeywords = new HashSet<CharmKeywords>();
            CharmPrerequisitesCharm = new HashSet<CharmPrerequisites>();
            CharmPrerequisitesCharmPrerequisite = new HashSet<CharmPrerequisites>();
            CharmTraits = new HashSet<CharmTraits>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int Essence { get; set; }
        public int TreeTypeId { get; set; }
        public int TypeId { get; set; }
        public int DurationId { get; set; }
        public string Description { get; set; }
        public bool? IsCustomCharm { get; set; }
        public int? GameId { get; set; }

        [ForeignKey(nameof(DurationId))]
        [InverseProperty(nameof(CharmDurationTypes.Charms))]
        public virtual CharmDurationTypes Duration { get; set; }
        [ForeignKey(nameof(TypeId))]
        [InverseProperty(nameof(CharmTypes.Charms))]
        public virtual CharmTypes Type { get; set; }
        [InverseProperty("Charm")]
        public virtual ICollection<CharacterCharms> CharacterCharms { get; set; }
        [InverseProperty("Charm")]
        public virtual ICollection<CharmCosts> CharmCosts { get; set; }
        [InverseProperty("Charm")]
        public virtual ICollection<CharmKeywords> CharmKeywords { get; set; }
        [InverseProperty(nameof(CharmPrerequisites.Charm))]
        public virtual ICollection<CharmPrerequisites> CharmPrerequisitesCharm { get; set; }
        [InverseProperty(nameof(CharmPrerequisites.CharmPrerequisite))]
        public virtual ICollection<CharmPrerequisites> CharmPrerequisitesCharmPrerequisite { get; set; }
        [InverseProperty("Charm")]
        public virtual ICollection<CharmTraits> CharmTraits { get; set; }
    }
}
