using App.Entities;
using Newtonsoft.Json;
using System;

namespace App.DataProvider.Models
{
    public class Parking : EntityBase<int>
    {
        [JsonProperty(PropertyName = "LevelId")]
        public int LevelId { get; set; }

        [JsonProperty(PropertyName = "VehicleId")]
        public int VehicleId { get; set; }

        [JsonProperty(PropertyName = "FromDate")]
        public DateTime FromDate { get; set; }

        [JsonProperty(PropertyName = "EndDate")]
        public DateTime? EndDate { get; set; }

        [JsonProperty(PropertyName = "CardNo")]
        public int CardNo { get; set; }
    }
}
