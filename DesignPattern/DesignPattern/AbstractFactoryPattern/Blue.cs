using System;

namespace DesignPattern.AbstractFactoryPattern
{
    class Blue : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Fill Blue");
        }
    }
}
