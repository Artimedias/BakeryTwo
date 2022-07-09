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
            int a = 8;
            cookieThing newThing = new cookieThing();
            Assert.AreEqual(newThing.monster(4), a);
        }
    }
}