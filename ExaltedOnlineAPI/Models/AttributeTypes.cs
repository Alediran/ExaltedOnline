using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    public partial class AttributeTypes
    {
        public AttributeTypes()
        {
            Attributes = new HashSet<Attributes>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Attributes> Attributes { get; set; }
    }
}
