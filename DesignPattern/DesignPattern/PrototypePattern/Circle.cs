﻿using System;

namespace DesignPattern.PrototypePattern
{
    [Serializable]
    public class Circle : Shape
    {
        public override string Type => "Circle";

        public override void Draw()
        {
            Console.WriteLine("Inside Circle::Draw() method.");
        }
    }
}
