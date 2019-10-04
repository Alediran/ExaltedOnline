using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    public partial class Weapons
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public int Withering { get; set; }
        public int Decisive { get; set; }
        public int Damage { get; set; }

        public virtual Characters Character { get; set; }
    }
}
