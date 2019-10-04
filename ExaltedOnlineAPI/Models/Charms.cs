using System;
using System.Collections.Generic;

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

        public int Id { get; set; }
        public string Name { get; set; }
        public int Essence { get; set; }
        public int TypeId { get; set; }
        public int DurationId { get; set; }
        public string Description { get; set; }
        public bool? IsCustomCharm { get; set; }
        public int? GameId { get; set; }

        public virtual CharmDurationTypes Duration { get; set; }
        public virtual CharmTypes Type { get; set; }
        public virtual ICollection<CharacterCharms> CharacterCharms { get; set; }
        public virtual ICollection<CharmCosts> CharmCosts { get; set; }
        public virtual ICollection<CharmKeywords> CharmKeywords { get; set; }
        public virtual ICollection<CharmPrerequisites> CharmPrerequisitesCharm { get; set; }
        public virtual ICollection<CharmPrerequisites> CharmPrerequisitesCharmPrerequisite { get; set; }
        public virtual ICollection<CharmTraits> CharmTraits { get; set; }
    }
}
