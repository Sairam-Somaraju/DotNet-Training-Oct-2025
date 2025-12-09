using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _25_11_25_Assessment
{
    internal class PayrollProcessor
    {
        private readonly IEmployeeDataReader dataReader;
 
        private static readonly Dictionary<int, decimal> BaseSalaries =
            new Dictionary<int, decimal>
            {
                [101] = 65000m,
                [102] = 120000m,
                [103] = 30000m
            };

        // Constructor Injection
        public PayrollProcessor(IEmployeeDataReader dataReader)
        {
            this.dataReader = dataReader;
        }
         
        public decimal CalculateTotalCompensation(int employeeId)
        {
            var emp = dataReader.GetEmployeeRecord(employeeId);

            decimal bonus = 0m;
             

            switch (emp.Role)
            {
                case "Manager":
                    if (emp.IsVeteran)
                        bonus = 10000m;
                    else
                        bonus = 5000m;
                    break;

                case "Developer":
                    bonus = 2000m;
                    break;

                case "Intern":
                    bonus = 500m;
                    break;

                default:
                    bonus = 0m;
                    break;
            }
             
            decimal baseSalary = 0m;
            BaseSalaries.TryGetValue(employeeId, out baseSalary);

            return baseSalary + bonus;
        }   

    }
}
