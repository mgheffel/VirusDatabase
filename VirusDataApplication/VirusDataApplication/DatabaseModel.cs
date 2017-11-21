using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using Npgsql;

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

        public DatabaseModel()
        {
            string connString = "SERVER= postgresql.cis.ksu.edu; PORT=5432; DATABASE=smoylan22; UID=smoylan22; PASSWORD=DarthMoyji66;";
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            try
            {
                conn.Open();
                MessageBox.Show("yes");
                conn.Close();
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
            }
            //initialize();

        }

        private void initialize()
        {
            server = "mysql.cis.ksu.edu";
            database = "mgheffel";
            uid = "mgheffel";
            password = "DarthMoyji66";

            string connString = "SERVER=" + server + "; DATABASE=" + database + "; UID=" + uid + "; PASSWORD=" + password + ";";
            db = new MySqlConnection(connString);

            try
            {
                db.Open();
                MessageBox.Show("Connection Open!");
            }
            catch (MySqlException e)
            {
                switch (e.Number)
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
