using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment4.Notification_Project
{
    internal class EmailNotificationService : INotificationService
    {
        public void SendNotification(string reciepent, string message)
        {
            Console.WriteLine($"The email is sent to {reciepent} and the body is {message}");
            Console.WriteLine("Email Sent Successfully\n");
        }
    }
}
