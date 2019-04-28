using System;

namespace DesignPattern.FactoryPattern
{
    public class FactoryPatternDemo : IDesignPatternDemo
    {
        public void Run()
        {
            Console.WriteLine("I am Factory Pattern!");
            ShapeFactory shapeFactory = new ShapeFactory();

            IShape shape = shapeFactory.GetShape("Circle");
            shape.Draw();
            shape = shapeFactory.GetShape("Square");
            shape.Draw();
            shape = shapeFactory.GetShape("Rectangle");
            shape.Draw();
        }
    }
}
