using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace _25_11_25
{
    public  interface FakeDemo
    {
        List<string> GetData(string d);
    }

    internal class Fakecls:FakeDemo
    {
        public List<string> GetData(string d)
        {
            List<string> st = new List<string>()
            {
                 "India","canada","uk","us"
            };
            var res=st.Where(c=>c.Contains(d)).ToList();
            return res;
        }
    }
     
}
