using System;
using System.Collections.Generic;

namespace DesignPattern
{
    class Program
    {
        /// <summary>
        /// 设计模式Demo实例字典
        /// </summary>
        private static readonly Dictionary<DesignPatternEnum, IDesignPatternDemo> _DesignPatternDemos = new Dictionary<DesignPatternEnum, IDesignPatternDemo>
        {
            { DesignPatternEnum.FactoryPattern,         new FactoryPattern.FactoryPatternDemo()                 },
            { DesignPatternEnum.AbstractFactoryPattern, new AbstractFactoryPattern.AbstractFactionPatternDemo() },
            { DesignPatternEnum.SingletonPattern,       new SingletonPattern.SingletonPatternDemo()             },
            { DesignPatternEnum.BuilderPattern,         new BuilderPattern.BuilderPatternDemo()                 },
            { DesignPatternEnum.PrototypePattern,       new PrototypePattern.PrototypePatternDemo()             },
            { DesignPatternEnum.AdapterPattern,         new AdapterPattern.AdapterPatternDemo()                 },
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello! I am Design Pattern Test Program!");
            Console.WriteLine("The following design patterns are currently supported:");
            // 通过反射输出枚举值，提供选项
            foreach (DesignPatternEnum item in Enum.GetValues(typeof(DesignPatternEnum)))
                Console.WriteLine("{0:#0}:{1}", ((int)item), item);
            Console.Write("please choose:");
            // 获取用户输入
            var optStr = Console.ReadLine();
            try
            {
                // 通过反射将输入转为枚举值
                DesignPatternEnum opt = (DesignPatternEnum)Enum.Parse(typeof(DesignPatternEnum), optStr);
                // 在字典中尝试获取对应设计模式实例对象
                if (_DesignPatternDemos.TryGetValue(opt, out IDesignPatternDemo designPatternDemo))
                {
                    // 执行对应设计模式Demo
                    designPatternDemo.Run();
                }
                else
                {
                    // 当未找到该对象时抛出异常
                    throw new ArgumentOutOfRangeException("opt");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception:{0}", ex.Message);
            }

        }
    }
}
