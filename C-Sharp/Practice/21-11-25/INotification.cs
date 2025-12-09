using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_25
{
    internal class INotification
    {
        internal interface INotifications
        {
            void Send(string message);

        }
        public class EmailNotification : INotifications
        {
            public void Send(string message)
            {
                Console.WriteLine("Email sent: " + message);
            }
        }
        public class SmsNotification : INotifications
        {
            public void Send(string message)
            {
                Console.WriteLine("SMS sent: " + message);
            }
        }
        public class PushNotification : INotifications
        {
            public void Send(string message)
            {
                Console.WriteLine("Push Notification sent: " + message);
            }
        }
        public class NotificationFactory
        {
            public static INotifications GetNotification(string type)
            {
                switch (type.ToLower())
                {
                    case "email": return new EmailNotification();
                    case "sms": return new SmsNotification();
                    case "push": return new PushNotification();
                    default:
                        return null;
                }
            }
        }
    }


}
