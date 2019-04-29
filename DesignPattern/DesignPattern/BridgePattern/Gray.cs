using System;

namespace DesignPattern.BridgePattern
{
    public class Gray : IColor
    {
        public void Fill()
        {
            Console.Write("[Gray]");
        }
    }
}
