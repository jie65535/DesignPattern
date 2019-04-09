namespace DesignPattern.FactoryPattern
{
    class ShapeFactory
    {
        public IShape GetShape(string shapeType)
        {
            switch (shapeType)
            {
                case "Circle":
                    return new Circle();
                case "Square":
                    return new Square();
                case "Rectangle":
                    return new Rectangle();
                default:
                    return null;
            }
        }
    }
}
