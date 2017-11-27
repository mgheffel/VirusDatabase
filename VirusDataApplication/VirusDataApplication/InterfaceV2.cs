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
    public partial class InterfaceV2 : Form
    {
        private DataTable species, strains, subContent, followingSubContent, alignStrains1, alignORF1, alignStrains2, alignORF2, alignGenome;
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
            string value = "";
            string tableName = "";
            if (uxSpeciesBox.SelectedIndex >= 0 && uxStrainsBox.SelectedIndex < 0)
            {
                MessageBox.Show("Error: Cannot edit species.", "Error");
            }
            else
            { 
                if (uxStrainsBox.SelectedIndex >= 0 && uxChoiceBox.SelectedIndex < 0 && uxFollowingBox.SelectedIndex < 0)
                {
                    value = uxStrainsBox.SelectedItem.ToString();
                    tableName = "Strains";
                }
                else if(uxChoiceBox.SelectedIndex >= 0 && uxFollowingBox.SelectedIndex < 0)
                {
                    value = uxChoiceBox.SelectedItem.ToString();
                    switch(uxOptionsDropdown.SelectedIndex)
                    {
                        case 0:
                            tableName = "OpenReadingFrames";
                            break;
                        case 1:
                        case 2:
                            tableName = "Publications";
                            break;
                    }
                }
                else
                {
                    value = uxFollowingBox.SelectedItem.ToString();
                    switch (uxOptionsDropdown.SelectedIndex)
                    {
                        case 0:
                            tableName = "Proteins";
                            break;
                        case 1:
                            tableName = "Publishers";
                            break;
                        case 2:
                            tableName = "Researchers";
                            break;
                    }
                }
                editGUI editWindow = new editGUI(value, tableName, c);
                editWindow.ShowDialog();
                if(editWindow.DialogResult == DialogResult.OK)
                {
                    MessageBox.Show("edit made");
                }
            }
        }

        private void uxSpecies2Drop_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxAlignButton.Enabled = false;
            uxStrain2Drop.Items.Clear();
            uxStrain2Drop.ResetText();
            alignStrains2 = c.displayTableContents("Strains WHERE specID = " + species.Rows[uxSpecies2Drop.SelectedIndex][0].ToString());
            AlignPopulateDropDown(uxStrain2Drop, alignStrains2, 0);
        }

        private void uxStrain2Drop_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxAlignButton.Enabled = false;
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
            uxAlignButton.Enabled = false;
            alignGenome = c.SendTheWave("Select st.strainID, orfID, startIndex, stopIndex, st.genome"
                                            + " FROM OpenReadingFrames as orf"
                                            + " JOIN Strains st"
                                            + " ON st.strainID = orf.strainID"
                                            + " WHERE (orf.strainID = '"
                                            + uxStrain1Drop.SelectedItem.ToString() + "'"
                                            + " AND orfID = '" + uxORF1Drop.SelectedItem.ToString() + "')"
                                            + " OR (orf.strainID = '"
                                            + uxStrain2Drop.SelectedItem.ToString() + "'"
                                            + " AND orfID = '" + uxORF2Drop.SelectedItem.ToString() + "')"
                                            );
            backgroundWorker1 = new BackgroundWorker();
            backgroundWorker1.WorkerReportsProgress = true;
            backgroundWorker1.DoWork += new DoWorkEventHandler(backgroundWorker1_DoWork);
            backgroundWorker1.ProgressChanged += new ProgressChangedEventHandler(backgroundWorker1_ProgressChanged);
            backgroundWorker1.RunWorkerAsync();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            sf.FileName = "AlignedORFs.txt";
            sf.Filter = "Text File | *.txt";
            Invoke((Action)(() => { sf.ShowDialog(); }));
            {
                StreamWriter sw = new StreamWriter(sf.OpenFile());
                int start1 = Convert.ToInt32(alignGenome.Rows[0][2].ToString());
                int end1 = Convert.ToInt32(alignGenome.Rows[0][3].ToString());
                int start2 = Convert.ToInt32(alignGenome.Rows[1][2].ToString());
                int end2 = Convert.ToInt32(alignGenome.Rows[1][3].ToString());
                Tuple<string, string> values = alignORF(alignGenome.Rows[0][4].ToString().Substring(start1, end1-start1), alignGenome.Rows[1][4].ToString().Substring(start2, end2-start2));
                sw.WriteLine(values.Item1.ToString());
                sw.WriteLine();
                sw.WriteLine();
                sw.WriteLine(values.Item2.ToString());
                sw.Dispose();
                sw.Close();
                MessageBox.Show(values.Item1.ToString() + values.Item2.ToString());
            }
            Invoke(new Action(() => {
                uxAlignButton.Enabled = true;
            }));
            
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }


        private Tuple<string, string> alignORF (string refSeq, string alignSeq)
        {
           

            int refSeqCnt = refSeq.Length + 1;
            int alineSeqCnt = alignSeq.Length + 1;

            int[,] scoringMatrix = new int[alineSeqCnt, refSeqCnt];

            //Initialization Step - filled with 0 for the first row and the first column of matrix
            for (int i = 0; i < alineSeqCnt; i++)
            {
                scoringMatrix[i, 0] = 0;
            }

            for (int j = 0; j < refSeqCnt; j++)
            {
                scoringMatrix[0, j] = 0;
            }

            //Matrix Fill Step
            for (int i = 1; i < alineSeqCnt; i++)
            {
                for (int j = 1; j < refSeqCnt; j++)
                {
                    int scroeDiag = 0;
                    if (refSeq.Substring(j - 1, 1) == alignSeq.Substring(i - 1, 1))
                        scroeDiag = scoringMatrix[i - 1, j - 1] + 2;
                    else
                        scroeDiag = scoringMatrix[i - 1, j - 1] + -1;

                    int scroeLeft = scoringMatrix[i, j - 1] - 2;
                    int scroeUp = scoringMatrix[i - 1, j] - 2;

                    int maxScore = Math.Max(Math.Max(scroeDiag, scroeLeft), scroeUp);

                    scoringMatrix[i, j] = maxScore;
                }
            }


            //Traceback step
            char[] alineSeqArray = alignSeq.ToCharArray();
            char[] refSeqArray = refSeq.ToCharArray();

            string AlignmentA = string.Empty;
            string AlignmentB = string.Empty;
            int m = alineSeqCnt - 1;
            int n = refSeqCnt - 1;
            while (m > 0 && n > 0)
            {
                int scroeDiag = 0;

                //Remembering that the scoring scheme is +2 for a match, -1 for a mismatch and -2 for a gap
                if (alineSeqArray[m - 1] == refSeqArray[n - 1])
                    scroeDiag = 2;
                else
                    scroeDiag = -1;

                if (m > 0 && n > 0 && scoringMatrix[m, n] == scoringMatrix[m - 1, n - 1] + scroeDiag)
                {
                    AlignmentA = refSeqArray[n - 1] + AlignmentA;
                    AlignmentB = alineSeqArray[m - 1] + AlignmentB;
                    m = m - 1;
                    n = n - 1;
                }
                else if (n > 0 && scoringMatrix[m, n] == scoringMatrix[m, n - 1] - 2)
                {
                    AlignmentA = refSeqArray[n - 1] + AlignmentA;
                    AlignmentB = "-" + AlignmentB;
                    n = n - 1;
                }
                else //if (m > 0 && scoringMatrix[m, n] == scoringMatrix[m - 1, n] + -2)
                {
                    AlignmentA = "-" + AlignmentA;
                    AlignmentB = alineSeqArray[m - 1] + AlignmentB;
                    m = m - 1;
                }
            }

            string ann = "";
            for (int i = 0; i < AlignmentA.Length; i++)
            {
                if (AlignmentA[i] == AlignmentB[i])
                {
                    ann += ' ';
                }
                else if (AlignmentA[i].ToString().Equals("-") || AlignmentB[i].ToString().Equals("-"))
                {
                    ann += '-';
                }
                else
                {
                    ann += 'X';
                }
            }
            Tuple<string, string> values = new Tuple<string, string>(AlignmentA, AlignmentB);
            return values;
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
            uxAlignButton.Enabled = false;
            uxStrain1Drop.Items.Clear();
            uxStrain1Drop.ResetText();
            alignStrains1 = c.displayTableContents("Strains WHERE specID = " + species.Rows[uxSpecies1Drop.SelectedIndex][0].ToString());
            //POTENTIAL SOURCE OF ERROR BETWEEN TABS BECAUSE WE ARE UPDATING STRAINS
            AlignPopulateDropDown(uxStrain1Drop, alignStrains1, 0);

        }

        private void uxStrain1Drop_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxAlignButton.Enabled = false;
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
