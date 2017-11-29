using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace VirusDataApplication
{
    public partial class InsertStrain : Form
    {
        private InsertPublication ip;
        private string genome;
        public InsertStrain(InsertPublication ipub)
        {
            ip = ipub;
            InitializeComponent();
        }

        private void uxSelectGenomeButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(of.FileName);
                genome = sr.ReadToEnd();
                uxFilePathLabel.Text = of.FileName.ToString();
                sr.Close();
            }
        }

        private void ButtonEnable(object sender, EventArgs e)
        {
            if (uxStrainID.Text.Length > 0 && uxBasePairs.Text.Length > 0 && uxFilePathLabel.Text.Length > 0)
            {
                uxAddStrainButton.Enabled = true;
            }
            else uxAddStrainButton.Enabled = false;
        }

        private void uxAddStrainButton_Click(object sender, EventArgs e)
        {
            ip.AddStrainToList(new Tuple<string, string, string>(uxStrainID.Text, uxBasePairs.Text, genome));
            this.Close();
        }
    }
}
