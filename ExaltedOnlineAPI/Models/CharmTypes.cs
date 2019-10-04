﻿using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace ExaltedOnlineAPI.Models
{
    public partial class CharmTypes
    {
        public CharmTypes()
        {
            Charms = new HashSet<Charms>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual ICollection<Charms> Charms { get; set; }
    }
}