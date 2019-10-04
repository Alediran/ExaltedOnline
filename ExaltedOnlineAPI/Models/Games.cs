using System;
using System.Collections.Generic;

namespace ExaltedOnlineAPI.Models
{
    public partial class Games
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int? OwnerId { get; set; }
    }
}
