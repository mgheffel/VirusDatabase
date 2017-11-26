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
        string tableName;
        Controller c;
        TextBox[] tbArr = new TextBox[6];
        Label[] lblArr = new Label[6];
        DataTable currentTable;

        public editGUI(string name, string val, Controller control)
        {
            InitializeComponent();
            tableName = name;
            c = control;
            tbArr[0] = tb1;
            tbArr[1] = tb2;
            tbArr[2] = tb3;
            tbArr[3] = tb4;
            tbArr[4] = tb5;
            tbArr[5] = tb6;
            lblArr[0] = tb1_lbl;
            lblArr[0] = tb1_lbl;
            lblArr[0] = tb1_lbl;
            lblArr[0] = tb1_lbl;
            lblArr[0] = tb1_lbl;
            lblArr[0] = tb1_lbl;
            tableName_lbl.Text = tableName;
        }

        private void enableApprpriateTBs(int count)
        {
            for (int i = 0; i < count; i++)
                tbArr[i].Enabled = true;
        }
    }
}
