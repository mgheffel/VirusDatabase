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
            DataSet output = c.tempQuery(input);
            output_lb.Items.Add(output.ToString());
        }

        private void delete_rb_CheckedChanged(object sender, EventArgs e)
        {
            if (delete_rb.Checked)
                selected_table_lb.Enabled = true;
            else
                selected_table_lb.Enabled = false;
        }

        private void edit_tables_lb_SelectedIndexChanged(object sender, EventArgs e)
        {
            string table;
            table = edit_tables_lb.SelectedIndex.ToString();
            DataSet resultSet = c.displayTableContents(table);
            DataTable resultTable = resultSet.Tables[0];
            int columnCount = resultTable.Columns.Count;
            int rowCount = resultTable.Rows.Count;
            foreach (DataColumn col in resultTable.Columns)
                selected_table_lv.Columns.Add(col.ColumnName);
            for(int i = 0; i < rowCount; i++)
            {
                for(int j = 0; j < columnCount; j++)
                {
                    selected_table_lv.Items[i].SubItems.Add(resultTable.Rows[i][j].ToString());
                }
            }
        }
    }
}
