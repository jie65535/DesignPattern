using System;

namespace DesignPattern.FactoryPattern
{
    class Circle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I am Circle");
        }
    }
}
