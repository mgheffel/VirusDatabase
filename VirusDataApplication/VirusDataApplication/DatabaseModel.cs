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
        private DataTable dt;
        public DatabaseModel()
        {
            /*Do not forget to estabish a VPN with K-State so that the connection will work with mysql.cs.ksu.edu*/
            initialize();
            /*
            sendInsert("test call");
            sendQuery("test call");
            sendUpdate("test call");
            sendQuery("test call");
            sendDelete("test call");
            sendQuery("test call");
            */
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
        public DataTable sendQuery(string selectSQLStatement)
        {
            db.Open();
            string query = selectSQLStatement;
            //string query = "SELECT * FROM Proteins";
            da = new MySqlDataAdapter(query, db);
            MySqlCommandBuilder cb = new MySqlCommandBuilder(da);        
            dt = new DataTable();
            da.Fill(dt);
            db.Close();
            return dt;
        }
        /// <summary>
        /// This method will update an existing entry in the database
        /// </summary>
        /// <param name="updateSQLStatement"></param>
        /// <returns>Returns a dataset. Maybe just make it a bool to say that the changes were either done or not done?</returns>
        public bool sendUpdate(string updateSQLStatement)
        {
            int rows_affected;

            db.Open();
            da = new MySqlDataAdapter();
            //MySqlCommand msc = new MySqlCommand("UPDATE Proteins SET pType = 'cow' " + "WHERE pID > 68", db);
            MySqlCommand msc = new MySqlCommand(updateSQLStatement, db);
            rows_affected = msc.ExecuteNonQuery();
            db.Close();

            //MessageBox.Show(rows_affected.ToString());

            if (rows_affected > 0)
            {
                return true;
            }   
            return false;
        }

        public bool sendInsert(string insertSQLStatement)
        {
            int rows_affected;

            db.Open();
            //MySqlCommand msc = new MySqlCommand("INSERT INTO Proteins (pID, pType) " + " VALUES(72, 'dickbutt')", db);
            MySqlCommand msc = new MySqlCommand(insertSQLStatement, db);            
            rows_affected = msc.ExecuteNonQuery();
            db.Close();

            //MessageBox.Show(rows_affected.ToString()); 

            if (rows_affected > 0)
            {
                return true;
            }
            return false;
        }

        public bool sendDelete(string deleteSQLStatement)
        {
            int rows_affected;

            db.Open();
            //MySqlCommand msc = new MySqlCommand("DELETE FROM Proteins WHERE pID > 68", db);
            MySqlCommand msc = new MySqlCommand(deleteSQLStatement, db);
            rows_affected = msc.ExecuteNonQuery();
            db.Close();

            //MessageBox.Show(rows_affected.ToString());            

            if (rows_affected > 0)
            {
                return true;
            }
            return false;
        }

    }
}
