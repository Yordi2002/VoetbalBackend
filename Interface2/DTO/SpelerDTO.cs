namespace Interface.DTO
{
    public class SpelerDTO
    {
        public int SpelerID { get; set; }
        public int TeamID { get; set; }
        public string Naam { get; set; }
        public string Land { get; set; }
        public string Positie { get; set; }
        public string TeamNaam { get; set; }

        public SpelerDTO(int SpelerID, int TeamID, string Naam, string Land, string Positie, string TeamNaam)
        {
            this.SpelerID = SpelerID;
            this.TeamID = TeamID;
            this.Naam = Naam;
            this.Land = Land;
            this.Positie = Positie;
            this.TeamNaam = TeamNaam;
        }

        public SpelerDTO() { }
    }
}
