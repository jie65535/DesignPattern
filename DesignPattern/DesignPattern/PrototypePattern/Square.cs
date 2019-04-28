using System;

namespace DesignPattern.PrototypePattern
{
    [Serializable]
    public class Square : Shape
    {
        public override string Type => "Square";

        public override void Draw()
        {
            Console.WriteLine("Inside Square::Draw() method.");
        }
    }
}
