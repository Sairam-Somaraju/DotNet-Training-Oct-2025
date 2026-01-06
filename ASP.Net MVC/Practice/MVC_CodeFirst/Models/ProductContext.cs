using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace MVC_CodeFirst.Models
{
    public class ProductContext:DbContext
    {
        public ProductContext():base("name=connectstr") { }
        public DbSet<Sales> Sales { get; set; }

        public System.Data.Entity.DbSet<MVC_CodeFirst.Models.Product> Products { get; set; }
    }
}