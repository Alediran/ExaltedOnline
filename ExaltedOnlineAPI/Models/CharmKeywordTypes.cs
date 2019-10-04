﻿using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    public partial class CharmKeywordTypes
    {
        public CharmKeywordTypes()
        {
            CharmKeywords = new HashSet<CharmKeywords>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<CharmKeywords> CharmKeywords { get; set; }
    }
}