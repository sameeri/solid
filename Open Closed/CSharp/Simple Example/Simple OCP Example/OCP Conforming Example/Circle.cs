using System;

namespace OCP_Conforming_Example
{
    class Circle : IShape
    {

        //new keyword is needed since System.Object.GetType() is a method that is automatically inherited from System.Object, Circle's base class            
        public new string GetType()
        {
            return "Circle";
        }

        public void Draw()
        {
            Console.WriteLine("Circle Drawing Algorithm");
        }
    }
}