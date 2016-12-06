using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using HW8.Models;

namespace HW8.DAL
{
    public class PirateContext : DbContext
    {
        public PirateContext() : base("name=PirateContext"){}

        public virtual DbSet<Pirate> Pirates { get; set; }
        public virtual DbSet<Crew> Crews { get; set; }
        public virtual DbSet<Ship> Ships { get; set; }

    }
}