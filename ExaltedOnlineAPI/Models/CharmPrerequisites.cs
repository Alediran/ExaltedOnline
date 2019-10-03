using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    public partial class CharmPrerequisites
    {
        public int CharmId { get; set; }
        public int CharmPrerequisiteId { get; set; }

        public virtual Charms Charm { get; set; }
        public virtual Charms CharmPrerequisite { get; set; }
    }
}
