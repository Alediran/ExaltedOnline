using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    public partial class CharmKeywords
    {
        public int CharmId { get; set; }
        public int KeywordId { get; set; }
        public int DisplayOrder { get; set; }

        public virtual Charms Charm { get; set; }
        public virtual CharmKeywordTypes Keyword { get; set; }
    }
}
