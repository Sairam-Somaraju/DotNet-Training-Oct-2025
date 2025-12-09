using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_11_25
{
    internal class DefaultConstructor
    {
        public static void Main(String[] args)
        {
            DepartmentConstructor dpcon1 = new DepartmentConstructor(103, "developer", "Bengaluru");
            dpcon1.DisplayDepartmentInfo();

            DepartmentConstructor dpcon2 = new DepartmentConstructor(104, "testing", "Vizag");
            dpcon2.DisplayDepartmentInfo();

            DepartmentConstructor dpcon = new DepartmentConstructor();
            dpcon.DisplayDepartmentInfo();

            DepartmentConstructor dpcon3 = new DepartmentConstructor(102,"Consultant","Hyderabad");
            dpcon3.DisplayDepartmentInfo();

            DepartmentConstructor dpcon4 = new DepartmentConstructor(dpcon3);
            dpcon4.DisplayDepartmentInfo();



        }
    }
}
