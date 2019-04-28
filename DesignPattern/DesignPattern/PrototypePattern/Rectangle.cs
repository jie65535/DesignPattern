using System;

namespace DesignPattern.PrototypePattern
{
    [Serializable]
    class Rectangle : Shape
    {
        public override string Type => "Rectangle";

        public override void Draw()
        {
            Console.WriteLine("Inside Rectangle::Draw() method.");
        }
    }
}
