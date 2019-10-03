using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CharmCosts
    {
        /// <summary>
        /// 
        /// </summary>
        public int CharmId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int CostTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int Quantity { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Charms Charm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual CharmCostTypes CostType { get; set; }
    }
}
