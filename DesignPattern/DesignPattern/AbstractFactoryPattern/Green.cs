using System;

namespace DesignPattern.AbstractFactoryPattern
{
    class Green : IColor
    {
        public void Fill()
        {
            Console.WriteLine("Fill Green");
        }
    }
}
