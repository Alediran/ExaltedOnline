using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExaltedOnlineAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class AttributeTypes
    {
        /// <summary>
        /// 
        /// </summary>
        public AttributeTypes()
        {
            Attributes = new HashSet<Attributes>();
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
        public virtual ICollection<Attributes> Attributes { get; set; }
    }
}
