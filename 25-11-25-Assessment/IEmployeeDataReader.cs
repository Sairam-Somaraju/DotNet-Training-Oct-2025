using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_11_25_Assessment
{
    internal interface IEmployeeDataReader
    {
        EmployeeRecord GetEmployeeRecord(int employeeId);

    }
}
