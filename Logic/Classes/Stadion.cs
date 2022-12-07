using Interface.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes
{
    public class Stadion
    {
        public int StadionID { get; set; }
        public string StadionNaam { get; set; }
        public int Capaciteit { get; set; }
        public string Locatie { get; set; }

        public Stadion(StadionDTO stadionDTO)
        {
            StadionID = stadionDTO.StadionID;
            StadionNaam = stadionDTO.StadionNaam;
            Capaciteit = stadionDTO.Capaciteit;
            Locatie = stadionDTO.Locatie;
        }

        public Stadion(int StadionID, string StadionNaam, int Capaciteit, string Locatie)
        {
            StadionID = StadionID;
            StadionNaam = StadionNaam;
            Capaciteit = Capaciteit;
            Locatie = Locatie;
        }
        public StadionDTO ToDTO()
        {
            return new StadionDTO
            {
                StadionID=StadionID,
                StadionNaam=StadionNaam,
                Capaciteit=Capaciteit,
                Locatie=Locatie
            };
        }
    }
}
