using System;
using System.Collections.Generic;

namespace ISP_Conformation
{
    internal class NotificationService : INotificationService
    {
     
        public void SendNotification(IEnumerable<User> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine("Send Notification to {0}", user.Name); 
            }
        }
    }
}