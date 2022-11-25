using Interface.DTO;
using Interface.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Context
{
    public class TeamContext : ITeamContext
    {
        private readonly string connectionstring;
        private readonly SQLVerbinding con;
        public TeamContext(string cs)
        {
            connectionstring = cs;
            con = new SQLVerbinding(connectionstring);
        }

        public List<TeamDTO> GetAllTeams()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Teams.*, Stadion.StadionNaam From Teams INNER JOIN Stadion On Teams.StadionID = Stadion.StadionID", con);
                List<TeamDTO> dtos = new List<TeamDTO>();
                cmd.ExecuteNonQuery();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    TeamDTO dto = new TeamDTO();
                    dto.TeamID = Convert.ToInt32(r["TeamID"]);
                    dto.StadionID = Convert.ToInt32(r["StadionID"]);
                    dto.TeamNaam = r["Teamnaam"].ToString();
                    dto.ThuisShirt = r["ThuisShirt"].ToString();
                    dto.UitShirt = r["Uitshirt"].ToString();
                    dto.StadionNaam = r["StadionNaam"].ToString();

                    dtos.Add(dto);

                }
                r.Close();

                return dtos;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception Message: " + ex.Message);
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        
        /*
        public List<TeamDTO> GetAllWedstrijden()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Wedstrijd.*, Stadion.StadionNaam, Teams.TeamNaam From Wedstrijd INNER JOIN Stadion On Wedstrijd.StadionID = Stadion.StadionID INNER JOIN Teams On Wedstrijd.ThuisTeamID  = Teams.TeamID", con);
                List<TeamDTO> dtos = new List<TeamDTO>();
                cmd.ExecuteNonQuery();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    TeamDTO dto = new TeamDTO();
                    dto.WedstrijdID = Convert.ToInt32(r["WedstrijdID"]);
                    dto.ThuisTeamID = Convert.ToInt32(r["ThuisTeamID"]);
                    dto.UitTeamID = Convert.ToInt32(r["UitTeamID"]);
                    dto.StadionID = Convert.ToInt32(r["StadionID"]);
                    dto.TeamNaam = r["Teamnaam"].ToString();
                    dto.StadionNaam = r["StadionNaam"].ToString();

                    dtos.Add(dto);

                }
                r.Close();

                return dtos;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Exception Message: " + ex.Message);
                throw;
            }
            finally
            {
                con.Close();
            }
        }
        */
    }
}
