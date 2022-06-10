using App.Entities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace App.DataProvider.Models
{
    public class Vehicle: EntityBase<int>
    {

        [JsonProperty(PropertyName = "type")]
        public int? Type { get; set; }

        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "LicenseNo")]
        public string LicenseNo { get; set; }

        [JsonProperty(PropertyName = "ProvidedDate")]
        public DateTime? ProvidedDate { get; set; }

        [JsonProperty(PropertyName = "ProvidedBy")]
        public int? ProvidedBy { get; set; }

        public DateTime? DeleteOn { get; set; }
    }
}
