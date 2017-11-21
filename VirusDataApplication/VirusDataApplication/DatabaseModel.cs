using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace VirusDataApplication
{
    /// <summary>
    /// Making the database model class static, because there will be only one. The controller will then call methods from it directly.
    /// </summary>
    public class DatabaseModel: iDBModel
    {
        private string myConnectionString;
        private MySqlConnection db;
        public DatabaseModel()
        {
            myConnectionString = "server=mysql.cis.ksu.edu;database=mgheffel;uid=mgheffel;pwd=insecurepassword;";
            db = new MySqlConnection(myConnectionString);
            try
            {
                db.Open();
                MessageBox.Show("Connection Open!");
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            db.Close();
        }

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
