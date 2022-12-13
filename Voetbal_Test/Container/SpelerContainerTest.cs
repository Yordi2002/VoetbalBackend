using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using Logic.Classes;
using UnitTest.DALTest;

namespace UnitTest.Container
{
    [TestClass]
    public class SpelerContainerTest
    {
        [TestMethod]
        public void GetAllSpelers_Test()
        {
            SpelerContainer spelerContainer = new SpelerContainer(new speler());

            spelerContainer.GetAllSpelers();

            Assert.AreEqual(3, spelerContainer.GetAllSpelers().Count);
        }


    }
}