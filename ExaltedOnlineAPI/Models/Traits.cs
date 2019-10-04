using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    public partial class Traits
    {
        public Traits()
        {
            CharacterAttributes = new HashSet<CharacterAttributes>();
            CharmTraits = new HashSet<CharmTraits>();
        }

        public int Id { get; set; }
        public int? ParentId { get; set; }
        public string Name { get; set; }
        public int TraitTypeId { get; set; }
        public string Description { get; set; }

        public virtual TraitTypes TraitType { get; set; }
        public virtual ICollection<CharacterAttributes> CharacterAttributes { get; set; }
        public virtual ICollection<CharmTraits> CharmTraits { get; set; }
    }
}
