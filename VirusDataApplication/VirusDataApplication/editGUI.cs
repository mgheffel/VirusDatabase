using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VirusDataApplication
{
    public partial class editGUI : Form
    {
        string tableName;   //name of table that update is performed on
        string strValue;    //old value by which to search for the update if its a string
        string strValue2;   //if needed
        int intValue;       //old value by which to search for the update if its an int.
        string colName1;    //column name that value is associated with
        string colName2;    //column name that second value is associated with, if needed

        Controller c;
        TextBox[] tbArr = new TextBox[6];
        Label[] lblArr = new Label[6];

        DataTable row;      //table resulting from the selection from the main GUI
        int numCol;         //number of columns in the table above

        string displayStatement;
        string updateStatement;


        /// <summary>
        /// Constructor for editGUI class
        /// </summary>
        /// <param name="control"></param>//controller passed from InterfaceV2.cs
        public editGUI(Controller control)
        {
            InitializeComponent();
            tbArr[0] = tb1;
            tbArr[1] = tb2;
            tbArr[2] = tb3;
            tbArr[3] = tb4;
            tbArr[4] = tb5;
            tbArr[5] = tb6;
            lblArr[0] = tb1_lbl;
            lblArr[1] = tb2_lbl;
            lblArr[2] = tb3_lbl;
            lblArr[3] = tb4_lbl;
            lblArr[4] = tb5_lbl;
            lblArr[5] = tb6_lbl;
            c = control;
        }//end constructor


        //ASSIGN VALUES METHOD BLOCK
        //********************************************************************************************************


        /// <summary>
        /// Method will assign the fields the appropriate values when the edit is being performed on
        /// a table whose has a single integer primary key.
        /// </summary>
        /// <param name="tName"></param>table name
        /// <param name="cName"></param>column name
        /// <param name="intVal"></param>integer value to find appropriate row by
        public void assignValsInt(string tName, string cName, int intVal)
        {
            tableName = tName;
            colName1 = cName;
            intValue = intVal;
            displayStatement = getQueryIntBasic();
            row = c.SendTheWave(displayStatement);
            numCol = row.Columns.Count;
            enableApprpriateTBs();
            populateTBandLBL();
        }//end method

        /// <summary>
        /// Assigns the fields if the selected table to edit is the ORF table.
        /// </summary>
        /// <param name="tname"></param>table name
        /// <param name="cName1"></param>first column needed to find correct row
        /// <param name="cName2"></param>second column needed to find correct row
        /// <param name="strVal"></param>first string value needed to find correct row
        /// <param name="strVal2"></param>second string value needed to find correct row
        public void assignValsORF(string tname, string cName1, string cName2, string strVal, string strVal2)
        {
            tableName = tname;
            colName1 = cName1;
            colName2 = cName2;
            strValue = strVal;
            strValue2 = strVal2;
            displayStatement = getQueryString2();
            row = c.SendTheWave(displayStatement);
            numCol = row.Columns.Count;
            enableApprpriateTBs();
            populateTBandLBL();
        }//end method


        //WRITE UPDATE STATEMENTS METHOD BLOCK
        //*********************************************************************************************************************


        /// <summary>
        /// Method will write the update SQL statement when the update is being performed on the Species table.
        /// </summary>
        private void writeUpdateSpecies()
        {
            string[] components = new string[numCol];
            for(int i = 0; i < numCol; i++)
            {
                components[i] = tbArr[i].Text;
            }
            updateStatement = "UPDATE Species SET sName = '" + components[1] + "', sAbbreviation = '" + components[2]
                            + "', sGenus = '" + components[3] + "', sFamily = '" + components[4] + "', sOrder = '"
                            + components[5] + "' WHERE specID = " + Convert.ToInt32(components[0]);
        }//end method

        /// <summary>
        /// Method will write the update SQL statement when the update is being performed on the ORFs table.
        /// </summary>
        private void writeUpdateORF()
        {
            string[] components = new string[numCol];
            for (int i = 0; i < numCol; i++)
            {
                components[i] = tbArr[i].Text;
            }
            updateStatement = "UPDATE OpenReadingFrames SET startIndex = " + Convert.ToInt32(components[3]) + ", stopIndex = "
                            + Convert.ToInt32(components[4]) + " WHERE orfID = '" + components[1] + "' AND strainID = '"
                            + components[0] + "'";
        }//end method

        /// <summary>
        /// Method will write the update SQL statement when the update is being performed on the Publications table.
        /// </summary>
        private void writeUpdatePublications()
        {
            string[] components = new string[numCol];
            for (int i = 0; i < numCol; i++)
            {
                components[i] = tbArr[i].Text;
            }
            updateStatement = "UPDATE Publications SET pYear = " + Convert.ToInt32(components[1]) + ", title = '"
                            + components[2] + "' WHERE pubID = " + Convert.ToInt32(components[0]);
        }

        /// <summary>
        /// Method will write the update SQL statement when the update is being performed on the Proteins table.
        /// </summary>
        private void writeUpdateProteins()
        {
            string[] components = new string[numCol];
            for (int i = 0; i < numCol; i++)
            {
                components[i] = tbArr[i].Text;
            }
            updateStatement = "UPDATE Proteins SET pName = '" + components[1] + "' WHERE pID = " + Convert.ToInt32(components[0]);
        }//end method

        /// <summary>
        /// Method will write the update SQL statement when the update is being performed on the Publishers table.
        /// </summary>
        private void writeUpdatePublishers()
        {
            string[] components = new string[numCol];
            for (int i = 0; i < numCol; i++)
            {
                components[i] = tbArr[i].Text;
            }
            updateStatement = "UPDATE Publishers SET name = '" + components[1] + "' WHERE publisherID = "
                            + Convert.ToInt32(components[0]);
        }//end method

        /// <summary>
        /// Method will write the update SQL statement when the update is being performed on the Researchers table.
        /// </summary>
        private void writeUpdateResearchers()
        {
            string[] components = new string[numCol];
            for (int i = 0; i < numCol; i++)
            {
                components[i] = tbArr[i].Text;
            }
            updateStatement = "UPDATE Researchers SET rName = '" + components[1] + "', rEmail = '" + components[2]
                            + "', rOrg = '" + components[3] + "' WHERE rID = " + Convert.ToInt32(components[0]);
        }//end method


        //GET QUERY METHOD BLOCK
        //*********************************************************************************************************


        /// <summary>
        /// Basic query in the format SELECT * FROM tableName WHERE colName = 'value'
        /// </summary>
        /// <returns></returns>returns SQL query statement
        private string getQueryStringBasic()
        {
            return "SELECT * FROM " + tableName + " WHERE " + colName1 + " = '" + strValue + "'";
        }//end method

        /// <summary>
        /// Query in the form SELECT * FROM tableName WHERE column1 = 'val1' AND column2 = 'val2'
        /// </summary>
        /// <returns></returns>returns SQL query statement
        private string getQueryString2()
        {
            return "SELECT * FROM " + tableName + " WHERE " + colName1 + " = '" + strValue
                    + "' AND " + colName2 + " = '" + strValue2 + "'";
        }

        /// <summary>
        /// Basic query in the form SELECT * FROM tableName WHERE colName = integerValue
        /// </summary>
        /// <returns></returns>
        private string getQueryIntBasic()
        {
            return "SELECT * FROM " + tableName + " WHERE " + colName1 + " = " + intValue;
        }//end method

        /// <summary>
        /// Method enables textboxes according to which table is being edited.
        /// </summary>
        private void enableApprpriateTBs()
        {
            if(tableName == "OpenReadingFrames")
            {
                for (int i = 3; i < numCol; i++)
                    tbArr[i].Enabled = true;
            }
            else
            {
                for (int i = 1; i < numCol; i++)
                    tbArr[i].Enabled = true;
            }
        }//end method

        /// <summary>
        /// Method populates the appropriate textboxes and labels
        /// </summary>
        private void populateTBandLBL()
        {
            for (int i = 0; i < numCol; i++)
            {
                tbArr[i].Text = row.Rows[0][i].ToString();
            }
            int chode = 0;
            foreach (DataColumn col in row.Columns)
            {
                lblArr[chode].Text = col.ColumnName;
                chode++;
            }
        }//end method


        /// <summary>
        /// Event handler for submit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void submit_btn_Click(object sender, EventArgs e)
        {
            switch(tableName)
            {
                case "Species":
                    writeUpdateSpecies();
                    break;
                case "OpenReadingFrames":
                    writeUpdateORF();
                    break;
                case "Publications":
                    writeUpdatePublications();
                    break;
                case "Proteins":
                    writeUpdateProteins();
                    break;
                case "Publishers":
                    writeUpdatePublishers();
                    break;
                case "Researchers":
                    writeUpdateResearchers();
                    break;
            }
            if (c.sendNonQuery(updateStatement))
                MessageBox.Show("Update was completed successfully.", "Update");
            else
                MessageBox.Show("There was an error executing the update", "Error");
        }//end method
    }
}
