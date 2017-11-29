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
    public partial class InsertORF : Form
    {
        private Controller c;

        private string StrainID;

        public InsertORF(Controller con, string orfID, string strainID)
        {
            StrainID = strainID;
            
            c = con;
            InitializeComponent();
            uxORFID.Text = orfID;
            PopulateProteinsDropDown();
            DataTable d = c.SendTheWave("SELECT LENGTH(genome) FROM Strains where strainID = '" + StrainID + "'");
            uxStartIndex.Maximum = Convert.ToInt32(d.Rows[0][0].ToString()) - 1;
            uxStopIndex.Maximum = Convert.ToInt32(d.Rows[0][0].ToString());
        }

        private void InsertORF_Load(object sender, EventArgs e)
        {

        }

        private void PopulateProteinsDropDown()
        {
            DataTable d = c.SendTheWave("SELECT distinct pName from Proteins");
            uxSelectProteinDown.Items.Clear();
            foreach (DataRow row in d.Rows)
            {
                uxSelectProteinDown.Items.Add(row[0].ToString());
            }
        }

        private void uxCreateStructuralProteinButton_Click(object sender, EventArgs e)
        {
            //First Create the protein in the Proteins table.
            c.sendNonQuery("INSERT INTO Proteins(pName) VALUES ('" + uxProteinName.Text + "')");
            //Now Create it in the StructuralProteins table after finding pID
            DataTable d = c.SendTheWave("SELECT pID from Proteins where pName = '" + uxProteinName.Text + "'");
            c.sendNonQuery("INSERT INTO StructuralProteins(pID, struct) VALUES ('" + d.Rows[0][0].ToString() + "', '" + uxStructTextBox.Text + "')");
            uxProteinName.ResetText();
            uxStructTextBox.ResetText();
            PopulateProteinsDropDown();
            uxSelectProteinDown.SelectedIndex = uxSelectProteinDown.Items.Count - 1;

        }

        private void uxCreateNonStructuralProteinButton_Click(object sender, EventArgs e)
        {
            //First Create the protein in the Proteins table.
            c.sendNonQuery("INSERT INTO Proteins(pName) VALUES ('" + uxProteinName.Text + "');");
            //Now Create it in the NonStructuralProteins table after finding pID
            DataTable d = c.SendTheWave("SELECT pID from Proteins where pName = '" + uxProteinName.Text + "'");
            c.sendNonQuery("INSERT INTO NonStructuralProteins(pID, funct) VALUES ('" + d.Rows[0][0].ToString() + "', '" + uxFunctTextBox.Text + "')");
            uxProteinName.ResetText();
            uxFunctTextBox.ResetText();
            PopulateProteinsDropDown();
            uxSelectProteinDown.SelectedIndex = uxSelectProteinDown.Items.Count - 1;

        }

        private void uxStructTextBox_TextChanged(object sender, EventArgs e)
        {
            if (uxStructTextBox.Text.Length > 0 && uxProteinName.Text.Length > 0)
            {
                uxCreateStructuralProteinButton.Enabled = true;
            }
            else uxCreateStructuralProteinButton.Enabled = false;
        }

        public void EnableCreateORFButton(object sender, EventArgs e)
        {
            if (uxORFID.Text.Length > 0 && uxSelectProteinDown.SelectedIndex >= 0 && uxStartIndex.Value < uxStopIndex.Value)
            {
                uxCreateORF.Enabled = true;
            }
            else uxCreateORF.Enabled = false;
        }

        private void uxFunctTextBox_TextChanged(object sender, EventArgs e)
        {
            if (uxFunctTextBox.Text.Length > 0 && uxProteinName.Text.Length > 0)
            {
                uxCreateNonStructuralProteinButton.Enabled = true;
            }
            else uxCreateNonStructuralProteinButton.Enabled = false;
        }

        private void uxCreateORF_Click(object sender, EventArgs e)
        {
            //Find pID of selected protein
            DataTable pID = c.SendTheWave("SELECT pID from Proteins where pName = '" + uxSelectProteinDown.SelectedItem.ToString() + "'");
            //Do sql insert
            string sendString = "INSERT INTO OpenReadingFrames(strainID, orfID, pID, startIndex, stopIndex) VALUES ('" + StrainID + "', '" + uxORFID.Text
                            + "', " + pID.Rows[0][0].ToString() + ", " + uxStartIndex.Value.ToString() + ", " + uxStopIndex.Value.ToString() + ")";
            c.sendNonQuery(sendString);
            this.Close();
        }
    }
}
