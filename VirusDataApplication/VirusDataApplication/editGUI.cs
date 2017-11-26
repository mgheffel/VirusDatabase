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
        public editGUI(string tbValue)
        {
            InitializeComponent();
            edit_tb.Text = tbValue;
            edit_tb.SelectionStart = 0;
            edit_tb.SelectionLength = edit_tb.Text.Length;
        }
    }
}
