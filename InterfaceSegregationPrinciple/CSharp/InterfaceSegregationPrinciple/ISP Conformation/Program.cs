using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISP_Conformation
{
    class Program
    {
        private static INotificationService _notificationService;
        private static ISaveImages _saveImages;
   
        static void Main(string[] args)
        {
            Console.WriteLine("After Segregating Interfaces..");
            NotifyUsers();
            SaveImages();
            Console.ReadKey();
        }

        private static void SaveImages()
        {
            _saveImages = new SaveImages();
            var image = new TelogicalImage("Awesome image" , "C:\\ProtectedData");
            _saveImages.Save(image);
        }

        private static void NotifyUsers()
        {
            _notificationService = new NotificationService();
            var engineers = new List<User>
                                {
                                    new User("Xing"),
                                    new User("Saurav"),
                                    new User("Saurabh"),
                                    new User("Gerry"),
                                    new User("Te"),
                                    new User("Rupesh"),
                                    new User("Chris"),
                                    new User("Micheal"),
                                    new User("Will"),
                                    new User("Eric"),
                                    new User("Ray"),
                                    new User("Sameeri")
                                };
            _notificationService.SendNotification(engineers);
        }
    }
}
