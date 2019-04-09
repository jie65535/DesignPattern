using System;

namespace DesignPattern.FactoryPattern
{
    class Square : IShape
    {
        public void Draw()
        {
            Console.WriteLine("I am Square");
        }
    }
}
