using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    public partial class IntimaciesIntensity
    {
        public IntimaciesIntensity()
        {
            CharacterIntimacies = new HashSet<CharacterIntimacies>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CharacterIntimacies> CharacterIntimacies { get; set; }
    }
}
