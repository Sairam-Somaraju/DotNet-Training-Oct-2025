using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_12_25
{
    internal class ConnectedArchitecture
    {
        //TASK- 1
        public void GetTransactions(DateTime d1, DateTime d2)
        {
             SqlConnection con = new SqlConnection("Integrated security=true;database=ADOnet;server=(localdb)\\MSSQLLocalDB");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_GetEmployeesByDOJ", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@d1", d1);
                cmd.Parameters.AddWithValue("@d2", d2);
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Console.WriteLine( $"ID: {dr["EmpID"]} , Name: {dr["EmpName"]}  ,  Salary: {dr["Salary"]}  ,  DOJ: {dr["DateOfJoin"]}");
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);

            }
            finally
            {
                con.Close();
            }

        }
        //-------TASK-2-----------------

        public void GetCommonRecords(int id)
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=ADOnet;server=(localdb)\\MSSQLLocalDB");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("sp_GetCommonRecords", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    Console.WriteLine($"ID: {dr["EmpID"]} , Name: {dr["EmpName"]}  ,  Salary: {dr["Salary"]}  ,  DOJ: {dr["DateOfJoin"]}");
                }
                dr.Close();
              

            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);

            }
            finally
            {
                con.Close();
            }

        }

        //-----------------------TASK-3------------------------------
        public void InsertRecordsusingtrans()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=ADOnet;server=(localdb)\\MSSQLLocalDB");
            con.Open();
            SqlTransaction tr = con.BeginTransaction();
            try
            {
                Console.WriteLine("Enter the name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter the salary: ");
                decimal salary = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter the Date: ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Enter dept id: ");
                int deptid = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter the dept name: ");
                string depname = Console.ReadLine();

                SqlCommand cmd2 = new SqlCommand("insert into Department (DeptID,DeptName) values (@deptid,@depname)", con, tr);
                cmd2.Parameters.AddWithValue("@deptid", deptid);
                cmd2.Parameters.AddWithValue("@depname", depname);
                cmd2.ExecuteNonQuery();

                SqlCommand cmd1 = new SqlCommand("insert into Employee  (EmpName,Salary,DateOfJoin ,DeptID) values (@name,@salary,@date,@deptid)", con, tr);
                cmd1.Parameters.AddWithValue("@name", name);
                cmd1.Parameters.AddWithValue("@salary", salary);
                cmd1.Parameters.AddWithValue("@date", date);
                cmd1.Parameters.AddWithValue("@deptid", deptid);
  
                 cmd1.ExecuteNonQuery();
                 
                tr.Commit();
                Console.WriteLine("Transaction completed successfully");
            }
            catch(Exception ex)
            {
                tr.Rollback();
                Console.WriteLine("SQL Error: "+ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        //--------------------TASK-4---------------------
        public void InsertAndFetchIdentity()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=ADOnet;server=(localdb)\\MSSQLLocalDB");
            con.Open();
            try
            {
                Console.Write("Enter Employee Name: ");
                string name = Console.ReadLine();
                Console.Write("Enter Salary: ");
                decimal salary = decimal.Parse(Console.ReadLine());
                Console.Write("Enter Date of Joining (yyyy-MM-dd): ");
                DateTime doj = DateTime.Parse(Console.ReadLine());
                Console.Write("Enter DeptID: ");
                int deptId = int.Parse(Console.ReadLine());
                string insertQuery = @"insert into Employee (EmpName, Salary, DateOfJoin, DeptID) values (@name, @salary, @doj, @deptId);
                   SELECT SCOPE_IDENTITY();";

                SqlCommand cmd = new SqlCommand(insertQuery, con);

                cmd.Parameters.AddWithValue("@name", name);
                cmd.Parameters.AddWithValue("@salary", salary);
                cmd.Parameters.AddWithValue("@doj", doj);
                cmd.Parameters.AddWithValue("@deptId", deptId);

                int newEmpID = Convert.ToInt32(cmd.ExecuteScalar());
                Console.WriteLine($"\nNew Employee Inserted with EmpID: {newEmpID}");

                SqlCommand cmdFetch = new SqlCommand("SELECT EmpID, EmpName, Salary, DateOfJoin, DeptID FROM Employee WHERE EmpID=@id", con);
                cmdFetch.Parameters.AddWithValue("@id", newEmpID);

                SqlDataReader dr = cmdFetch.ExecuteReader();

                Console.WriteLine("\nValidating inserted Employee:");

                while(dr.Read())
                {
                    Console.WriteLine(
                        $"EmpID: {dr["EmpID"]}, Name: {dr["EmpName"]}, Salary: {dr["Salary"]}, DOJ: {dr["DateOfJoin"]}, DeptID: {dr["DeptID"]}"
                    );
                }
                
                dr.Close();
            }
            catch (SqlException ex)
            {
                Console.WriteLine("SQL Error: " + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        //----------------------TASK-5-------------------------
        public void MultiResultReader()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=ADOnet;server=(localdb)\\MSSQLLocalDB");
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("sp_GetEmployeesAndDepartments", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader dr = cmd.ExecuteReader();
                Console.WriteLine("\n---- EMPLOYEES ----");

                while (dr.Read())
                {
                    Console.WriteLine($"EmpID: {dr["EmpID"]}, Name: {dr["EmpName"]}, Salary: {dr["Salary"]}, DOJ: {dr["DateOfJoin"]}, DeptID: {dr["DeptID"]}");
                }
                if (dr.NextResult())
                {
                    Console.WriteLine("\n---- DEPARTMENTS ----");
                    while (dr.Read())
                    {
                        Console.WriteLine($"DeptID: {dr["DeptID"]}, DeptName: {dr["DeptName"]}");

                    }
                }
                dr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine( "SQL Error: "+ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        public void GetEmployeeDetailsUsingOutput()
        {
            SqlConnection con = new SqlConnection("Integrated security=true;database=ADOnet;server=(localdb)\\MSSQLLocalDB");
             con.Open();
            try
            {
                Console.Write("Enter Employee ID: ");
               int empId = int.Parse(Console.ReadLine());

                SqlCommand cmd = new SqlCommand("sp_GetEmployeeDet", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@EmpID", empId);

            }
            catch (Exception ex)
            {
                Console.WriteLine("SQL Error: "+ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
