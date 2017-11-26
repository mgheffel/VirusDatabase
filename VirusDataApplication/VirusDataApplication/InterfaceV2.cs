﻿using System;
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
        private DataTable species, strains, subContent, followingSubContent;
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
    }
}
