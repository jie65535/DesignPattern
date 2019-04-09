using System;

namespace DesignPattern.SingletonPattern
{
    sealed class Singleton2
    {
        // Static Initialization
        // MSDN Help:https://docs.microsoft.com/zh-cn/previous-versions/msp-n-p/ff650316(v=pandp.10)
        public static readonly Singleton2 Instance = new Singleton2();
        private Singleton2()
        {
            Console.WriteLine("Singleton2()");
        }
        public int Number { set; get; } = 0;
    }
}
