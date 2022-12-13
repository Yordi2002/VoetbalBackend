using Interface.DTO;
using Interface.Interface;
using System.Collections.Generic;

namespace UnitTest.DALTest
{
    public class stadion : IStadionContext
    {
        public List<StadionDTO> stadionDTOs = new List<StadionDTO>();

        public stadion()
        {
            stadionDTOs.Add(new StadionDTO { StadionID = 1, StadionNaam = "Stadion" , Capaciteit = 23000 , Locatie = "Rotterdam"});
            stadionDTOs.Add(new StadionDTO { StadionID = 3, StadionNaam = "Stadion" , Capaciteit = 43000 , Locatie = "Rotterdam" });
            stadionDTOs.Add(new StadionDTO { StadionID = 6, StadionNaam = "Stadion" , Capaciteit = 10000 , Locatie = "Maastricht" });
        }

        public List<StadionDTO> GetAllStadions()
        {
            return stadionDTOs;
        }
    }
}
