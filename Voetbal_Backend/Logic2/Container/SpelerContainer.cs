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
    public class SpelerContainer
    {
        private ISpelerContext context;

        public SpelerContainer(ISpelerContext _context)
        {
            context = _context;
        }

        public List<Speler> GetAllSpelers()
        {
            var dtos = context.GetAllSpelers();

            List<SpelerDTO> spelerDTOlist = context.GetAllSpelers();
            List<Speler> spelerList = new List<Speler>();

            foreach (var d in dtos)
            {
                spelerList.Add(new Speler(d));

            }
            return spelerList;
        }
    }
}
