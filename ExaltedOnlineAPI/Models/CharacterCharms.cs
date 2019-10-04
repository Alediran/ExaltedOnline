using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    public partial class CharacterCharms
    {
        public int CharacterId { get; set; }
        public int CharmId { get; set; }

        public virtual Characters Character { get; set; }
        public virtual Charms Charm { get; set; }
    }
}
