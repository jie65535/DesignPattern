using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.PrototypePattern
{
    [Serializable]
    public abstract class Shape : BaseClone<Shape>
    {
        public string ID { set; get; }

        public abstract string Type { get; }

        public abstract void Draw();
    }
}
