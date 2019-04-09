namespace DesignPattern.AbstractFactoryPattern
{
    class ShapeFactory : AbstractFactory
    {
        public override IColor GetColor(string color)
        {
            return null;
        }

        public override IShape GetShape(string shape)
        {
            switch (shape)
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
