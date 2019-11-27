using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaltedOnlineAPI.Models
{
    public partial class IntimaciesIntensity
    {
        public IntimaciesIntensity()
        {
            CharacterIntimacies = new HashSet<CharacterIntimacies>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        public string Description { get; set; }

        [InverseProperty("Intensity")]
        public virtual ICollection<CharacterIntimacies> CharacterIntimacies { get; set; }
    }
}
