using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaltedOnlineAPI.Models
{
    /// <summary>
    /// Main object for the Charms table
    /// </summary>
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

    /// <summary>
    /// Main object for the Traits table
    /// </summary>
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

    /// <summary>
    /// Main object for the Users table
    /// </summary>
    public partial class Users
    {
        /// <summary>
        /// Non-persisted Property to pass between API and Client
        /// </summary>
        public string Password { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Users()
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public Users(int id) : this()
        {
            Id = id;
        }
    }
}
