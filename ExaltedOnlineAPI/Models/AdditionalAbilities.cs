using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    public partial class AdditionalAbilities
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public int Total { get; set; }

        public virtual Characters Character { get; set; }
    }
}
