using System.Data.SqlClient;

namespace DAL
{
    public class SQLVerbinding
    {
        private readonly string connect;

        public SQLVerbinding(string cs)
        {
            connect = cs;
        }

        public static SqlConnection returnconnection()
        {
            try
            {
                return new SqlConnection("Server=mssqlstud.fhict.local;Database=dbi459372_voetbal;User Id=dbi459372_voetbal;Password=Voetbal");
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
