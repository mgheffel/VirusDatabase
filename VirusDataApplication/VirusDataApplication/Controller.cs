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
        public DataSet tempQuery(string a)
        {
            string queryStatement = "SELECT * FROM OpenReadingFrames WHERE strainID = " + a;
            return model.sendQuery(queryStatement);
        }

        /// <summary>
        /// Method will take a table name as a parameter and return a DataSet containing
        /// the entire contents of the specified table.
        /// </summary>
        /// <param name="table"></param> table to display contents of
        /// <returns></returns> DataSet containing contents of table param
        public DataSet displayTableContents(string table)
        {
            string query = "SELECT * FROM " + table;
            return model.sendQuery(query);
        }
        //code will go here
    }
}
