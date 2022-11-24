using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.DTO
{
    public class StadionDTO
    {
        public int StadionID { get; set; }
        public string StadionNaam { get; set; }
        public int Capaciteit { get; set; }
        public string Locatie { get; set; }

        public StadionDTO(int StadionID, string StadionNaam, int Capaciteit, string Locatie)
        {
            StadionID = StadionID;
            StadionNaam = StadionNaam;
            Capaciteit = Capaciteit;
            Locatie = Locatie;
        }

        public StadionDTO() { }
    }
}
