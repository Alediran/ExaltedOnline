using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    public partial class Attributes
    {
        public Attributes()
        {
            CharmAttributes = new HashSet<CharmAttributes>();
        }

        public Attributes(int id): this()
        {
            Id = id;
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int AttributeTypeId { get; set; }
        public string Description { get; set; }

        public virtual AttributeTypes AttributeType { get; set; }
        public virtual ICollection<CharmAttributes> CharmAttributes { get; set; }
    }
}
