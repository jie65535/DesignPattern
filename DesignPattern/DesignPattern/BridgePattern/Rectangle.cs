using System;

namespace DesignPattern.BridgePattern
{
    public class Rectangle : IShape
    {
        public IColor Color { get; set; }

        public bool Draw()
        {
            if (Color == null)
                return false;
            Color.Fill();
            Console.WriteLine("Rectangle");
            return true;
        }
    }
}
