using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDoperations
{
    internal class Demo
    {
        public void ShowEmployee()
        {
           
            SqlConnection con = new SqlConnection("Integrated security=true;database=ADOnet;server=(localdb)\\MSSQLLocalDB");
            con.Open();  
             
            SqlCommand cmd = new SqlCommand("select * from Employee", con);
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read()) { 

                Console.WriteLine($"{dr[0]}   {dr[1]}   {dr[2]}    {dr[3]}    {dr[4]}");
             }
             
            con.Close();
         }

        public void AddEmployee()
        {
            
            SqlConnection con = new SqlConnection("Integrated security=true;database=ADOnet;server=(localdb)\\MSSQLLocalDB");
            con.Open();

            Console.WriteLine("Enter the id");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Enter  the Salary: ");
            int salary=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the date: ");
            string date=Console.ReadLine();
             
            SqlCommand cmd = new SqlCommand($"insert into Employee values('{name}',{salary},'{date}',{id}", con);
              
            int rowaffected = cmd.ExecuteNonQuery();

            Console.WriteLine("Total Records Inserted is " + rowaffected);
            
            con.Close();
          
        }

        public void DeleteEmployee()
        {
             SqlConnection con = new SqlConnection("Integrated security=true;database=ADOnet;server=(localdb)\\MSSQLLocalDB");
            con.Open();
            Console.WriteLine("Enter the Employe Id to delete: ");
            int empid= int.Parse(Console.ReadLine());
            SqlCommand cmd = new SqlCommand($"Delete from Employee where EmpID={empid}", con);
 
            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine("deleted "+ rowaffected);

            con.Close() ;
        }

        public void UpdateEmployee()
        { 
            SqlConnection con = new SqlConnection("Integrated security=true;database=ADOnet;server=(localdb)\\MSSQLLocalDB");
            con.Open();
            Console.WriteLine("Enter the Employe Id to Update: ");
            int empid = int.Parse(Console.ReadLine());
            SqlCommand cmd = new SqlCommand($"update  Employee set Salary=70000 where EmpID={empid}", con);
            
            int rowaffected = cmd.ExecuteNonQuery();
            Console.WriteLine("Updated "+rowaffected);
            con.Close();

        }

    }
}
