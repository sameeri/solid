using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LiskovSubstitutionPrinciple_Conforming
{
    class Program
    {
        static void Main(string[] args)
        {

            var birdsThatFly = new List<IFly> { new Nightingale("Night-in-gale"), new Raven("Black Arrow")};
            var birdsThatMakeNoise = new List<IMakeNoise> { new Nightingale("M Night Shyamalan"), new Raven("Raven-er"), new Penguin("Pen-jam-in") };

            ObserveMakeNoiseBehavior(birdsThatMakeNoise);
            ObserveFlyBehavior(birdsThatFly);
            Console.ReadKey();
        }

        private static void ObserveFlyBehavior(IEnumerable<IFly> items)
        {
            foreach (var item in items)
            {
                item.Fly();
            }
        }

        private static void ObserveMakeNoiseBehavior(IEnumerable<IMakeNoise> items)
        {
            foreach (var item in items)
            {
                item.MakeNoise();
            }
        }
    }

    internal interface IMakeNoise
    {
        void MakeNoise();
    }

    internal interface IFly
    {
        void Fly();
    }

    internal interface IBird
    {
        string Name { get; set; }
    }


    class Raven : IBird, IMakeNoise, IFly
    {
        public Raven(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Fly()
        {
            Console.WriteLine("I am {0}, and I am flying!", Name);
        }

        public void MakeNoise()
        {
            Console.WriteLine("Kaw Kaw");
        }
    }

    class Nightingale : IBird, IFly, IMakeNoise
    {
        public Nightingale(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void Fly()
        {
            Console.WriteLine("I am {0}, and I am flying!", Name);
        }

        public void MakeNoise()
        {
            Console.WriteLine("Tweedly Dee!");
        }
    }

    class Penguin : IBird, IMakeNoise
    {
        public Penguin(string name)
        {
            Name = name;
        }

        public string Name { get; set; }

        public void MakeNoise()
        {
            Console.WriteLine("Sqwak!");
        }
    }


}
