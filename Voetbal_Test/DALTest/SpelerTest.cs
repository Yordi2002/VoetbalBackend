using Interface.DTO;
using Interface.Interface;

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
            SpelerDTOs.Add(speler);
        }
        public void DeleteSpeler(SpelerDTO speler)
        {
            for (int i = 0; i < SpelerDTOs.Count; i++)
            {
                if (SpelerDTOs[i].SpelerID == speler.SpelerID)
                {
                    SpelerDTOs.Remove(SpelerDTOs[i]);
                }
            }
        }
        public void UpdateSpeler(SpelerDTO speler)
        {
            for(var i =0; i < SpelerDTOs.Count; i++)
            {
                if (SpelerDTOs[i].SpelerID == speler.SpelerID)
                {
                    (SpelerDTOs[i]) = speler;
                }
            }
            
        }

        public SpelerDTO GetSpelerById(int id)
        {
            for (int i = 0; i < SpelerDTOs.Count; i++)
            {
                if (SpelerDTOs[i].SpelerID == id)
                {
                    return SpelerDTOs[i];
                }
            }
            return default;
        }
    }
}
