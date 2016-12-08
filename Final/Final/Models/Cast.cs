using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Final.Models
{
    public class Cast
    {
        public int ID { get; set; }
        public int ActorID { get; set; }
        public int MovieID { get; set; }
        public string Actor { get; set; }
        public string Movie { get; set; }
    }
}