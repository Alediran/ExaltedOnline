using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaltedOnlineAPI.Models
{
    public partial class CharmKeywords
    {
        [Key]
        public int CharmId { get; set; }
        [Key]
        public int KeywordId { get; set; }
        public int DisplayOrder { get; set; }

        [ForeignKey(nameof(CharmId))]
        [InverseProperty(nameof(Charms.CharmKeywords))]
        public virtual Charms Charm { get; set; }
        [ForeignKey(nameof(KeywordId))]
        [InverseProperty(nameof(CharmKeywordTypes.CharmKeywords))]
        public virtual CharmKeywordTypes Keyword { get; set; }
    }
}
