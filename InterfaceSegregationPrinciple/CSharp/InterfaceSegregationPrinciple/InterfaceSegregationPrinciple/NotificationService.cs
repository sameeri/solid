using System;
using System.Collections.Generic;

namespace InterfaceSegregationPrinciple
{
    internal class NotificationService : ITelogicalService
    {
        public void Print()
        {
            throw new NotImplementedException();
        }

        public void Draw(ISurface surface)
        {
            throw new NotImplementedException();
        }

        public TelogicalPaintBrush GetPaintBrush()
        {
            throw new NotImplementedException();
        }

        public TelogicalImage TakeSnapShot()
        {
            throw new NotImplementedException();
        }

        public void SendNotification(IEnumerable<User> users)
        {
            foreach (var user in users)
            {
                Console.WriteLine("Send Notification to {0}", user.Name); 
            }
        }

        public void SendNotification(User user)
        {
            
        }

        public void Save(TelogicalImage image)
        {
            throw new NotImplementedException();
        }


    }
}