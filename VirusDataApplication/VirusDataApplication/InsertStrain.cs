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
        private bool noPublication;
        private InterfaceV2 iv2;

        /// <summary>
        /// This version is for when there is a publisher
        /// </summary>
        /// <param name="ipub">Handle to publication insert gui</param>
        public InsertStrain(InsertPublication ipub)
        {
            ip = ipub;
            InitializeComponent();
        }

        /// <summary>
        /// This version is for when there is no publisher.
        /// </summary>
        public InsertStrain(InterfaceV2 iv)
        {
            iv2 = iv;
            noPublication = true;
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
            if (noPublication)
            {
                iv2.insertStrain(new Tuple<string, string, string>(uxStrainID.Text, uxBasePairs.Text, genome));
            }
            else
            {
                ip.AddStrainToList(new Tuple<string, string, string>(uxStrainID.Text, uxBasePairs.Text, genome));
            }
            this.Close();
        }
    }
}
