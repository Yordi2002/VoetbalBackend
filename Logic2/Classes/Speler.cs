using Interface.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic.Classes
{
    public class Speler
    {
        public int SpelerID { get; set; }
        public int TeamID { get; set; }
        public string Naam { get; set; }
        public string Land { get; set; }
        public string Positie { get; set; }
        public string TeamNaam { get; set; }

        public Speler(SpelerDTO spelerDTO)
        {
            SpelerID = spelerDTO.SpelerID;
            TeamID = spelerDTO.TeamID;
            Naam = spelerDTO.Naam;
            Land = spelerDTO.Land;
            Positie = spelerDTO.Positie;
            TeamNaam = spelerDTO.TeamNaam;
        }

        public Speler(int SpelerID, int TeamID, string Naam, string Land, string Positie, string TeamNaam)
        {
            this.SpelerID = SpelerID;
            this.TeamID = TeamID;
            this.Naam = Naam;
            this.Land = Land;
            this.Positie = Positie;
            this.TeamNaam = TeamNaam;
        }
        public SpelerDTO ToDTO()
        {
            return new SpelerDTO
            {
                SpelerID = SpelerID,
                TeamID = TeamID,
                Naam = Naam,
                Land = Land,
                Positie = Positie,
                TeamNaam = TeamNaam
            };
        }
        public Speler(){
        }
    }
}
