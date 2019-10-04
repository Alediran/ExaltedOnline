using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    public partial class CharmTraits
    {
        public int CharmId { get; set; }
        public int TraitId { get; set; }
        public int DisplayOrder { get; set; }
        public int AttributeLevel { get; set; }

        public virtual Charms Charm { get; set; }
        public virtual Traits Trait { get; set; }
    }
}
