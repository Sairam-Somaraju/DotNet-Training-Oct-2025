using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace _15_12_25
{
    public  class CodeFirstDemo
    {
        Model1 dc = new Model1();

        public void insertnewstudents()

        {

            try

            {

                Student s = new Student()

                {

                    Studentid = 100,

                    Studentname = "Raj",

                    DOB = DateTime.Now,

                    Class = 10,

                    Email = "raj@gmail.com"

                };

                dc.Studenttbl.Add(s);   

                int res = dc.SaveChanges(); 

                Console.WriteLine("Total record inserted is " + res);

            }

            catch (Exception)

            {

                var errors = dc.GetValidationErrors();

                foreach (var entity in errors)

                {

                    foreach (var err in entity.ValidationErrors)

                    {

                        Console.WriteLine(err.ErrorMessage);

                    }

                }

            }

        }



    }
}
