using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic.Container;
using System;
using System.Collections.Generic;
using System.Linq;
using Logic.Classes;
using UnitTest.DALTest;
using System.Diagnostics.CodeAnalysis;

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

        [TestMethod()]
        public void GetSpelerById_Test()
        {
            SpelerContainer spelerContainer = new SpelerContainer(new speler());

            spelerContainer.GetSpelerById(1);

            Assert.AreEqual("Pieter", spelerContainer.GetSpelerById(1).Naam);
            Assert.AreEqual(1, spelerContainer.GetSpelerById(1).SpelerID);
        }


        [TestMethod]
        public void Delete_Test()
        {
            SpelerContainer spelerContainer = new SpelerContainer(new speler());

            spelerContainer.DeleteSpeler(new Speler(1, 1, "Pieter", "Nederland", "Keeper", "sparta"));

            Assert.AreEqual(2, spelerContainer.GetAllSpelers().Count());
        }

        [TestMethod]
        public void Update_Test()
        {
            SpelerContainer spelerContainer = new SpelerContainer(new speler());

            spelerContainer.UpdateSpeler(new Speler(2, 5, "Krul", "Nederland", "Keeper", "psv"));

            Assert.IsNotNull(spelerContainer.GetSpelerById(2));
            Assert.AreEqual(2, spelerContainer.GetAllSpelers()[1].SpelerID);
            Assert.AreEqual(5, spelerContainer.GetAllSpelers()[1].TeamID);
        }

        [TestMethod]
        public void Add_Test()
        {
            var context = new DALTest.speler();
            SpelerContainer spelerContainer = new SpelerContainer(context);
            Logic.Classes.Speler speler = new Logic.Classes.Speler
            {
                TeamID = 1,
                Naam = "John",
                Land = "Nederland",
                Positie = "Verdediger",
                TeamNaam = "Feyenoord"
            };

            spelerContainer.AddSpeler(speler);

            Assert.IsTrue(context.SpelerDTOs.Any(dto => dto.Naam == "John" && dto.TeamNaam == "Feyenoord"));
        }
    }
}