using System;

namespace DesignPattern.PrototypePattern
{
    public class PrototypePatternDemo : IDesignPatternDemo
    {
        public void Run()
        {
            ShapeCache.LoadCache();

            Shape clonedShape1 = ShapeCache.GetShape("1");
            Console.WriteLine("Shape : " + clonedShape1.Type);
            clonedShape1.Draw();

            Shape clonedShape2 = ShapeCache.GetShape("2");
            Console.WriteLine("Shape : " + clonedShape2.Type);
            clonedShape2.Draw();

            Shape clonedShape3 = ShapeCache.GetShape("3");
            Console.WriteLine("Shape : " + clonedShape3.Type);
            clonedShape3.Draw();


        }
    }
}
