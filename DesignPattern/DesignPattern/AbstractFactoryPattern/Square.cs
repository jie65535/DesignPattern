using System;

namespace DesignPattern.AbstractFactoryPattern
{
    class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I am Square");
        }
    }
}
