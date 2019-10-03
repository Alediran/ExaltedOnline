using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ExaltedOnlineAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Charms
    {
        /// <summary>
        /// 
        /// </summary>
        public Charms()
        {
            CharmAttributes = new HashSet<CharmAttributes>();
            CharmCosts = new HashSet<CharmCosts>();
            CharmKeywords = new HashSet<CharmKeywords>();
            CharmPrerequisitesCharm = new HashSet<CharmPrerequisites>();
            CharmPrerequisitesCharmPrerequisite = new HashSet<CharmPrerequisites>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public Charms(int id) : this()
        {
            Id = id;
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
        [Required]
        public int Essence { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public int TypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        public int DurationId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [Required]
        [StringLength(int.MaxValue)]
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool? IsCustomCharm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int? GameId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual CharmDurationTypes Duration { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual CharmTypes Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<CharmAttributes> CharmAttributes { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<CharmCosts> CharmCosts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<CharmKeywords> CharmKeywords { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<CharmPrerequisites> CharmPrerequisitesCharm { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<CharmPrerequisites> CharmPrerequisitesCharmPrerequisite { get; set; }
    }
}
