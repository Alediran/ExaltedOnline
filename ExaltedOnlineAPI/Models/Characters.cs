using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

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

        [Key]
        public int Id { get; set; }
        public int? GameId { get; set; }
        public int OwnerId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int TreeTypeId { get; set; }
        public int CasteId { get; set; }
        [StringLength(50)]
        public string Concept { get; set; }
        [StringLength(50)]
        public string Anima { get; set; }
        public int? Willpower { get; set; }
        public int? WillpowerCurrent { get; set; }
        public int? Essence { get; set; }
        public int? EssenceCurrentPersonal { get; set; }
        [StringLength(10)]
        public string EssenceCurrentPeripheral { get; set; }
        public int? ExperienceCurrent { get; set; }
        public int? ExperienceTotal { get; set; }
        public int? ExperienceTypeCurrent { get; set; }
        public int? ExperienceTypeTotal { get; set; }
        [StringLength(50)]
        public string LimitTrigger { get; set; }

        [InverseProperty("Character")]
        public virtual ICollection<AdditionalAbilities> AdditionalAbilities { get; set; }
        [InverseProperty("Character")]
        public virtual ICollection<CharacterAttributes> CharacterAttributes { get; set; }
        [InverseProperty("Character")]
        public virtual ICollection<CharacterCharms> CharacterCharms { get; set; }
        [InverseProperty("Character")]
        public virtual ICollection<CharacterIntimacies> CharacterIntimacies { get; set; }
        [InverseProperty("Character")]
        public virtual ICollection<Weapons> Weapons { get; set; }
    }
}
