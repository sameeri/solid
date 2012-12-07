using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InterfaceSegregationPrinciple
{
    class Program
    {
        private static ITelogicalService _telogicalService;

        static void Main(string[] args)
        {
            Console.WriteLine("Demo-ing the ISP problem..");
            Console.WriteLine("We just want to send usage data of our tool to engineers.");
            TheIspProblem();
            Console.ReadKey();
        }

        private static void TheIspProblem()
        {
            _telogicalService = new NotificationService();
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
            _telogicalService.SendNotification(engineers);
        }
    }
}
