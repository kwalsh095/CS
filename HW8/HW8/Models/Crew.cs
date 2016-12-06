using System;
using System.Collections.Generic;

namespace HW8.Models
{
    public class Crew
    {
        public int ID { get; set; }
        public int PirateID { get; set; }
        public int ShipID { get; set; }
        public decimal Booty { get; set; }

        public virtual Pirate Pirate { get; set; }
        public virtual Ship Ship { get; set; }
    }
}