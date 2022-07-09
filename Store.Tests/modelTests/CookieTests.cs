using Microsoft.VisualStudio.TestTools.UnitTesting;
using cookieMath;
using System.Collections.Generic;
using System;

namespace cookieTesting
{
    [TestClass]
    public class cookieThingTesting
    {
        [TestMethod]
        public void screaming()
        {
            cookieThing newThing = new cookieThing();
            Assert.AreEqual(7, newThing.monster(4, 0));
            Assert.AreEqual(9, newThing.monster(5, 0));
            Assert.AreEqual(10, newThing.monster(6, 0));
            Assert.AreEqual(32, newThing.monster(19, 0));
        }
    }
}