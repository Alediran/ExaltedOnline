using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ExaltedOnlineAPI.Models
{
    public partial class CharmTypes
    {
        public CharmTypes()
        {
            Charms = new HashSet<Charms>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string Description { get; set; }

        [InverseProperty("Type")]
        public virtual ICollection<Charms> Charms { get; set; }
    }
}
