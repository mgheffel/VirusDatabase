using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace VirusDataApplication
{
    /// <summary>
    /// Making the database model class static, because there will be only one. The controller will then call methods from it directly.
    /// </summary>
    public class DatabaseModel: iDBModel
    {
        private string myConnectionString = "server=mysql.cis.ksu.edu;database=mgheffel;uid=mgheffel;pwd=insecurepassword;";

        public string sendQuery(string selectSQLStatement)
        {
            return null;
        }

        public string sendUpdate(string updateSQLStatement)
        {
            return null;
        }

    }
}
