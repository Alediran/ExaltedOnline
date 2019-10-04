using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    public partial class CharmDurationTypes
    {
        public CharmDurationTypes()
        {
            Charms = new HashSet<Charms>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Charms> Charms { get; set; }
    }
}
