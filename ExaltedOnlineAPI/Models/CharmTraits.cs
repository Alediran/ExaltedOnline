using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaltedOnlineAPI.Models
{
    public partial class CharmTraits
    {
        [Key]
        public int CharmId { get; set; }
        [Key]
        public int TraitId { get; set; }
        public int DisplayOrder { get; set; }
        public int AttributeLevel { get; set; }

        [ForeignKey(nameof(CharmId))]
        [InverseProperty(nameof(Charms.CharmTraits))]
        public virtual Charms Charm { get; set; }
        [ForeignKey(nameof(TraitId))]
        [InverseProperty(nameof(Traits.CharmTraits))]
        public virtual Traits Trait { get; set; }
    }
}
