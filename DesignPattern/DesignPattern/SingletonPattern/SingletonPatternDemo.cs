using System;

namespace DesignPattern.SingletonPattern
{
    class SingletonPatternDemo : IDesignPatternDemo
    {
        public void Run()
        {
            Console.WriteLine("I am Singleton Pattern!");

            // Singleton1
            Singleton1.Instance.Number = 10;
            Console.WriteLine("Singleton1.Instance.Namber={0}", Singleton1.Instance.Number);
            Singleton1.Instance.Number = 20;
            Console.WriteLine("Singleton1.Instance.Namber={0}", Singleton1.Instance.Number);

            // Singleton2
            Singleton2.Instance.Number = 30;
            Console.WriteLine("Singleton2.Instance.Namber={0}", Singleton2.Instance.Number);
            Singleton2.Instance.Number = 40;
            Console.WriteLine("Singleton2.Instance.Namber={0}", Singleton2.Instance.Number);

            // Singleton3
            Singleton3.Instance.Number = 50;
            Console.WriteLine("Singleton3.Instance.Namber={0}", Singleton3.Instance.Number);
            Singleton3.Instance.Number = 60;
            Console.WriteLine("Singleton3.Instance.Namber={0}", Singleton3.Instance.Number);

            // Singleton4
            Singleton4.Instance.Number = 70;
            Console.WriteLine("Singleton4.Instance.Namber={0}", Singleton4.Instance.Number);
            Singleton4.Instance.Number = 80;
            Console.WriteLine("Singleton4.Instance.Namber={0}", Singleton4.Instance.Number);
        }
    }
}
