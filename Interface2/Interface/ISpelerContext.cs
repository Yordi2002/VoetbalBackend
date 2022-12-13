using Interface.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

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
