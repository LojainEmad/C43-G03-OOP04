using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Assignment4.Notification_Project
{
    internal interface INotificationService
    {
        public void SendNotification(string reciepent, string message);

    }
}
