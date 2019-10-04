using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    public partial class CharmAttributes
    {
        public int CharmId { get; set; }
        public int AttributeId { get; set; }
        public int DisplayOrder { get; set; }
        public int AttributeLevel { get; set; }

        public virtual Attributes Attribute { get; set; }
        public virtual Charms Charm { get; set; }
    }
}
