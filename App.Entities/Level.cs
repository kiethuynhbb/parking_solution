using System;
using System.Collections.Generic;
using System.Text;

namespace App.Entities
{
    public class Level : EntityBase<int>
    {
        public int LevelNo { get; set; }

        public ICollection<Capacity> Capacities { get; set; }

        public ICollection<Parking> Parkings { get; set; }

    }
}
