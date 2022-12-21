using Interface.DTO;

namespace Interface.Interface
{
    public interface IStadionContext
    {
        List<StadionDTO> GetAllStadions();
    }
}
