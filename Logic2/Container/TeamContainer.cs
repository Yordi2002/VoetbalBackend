using Interface.Interface;
using Logic.Classes;

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
