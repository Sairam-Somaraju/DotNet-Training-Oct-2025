using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVC_CodeFirst.Models
{
    //[Table("SalesTable")]
    public class Sales
    {
        [Key]
        public int SaleId { get; set; } 
        public DateTime? SaleDate { get; set; }
        public int QtySold { get; set; }
        public double SaleTotal { get; set; }

        public ICollection<Product> products { get; set; }

    }
}