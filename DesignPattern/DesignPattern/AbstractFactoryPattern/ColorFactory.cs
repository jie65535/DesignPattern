namespace DesignPattern.AbstractFactoryPattern
{
    class ColorFactory : AbstractFactory
    {
        public override IColor GetColor(string color)
        {
            switch (color)
            {
                case "Red":
                    return new Red();
                case "Green":
                    return new Green();
                case "Blue":
                    return new Blue();
                default:
                    return null;
            }
        }

        public override IShape GetShape(string shape)
        {
            return null;
        }
    }
}
