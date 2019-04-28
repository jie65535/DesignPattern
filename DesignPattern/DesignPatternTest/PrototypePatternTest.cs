using System.Collections.Generic;
using DesignPattern.PrototypePattern;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DesignPatternTest
{
    [TestClass]
    public class PrototypePattern
    {
        [ClassInitialize]
        public static void TestInit(TestContext _)
        {
            ShapeCache.LoadCache();
        }

        [DataTestMethod]
        [DataRow("1", "Circle")]
        [DataRow("2", "Square")]
        [DataRow("3", "Rectangle")]
        public void TestMethod1(string id, string type)
        {
            Shape shape = ShapeCache.GetShape(id);
            Assert.AreEqual(id, shape.ID);
            Assert.AreEqual(type, shape.Type);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Assert.ThrowsException<KeyNotFoundException>(()=> ShapeCache.GetShape("4"));
        }
    }
}
