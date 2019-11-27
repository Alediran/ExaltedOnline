using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaltedOnlineAPI.Models
{
    public partial class CharmKeywordTypes
    {
        public CharmKeywordTypes()
        {
            CharmKeywords = new HashSet<CharmKeywords>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }

        [InverseProperty("Keyword")]
        public virtual ICollection<CharmKeywords> CharmKeywords { get; set; }
    }
}
