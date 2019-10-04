using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    public partial class CharacterAttributes
    {
        public int CharacterId { get; set; }
        public int AttributeId { get; set; }
        public bool? IsFavored { get; set; }
        public int? IsSupernal { get; set; }

        public virtual Traits Attribute { get; set; }
        public virtual Characters Character { get; set; }
    }
}
