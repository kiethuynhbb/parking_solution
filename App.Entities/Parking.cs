using System;
using System.Collections.Generic;
using System.Text;

namespace App.Entities
{
    public class Parking : EntityBase<int>
    {
        public int LevelId { get; set; }

        public int VehicleId { get; set; }

        public int CardNo { get; set; }

        public DateTime FromDate { get; set; }

        public DateTime? EndDate { get; set; }

        public Vehicle Vehicle { get; set; }

        public Level Level { get; set; }
    }
}
