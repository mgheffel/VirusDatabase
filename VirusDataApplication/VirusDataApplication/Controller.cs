﻿using System;
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
        public DataTable tempQuery(string a)
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
        public DataTable displayTableContents(string table)
        {
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
            return model.sendQuery(query);
        }


       
        public bool deleteRow(int size, string table, string[] cols, string[] vals, string type)
        {
            string statement = writeStatement(size, table, cols, vals, type);
            MessageBox.Show(statement);
            return model.sendDelete(statement);
        }



        private string writeStatement(int size, string table, string[] cols, string[] vals, string type)
        {
            string statement = null;
            //DELETE FROM Proteins WHERE pID > 68
            if (type == "delete")
            {
                switch (size)
                {
                    case 2:
                        statement = "DELETE FROM " + table + " WHERE " + cols[0] + " = " + vals[0] + " AND " + cols[1] + " = " + vals[1];
                        break;
                    case 3:
                        break;
                    case 4:
                        break;
                    case 5:
                        break;
                    case 6:
                        break;
                }
            }
            return statement;
        }//end method

        public bool editTable(string table, string oldVal, string newVal)
        {
            return true;
        }

        public DataTable getRowToEdit(string tableName, string val)
        {
            return new DataTable();
        }
    }//end class Controller
}//end namespace
