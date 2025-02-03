using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment4.Notification_Project
{
    internal class PushNotificationService : INotificationService
    {
        public void SendNotification(string reciepent, string message)
        {
            Console.WriteLine($"Push Notification Reciepenet :{reciepent} , and the Body is {message} ");
            Console.WriteLine("Push Notification is send Successfully\n");
        }
    }
}
