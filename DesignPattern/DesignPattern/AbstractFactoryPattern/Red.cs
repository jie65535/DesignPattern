using System;

namespace DesignPattern.AbstractFactoryPattern
{
    class Red : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Fill Red");
        }
    }
}
