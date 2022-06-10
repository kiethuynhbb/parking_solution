using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace App.Services.ViewModels
{
    public class VehicleDto
    {
        public int Id { get; set; }

        [JsonProperty(PropertyName = "type")]
        [Required]
        public int Type { get; set; }

        [JsonProperty(PropertyName = "Name")]
        [Required]
        public string Name { get; set; }
    }
}
