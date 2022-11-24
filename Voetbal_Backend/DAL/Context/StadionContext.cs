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
    public class StadionContext : IStadionContext
    {
        private readonly string connectionstring;
        private readonly SQLVerbinding con;
        public StadionContext(string cs)
        {
            connectionstring = cs;
            con = new SQLVerbinding(connectionstring);
        }
        public List<StadionDTO> GetAllStadions()
        {
            SqlConnection con = new SqlConnection(connectionstring);
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("Select * From Stadion", con);
                List<StadionDTO> dtos = new List<StadionDTO>();
                cmd.ExecuteNonQuery();
                SqlDataReader r = cmd.ExecuteReader();
                while (r.Read())
                {
                    StadionDTO dto = new StadionDTO();
                    dto.StadionID = Convert.ToInt32(r["StadionID"]);
                    dto.StadionNaam = r["StadionNaam"].ToString();
                    dto.Locatie = r["Locatie"].ToString();
                    dto.Capaciteit = Convert.ToInt32(r["Capaciteit"]);

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
