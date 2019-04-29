using System;

namespace DesignPattern.BridgePattern
{
    public class White : IColor
    {
        public void Fill()
        {
            Console.Write("[White]");
        }
    }
}
