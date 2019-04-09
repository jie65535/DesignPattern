using System;

namespace DesignPattern.SingletonPattern
{
    sealed class Singleton1
    {
        // .NET 4.0   Lazy<T>
        private static readonly Lazy<Singleton1> _Instance = new Lazy<Singleton1>(() => new Singleton1());
        public static Singleton1 Instance => _Instance.Value;

        private Singleton1()
        {
            Console.WriteLine("Singleton1()");
        }

        public int Number { set; get; } = 0;
    }
}
