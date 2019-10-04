﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace ExaltedOnlineAPI.Models
{
    public partial class Charms
    {        
        public Charms()
        {
            CharmAttributes = new HashSet<CharmAttributes>();
            CharmCosts = new HashSet<CharmCosts>();
            CharmKeywords = new HashSet<CharmKeywords>();
            CharmPrerequisitesCharm = new HashSet<CharmPrerequisites>();
            CharmPrerequisitesCharmPrerequisite = new HashSet<CharmPrerequisites>();
        }

        public Charms(int id): this()
        {
            Id = id;
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Essence { get; set; }
        public int TreeTypeId { get; set; }
        public int TypeId { get; set; }
        public int DurationId { get; set; }
        public string Description { get; set; }
        public bool? IsCustomCharm { get; set; }
        public int? GameId { get; set; }


        [JsonIgnore]
        public virtual CharmDurationTypes Duration { get; set; }

        [JsonIgnore]
        public virtual TreeTypes TreeType { get; set; }
        
        [JsonIgnore] 
        public virtual CharmTypes Type { get; set; }
        public virtual ICollection<CharmAttributes> CharmAttributes { get; set; }
        public virtual ICollection<CharmCosts> CharmCosts { get; set; }
        public virtual ICollection<CharmKeywords> CharmKeywords { get; set; }
        public virtual ICollection<CharmPrerequisites> CharmPrerequisitesCharm { get; set; }                
        public virtual ICollection<CharmPrerequisites> CharmPrerequisitesCharmPrerequisite { get; set; }
    }
}