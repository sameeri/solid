using System.Collections.Generic;

namespace Simple_OCP_Example
{
    internal class ShapeDrawer
    {
        private List<Shape> _shapes;

        public ShapeDrawer()
        {

            _shapes = new List<Shape>()
                             {
                                 new Square(),
                                 new Circle()
                             };
            
        }

        public void DrawShapes()
        {

            //Voilates OCP
            //Since a new type of object involves modifying code here
            foreach (var shape in _shapes)
            {

                if (shape.GetType() == "Square")
                {
                    var s = (Square) shape;
                    s.DrawSquare();
                }
                if (shape.GetType() == "Circle")
                {
                    var s = (Circle) shape;
                    s.DrawCircle();
                }
            }
        }
    }
}