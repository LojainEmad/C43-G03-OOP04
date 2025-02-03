using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment4.Notification_Project
{
    internal class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recPhone, string message)
        {
            Console.WriteLine($"Sms : reciepent phonenumber {recPhone} and the body of Sms:{message} ");
            Console.WriteLine("Sms is sent Successfully\n");
        }
    }
}
