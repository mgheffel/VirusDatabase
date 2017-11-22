using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using MySql.Data;
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
        /// 
        /// </summary>
        private MySqlConnection db;
        private MySqlConnectionStringBuilder csb;
        private MySqlDataAdapter da;
        private DataSet ds;
        public DatabaseModel()
        {
            /*Do not forget to estabish a VPN with K-State so that the connection will work with mysql.cs.ksu.edu*/
            initialize();
            sendInsert("test call");
            sendQuery("test call");
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
                //MessageBox.Show("Connection Open!");
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
        /// <returns>Returns a DataSet, maybe change to DataTable later</returns>
        public DataSet sendQuery(string selectSQLStatement)
        {
            //MessageBox.Show("Sending request...");
            db.Open();
            //string query = selectSQLStatement;
            string query = "SELECT * FROM Proteins";

            da = new MySqlDataAdapter(query, db);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);
            ds = new DataSet();
            da.Fill(ds);
            db.Close();
            return ds;
        }
        /// <summary>
        /// This method will update insert or delete from the database.
        /// </summary>
        /// <param name="updateSQLStatement"></param>
        /// <returns>Returns a dataset. Maybe just make it a bool to say that the changes were either done or not done?</returns>
        public DataSet sendUpdate(string updateSQLStatement)
        {
            db.Open();

            da = new MySqlDataAdapter();
            MySqlCommand msc = new MySqlCommand(updateSQLStatement, db);

            db.Close();
            return null;
        }

        public DataSet sendInsert(string insertSQLStatement)
        {
            db.Open();
            int rows_affected;
            //MySqlCommand msc = new MySqlCommand(insertSQLStatement, db);
            MySqlCommand msc = new MySqlCommand("INSERT INTO Proteins (pID, pType) " + " VALUES(70, 'dickbutt')", db);
            msc.Parameters.Add("pID" , MySqlDbType.Int32).Value = "70";
            msc.Parameters.Add("pType", MySqlDbType.VarChar).Value = "dickbutt";
            rows_affected = msc.ExecuteNonQuery();

            MessageBox.Show(rows_affected.ToString());

            db.Close();
            return null;
        }

        public DataSet sendDelete(string deleteSQLStatement)
        {
            db.Open();

            db.Close();
            return null;
        }

    }
}
