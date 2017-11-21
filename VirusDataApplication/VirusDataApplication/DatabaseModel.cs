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
        /// <summary>
        /// Have db and csb right now, because testing
        /// </summary>
        private MySqlConnection db;
        private string server;
        private string database;
        private string uid;
        private string password;
        //private MySqlConnectionStringBuilder csb;
        public DatabaseModel()
        {
            /*
            csb = new MySqlConnectionStringBuilder();
            csb.Server = "mysql.cs.ksu.edu";
            csb.Database = "mgheffel";
            csb.UserID = "mgheffel";
            csb.Password = "insecurepassword";
            csb.Port = 3306;
            */
            server = "mysql.cis.ksu.edu";
            database = "mgheffel";
            uid = "mgheffel";
            password = "insecurepassword";

            string connString = "SERVER=mysql.cs.ksu.edu; DATABASE=mgheffel; UID=mgheffel; PASSWORD=insecurepassword";
            db = new MySqlConnection(connString);

            try
            {
                db.Open();
                MessageBox.Show("Connection Open!");
            }
            catch(MySqlException e)
            {
                switch(e.Number)
                {
                    case 0:
                        MessageBox.Show("Cannot connect to server");
                        break;
                    case 1045:
                        MessageBox.Show("Invalid username/password, please try again");
                        break;
                    default:
                        MessageBox.Show(e.ToString());
                        break;
                }                
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
