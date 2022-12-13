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
    public class TeamContainerTest
    {
        [TestMethod]
        public void GetAllTeams_Test()
        {
            TeamContainer teamContainer = new TeamContainer(new team());

            teamContainer.GetAllTeams();

            Assert.AreEqual(3, teamContainer.GetAllTeams().Count);
        }


    }
}
