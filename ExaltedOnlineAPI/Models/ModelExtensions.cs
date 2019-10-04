using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaltedOnlineAPI.Models
{
    public partial class Charms
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public Charms(int id) : this()
        {
            Id = id;
        }
    }

    public partial class Traits
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public Traits(int id) : this()
        {
            Id = id;
        }
    }
}
