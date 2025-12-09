using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _21_11_25
{
    internal class IObserverMainmethod
    {
        public static void Main(string[] args)
        {
            IObserverNotificationService notificationService = new IObserverNotificationService();

            IObserverUser user1 = new IObserverUser("Apporv");
            IObserverUser user2 = new IObserverUser("Prince");
            IObserverUser user3 = new IObserverUser("Rathan");
            IObserverUser user4 = new IObserverUser("Satish");

            notificationService.Subscribe(user1);
            notificationService.Subscribe(user2);
            notificationService.Subscribe(user3);
            notificationService.Subscribe(user4);

            notificationService.NotifyObservers("Hello Students Happy Week end!");


            Console.WriteLine("=================");
            notificationService.Unsubscribe(user4);

            notificationService.NotifyObservers("Have a Great Day!!!");





        }
    }
}
