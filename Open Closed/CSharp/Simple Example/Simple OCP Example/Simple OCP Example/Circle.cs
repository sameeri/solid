using System;

namespace Simple_OCP_Example
{
    class Circle : Shape
    {
        public override string GetType()
        {
            return "Circle";
        }

        public void DrawCircle()
        {
            Console.WriteLine("Circle Drawing Algorithm");
        }
    }
}