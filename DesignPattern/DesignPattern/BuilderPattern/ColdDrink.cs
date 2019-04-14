using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BuilderPattern
{
    /// <summary>
    /// 冷饮
    /// </summary>
    abstract class ColdDrink : IItem
    {
        public abstract string Name { get; }

        public IPacking Packing => new Bottle();

        public abstract float Price { get; }
    }
}
