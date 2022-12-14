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
    public class SpelerContext : ISpelerContext
    {
        private readonly string connectionstring;
        private readonly SQLVerbinding con;
        public SpelerContext(string cs)
        {
            connectionstring = cs;
            con = new SQLVerbinding(connectionstring);
        }

        public List<SpelerDTO> GetAllSpelers()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select Speler.*, Teams.TeamNaam From Speler INNER JOIN Teams On Speler.TeamID = Teams.TeamID", con);
                List<SpelerDTO> dtos = new List<SpelerDTO>();
                cmd.ExecuteNonQuery();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    SpelerDTO dto = new SpelerDTO();
                    dto.SpelerID = Convert.ToInt32(r["SpelerID"]);
                    dto.TeamID = Convert.ToInt32(r["TeamID"]);
                    dto.Naam = r["Naam"].ToString();
                    dto.Land = r["Land"].ToString();
                    dto.Positie = r["Positie"].ToString();
                    dto.TeamNaam = r["TeamNaam"].ToString();

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
    }
}
