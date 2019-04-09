using System;

namespace DesignPattern
{
    class Program
    {
        /// <summary>
        /// <example>
        /// <code>
        /// int a;
        /// </code>
        /// </example>
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! I am Design Pattern Test Program!");
            Console.WriteLine("The following design patterns are currently supported:");
            foreach (DesignPatternEnum item in Enum.GetValues(typeof(DesignPatternEnum)))
                Console.WriteLine("{0:#0}:{1}", ((int)item), item);
            Console.Write("please choose:");
            var optStr = Console.ReadLine();
            try
            {
                DesignPatternEnum opt = (DesignPatternEnum)Enum.Parse(typeof(DesignPatternEnum), optStr);
                switch (opt)
                {
                    case DesignPatternEnum.FactoryPattern:
                        FactoryPattern.FactoryPatternDemo.Run();
                        break;
                    case DesignPatternEnum.AbstractFactoryPattern:
                        AbstractFactoryPattern.AbstractFactionPatternDemo.Run();
                        break;
                    case DesignPatternEnum.SingletonPattern:
                        SingletonPattern.SingletonPatternDemo.Run();
                        break;
                    default:
                        Console.WriteLine("Input Error!");
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:{0}", ex.Message);
            }
        }
    }
}
