using Microsoft.VisualStudio.TestTools.UnitTesting;
using LoafMath;
using System.Collections.Generic;
using System;

namespace LoafTesting
{
    [TestClass]
    public class LoafThingTesting
    {
        [TestMethod]
        public void Main()
        {
            LoafThing newThing = new LoafThing();
            Assert.AreEqual(5, newThing.oven(1, 0));
            Assert.AreEqual(10, newThing.oven(2, 0));
            Assert.AreEqual(10, newThing.oven(3, 0));
            Assert.AreEqual(30, newThing.oven(8, 0));
        }
    }
}