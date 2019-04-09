using System;

namespace DesignPattern.AbstractFactoryPattern
{
    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I am Rectangle");
        }
    }
}
