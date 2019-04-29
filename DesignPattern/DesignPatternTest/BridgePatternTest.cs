using System;
using DesignPattern.BridgePattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTest
{
    [TestClass]
    public class BridgePatternTest
    {
        [DataTestMethod]
        [DataRow(typeof(Rectangle), typeof(Black))]
        [DataRow(typeof(Rectangle), typeof(White))]
        [DataRow(typeof(Rectangle), typeof(Gray))]
        [DataRow(typeof(Circle), typeof(Black))]
        [DataRow(typeof(Circle), typeof(White))]
        [DataRow(typeof(Circle), typeof(Gray))]
        [DataRow(typeof(Square), typeof(Black))]
        [DataRow(typeof(Square), typeof(White))]
        [DataRow(typeof(Square), typeof(Gray))]
        public void TestMethod1(Type shape_t, Type color_t)
        {
            IShape shape = (IShape)Activator.CreateInstance(shape_t);
            shape.Color = (IColor)Activator.CreateInstance(color_t);
            Assert.IsTrue(shape.Draw());
        }

        [TestMethod]
        public void TestMethod2()
        {
            IShape shape = new Rectangle();
            Assert.IsFalse(shape.Draw());
        }
    }
}
