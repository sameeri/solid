using System;

namespace OCP_Conforming_Example
{
    class Square : IShape
    {
        //new keywork is needed since System.Object.GetType() is a method that is automatically inherited from System.Object, Circle's base class
        // Or else we can explicitly say what we are trying to implement the IShape's GetType method
        string IShape.GetType()
        {
            return "Square";
        }

        public void Draw()
        {
            Console.WriteLine("Square Drawing Algorithm");
        }
    }
}