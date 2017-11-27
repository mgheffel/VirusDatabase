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
        string tableName;//name of table that update is performed on
        string strValue; //old value by which to search for the update if its a string
        int intValue; //old value by which to search for the update if its an int.
        string colName; //column name that value is associated with
        Controller c;
        TextBox[] tbArr = new TextBox[6];
        Label[] lblArr = new Label[6];
        DataTable row;//table resulting from the selection from the main GUI
        int numCol; //number of columns in the table above
        int dropDownChoice;
        string displayStatement;
        string updateStatement;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="tName"></param>
        /// <param name="val"></param>
        /// <param name="cName"></param>
        /// <param name="control"></param>
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

        public void assignValsSpecies(string tName, string cName, int specID)
        {
            tableName = tName;
            colName = cName;
            intValue = specID;
            displayStatement = getQueryIntBasic();
            row = c.SendTheWave(displayStatement);
            numCol = row.Columns.Count;
            enableApprpriateTBs();
            populateTBandLBLBasic();
        }

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
        }


        /// <summary>
        /// Basic query in the format SELECT * FROM tableName WHERE colName = 'value'
        /// </summary>
        /// <returns></returns>
        private string getQueryStringBasic()
        {
            return "SELECT * FROM " + tableName + " WHERE " + colName + " = '" + strValue + "'";
        }

        private string getQueryIntBasic()
        {
            return "SELECT * FROM " + tableName + " WHERE " + colName + " = " + intValue;
        }
        private void enableApprpriateTBs()
        {
            for (int i = 1; i < numCol; i++)
                tbArr[i].Enabled = true;
        }
        private void populateTBandLBLBasic()
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
        }


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
            }
            if (c.sendNonQuery(updateStatement))
                MessageBox.Show("Update was completed successfully.", "Update");
            else
                MessageBox.Show("There was an error executing the update", "Error");
        }//end method
    }
}
