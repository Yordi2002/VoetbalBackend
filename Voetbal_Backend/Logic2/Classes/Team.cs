using Interface.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes
{
    public class Team
    {
        public int TeamID { get; set; }
        public int StadionID { get; set; }
        public string TeamNaam { get; set; }
        public string ThuisShirt { get; set; }
        public string UitShirt { get; set; }
        public string StadionNaam { get; set; }

        public Team(TeamDTO teamDTO)
        {
            TeamID = teamDTO.TeamID;
            StadionID = teamDTO.StadionID;
            TeamNaam = teamDTO.TeamNaam;
            ThuisShirt = teamDTO.ThuisShirt;
            UitShirt = teamDTO.UitShirt;
            StadionNaam = teamDTO.StadionNaam;
        }

 

        public Team(int TeamID, int StadionID, string TeamNaam, string ThuisShirt, string UitShirt, string StadionNaam)
        {
            TeamID = TeamID;
            StadionID = StadionID;
            TeamNaam = TeamNaam;
            ThuisShirt = ThuisShirt;
            UitShirt = UitShirt;
            StadionNaam = StadionNaam;
        }

        public TeamDTO ToDTO()
        {
            return new TeamDTO
            {
                TeamID = TeamID,
                StadionID = StadionID,
                TeamNaam = TeamNaam,
                ThuisShirt = ThuisShirt,
                UitShirt = UitShirt,
                StadionNaam = StadionNaam
            };
        }
    }
}
