using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    public partial class CharmCosts
    {
        public int CharmId { get; set; }
        public int CostTypeId { get; set; }
        public int DisplayOrder { get; set; }
        public int Quantity { get; set; }

        public virtual Charms Charm { get; set; }
        public virtual CharmCostTypes CostType { get; set; }
    }
}
