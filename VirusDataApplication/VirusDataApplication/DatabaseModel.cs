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
        private MySqlConnectionStringBuilder csb;
        private MySqlDataAdapter da;
        public DatabaseModel()
        {
            /*Do not forget to estabish a VPN with K-State so that the connection will work with mysql.cs.ksu.edu*/
            initialize();
        }

        /// <summary>
        /// Function used to make constructor cleaner, intializes the connection string and opens a connection.
        /// </summary>
        public void initialize()
        {
            csb = new MySqlConnectionStringBuilder();
            csb.Server = "mysql.cs.ksu.edu";
            csb.Database = "mgheffel";
            csb.UserID = "mgheffel";
            csb.Password = "insecurepassword";
            csb.Port = 3306;

            db = new MySqlConnection(csb.ToString());
            /*  Might not need to have an open connection, can just open a connection per request.
             *  So as long as we know this works we can comment this out? and then just open 
             *  connections per request, or in send request method(s)?
            */
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
            /*Will move this to a function call or exit button press.*/
            db.Close();
        }
        /// <summary>
        /// This method will take a query request from the controller and run that request on the database
        /// </summary>
        /// <param name="selectSQLStatement"></param>
        /// <returns>Still working on return, might be DataTable of some sorts or DataSet</returns>
        public string sendQuery(string selectSQLStatement)
        {
            MessageBox.Show("Sending request...");
            string query = selectSQLStatement;



            return null;
        }

        public string sendUpdate(string updateSQLStatement)
        {
            return null;
        }

    }
}
