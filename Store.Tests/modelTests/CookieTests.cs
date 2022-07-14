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
        public void AreCookiesReal()
        {
            cookieThing ItsACookie = new cookieThing("Smore", 9, 0);
            //Leaving this in as a question, why doesn't it work?
            ///Assert.IsInstanceOfType(ItsACookie, cookieThing);
            Assert.AreEqual(typeof(cookieThing), ItsACookie.GetType());
        }
        [TestMethod]
        public void DoesTheCalculationWork()
        {
            cookieThing CookieCost = new cookieThing("Chocolate", 4, 0);
            CookieCost.monster = 4;
            Assert.AreEqual(7, CookieCost.monster);
        }
                [TestMethod]
        public void DoesTheFlavorPickerWorkWithRandom()
        {
            cookieThing whatsUp = new cookieThing("Random", 4, 0);
            whatsUp.flavortown = "0";
            Assert.AreNotEqual("Make sure that you got Random cookies like they asked for.", (whatsUp.flavortown));
        }
                [TestMethod]
        public void DoesTheFlavorPickerWorkNormally()
        {
            cookieThing whatsUp = new cookieThing("Random", 4, 0);
            whatsUp.flavortown = "1";
            Assert.AreEqual("Make sure that you got Chocolate Chip cookies like they asked for.", (whatsUp.flavortown));
        }
                        [TestMethod]
        public void DoesHowManyWork()
        {
            cookieThing doc = new cookieThing("okay", 4, 0);
            Assert.AreEqual(4, doc.HowMany);
        }
    }
}