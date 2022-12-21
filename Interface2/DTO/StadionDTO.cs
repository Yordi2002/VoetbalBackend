namespace Interface.DTO
{
    public class StadionDTO
    {
        public int StadionID { get; set; }
        public string StadionNaam { get; set; }
        public int Capaciteit { get; set; }
        public string Locatie { get; set; }

        public StadionDTO(int StadionID, string StadionNaam, int Capaciteit, string Locatie)
        {
            this.StadionID = StadionID;
            this.StadionNaam = StadionNaam;
            this.Capaciteit = Capaciteit;
            this.Locatie = Locatie;
        }

        public StadionDTO() { }
    }
}
