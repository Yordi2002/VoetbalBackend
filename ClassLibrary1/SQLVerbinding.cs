using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
