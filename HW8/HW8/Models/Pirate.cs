using System;
using System.Collections.Generic;

namespace HW8.Models
{
    public class Pirate
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime Conscript { get; set; }

        public virtual IEnumerable<Crew> Crews { get; set; }
        public virtual IEnumerable<Ship> Ships { get; set; }
    }
}