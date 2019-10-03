using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    /// <summary>
    /// 
    /// </summary>
    public partial class CharmAttributes
    {
        /// <summary>
        /// 
        /// </summary>
        public int CharmId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int AttributeId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int DisplayOrder { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int AttributeLevel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Attributes Attribute { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public virtual Charms Charm { get; set; }
    }
}
