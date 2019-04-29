using System;
using System.Collections.Generic;

/// <summary>
/// 这是一个设计模式学习项目，内部大多数实现来源网络
/// 主要照着菜鸟教程抄了一遍，用以巩固个人基础
/// 后面计划根据自己的理解来使用各种设计模式解决实际问题
/// </summary>
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
            { DesignPatternEnum.BridgePattern,          new BridgePattern.BridgePatternDemo()                   },
            { DesignPatternEnum.FilterPattern,          new FilterPattern.FilterPatternDemo()                   },
        };

        static void Main(string[] args)
        {
            Console.WriteLine("Hello! I am Design Pattern Test Program!");
            Console.WriteLine("The following design patterns are currently supported:");
            // 使用反射将设计模式枚举条目包含序号遍历输出
            foreach (DesignPatternEnum item in Enum.GetValues(typeof(DesignPatternEnum)))
                Console.WriteLine("{0:#0}:{1}", ((int)item), item);
            Console.Write("Please choose:");
            // 获取用户输入
            var optStr = Console.ReadLine();
            try
            {
                // 使用反射实现输入判定，即用户既可以输入序号，也可以输入枚举名
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
