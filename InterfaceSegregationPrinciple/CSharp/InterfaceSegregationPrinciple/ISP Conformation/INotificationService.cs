using System.Collections.Generic;

namespace ISP_Conformation
{
    internal interface INotificationService
    {
        void SendNotification(IEnumerable<User> users);
    }
}