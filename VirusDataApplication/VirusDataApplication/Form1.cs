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

        /// <summary>
        /// Event handler to handle enabling/disabling of controls based on 
        /// whether the insert delete button is selected.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (delete_rb.Checked)
            {
                selected_table_lv.Enabled = true;
                delete_btn.Enabled = true;
            }
            else
            { 
                selected_table_lv.Enabled = false;
                delete_btn.Enabled = false;
            }
        }//end method

        

        private void selected_table_lv_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }//method

        /// <summary>
        /// Displays the contents of the table that is selected in the listbox in the listview.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void edit_tables_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            edit_col1_lbl.Text = "";
            edit_col2_lbl.Text = "";
            edit_col3_lbl.Text = "";
            edit_col4_lbl.Text = "";
            edit_col5_lbl.Text = "";
            selected_table_lv.Columns.Clear();
            selected_table_lv.Items.Clear();
            selected_table_lv.View = View.Details;
            string tableName;
            tableName = edit_tables_lb.SelectedItem.ToString();
            selected_table_lbl.Text = tableName;
            DataTable resultTable = c.displayTableContents(tableName);
            int columnCount = resultTable.Columns.Count;
            int rowCount = resultTable.Rows.Count;
            string[] temp = new string[2];
            foreach (DataColumn col in resultTable.Columns)
                selected_table_lv.Columns.Add(col.ColumnName);
            string[] strArray = new string[columnCount];
            for (int i = 0; i < rowCount; i++)
            {
                for (int j = 0; j < columnCount; j++)
                {
                    strArray[j] = resultTable.Rows[i][j].ToString();
                }
                selected_table_lv.Items.Add(new ListViewItem(strArray));
            }
            string[] colNames = new string[columnCount];
            int chodybanks;

            switch (columnCount)
            {
                case 2:
                    chodybanks = 0;
                        foreach (DataColumn col in resultTable.Columns)
                        {
                            colNames[chodybanks] = col.ColumnName;
                            chodybanks++;
                        }
                        edit_col1_lbl.Text = colNames[0];
                        edit_col2_lbl.Text = colNames[1];
                        break;
                case 3:
                    chodybanks = 0;
                        foreach (DataColumn col in resultTable.Columns)
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
                    foreach (DataColumn col in resultTable.Columns)
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
                    foreach (DataColumn col in resultTable.Columns)
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
                    foreach (DataColumn col in resultTable.Columns)
                    {
                        colNames[chodybanks] = col.ColumnName;
                        chodybanks++;
                    }
                    edit_col1_lbl.Text = colNames[0];
                    edit_col2_lbl.Text = colNames[1];
                    edit_col3_lbl.Text = colNames[2];
                    edit_col4_lbl.Text = colNames[3];
                    edit_col5_lbl.Text = colNames[4];
                    edit_col5_lbl.Text = colNames[5];
                    break;
                default:
                    chodybanks = 0;
                    break;
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
                insert_btn.Enabled = true;
                int numCols = selected_table_lv.Columns.Count;
                switch (numCols)
                {
                    case 0:
                        edit_col1_tb.Enabled = false;
                        edit_col2_tb.Enabled = false;
                        edit_col3_tb.Enabled = false;
                        edit_col4_tb.Enabled = false;
                        edit_col5_tb.Enabled = false;
                        break;
                    case 1:
                        edit_col1_tb.Enabled = true;
                        break;
                    case 2:
                        edit_col1_tb.Enabled = true;
                        edit_col2_tb.Enabled = true;
                        break;
                    case 3:
                        edit_col1_tb.Enabled = true;
                        edit_col2_tb.Enabled = true;
                        edit_col3_tb.Enabled = true;
                        break;
                    case 4:
                        edit_col1_tb.Enabled = true;
                        edit_col2_tb.Enabled = true;
                        edit_col3_tb.Enabled = true;
                        edit_col4_tb.Enabled = true;
                        break;
                    case 5:
                        edit_col1_tb.Enabled = true;
                        edit_col2_tb.Enabled = true;
                        edit_col3_tb.Enabled = true;
                        edit_col4_tb.Enabled = true;
                        edit_col5_tb.Enabled = true;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                insert_btn.Enabled = false;
                edit_col1_tb.Enabled = false;
                edit_col2_tb.Enabled = false;
                edit_col3_tb.Enabled = false;
                edit_col4_tb.Enabled = false;
                edit_col5_tb.Enabled = false;
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
            if(edit_rb.Checked)
            {
                edit_btn.Enabled = true;
                selected_table_lv.Enabled = true;
            }
            else
            {
                edit_btn.Enabled = false;
                selected_table_lv.Enabled = false;
            }
        }//end method

        private void insert_btn_Click(object sender, EventArgs e)
        {
            if(edit_tables_lb.SelectedIndex < 0)
            {
                MessageBox.Show("You must select a table to insert into.", "Error");
            }
        }//end method

        private void delete_btn_Click(object sender, EventArgs e)
        {
            if (edit_tables_lb.SelectedIndex < 0)
            {
                MessageBox.Show("You must select a table to delete from.", "Error");
            }
        }//end method
    }//end class
}//end namespace
