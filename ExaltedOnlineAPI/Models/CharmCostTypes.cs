using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaltedOnlineAPI.Models
{
    public partial class CharmCostTypes
    {
        public CharmCostTypes()
        {
            CharmCosts = new HashSet<CharmCosts>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        [StringLength(5)]
        public string DisplayFormat { get; set; }

        [InverseProperty("CostType")]
        public virtual ICollection<CharmCosts> CharmCosts { get; set; }
    }
}
