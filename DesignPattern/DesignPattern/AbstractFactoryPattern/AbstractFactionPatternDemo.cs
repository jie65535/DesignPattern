namespace DesignPattern.AbstractFactoryPattern
{
    class AbstractFactionPatternDemo
    {
        public static void Run()
        {
            System.Console.WriteLine("I am Abstract Faction Pattern");

            AbstractFactory shapeFactory = FactoryProducer.GetFactory("Shape");
            IShape shape = shapeFactory.GetShape("Circle");
            shape.Draw();
            shape = shapeFactory.GetShape("Rectangle");
            shape.Draw();
            shape = shapeFactory.GetShape("Square");
            shape.Draw();

            AbstractFactory colorFactory = FactoryProducer.GetFactory("Color");
            IColor color = colorFactory.GetColor("Red");
            color.Fill();
            color = colorFactory.GetColor("Green");
            color.Fill();
            color = colorFactory.GetColor("Blue");
            color.Fill();
        }
    }
}
