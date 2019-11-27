using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaltedOnlineAPI.Models
{
    public partial class CharmPrerequisites
    {
        [Key]
        public int CharmId { get; set; }
        [Key]
        public int CharmPrerequisiteId { get; set; }

        [ForeignKey(nameof(CharmId))]
        [InverseProperty(nameof(Charms.CharmPrerequisitesCharm))]
        public virtual Charms Charm { get; set; }
        [ForeignKey(nameof(CharmPrerequisiteId))]
        [InverseProperty(nameof(Charms.CharmPrerequisitesCharmPrerequisite))]
        public virtual Charms CharmPrerequisite { get; set; }
    }
}
