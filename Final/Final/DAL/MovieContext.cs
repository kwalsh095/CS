using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using Final.Models;

namespace Final.DAL
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("name=MovieContext") { }

        public virtual DbSet<Actor> Actors { get; set; }
        public virtual DbSet<Cast> Casts { get; set; }
        public virtual DbSet<Director> Directors { get; set; }
        public virtual DbSet<Movie> Movies { get; set; }
    }
}