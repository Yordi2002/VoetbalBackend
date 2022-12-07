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
    public class StadionContainer
    {
        private IStadionContext context;

        public StadionContainer(IStadionContext _context)
        {
            context = _context;
        }
        public List<Stadion> GetAllStadions()
        {
            var dtos = context.GetAllStadions();

            List<StadionDTO> stadionDTOlist = context.GetAllStadions();
            List<Stadion> stadionList = new List<Stadion>();

            foreach (var d in dtos)
            {
                stadionList.Add(new Stadion(d));

            }
            return stadionList;
        }
    }
}
