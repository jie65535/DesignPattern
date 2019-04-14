using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPattern.BuilderPattern
{
    /// <summary>
    /// 餐点条目
    /// </summary>
    interface IItem
    {
        /// <summary>
        /// 条目名称
        /// </summary>
        string Name { get; }

        /// <summary>
        /// 包装
        /// </summary>
        IPacking Packing { get; }

        /// <summary>
        /// 价格
        /// </summary>
        float Price { get; }
    }
}
