using System;
using System.Collections.Generic;

namespace App.Entities
{
    public class Vehicle : EntityBase<int>
    {
        public int? Type { get; set; }

        public string Name { get; set; }

        public string Brand { get; set; }

        public string LicenseNo { get; set; }

        public DateTime? ProvidedDate { get; set; }

        public DateTime? DeleteOn { get; set; }

        public int? ProvidedBy { get; set; }

        public ICollection<Parking> Parkings { get; set; }
    }
}
