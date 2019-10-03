using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExaltedOnlineAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CharmTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public CharmTypes()
        {
            Charms = new HashSet<Charms>();
        }

        /// <summary>
        /// 
        /// </summary>
        [Key]
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [StringLength(int.MaxValue)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<Charms> Charms { get; set; }
    }
}
