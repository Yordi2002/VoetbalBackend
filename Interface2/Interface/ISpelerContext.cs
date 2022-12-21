using Interface.DTO;

namespace Interface.Interface
{
    public interface ISpelerContext
    {
        List<SpelerDTO> GetAllSpelers();
        void AddSpeler(SpelerDTO speler);
        void DeleteSpeler(SpelerDTO speler);
        void UpdateSpeler(SpelerDTO speler);
        SpelerDTO GetSpelerById(int id);
    }
}
