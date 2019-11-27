using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaltedOnlineAPI.Models
{
    public partial class Traits
    {
        public Traits()
        {
            CharacterAttributes = new HashSet<CharacterAttributes>();
            CharmTraits = new HashSet<CharmTraits>();
            InverseParent = new HashSet<Traits>();
        }

        [Key]
        public int Id { get; set; }
        public int? ParentId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int TraitTypeId { get; set; }
        public string Description { get; set; }

        [ForeignKey(nameof(ParentId))]
        [InverseProperty(nameof(Traits.InverseParent))]
        public virtual Traits Parent { get; set; }
        [ForeignKey(nameof(TraitTypeId))]
        [InverseProperty(nameof(TraitTypes.Traits))]
        public virtual TraitTypes TraitType { get; set; }
        [InverseProperty("Attribute")]
        public virtual ICollection<CharacterAttributes> CharacterAttributes { get; set; }
        [InverseProperty("Trait")]
        public virtual ICollection<CharmTraits> CharmTraits { get; set; }
        [InverseProperty(nameof(Traits.Parent))]
        public virtual ICollection<Traits> InverseParent { get; set; }
    }
}
