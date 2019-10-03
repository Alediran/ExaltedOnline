using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class Attributes
    {
        /// <summary>
        /// 
        /// </summary>
        public Attributes()
        {
            CharmAttributes = new HashSet<CharmAttributes>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public Attributes(int id) : this()
        {
            Id = id;
        }

        /// <summary>
        /// 
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int AttributeTypeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual AttributeTypes AttributeType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual ICollection<CharmAttributes> CharmAttributes { get; set; }
    }
}
