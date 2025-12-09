using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using static System.Console;

public class Student
{
    public string Name { get; set; }
    public string Class { get; set; }
    public int TotalMarks { get; set; }
     
    public override string ToString()
        => $"{Name}, Class: {Class}, Total Marks: {TotalMarks}";
}

public class StudentClass
{ 
    private Dictionary<int, Student> students = new Dictionary<int, Student>
    {
        { 1, new Student { Name="Sairam",   Class="A", TotalMarks=450  } },
        { 2, new Student { Name="Venkat",  Class="B", TotalMarks=290  } },
        { 3, new Student { Name="Satheesh",   Class="C",  TotalMarks=510  } },
        { 4, new Student { Name="Siva",   Class="D",  TotalMarks=350  } }
    };
 
    public void ShowAllStudents()
    { 
            Console.WriteLine("\n--- All Students ---\n");

            foreach (var s in students.Values)
            {
                Console.WriteLine(s);  // Calls overridden ToString()
            }
        
    }
     
    public async Task<Student> GetStudentAsync(int id)
    {
        try
        {
            return await Task.Run(() =>
            { 
                if (id == 0)
                {
                    return new Student
                    {
                        Name = "Default Student",
                        Class = "NA",
                        TotalMarks = 0,

                    };
                }
                 
                if (students.TryGetValue(id, out Student st))
                { 
                    if (st.TotalMarks < 300)
                        throw new Exception("Student marks are less than 500");

                    return st;
                }
                else
                {
                    throw new Exception("Student ID not found");
                }
            });
        }
        catch (Exception ex) when (ex.Message.Contains("less than 500"))
        {
            await Task.Run(() => WriteLine("Marks too low! " + ex.Message));
            return null;
        }
        catch (Exception ex)
        {
            await Task.Run(() =>  WriteLine("Error in GetStudentAsync(): " + ex.Message));
            return null;
        }
    }
}

public class Program
{
    static async Task Main(string[] args)
    {
        StudentClass student = new StudentClass();
  
        student.ShowAllStudents();

        WriteLine("\n--- Testing GetStudentAsync ---\n");
         
        var s1 = await student.GetStudentAsync(1);
        WriteLine(s1);
 
        var s2 = await student.GetStudentAsync(2);
 
        var s3 = await student.GetStudentAsync(0);
        WriteLine(s3);
        
        var s4 = await student.GetStudentAsync(999);
    }
}
