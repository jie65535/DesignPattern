using System;

namespace DesignPattern.BridgePattern
{
    public class Black : IColor
    {
        public void Fill()
        {
            Console.Write("[Black]");
        }
    }
}
