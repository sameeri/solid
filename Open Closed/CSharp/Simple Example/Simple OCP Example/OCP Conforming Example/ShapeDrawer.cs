using System.Collections.Generic;

namespace OCP_Conforming_Example
{
    internal class ShapeDrawer
    {
        private List<IShape> _shapes;

        public ShapeDrawer()
        {
            _shapes = new List<IShape>()
                          {
                              new Square(),
                              new Circle()
                          };
        }
        public void DrawShapes()
        {
            //Conforms to OCP 
            //But only against a specific type of change, that happens when we add a new shape type such as Triangle.
            //Code here doesnt need to change
            //But for a change that says first draw all Squares, then circles, we have to come back here and re-think
            //What should be done if there's a sorting criteria and this sorting criteria could be in many ways?
            //100% OCP Conformation is never possible.
            //We have to be strategic in ways of closing our software.

            foreach (var shape in _shapes)
            {
                shape.Draw();
            }
        }
    }
}