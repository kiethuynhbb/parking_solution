using App.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.DataProvider.Models
{
    public class Capacity : EntityBase<int>
    {
        [JsonProperty(PropertyName = "Amount")]
        public int Amount { get; set; }

        [JsonProperty(PropertyName = "InActive")]
        public bool InActive { get; set; }

        [JsonProperty(PropertyName = "LevelId")]
        public int LevelId { get; set; }
    }
}
