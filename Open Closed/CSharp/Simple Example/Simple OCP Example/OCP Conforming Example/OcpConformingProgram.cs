using System;

namespace OCP_Conforming_Example
{
    class OcpConformingProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OCP Conforming example");
            var drawThoseShapes = new ShapeDrawer();
            drawThoseShapes.DrawShapes();
            Console.ReadKey();
        }
    }
}
