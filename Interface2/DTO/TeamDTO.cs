namespace Interface.DTO
{
    public class TeamDTO
    {
        public int TeamID { get; set; }
        public int StadionID { get; set; }
        public string TeamNaam { get; set; }
        public string ThuisShirt { get; set; }
        public string UitShirt { get; set; }
        public string StadionNaam { get; set; }


        public TeamDTO(int TeamID, int StadionID, string TeamNaam, string ThuisShirt, string UitShirt, string StadionNaam)
        {
            this.TeamID = TeamID;
            this.StadionID = StadionID;
            this.TeamNaam = TeamNaam;
            this.ThuisShirt = ThuisShirt;
            this.UitShirt = UitShirt;
            this.StadionNaam = StadionNaam;
        }

        public TeamDTO() { }
    }
}
