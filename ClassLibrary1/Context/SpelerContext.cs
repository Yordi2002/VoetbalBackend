using Dapper;
using Interface.DTO;
using Interface.Interface;
using System.Data;

namespace DAL.Context
{
    public class SpelerContext : Database, ISpelerContext
    {
        private readonly string cons;
        private readonly IDbConnection connection;

        public SpelerContext(string cs)
        {
            this.cons = cs;
            connection = new System.Data.SqlClient.SqlConnection(cs);
        }

        //GetAll
        public List<SpelerDTO> GetAllSpelers()
        {
            var sql = "SELECT * from Speler";
            List<SpelerDTO> list = new List<SpelerDTO>();

            try
            {
                using (connection)
                {
                    list = connection.Query<SpelerDTO>(sql).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return list;
        }

        //Create
        public void AddSpeler(SpelerDTO speler) 
        {
            var sql = "INSERT INTO Speler(Naam, Land, Positie) VALUES(@Naam,@Land,@Positie)";
            try
            {
                using (connection)
                {
                    connection.Query<SpelerDTO>(sql, new { Naam = speler.Naam, Land = speler.Land, Positie = speler.Positie });
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        //Delete
        public void DeleteSpeler(SpelerDTO speler)
        {
            var sql = "DELETE FROM Speler WHERE SpelerID = @SpelerID";
            try
            {
                using (connection)
                {
                    connection.Query<SpelerDTO>(sql, new { SpelerID = speler.SpelerID});
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        //Update
        public void UpdateSpeler(SpelerDTO speler)
        {
            var sql = "Update Speler SET Naam = @Naam, Land = @Land, Positie = @Positie, TeamID = @TeamID WHERE SpelerID = '" + speler.SpelerID + "'";
            try
            {
                using (connection)
                {
                    connection.Query<SpelerDTO>(sql, new { Naam = speler.Naam, Land = speler.Land, Positie = speler.Positie, TeamID = speler.TeamID});
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        //GetID
        public SpelerDTO GetSpelerById(int id)
        {
            SpelerDTO speler = new SpelerDTO();
            var sql = "SELECT * FROM Speler WHERE SpelerID = '" + id + "'";

            try
            {
                using (connection)
                {
                    speler = connection.QuerySingle<SpelerDTO>(sql);
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return speler;
        }
    }
}
