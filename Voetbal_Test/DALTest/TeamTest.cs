using Interface.DTO;
using Interface.Interface;
using System.Collections.Generic;

namespace UnitTest.DALTest
{
    public class team : ITeamContext
    {
        public List<TeamDTO> TeamDTOs = new List<TeamDTO>();

        public team()
        {
            TeamDTOs.Add(new TeamDTO { TeamID = 1, StadionID = 1, TeamNaam = "sparta", ThuisShirt = "Wit-Rood", UitShirt = "Blauw", StadionNaam = "Stadion" });
            TeamDTOs.Add(new TeamDTO { TeamID = 2, StadionID = 1, TeamNaam = "psv", ThuisShirt = "Rood-Wit", UitShirt = "Zwart", StadionNaam = "Stadion" });
            TeamDTOs.Add(new TeamDTO { TeamID = 3, StadionID = 1, TeamNaam = "vvv venlo", ThuisShirt = "Geel-Zwart", UitShirt = "Zwart", StadionNaam = "Stadion" });
        }

        public List<TeamDTO> GetAllTeams()
        {
            return TeamDTOs;
        }
    }
}
