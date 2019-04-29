using System;

namespace DesignPattern.BridgePattern
{
    public class Square : IShape
    {
        public IColor Color { get; set; }

        public bool Draw()
        {
            if (Color == null)
                return false;
            Color.Fill();
            Console.WriteLine("Square");
            return true;
        }
    }
}
