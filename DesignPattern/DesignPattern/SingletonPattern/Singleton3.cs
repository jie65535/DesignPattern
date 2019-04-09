using System;

namespace DesignPattern.SingletonPattern
{
    sealed class Singleton3
    {
        private static volatile Singleton3 _Instance;
        private static object _SyncRoot = new object();
        private Singleton3()
        {
            Console.WriteLine("Singleton3()");
        }

        public static Singleton3 Instance
        {
            get
            {
                if (_Instance == null)
                {
                    lock (_SyncRoot)
                    {
                        if (_Instance == null)
                            _Instance = new Singleton3();
                    }
                }
                return _Instance;
            }
        }

        public int Number { set; get; } = 0;
    }
}
