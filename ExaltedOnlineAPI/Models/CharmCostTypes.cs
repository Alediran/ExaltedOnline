using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    public partial class CharmCostTypes
    {
        public CharmCostTypes()
        {
            CharmCosts = new HashSet<CharmCosts>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string DisplayFormat { get; set; }

        public virtual ICollection<CharmCosts> CharmCosts { get; set; }
    }
}
