using Interface.DTO;

namespace Interface.Interface
{
    public interface ITeamContext
    {
        List<TeamDTO> GetAllTeams();
    }
}
