using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

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

        //[JsonIgnore]
        public virtual ICollection<Charms> Charms { get; set; }
    }
}
