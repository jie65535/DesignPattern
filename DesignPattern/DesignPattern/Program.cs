using System;

/// <summary>
/// 这是一个设计模式学习项目，内部大多数实现来源网络
/// 主要照着菜鸟教程抄了一遍，用以巩固个人基础
/// 后面计划根据自己的理解来使用各种设计模式解决实际问题
/// </summary>
namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello! I am Design Pattern Test Program!");
            Console.WriteLine("The following design patterns are currently supported:");
            // 使用反射将设计模式枚举条目包含序号遍历输出
            foreach (DesignPatternEnum item in Enum.GetValues(typeof(DesignPatternEnum)))
                Console.WriteLine("{0:#0}:{1}", ((int)item), item);
            Console.Write("please choose:");
            var optStr = Console.ReadLine();
            try
            {
                // 使用反射实现输入判定，即用户既可以输入序号，也可以输入枚举名
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
                    case DesignPatternEnum.BuilderPattern:
                        BuilderPattern.BuilderPatternDemo.Run();
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
