using Interface.DTO;

namespace Logic.Classes
{
    public class Stadion
    {
        public int StadionID { get; set; }
        public string StadionNaam { get; set; }
        public int Capaciteit { get; set; }
        public string Locatie { get; set; }

        public Stadion(StadionDTO stadionDTO)
        {
            StadionID = stadionDTO.StadionID;
            StadionNaam = stadionDTO.StadionNaam;
            Capaciteit = stadionDTO.Capaciteit;
            Locatie = stadionDTO.Locatie;
        }

        public Stadion(int StadionID, string StadionNaam, int Capaciteit, string Locatie)
        {
            this.StadionID = StadionID;
            this.StadionNaam = StadionNaam;
            this.Capaciteit = Capaciteit;
            this.Locatie = Locatie;
        }
        public StadionDTO ToDTO()
        {
            return new StadionDTO
            {
                StadionID=StadionID,
                StadionNaam=StadionNaam,
                Capaciteit=Capaciteit,
                Locatie=Locatie
            };
        }
    }
}
