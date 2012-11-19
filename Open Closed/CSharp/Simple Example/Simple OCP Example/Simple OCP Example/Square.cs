using System;

namespace Simple_OCP_Example
{
    class Square : Shape
    {

        public void DrawSquare()
        {
            Console.WriteLine("Square Drawing Algorithm");
        }

        public override string GetType()
        {
            return "Square";

        }
    }
}