using System;

namespace DesignPattern.AbstractFactoryPattern
{
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I am Circle");
        }
    }
}
