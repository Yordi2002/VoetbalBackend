using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.DTO
{
    public class TeamDTO
    {
        public int TeamID { get; set; }
        public int StadionID { get; set; }
        public string TeamNaam { get; set; }
        public string ThuisShirt { get; set; }
        public string UitShirt { get; set; }
        public string StadionNaam { get; set; }


        public TeamDTO(int TeamID, int StadionID, string TeamNaam, string ThuisShirt, string UitShirt, string StadionNaam)
        {
            TeamID = TeamID;
            StadionID = StadionID;
            TeamNaam = TeamNaam;
            ThuisShirt = ThuisShirt;
            UitShirt = UitShirt;
            StadionNaam = StadionNaam;
        }

        public TeamDTO() { }
    }
}
