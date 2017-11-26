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
    public partial class InterfaceV2 : Form
    {
        private DataTable species, strains, subContent, followingSubContent, alignStrains1, alignORF1, alignStrains2, alignORF2, alignGenome1, alignGenome2;
        private List<DataTable> ldt;
        private List<Label> ll;
        private List<ListBox> contentViewer;
        private Controller c;
        private int dropdownChoice;

        public InterfaceV2(Controller c)
        {
            InitializeComponent();
            //onOffRadioButtons();
            this.c = c;
            ldt = new List<DataTable>();
            ll = new List<Label>();            
            contentViewer = new List<ListBox>();
            addEverything();            
            species = c.displayTableContents("Species");
            populateListView(uxSpeciesBox, species, 1, "Species Name");
        }
        /// <summary>
        /// Add all the objects to the global lists
        /// </summary>
        private void addEverything()
        {
            ll.Add(species_lbl);
            ll.Add(strain_lbl);
            ll.Add(choice_lbl);
            ll.Add(following_lbl);
            ldt.Add(species);
            ldt.Add(strains);
            ldt.Add(subContent);
            ldt.Add(followingSubContent);
            contentViewer.Add(uxSpeciesBox);
            contentViewer.Add(uxStrainsBox);
            contentViewer.Add(uxChoiceBox);
            contentViewer.Add(uxFollowingBox);
            species = c.displayTableContents("Species");
            populateListView(uxSpeciesBox, species, 1, "Species Name");
            AlignPopulateDropDown(uxSpecies1Drop, species, 1);
            AlignPopulateDropDown(uxSpecies2Drop, species, 1);
        }
        
        /// <summary>
        /// When a strain is selected event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxStrainsBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxChoiceBox.Items.Clear();
            uxFollowingBox.Items.Clear();
            uxOptionsDropdown.Enabled = true;
            if(uxOptionsDropdown.SelectedIndex == -1)//nothing selected yet
            {
                MessageBox.Show("Please select an item from the dropdown.");
                return;
            }
            //MessageBox.Show(dropdownChoice.ToString());
            switch(dropdownChoice)
            {
                case 1://display protiens
                    subContent = c.displayTableContents(" OpenReadingFrames WHERE strainID = '" + strains.Rows[uxStrainsBox.SelectedIndex][0].ToString() + "'");
                    populateListView(uxChoiceBox, subContent, 1, "ORF ID");
                    followingSubContent = c.displayTableContents(" Proteins WHERE pID = " + subContent.Rows[0][2].ToString());
                    populateListView(uxFollowingBox, followingSubContent, 1, "Protien Name");
                    break;
                case 2://display publishers
                    subContent = c.displayTableContents(" Publications as p JOIN Strain_Publication AS sp ON sp.pubID = p.pubID WHERE sp.strainID = '" + strains.Rows[uxStrainsBox.SelectedIndex][0].ToString() + "'");
                    populateListView(uxChoiceBox, subContent, 2, "Publication Title");
                    followingSubContent = c.displayTableContents(" Publishers as p join Publisher_Publication as pp on pp.publisherID = p.publisherID WHERE pp.pubID = " + subContent.Rows[0][0].ToString());
                    populateListView(uxFollowingBox, followingSubContent, 1, "Publisher Name");
                    break;
                case 3://display researchers
                    subContent = c.displayTableContents(" Publications as p JOIN Strain_Publication AS sp ON sp.pubID = p.pubID WHERE sp.strainID = '" + strains.Rows[uxStrainsBox.SelectedIndex][0].ToString() + "'");
                    populateListView(uxChoiceBox, subContent, 2, "Publication Title");
                    followingSubContent = c.displayTableContents(" Researchers as r join Publication_Researcher AS pr ON pr.rID = r.rID WHERE pr.pubID = " + subContent.Rows[0][0].ToString());
                    populateListView(uxFollowingBox, followingSubContent, 1, "Researcher Name");
                    break;
            }
        }

        private void uxOptionsDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxChoiceBox.Items.Clear();
            uxFollowingBox.Items.Clear();

            switch (uxOptionsDropdown.SelectedItem.ToString())
            {
                case "OpenReadingFrames":
                    {
                        choice_lbl.Text = "OpenReadingFrames";
                        following_lbl.Text = "Protiens";
                        choice_lbl.Visible = true;
                        following_lbl.Visible = true;
                        dropdownChoice = 1;
                        break;
                    }
                case "Publications - Publishers":
                    {
                        choice_lbl.Text = "Publications";
                        following_lbl.Text = "Publishers";
                        choice_lbl.Visible = true;
                        following_lbl.Visible = true;
                        dropdownChoice = 2;
                        break;
                    }
                case "Publications - Researchers":
                    {
                        choice_lbl.Text = "Publications";
                        following_lbl.Text = "Researchers";
                        choice_lbl.Visible = true;
                        following_lbl.Visible = true;
                        dropdownChoice = 3;
                        break;
                    }
            }

            uxStrainsBox_SelectedIndexChanged(sender, e);
        }

        /// <summary>
        /// On Button Press
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxDetialsButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder();
            
            int numOfColumns = 0, counter = 0;

            foreach(ListBox view in contentViewer)
            {
                if(view.SelectedIndex == -1)
                {
                    break;
                }
                numOfColumns = ldt[counter].Columns.Count;
                sb.Append(ll[counter].Text + ":\n");
                for (int i = 0; i < numOfColumns; i++)
                {
                    
                }
                counter++;
            }
            MessageBox.Show(sb.ToString());
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            if(uxSpeciesBox.SelectedIndex >= 0 && uxStrainsBox.SelectedIndex < 0)
            {
                MessageBox.Show("Error: Cannot edit species.", "Error");
            }
            else if(uxStrainsBox.SelectedIndex >= 0)
            {

            }
            editGUI editWindow = new editGUI("chode");
            editWindow.ShowDialog();
        }

        private void uxSpecies2Drop_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxStrain2Drop.Items.Clear();
            uxStrain2Drop.ResetText();
            alignStrains2 = c.displayTableContents("Strains WHERE specID = " + species.Rows[uxSpecies2Drop.SelectedIndex][0].ToString());
            AlignPopulateDropDown(uxStrain2Drop, alignStrains2, 0);
        }

        private void uxStrain2Drop_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxORF2Drop.Items.Clear();
            uxORF2Drop.ResetText();
            alignORF2 = c.displayTableContents(" OpenReadingFrames WHERE strainID = '" + alignStrains2.Rows[uxStrain2Drop.SelectedIndex][0].ToString() + "'");
            AlignPopulateDropDown(uxORF2Drop, alignORF2, 1);
        }

        private void uxORF1Drop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxORF1Drop.SelectedIndex >= 0 && uxORF2Drop.SelectedIndex >= 0)
            {
                uxAlignButton.Enabled = true;
            }
            else uxAlignButton.Enabled = false;
        }

        private void uxORF2Drop_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uxORF1Drop.SelectedIndex >= 0 && uxORF2Drop.SelectedIndex >= 0)
            {
                uxAlignButton.Enabled = true;
            }
            else uxAlignButton.Enabled = false;
        }

        private void uxAlignButton_Click(object sender, EventArgs e)
        {
            //alignGenome1 = c.displayTableContents("Select genome FROM Strains WHERE")
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="lv"></param>
        /// <param name="dt"></param>
        /// <param name="colNum"></param>
        /// <param name="colName"></param>
        private void populateListView(ListBox lv, DataTable dt, int colNum, string colName)
        {
            int totalRows;

            lv.Items.Clear();
            totalRows = dt.Rows.Count;
            for(int i = 0; i < totalRows; i++)
            {
                lv.Items.Add(dt.Rows[i][colNum].ToString());
            }
        }

        private void uxSpecies1Drop_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxStrain1Drop.Items.Clear();
            uxStrain1Drop.ResetText();
            alignStrains1 = c.displayTableContents("Strains WHERE specID = " + species.Rows[uxSpecies1Drop.SelectedIndex][0].ToString());
            //POTENTIAL SOURCE OF ERROR BETWEEN TABS BECAUSE WE ARE UPDATING STRAINS
            AlignPopulateDropDown(uxStrain1Drop, alignStrains1, 0);

        }

        private void uxStrain1Drop_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxORF1Drop.Items.Clear();
            uxORF1Drop.ResetText();
            alignORF1 = c.displayTableContents(" OpenReadingFrames WHERE strainID = '" + alignStrains1.Rows[uxStrain1Drop.SelectedIndex][0].ToString() + "'");
            AlignPopulateDropDown(uxORF1Drop, alignORF1, 1);
        }

        /// <summary>
        /// When a Species is selected(clicked on) it will populate the Strains for that Species in the uxStrainsListBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxSpeciesBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxOptionsDropdown.Enabled = false;
            uxChoiceBox.Items.Clear();
            uxFollowingBox.Items.Clear();
            uxStrainsBox.Items.Clear();
            strains = c.displayTableContents("Strains WHERE specID = " + species.Rows[uxSpeciesBox.SelectedIndex][0].ToString());
            populateListView(uxStrainsBox, strains, 0, "Strain ID");
        }
        
        /// <summary>
        /// When the applicaton is launched, it will run this method, load method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InterfaceV2_Load(object sender, EventArgs e)
        {
            
        }
        private void AlignPopulateDropDown(ComboBox dd, DataTable dt, int colNum)
        {
            dd.Items.Clear();
            foreach(DataRow row in dt.Rows)
            {
                dd.Items.Add(row[colNum].ToString());
            }
        }
    }
}
