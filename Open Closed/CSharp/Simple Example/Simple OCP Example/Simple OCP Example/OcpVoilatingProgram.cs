using System;
using System.Linq;
using System.Text;

namespace Simple_OCP_Example
{
    class OcpVoilatingProgram
    {
        static void Main(string[] args)
        {
            Console.WriteLine("OCP Voilating example");
            var drawThoseShapes = new ShapeDrawer();
            drawThoseShapes.DrawShapes();
            Console.ReadKey();
        }

    }
}
