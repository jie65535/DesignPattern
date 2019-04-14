using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BuilderPattern
{
    /// <summary>
    /// 包装袋
    /// </summary>
    class Wrapper : IPacking
    {
        public string Pack => "Wrapper";
    }
}
