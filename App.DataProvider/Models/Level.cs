using App.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.DataProvider.Models
{
    public class Level : EntityBase<int>
    {

        [JsonProperty(PropertyName = "LevelNo")]
        public int LevelNo { get; set; }

        public ICollection<Capacity> Capacities { get; set; }

        public ICollection<Parking> Parkings { get; set; }
    }
}
