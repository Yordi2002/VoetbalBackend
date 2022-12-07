using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.DTO
{
    public class SpelerDTO
    {
        public int SpelerID { get; set; }
        public int TeamID { get; set; }
        public string Naam { get; set; }
        public string Land { get; set; }
        public string Positie { get; set; }
        public string TeamNaam { get; set; }

        public SpelerDTO(int SpelerID, int TeamID, string Naam, string Land, string Positie, string TeamNaam)
        {
            SpelerID = SpelerID;
            TeamID = TeamID;
            Naam = Naam;
            Land = Land;
            Positie = Positie;
            TeamNaam = TeamNaam;
        }

        public SpelerDTO() { }
    }
}
