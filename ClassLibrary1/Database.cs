using System.Data.SqlClient;

namespace DAL
{
    public class Database
    {
        private string connectiestring;
        SqlConnection cnn;
        SqlCommand command;
        SqlDataReader reader;

        private readonly string connect;

        public Database(string cs)
        {
            connect = cs;
        }

        public Database()
        {
            connectiestring = "Server=mssqlstud.fhict.local;Database=dbi459372_voetbal;User Id=dbi459372_voetbal;Password=Voetbal;";
        }
    }
}
