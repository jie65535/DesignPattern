namespace DesignPattern.AbstractFactoryPattern
{
    class FactoryProducer
    {
        public static AbstractFactory GetFactory(string choice)
        {
            switch (choice)
            {
                case "Shape":
                    return new ShapeFactory();
                case "Color":
                    return new ColorFactory();
                default:
                    return null;
            }
        }
    }
}
