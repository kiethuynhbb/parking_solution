using System;
using System.Collections.Generic;
using System.Text;

namespace App.Entities
{
    public class Capacity : EntityBase<int>
    {
        public int Amount { get; set; }

        public bool InActive { get; set; }

        public int LevelId { get; set; }

        public Level Level { get; set; }
    }
}
