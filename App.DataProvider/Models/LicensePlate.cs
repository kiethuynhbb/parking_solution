using App.Entities;
using Newtonsoft.Json;
using System;

namespace App.DataProvider.Models
{
    public class LicensePlate : EntityBase<int>
    {
        [JsonProperty(PropertyName = "LicenseNo")]
        public int LicenseNo { get; set; }

        [JsonProperty(PropertyName = "ProvidedDate")]
        public DateTime? ProvidedDate { get; set; }

        [JsonProperty(PropertyName = "ProvidedBy")]
        public int? ProvidedBy { get; set; }
    }
}
