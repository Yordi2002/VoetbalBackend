using Interface.DTO;
using Interface.Interface;
using Logic.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Container
{
    public class TeamContainer
    {
        private ITeamContext context;

        public TeamContainer(ITeamContext _context)
        {
            context = _context;
        }

        public List<Team> GetAllTeams()
        {
            var dtos = context.GetAllTeams();

            
            List<Team> TeamList = new List<Team>();

            foreach (var d in dtos)
            {
                TeamList.Add(new Team(d));

            }
            return TeamList;
        }
    }
}
