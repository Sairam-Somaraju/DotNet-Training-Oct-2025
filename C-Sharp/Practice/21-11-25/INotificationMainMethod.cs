using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static _21_11_25.INotification;

namespace _21_11_25
{
    internal class INotificationMainMethod
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter notification type (email / sms / push): ");
            string input = Console.ReadLine();

            // Get correct notification object from factory
            INotifications notification = NotificationFactory.GetNotification(input);
             
            if (notification == null)
            {
                Console.WriteLine("Invalid notification type!");
            }
            else
            {
                Console.WriteLine("Enter your message: ");
                string msg = Console.ReadLine();

                notification.Send(msg);
            }

            Console.ReadLine();
        }
    }
}
