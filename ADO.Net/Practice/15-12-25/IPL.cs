using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_12_25
{
    public  class IPL
    {
        [Key]
        public  int TeamID {  get; set; }
        public string TeamName { get; set; }
        public string Captain { get; set; }
        public  string State {  get; set; }
    }
}
