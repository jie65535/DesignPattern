using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BuilderPattern
{
    /// <summary>
    /// 瓶子
    /// </summary>
    class Bottle : IPacking
    {
        public string Pack => "Bottle";
    }
}
