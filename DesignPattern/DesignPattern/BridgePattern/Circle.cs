using System;

namespace DesignPattern.BridgePattern
{
    public class Circle : IShape
    {
        public IColor Color { get; set; }

        public bool Draw()
        {
            if (Color == null)
                return false;
            Color.Fill();
            Console.WriteLine("Circle");
            return true;
        }
    }
}
