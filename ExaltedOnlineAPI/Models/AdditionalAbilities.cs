using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaltedOnlineAPI.Models
{
    public partial class AdditionalAbilities
    {
        [Key]
        public int Id { get; set; }
        public int CharacterId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int Total { get; set; }

        [ForeignKey(nameof(CharacterId))]
        [InverseProperty(nameof(Characters.AdditionalAbilities))]
        public virtual Characters Character { get; set; }
    }
}
