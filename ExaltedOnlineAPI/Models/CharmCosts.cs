using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaltedOnlineAPI.Models
{
    public partial class CharmCosts
    {
        [Key]
        public int CharmId { get; set; }
        [Key]
        public int CostTypeId { get; set; }
        public int DisplayOrder { get; set; }
        public int Quantity { get; set; }

        [ForeignKey(nameof(CharmId))]
        [InverseProperty(nameof(Charms.CharmCosts))]
        public virtual Charms Charm { get; set; }
        [ForeignKey(nameof(CostTypeId))]
        [InverseProperty(nameof(CharmCostTypes.CharmCosts))]
        public virtual CharmCostTypes CostType { get; set; }
    }
}
