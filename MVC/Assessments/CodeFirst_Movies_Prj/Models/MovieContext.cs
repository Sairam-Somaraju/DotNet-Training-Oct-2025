using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace CodeFirst_Movies_Prj.Models
{
    public class MovieContext:DbContext
    {
        public MovieContext() : base("name= connectstr") { }
        public DbSet<Movie> movie { get; set; }
    }
}