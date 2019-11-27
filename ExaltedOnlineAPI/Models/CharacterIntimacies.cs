using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaltedOnlineAPI.Models
{
    public partial class CharacterIntimacies
    {
        [Key]
        public int Id { get; set; }
        public int CharacterId { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public int IntensityId { get; set; }

        [ForeignKey(nameof(CharacterId))]
        [InverseProperty(nameof(Characters.CharacterIntimacies))]
        public virtual Characters Character { get; set; }
        [ForeignKey(nameof(IntensityId))]
        [InverseProperty(nameof(IntimaciesIntensity.CharacterIntimacies))]
        public virtual IntimaciesIntensity Intensity { get; set; }
    }
}
