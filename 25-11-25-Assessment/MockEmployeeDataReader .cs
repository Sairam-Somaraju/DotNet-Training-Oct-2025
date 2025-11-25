using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_11_25_Assessment
{
    internal class MockEmployeeDataReader: IEmployeeDataReader
    {
        public EmployeeRecord GetEmployeeRecord(int employeeId)
        {
            switch (employeeId)
            {
                case 101:
                    return new EmployeeRecord
                    {
                        Id = 101,
                        Name = "Sairam",
                        Role = "Developer",
                        IsVeteran = true
                    };
                case 102:
                    return new EmployeeRecord
                    {
                        Id = 102,
                        Name = "Vinnu",
                        Role = "Manager",
                        IsVeteran = false
                    };
                case 103:
                    return new EmployeeRecord
                    {
                        Id = 103,
                        Name = "Siva",
                        Role = "Intern",
                        IsVeteran = false
                    };
                default:
                    return new EmployeeRecord
                    {
                        Id = employeeId,
                        Name = "Unknown",
                        Role = "Other",
                        IsVeteran = false
                    };
            }
        }

    }
}
