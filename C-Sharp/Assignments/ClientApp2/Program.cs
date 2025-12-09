using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels.Tcp;
using remotingtrn2;
namespace ClientApp2
{
    internal class Program
    {
        //async System.Threading.Tasks.Task 
        static void  Main(string[] args)
        {
            TcpChannel channel = new TcpChannel();
            ChannelServices.RegisterChannel(channel, false);

            remotingtrn2.IMyinter remoteObj = (IMyinter)Activator.GetObject(
                typeof(IMyinter),
                "tcp://localhost:8085/StudentService");

            Console.WriteLine("Connected to Remote Student Service");

            Console.WriteLine("\n--- Show All Students ---");
            remoteObj.ShowAllStudents();

            
            Console.Write("\nEnter Student ID: ");
            int id = int.Parse(Console.ReadLine());

            try
            {
                Student s = remoteObj.GetStudent(id);
                Console.WriteLine("\nStudent Details:");
                Console.WriteLine(s);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception Occurred: " + ex.Message);
            }
            Console.ReadLine();
        }
    }
    }
