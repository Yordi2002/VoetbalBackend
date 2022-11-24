using Interface.Interface;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DAL.Context.UserContext;

namespace DAL.Context
{
    public class UserContext : IUserContext
    {
        SqlConnection con = SQLVerbinding.returnconnection();

    }
}
