using System;

namespace DesignPattern.SingletonPattern
{
    class Singleton4
    {
        private static Singleton4 instance;
        public static Singleton4 Instance
        {
            get
            {
                if (instance == null)
                    instance = new Singleton4();
                return instance;
            }
        }

        private Singleton4()
        {
            Console.WriteLine("Singleton4()");
        }

        public int Number { set; get; } = 0;
    }
}
