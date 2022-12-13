using Interface.DTO;
using Interface.Interface;
using System.Collections.Generic;

namespace UnitTest.DALTest
{
    public class speler : ISpelerContext
    {
        public List<SpelerDTO> SpelerDTOs = new List<SpelerDTO>();

        public speler()
        {
            SpelerDTOs.Add(new SpelerDTO { SpelerID = 1, TeamID = 1, Naam = "Pieter", Land = "Nederland", Positie = "Keeper" ,TeamNaam = "sparta"});
            SpelerDTOs.Add(new SpelerDTO { SpelerID = 2, TeamID = 2, Naam = "Krul", Land = "Nederland", Positie = "Keeper", TeamNaam = "psv"});
            SpelerDTOs.Add(new SpelerDTO { SpelerID = 4, TeamID = 3, Naam = "Luuk", Land = "Nederland", Positie = "Spits" , TeamNaam = "psv" });
        }

        public List<SpelerDTO> GetAllSpelers()
        {
            return SpelerDTOs;
        }
        public void AddSpeler(SpelerDTO speler)
        {
            return;
        }
        public void DeleteSpeler(SpelerDTO speler)
        {
            return;
        }
        public void UpdateSpeler(SpelerDTO speler)
        {
            return;
        }
    }
}
