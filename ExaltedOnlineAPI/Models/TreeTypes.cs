using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    public partial class TreeTypes
    {
        public TreeTypes()
        {
            Charms = new HashSet<Charms>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Charms> Charms { get; set; }
    }
}
