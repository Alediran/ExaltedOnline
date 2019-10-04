using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    public partial class TraitTypes
    {
        public TraitTypes()
        {
            Traits = new HashSet<Traits>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Traits> Traits { get; set; }
    }
}
