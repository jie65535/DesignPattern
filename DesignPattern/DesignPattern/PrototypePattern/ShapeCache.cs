using System.Collections.Generic;

namespace DesignPattern.PrototypePattern
{
    public class ShapeCache
    {
        private static Dictionary<string, Shape> _ShapeMap = new Dictionary<string, Shape>();

        public static Shape GetShape(string shapeID)
        {
            Shape cachedShape = _ShapeMap[shapeID];
            return cachedShape.Clone();
        }

        public static void LoadCache()
        {
            Circle circle = new Circle
            {
                ID = "1"
            };
            _ShapeMap.Add(circle.ID, circle);

            Square square = new Square
            {
                ID = "2"
            };
            _ShapeMap.Add(square.ID, square);

            Rectangle rectangle = new Rectangle
            {
                ID = "3"
            };
            _ShapeMap.Add(rectangle.ID, rectangle);
        }
    }
}
