using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaltedOnlineAPI.Models
{
    public partial class CharacterAttributes
    {
        [Key]
        public int CharacterId { get; set; }
        [Key]
        public int AttributeId { get; set; }
        public bool? IsFavored { get; set; }
        public int? IsSupernal { get; set; }

        [ForeignKey(nameof(AttributeId))]
        [InverseProperty(nameof(Traits.CharacterAttributes))]
        public virtual Traits Attribute { get; set; }
        [ForeignKey(nameof(CharacterId))]
        [InverseProperty(nameof(Characters.CharacterAttributes))]
        public virtual Characters Character { get; set; }
    }
}
