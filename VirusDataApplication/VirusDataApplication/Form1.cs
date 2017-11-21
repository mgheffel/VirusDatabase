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
        private Controller control;
        public Form1(Controller c)
        {
            InitializeComponent();
            control = c;
        }

        private void send_btn_Click(object sender, EventArgs e)
        {
            string input = input_tb.Text;
            string output = control.tempQuery(input);
            output_lb.Items.Add(output);
        }
    }
}
