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
    public class Controller
    {
        iDBModel model;
        public Controller(iDBModel m)
        {
            model = m;
        }
        

        /// <summary>
        /// Method will take a table name as a parameter and return a DataSet containing
        /// the entire contents of the specified table.
        /// </summary>
        /// <param name="table"></param> table to display contents of
        /// <returns></returns> DataSet containing contents of table param
        public DataTable displayTableContents(string table)
        {
            if (table.Contains(";"))
                return new DataTable();
            string query = "SELECT * FROM " + table;
            return model.sendQuery(query);
        }//end displayTableContents

        /// <summary>
        /// This method will send whatever comes in as a string as a SQL query.
        /// </summary>
        /// <param name="query">The query to send</param>
        /// <returns>the results of the query as a data set.</returns>
        public DataTable SendTheWave(string query)
        {
            if (query.Contains(";"))
                return new DataTable();
            return model.sendQuery(query);
        }


        /// <summary>
        /// Method used to send non query statements (update, delete) to the model. 
        /// </summary>
        /// <param name="statement"></param> statement to send
        /// <returns></returns> true if statement was executed, false if not.
        public bool sendNonQuery(string statement)
        {
            if (statement.Contains(";"))
                return false;
            return model.sendExecuteStatement(statement);
        }//end method

    }//end class Controller
}//end namespace
