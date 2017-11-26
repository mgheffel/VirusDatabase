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
    public partial class Form1 : Form
    {
        private Controller c;
        public Form1(Controller control)
        {
            InitializeComponent();
            c = control;
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            string input = input_tb.Text;
            DataTable output = c.tempQuery(input);
            output_lb.Items.Add(output.ToString());
        }


        //BEGIN EDIT TAB CODE
        //*********************************************************************************************************************


        /// <summary>
        /// Event handler for insert button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void insert_btn_Click(object sender, EventArgs e)
        {
            if (edit_tables_lb.SelectedIndex < 0)
                MessageBox.Show("You must select a table to insert into.", "Error");
            else
            {

            }
        }//end method


        /// <summary>
        /// Event handler for delete button click.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (edit_tables_lb.SelectedIndex < 0)
                MessageBox.Show("You must select a table to delete from.", "Error");
            else if (selected_table_lv.SelectedItems.Count == 0)
                MessageBox.Show("You must select a row to delete.", "Error");
            else
            {
                string tableName = edit_tables_lb.SelectedItem.ToString();
                DataTable table = c.displayTableContents(tableName);
                string[] colNames = new string[table.Columns.Count];
                int chodybanks = 0;
                foreach (DataColumn col in table.Columns)
                {
                    colNames[chodybanks] = col.ColumnName;
                    chodybanks++;
                }
                string[] values = new string[table.Columns.Count];
                ListViewItem item = selected_table_lv.SelectedItems[0];
                for (int i = 0; i < values.Length; i++)
                    values[i] = item.SubItems[i].Text;
                if (c.deleteRow(values.Length, tableName, colNames, values, "delete"))
                    MessageBox.Show("Row was deleted.", "Delete Row Operation");
                else
                    MessageBox.Show("Error: Row could not be deleted properly.", "Delete Row Operation");
            }
        }//end method


        /// <summary>
        /// Displays the contents of the table that is selected in the listbox in the listview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void edit_tables_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            clearEditColTBs();
            clearEditColLbls();
            selected_table_lbl.Text = "";
            selected_table_lv.Columns.Clear();
            selected_table_lv.Items.Clear();
            selected_table_lv.View = View.Details;
            string tableName;
            tableName = edit_tables_lb.SelectedItem.ToString();
            selected_table_lbl.Text = tableName;
            DataTable resultTable = c.displayTableContents(tableName);
            int[] typeArr = new int[resultTable.Columns.Count];
            int columnCount = resultTable.Columns.Count;
            int rowCount = resultTable.Rows.Count;
            int count = 0;
         
            string[] strArray = new string[columnCount];
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    strArray[j] = resultTable.Rows[i][j].ToString();
                }
                selected_table_lv.Items.Add(new ListViewItem(strArray));
            }
            if (insert_rb.Checked || edit_rb.Checked)
            {
                labelEditTBs(resultTable);
                if (insert_rb.Checked || edit_rb.Checked)
                    enableAppropriateTB(resultTable.Columns.Count);
                else
                    disableEditTBs();
            }
        }//end method


        /// <summary>
        /// Method will populate the edit_col_tb textboxes with the appropriate values
        /// from the selected row in the listview. Textboxes are only populated when
        /// the edit radio button is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void selected_table_lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(edit_rb.Checked && selected_table_lv.SelectedItems.Count > 0)
            {
                string[] arr = new string[selected_table_lv.Columns.Count];
                ListViewItem item = selected_table_lv.SelectedItems[0];
                for (int i = 0; i < arr.Length; i++)
                    arr[i] = item.SubItems[i].Text;
                switch(arr.Length)
                {
                    case 2:
                        edit_col1_tb.Text = arr[0];
                        edit_col2_tb.Text = arr[1];
                        break;
                    case 3:
                        edit_col1_tb.Text = arr[0];
                        edit_col2_tb.Text = arr[1];
                        edit_col3_tb.Text = arr[2];
                        break;
                    case 4:
                        edit_col1_tb.Text = arr[0];
                        edit_col2_tb.Text = arr[1];
                        edit_col3_tb.Text = arr[2];
                        edit_col4_tb.Text = arr[3];
                        break;
                    case 5:
                        edit_col1_tb.Text = arr[0];
                        edit_col2_tb.Text = arr[1];
                        edit_col3_tb.Text = arr[2];
                        edit_col4_tb.Text = arr[3];
                        edit_col5_tb.Text = arr[4];
                        break;
                    case 6:
                        edit_col1_tb.Text = arr[0];
                        edit_col2_tb.Text = arr[1];
                        edit_col3_tb.Text = arr[2];
                        edit_col4_tb.Text = arr[3];
                        edit_col5_tb.Text = arr[4];
                        edit_col6_tb.Text = arr[5];
                        break;
                }
            }
        }//end method


        /// <summary>
        /// Event handler to handle enabling/disabling of controls based on 
        /// whether the insert delete button is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_rb_CheckedChanged(object sender, EventArgs e)
        {
            disableEditTBs();
            if (delete_rb.Checked)
            {
                clearEditColLbls();
                clearEditColTBs();
                delete_btn.Enabled = true;
            }
            else
            {
                delete_btn.Enabled = false;
            }
        }//end method


        /// <summary>
        /// Event handler to handle enabling/disabling of controls based on 
        /// whether the insert radio button is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void insert_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (insert_rb.Checked)
            {
                clearEditColTBs();
                insert_btn.Enabled = true;
                if (selected_table_lv.Columns.Count == 0)
                    disableEditTBs();
                else
                    enableAppropriateTB(selected_table_lv.Columns.Count);
                labelEditTBs(c.displayTableContents(edit_tables_lb.SelectedItem.ToString()));
            }
            else
            {
                insert_btn.Enabled = false;
            }
        }//end method


        /// <summary>
        /// Event handler to handle enabling/disabling of controls based on 
        /// whether the edit radio button is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void edit_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (edit_rb.Checked)
            {
                edit_btn.Enabled = true;
                enableAppropriateTB(selected_table_lv.Columns.Count);
                labelEditTBs(c.displayTableContents(edit_tables_lb.SelectedItem.ToString()));
            }
            else
            {
                edit_btn.Enabled = false;
            }
        }//end method


        /// <summary>
        /// Method will clear all the edit_col_tb textboxes.
        /// </summary>
        private void clearEditColTBs()
        {
            edit_col1_tb.Text = "";
            edit_col2_tb.Text = "";
            edit_col3_tb.Text = "";
            edit_col4_tb.Text = "";
            edit_col5_tb.Text = "";
            edit_col6_tb.Text = "";
        }//end method

        /// <summary>
        /// Method will clear all of the edit_col_lbl labels.
        /// </summary>
        private void clearEditColLbls()
        {
            edit_col1_lbl.Text = "";
            edit_col2_lbl.Text = "";
            edit_col3_lbl.Text = "";
            edit_col4_lbl.Text = "";
            edit_col5_lbl.Text = "";
            edit_col6_lbl.Text = "";
        }//end method


        /// <summary>
        /// Method will enable/disable appropriate textboxes depending on
        /// which table is being displayed in the listview.
        /// </summary>
        /// <param name="chode"></param> number of textboxes to enable
        private void enableAppropriateTB(int chode)
        {
            switch (chode)
            {
                case 0:
                    edit_col1_tb.Enabled = false;
                    edit_col2_tb.Enabled = false;
                    edit_col3_tb.Enabled = false;
                    edit_col4_tb.Enabled = false;
                    edit_col5_tb.Enabled = false;
                    edit_col6_tb.Enabled = false;
                    break;
                case 2:
                    edit_col1_tb.Enabled = true;
                    edit_col2_tb.Enabled = true;
                    edit_col3_tb.Enabled = false;
                    edit_col4_tb.Enabled = false;
                    edit_col5_tb.Enabled = false;
                    edit_col6_tb.Enabled = false;
                    break;
                case 3:
                    edit_col1_tb.Enabled = true;
                    edit_col2_tb.Enabled = true;
                    edit_col3_tb.Enabled = true;
                    edit_col4_tb.Enabled = false;
                    edit_col5_tb.Enabled = false;
                    edit_col6_tb.Enabled = false;
                    break;
                case 4:
                    edit_col1_tb.Enabled = true;
                    edit_col2_tb.Enabled = true;
                    edit_col3_tb.Enabled = true;
                    edit_col4_tb.Enabled = true;
                    edit_col5_tb.Enabled = false;
                    edit_col6_tb.Enabled = false;
                    break;
                case 5:
                    edit_col1_tb.Enabled = true;
                    edit_col2_tb.Enabled = true;
                    edit_col3_tb.Enabled = true;
                    edit_col4_tb.Enabled = true;
                    edit_col5_tb.Enabled = true;
                    edit_col6_tb.Enabled = false;
                    break;
                case 6:
                    edit_col1_tb.Enabled = true;
                    edit_col2_tb.Enabled = true;
                    edit_col3_tb.Enabled = true;
                    edit_col4_tb.Enabled = true;
                    edit_col5_tb.Enabled = true;
                    edit_col6_tb.Enabled = true;
                    break;
            }
        }//end method


        /// <summary>
        /// Method disables all of the edit_col_tb textboxes on the edit tab page.
        /// </summary>
        private void disableEditTBs()
        {
            edit_col1_tb.Enabled = false;
            edit_col2_tb.Enabled = false;
            edit_col3_tb.Enabled = false;
            edit_col4_tb.Enabled = false;
            edit_col5_tb.Enabled = false;
            edit_col6_tb.Enabled = false;
        }//end method


        /// <summary>
        /// Method will put text in the labels corresponding to the appropriate edit_col_TB textboxes.
        /// </summary>
        /// <param name="table"></param> the current table in the listview
        private void labelEditTBs(DataTable table)
        {
            string[] colNames = new string[table.Columns.Count];
            int chodybanks;

            switch (table.Columns.Count)
            {
                case 2:
                    chodybanks = 0;
                    foreach (DataColumn col in table.Columns)
                    {
                        colNames[chodybanks] = col.ColumnName;
                        chodybanks++;
                    }
                    edit_col1_lbl.Text = colNames[0];
                    edit_col2_lbl.Text = colNames[1];
                    break;
                case 3:
                    chodybanks = 0;
                    foreach (DataColumn col in table.Columns)
                    {
                        colNames[chodybanks] = col.ColumnName;
                        chodybanks++;
                    }
                    edit_col1_lbl.Text = colNames[0];
                    edit_col2_lbl.Text = colNames[1];
                    edit_col3_lbl.Text = colNames[2];
                    break;
                case 4:
                    chodybanks = 0;
                    foreach (DataColumn col in table.Columns)
                    {
                        colNames[chodybanks] = col.ColumnName;
                        chodybanks++;
                    }
                    edit_col1_lbl.Text = colNames[0];
                    edit_col2_lbl.Text = colNames[1];
                    edit_col3_lbl.Text = colNames[2];
                    edit_col4_lbl.Text = colNames[3];
                    break;
                case 5:
                    chodybanks = 0;
                    foreach (DataColumn col in table.Columns)
                    {
                        colNames[chodybanks] = col.ColumnName;
                        chodybanks++;
                    }
                    edit_col1_lbl.Text = colNames[0];
                    edit_col2_lbl.Text = colNames[1];
                    edit_col3_lbl.Text = colNames[2];
                    edit_col4_lbl.Text = colNames[3];
                    edit_col5_lbl.Text = colNames[4];
                    break;
                case 6:
                    chodybanks = 0;
                    foreach (DataColumn col in table.Columns)
                    {
                        colNames[chodybanks] = col.ColumnName;
                        chodybanks++;
                    }
                    edit_col1_lbl.Text = colNames[0];
                    edit_col2_lbl.Text = colNames[1];
                    edit_col3_lbl.Text = colNames[2];
                    edit_col4_lbl.Text = colNames[3];
                    edit_col5_lbl.Text = colNames[4];
                    edit_col6_lbl.Text = colNames[5];
                    break;
                default:
                    chodybanks = 0;
                    break;
            }
        }//end method


        //END EDIT TAB CODE
        //**********************************************************************************************************************************

    }//end class
}//end namespace
