using System;
using System.Collections.Generic;

namespace LiskovSubstitutionPrinciple_NonConforming
{
    class Program
    {
        static void Main(string[] args)
        {
            var birds = new List<Bird> {new Nightingale("Night-in-gale"), new Raven("Black Arrow"),new Penguin("Pen-ja-min")};
            ObserveMakeNoiseBehavior(birds);
            ObserveFlyBehavior(birds);
            Console.ReadKey();
        }

        private static void ObserveFlyBehavior(IEnumerable<Bird> birds)
        {
            foreach (var bird in birds)
            {
                bird.Fly();
            }
        }

        private static void ObserveMakeNoiseBehavior(IEnumerable<Bird> birds)
        {
            foreach (var bird in birds)
            {
                bird.MakeNoise();
            }
        }
    }

    abstract class Bird
    {
        public void Fly()
        {
            Console.WriteLine("Iam {0},I am flying!!", Name);
        }

        public abstract void MakeNoise();

        public String Name { get; set; }

    }


    class Raven : Bird
    {
        public Raven(string name)
        {
            Name = name;
        }
        public override void MakeNoise()
        {
            Console.WriteLine("Kaw Kaw");
        }
    }

    class Nightingale: Bird
    {
        public Nightingale(string name)
        {
            Name = name;
        }
        public override void MakeNoise()
        {
            Console.WriteLine("Tweedly Dee!");
        }
    }

    class Penguin : Bird
    {
        public Penguin(string name)
        {
            Name = name;
        }
        public override void MakeNoise()
        {
            Console.WriteLine("Sqwak!");
        }
    }

    }
