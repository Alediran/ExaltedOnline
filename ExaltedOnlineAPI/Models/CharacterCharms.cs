using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaltedOnlineAPI.Models
{
    public partial class CharacterCharms
    {
        [Key]
        public int CharacterId { get; set; }
        [Key]
        public int CharmId { get; set; }

        [ForeignKey(nameof(CharacterId))]
        [InverseProperty(nameof(Characters.CharacterCharms))]
        public virtual Characters Character { get; set; }
        [ForeignKey(nameof(CharmId))]
        [InverseProperty(nameof(Charms.CharacterCharms))]
        public virtual Charms Charm { get; set; }
    }
}
