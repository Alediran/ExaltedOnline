using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    public partial class Characters
    {
        public Characters()
        {
            AdditionalAbilities = new HashSet<AdditionalAbilities>();
            CharacterAttributes = new HashSet<CharacterAttributes>();
            CharacterCharms = new HashSet<CharacterCharms>();
            CharacterIntimacies = new HashSet<CharacterIntimacies>();
            Weapons = new HashSet<Weapons>();
        }

        public int Id { get; set; }
        public int? GameId { get; set; }
        public int OwnerId { get; set; }
        public string Name { get; set; }
        public int TreeTypeId { get; set; }
        public int CasteId { get; set; }
        public string Concept { get; set; }
        public string Anima { get; set; }
        public int? Willpower { get; set; }
        public int? WillpowerCurrent { get; set; }
        public int? Essence { get; set; }
        public int? EssenceCurrentPersonal { get; set; }
        public string EssenceCurrentPeripheral { get; set; }
        public int? ExperienceCurrent { get; set; }
        public int? ExperienceTotal { get; set; }
        public int? ExperienceTypeCurrent { get; set; }
        public int? ExperienceTypeTotal { get; set; }
        public string LimitTrigger { get; set; }

        public virtual ICollection<AdditionalAbilities> AdditionalAbilities { get; set; }
        public virtual ICollection<CharacterAttributes> CharacterAttributes { get; set; }
        public virtual ICollection<CharacterCharms> CharacterCharms { get; set; }
        public virtual ICollection<CharacterIntimacies> CharacterIntimacies { get; set; }
        public virtual ICollection<Weapons> Weapons { get; set; }
    }
}
