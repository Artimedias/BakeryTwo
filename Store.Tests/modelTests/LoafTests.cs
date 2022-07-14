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
        public void DoesTheCalculationWork()
        {
            LoafThing newThing = new LoafThing();
            Assert.AreEqual(5, newThing.oven(1, 0));
            Assert.AreEqual(10, newThing.oven(2, 0));
            Assert.AreEqual(10, newThing.oven(3, 0));
            Assert.AreEqual(30, newThing.oven(8, 0));
        }
        [TestMethod]
        public void DoesTheDiscountWork()
        {
            LoafThing sour = new LoafThing();
            Assert.AreNotEqual(2, sour.Discount(2, "y"));
        }
    }
}