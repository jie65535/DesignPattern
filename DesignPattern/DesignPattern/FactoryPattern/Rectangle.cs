using System;

namespace DesignPattern.FactoryPattern
{
    class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I am Rectangle");
        }
    }
}
