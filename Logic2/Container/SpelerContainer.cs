using Interface.Interface;
using Logic.Classes;

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

            List<Speler> spelerList = new List<Speler>();

            foreach (var d in dtos)
            {
                spelerList.Add(new Speler(d));

            }
            return spelerList;
        }
        public void AddSpeler(Speler speler)
        {
            context.AddSpeler(speler.ToDTO());
        }
        public void DeleteSpeler(Speler speler)
        {
            context.DeleteSpeler(speler.ToDTO());
        }
        public void UpdateSpeler(Speler speler)
        {
            context.UpdateSpeler(speler.ToDTO());
        }
        public Speler GetSpelerById(int id)
        {
            Speler speler = new Speler(context.GetSpelerById(id));
            return speler;

        }


    }
}
