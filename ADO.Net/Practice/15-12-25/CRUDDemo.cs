using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_12_25
{
    internal class CRUDDemo
    {
        Model1 dc=new Model1();
        public void Display()
        {
            var res = from t in dc.IPLs
                      select t;
            foreach (var t in res)
            {
                Console.WriteLine(t.TeamID + ":" + t.TeamName + ":" + t.Captain + ":" + t.State);
            }
        }
        public void Insert()
        {
            List<IPL> ob = new List<IPL>()
            {   
            new IPL () {TeamID = 2, TeamName = "RCB", Captain = "Virat", State = "Karnataka" },
            new IPL () {TeamID = 1, TeamName = "MI", Captain = "Rohit", State = "Maharastra" },
            new IPL () {TeamID = 1, TeamName = "KKR", Captain = "Iyer", State = "WestBengal" }

            };
 
            dc.IPLs.AddRange(ob);
            int i=dc.SaveChanges();
            Console.WriteLine("Total Rows Inserted is: "+i);
        }
        
    }
}
