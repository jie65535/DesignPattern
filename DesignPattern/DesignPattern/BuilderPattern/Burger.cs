using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BuilderPattern
{
    /// <summary>
    /// 汉堡
    /// </summary>
    abstract class Burger : IItem
    {
        public abstract string Name { get; }

        public IPacking Packing => new Wrapper();

        public abstract float Price { get; }
    }
}
