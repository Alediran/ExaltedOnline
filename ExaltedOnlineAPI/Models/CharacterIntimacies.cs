using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    public partial class CharacterIntimacies
    {
        public int Id { get; set; }
        public int CharacterId { get; set; }
        public string Name { get; set; }
        public int IntensityId { get; set; }

        public virtual Characters Character { get; set; }
        public virtual IntimaciesIntensity Intensity { get; set; }
    }
}
