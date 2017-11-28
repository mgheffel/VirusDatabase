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
using System.Diagnostics;

namespace VirusDataApplication
{
    public partial class InterfaceV2 : Form
    {
        private DataTable species, strains, subContent, followingSubContent, alignStrains1, alignORF1, alignStrains2, alignORF2, alignGenome;
        //private List<DataTable> ldt;
        private DataTable[] ldt;
        private List<Label> ll;
        private List<ListBox> contentViewer;
        private Controller c;
        private int dropdownChoice;

        public InterfaceV2(Controller c)
        {
            InitializeComponent();
            //onOffRadioButtons();
            this.c = c;
            ldt = new DataTable[4];
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
            following_lbl.Visible = false;
            choice_lbl.Visible = false;
            ll.Add(species_lbl);
            ll.Add(strain_lbl);
            ll.Add(choice_lbl);
            ll.Add(following_lbl);            
            contentViewer.Add(uxSpeciesBox);
            contentViewer.Add(uxStrainsBox);
            contentViewer.Add(uxChoiceBox);
            contentViewer.Add(uxFollowingBox);
            species = c.displayTableContents("Species");
            populateListView(uxSpeciesBox, species, 1, "Species Name");
            ldt[0] = species;//if species is added or removed, this needs to be done in that method, INSERT, DELETE

            PopulateDropDown(uxSpecies1Drop, species, 1);
            PopulateDropDown(uxSpecies2Drop, species, 1);
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
                //MessageBox.Show("Please select an item from the dropdown.");
                return;
            }
            //MessageBox.Show(dropdownChoice.ToString());
            switch(dropdownChoice)
            {
                case 1://display protiens
                    subContent = c.displayTableContents(" OpenReadingFrames WHERE strainID = '" + strains.Rows[uxStrainsBox.SelectedIndex][0].ToString() + "'");
                    populateListView(uxChoiceBox, subContent, 1, "ORF ID");
                    
                    break;
                case 2://display publishers
                    subContent = c.displayTableContents(" Publications as p JOIN Strain_Publication AS sp ON sp.pubID = p.pubID WHERE sp.strainID = '" + strains.Rows[uxStrainsBox.SelectedIndex][0].ToString() + "'");
                    populateListView(uxChoiceBox, subContent, 2, "Publication Title");
                    
                    break;
                case 3://display researchers
                    subContent = c.displayTableContents(" Publications as p JOIN Strain_Publication AS sp ON sp.pubID = p.pubID WHERE sp.strainID = '" + strains.Rows[uxStrainsBox.SelectedIndex][0].ToString() + "'");
                    populateListView(uxChoiceBox, subContent, 2, "Publication Title");
                    
                    break;
            }
            ldt[2] = subContent;
            ldt[3] = followingSubContent;
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
            
            foreach (ListBox view in contentViewer)
            {
                if(view.SelectedIndex == -1)
                {
                    break;
                }
                numOfColumns = ldt[counter].Columns.Count;
                sb.Append(ll[counter].Text + ":\n");
                for (int i = 0; i < numOfColumns; i++)
                {
                    if(counter == 1 && i == 3)
                    {
                        sb.Append(ldt[counter].Rows[view.SelectedIndex][i].ToString().Substring(0,20));
                        break;
                    }
                    sb.Append(ldt[counter].Rows[view.SelectedIndex][i].ToString() + "\t");
                }
                sb.Append("\n");
                counter++;
            }
            MessageBox.Show(sb.ToString());
        }

        private void edit_btn_Click(object sender, EventArgs e)
        {
            int intVal;
            string strVal = "";
            string strVal2 = ""; //if needed
            string tableName = "";
            string colName = "";
            string colName2 = "";//if needed
            editGUI editWindow;
            if (uxSpeciesBox.SelectedIndex >= 0 && uxStrainsBox.SelectedIndex < 0 && uxChoiceBox.SelectedIndex < 0 && uxFollowingBox.SelectedIndex < 0)
            {//item in species box is selected, nothing else
                tableName = "Species";
                colName = "specID";
                intVal = Convert.ToInt32(species.Rows[uxSpeciesBox.SelectedIndex][0]);
                editWindow = new editGUI(c);
                editWindow.assignValsInt(tableName, colName, intVal);
                editWindow.ShowDialog();
            }
            else if (uxStrainsBox.SelectedIndex >= 0 && uxChoiceBox.SelectedIndex < 0)//item in species and strains boxes are selected, nothing else
                MessageBox.Show("You are unable to edit strains. Sorry.", "Error");
            else if (uxChoiceBox.SelectedIndex >= 0 && uxFollowingBox.SelectedIndex < 0)
            {//item in species, strains, and choice box are selected
                switch (dropdownChoice)
                {
                    case 1:
                        tableName = "OpenReadingFrames";
                        colName = "orfID";
                        colName2 = "strainID";
                        strVal = subContent.Rows[uxChoiceBox.SelectedIndex][1].ToString();
                        strVal2 = strains.Rows[uxStrainsBox.SelectedIndex][0].ToString();
                        editWindow = new editGUI(c);
                        editWindow.assignValsORF(tableName, colName, colName2, strVal, strVal2);
                        editWindow.ShowDialog();
                        break;
                    case 2:
                    case 3:
                        tableName = "Publications";
                        colName = "pubID";
                        intVal = Convert.ToInt32(subContent.Rows[uxChoiceBox.SelectedIndex][0]);
                        editWindow = new editGUI(c);
                        editWindow.assignValsInt(tableName, colName, intVal);
                        editWindow.ShowDialog();
                        break;
                }
            }
            else   //all boxes are displayed, edit will take place on selected item in fourth box.
            {
                switch(dropdownChoice)
                {
                    case 1:
                        tableName = "Proteins";
                        colName = "pID";
                        intVal = Convert.ToInt32(followingSubContent.Rows[uxFollowingBox.SelectedIndex][0]);
                        editWindow = new editGUI(c);
                        editWindow.assignValsInt(tableName, colName, intVal);
                        editWindow.ShowDialog();
                        break;
                    case 2:
                        tableName = "Publishers";
                        colName = "publisherID";
                        intVal = Convert.ToInt32(followingSubContent.Rows[uxFollowingBox.SelectedIndex][0]);
                        editWindow = new editGUI(c);
                        editWindow.assignValsInt(tableName, colName, intVal);
                        editWindow.ShowDialog();
                        break;
                    case 3:
                        tableName = "Researchers";
                        colName = "rID";
                        intVal = Convert.ToInt32(followingSubContent.Rows[uxFollowingBox.SelectedIndex][0]);
                        editWindow = new editGUI(c);
                        editWindow.assignValsInt(tableName, colName, intVal);
                        editWindow.ShowDialog();
                        break;
                }
            }
         }//end method
           

        private void uxSpecies2Drop_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxAlignButton.Enabled = false;
            uxORF2Drop.Items.Clear();
            uxORF2Drop.ResetText();
            uxStrain2Drop.Items.Clear();
            uxStrain2Drop.ResetText();
            alignStrains2 = c.displayTableContents("Strains WHERE specID = " + species.Rows[uxSpecies2Drop.SelectedIndex][0].ToString());
            PopulateDropDown(uxStrain2Drop, alignStrains2, 0);
        }

        private void uxStrain2Drop_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxAlignButton.Enabled = false;
            uxORF2Drop.Items.Clear();
            uxORF2Drop.ResetText();
            alignORF2 = c.displayTableContents(" OpenReadingFrames WHERE strainID = '" + alignStrains2.Rows[uxStrain2Drop.SelectedIndex][0].ToString() + "'");
            PopulateDropDown(uxORF2Drop, alignORF2, 1);
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
            Invoke(new Action(() => {
                uxAlignButton.Enabled = false;
                uxSpecies1Drop.Enabled = false;
                uxStrain1Drop.Enabled = false;
                uxORF1Drop.Enabled = false;
                uxSpecies2Drop.Enabled = false;
                uxStrain2Drop.Enabled = false;
                uxORF2Drop.Enabled = false;
            }));
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
                Tuple<string, string, string> values = alignORF(alignGenome.Rows[0][4].ToString().Substring(start1, end1-start1), alignGenome.Rows[1][4].ToString().Substring(start2, end2-start2));
                Invoke((Action)(() =>
                {
                    sw.WriteLine(uxSpecies1Drop.SelectedItem.ToString() + " |" + uxStrain1Drop.SelectedItem.ToString() + " | " + uxORF1Drop.SelectedItem.ToString());
                    sw.WriteLine(values.Item1.ToString().ToUpper());
                    sw.WriteLine(uxSpecies2Drop.SelectedItem.ToString() + " |" + uxStrain2Drop.SelectedItem.ToString() + " | " + uxORF2Drop.SelectedItem.ToString());
                    sw.WriteLine(values.Item2.ToString().ToUpper());
                    sw.WriteLine("Annotation");
                    sw.WriteLine(values.Item3.ToString());
                }));
                Process.Start("notepad.exe", sf.FileName);
                sw.Dispose();
                sw.Close();
            }
            Invoke(new Action(() => {
                uxAlignButton.Enabled = true;
                uxSpecies1Drop.Enabled = true;
                uxStrain1Drop.Enabled = true;
                uxORF1Drop.Enabled = true;
                uxSpecies2Drop.Enabled = true;
                uxStrain2Drop.Enabled = true;
                uxORF2Drop.Enabled = true;
            }));
            
            
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar1.Value = e.ProgressPercentage;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void uxInsert_Click(object sender, EventArgs e)
        {
            PopulateDropDown(uxInsertSpeciesDown, species, 1);
        }

        private void uxAddSpecies_Click(object sender, EventArgs e)
        {
            InsertSpecies insertSpecies = new InsertSpecies(c);
            if (insertSpecies.ShowDialog() == DialogResult.OK)
            {

            }



        }
        /// <summary>
        /// When a new index is selected in the uxChoiceBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void uxChoiceBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(dropdownChoice)
            {
                case 1:
                    if (subContent.Rows.Count > 0 && uxChoiceBox.SelectedIndex >= 0)
                    {
                        followingSubContent = c.displayTableContents(" Proteins WHERE pID = " + subContent.Rows[uxChoiceBox.SelectedIndex][2].ToString());
                        populateListView(uxFollowingBox, followingSubContent, 1, "Protien Name");
                    }
                    break;
                case 2:
                    if (subContent.Rows.Count > 0)
                    {
                        followingSubContent = c.displayTableContents(" Publishers as p join Publisher_Publication as pp on pp.publisherID = p.publisherID WHERE pp.pubID = " + subContent.Rows[0][0].ToString());
                        populateListView(uxFollowingBox, followingSubContent, 1, "Publisher Name");
                    }
                    break;
                case 3:
                    if (subContent.Rows.Count > 0)
                    {
                        followingSubContent = c.displayTableContents(" Researchers as r join Publication_Researcher AS pr ON pr.rID = r.rID WHERE pr.pubID = " + subContent.Rows[0][0].ToString());
                        populateListView(uxFollowingBox, followingSubContent, 1, "Researcher Name");
                    }
                    break;
            }
            
            
            
        }


        /// <summary>
        /// Event handler for delete button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void delete_btn_Click(object sender, EventArgs e)
        {
            if(uxFollowingBox.SelectedIndex >= 0)
            {//all four boxes selected, item selected in fourth box is to be deleted.
                switch(dropdownChoice)
                {
                    case 1:
                        if (deleteProtein())
                            MessageBox.Show("Selected protein has been deleted.", "Delete Operation");
                        else
                            MessageBox.Show("Error: Unable to delete selected protein.", "Delete Operation");
                        break;
                    case 2:
                        if (deletePublisher())
                            MessageBox.Show("Selected publisher has been deleted.", "Delete Operation");
                        else
                            MessageBox.Show("Error: Unable to delete selected publisher.", "Delete Operation");
                        break;
                    case 3:
                        if (deleteResearcher())
                            MessageBox.Show("Selected researcher has been deleted.", "Delete Operation");
                        else
                            MessageBox.Show("Error: Unable to delete selected researcher.", "Delete Operation");
                        break;
                }
            }
            else if(uxChoiceBox.SelectedIndex >= 0 && uxFollowingBox.SelectedIndex < 0)
            {//Third box is most recently selected item.

            }
            else if(uxStrainsBox.SelectedIndex >= 0 && uxChoiceBox.SelectedIndex < 0)
            {//Second box is most recently selected.
                
            }
        }//end method

        private Tuple<string, string, string> alignORF (string refSeq, string alignSeq)
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
            Tuple<string, string, string> values = new Tuple<string, string, string>(AlignmentA, AlignmentB, ann);
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
            uxORF1Drop.Items.Clear();
            uxORF1Drop.ResetText();
            uxStrain1Drop.Items.Clear();
            uxStrain1Drop.ResetText();
            alignStrains1 = c.displayTableContents("Strains WHERE specID = " + species.Rows[uxSpecies1Drop.SelectedIndex][0].ToString());
            //POTENTIAL SOURCE OF ERROR BETWEEN TABS BECAUSE WE ARE UPDATING STRAINS
            PopulateDropDown(uxStrain1Drop, alignStrains1, 0);

        }

        private void uxStrain1Drop_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxAlignButton.Enabled = false;
            uxORF1Drop.Items.Clear();
            uxORF1Drop.ResetText();
            alignORF1 = c.displayTableContents(" OpenReadingFrames WHERE strainID = '" + alignStrains1.Rows[uxStrain1Drop.SelectedIndex][0].ToString() + "'");
            PopulateDropDown(uxORF1Drop, alignORF1, 1);
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
            ldt[1] = strains;
        }
        
        /// <summary>
        /// When the applicaton is launched, it will run this method, load method.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InterfaceV2_Load(object sender, EventArgs e)
        {
            
        }
        private void PopulateDropDown(ComboBox dd, DataTable dt, int colNum)
        {
            dd.Items.Clear();
            foreach(DataRow row in dt.Rows)
            {
                dd.Items.Add(row[colNum].ToString());
            }
        }

        /// <summary>
        /// Deletes the selected item from Proteins table.
        /// Tables affected: Proteins, StructuralProteins, NonStructuralProteins, OpenReadingFrames
        /// </summary>
        /// <returns></returns>true if delete was executed, false if not
        private bool deleteProtein()
        {
            string deleteStatement = "";
            int pID = Convert.ToInt32(followingSubContent.Rows[uxFollowingBox.SelectedIndex][0]);
            deleteStatement = "DELETE FROM StructuralProteins WHERE pID = " + pID;
            if (!c.sendNonQuery(deleteStatement))
            {
                deleteStatement = "DELETE FROM NonStructuralProteins WHERE pID = " + pID;
                if (!c.sendNonQuery(deleteStatement))
                    return false;
            }
            else
            {
                deleteStatement = "DELETE FROM NonStructuralProteins WHERE pID = " + pID;
                if (!c.sendNonQuery(deleteStatement))
                    return false;
            }
            deleteStatement = "DELETE FROM OpenReadingFrames WHERE pID = " + pID;
            if (!c.sendNonQuery(deleteStatement))
                return false;
            deleteStatement = "DELETE FROM Proteins WHERE pID = " + pID;
            if (!c.sendNonQuery(deleteStatement))
                return false;
            return true;
        }//end method

        /// <summary>
        /// Method will delete the selected item from the Publishers table and all associated tables.
        /// Tables affected: Publishers, Publisher_Publication
        /// </summary>
        /// <returns></returns>true if deleted properly, false if not
        private bool deletePublisher()
        {
            int publisherID = Convert.ToInt32(followingSubContent.Rows[uxFollowingBox.SelectedIndex][0]);
            string deleteStatement = "DELETE FROM Publisher_Publication WHERE publisherID = " + publisherID;
            if (!c.sendNonQuery(deleteStatement))
                return false;
            deleteStatement = "DELETE FROM Publishers WHERE publisherID = " + publisherID;
            if (!c.sendNonQuery(deleteStatement))
                return false;
            return true;
        }//end method

        /// <summary>
        /// Method will delete the selected item from Researchers table and all associated tables.
        /// Affected tables: Researchers, Publication_Researchers
        /// </summary>
        /// <returns></returns>
        private bool deleteResearcher()
        {
            int rID = Convert.ToInt32(followingSubContent.Rows[uxFollowingBox.SelectedIndex][0]);
            string deleteStatement = "DELETE FROM Publication_Researchers WHERE rID = " + rID;
            if (!c.sendNonQuery(deleteStatement))
                return false;
            deleteStatement = "DELETE FROM Researchers WHERE rID = " + rID;
            if (!c.sendNonQuery(deleteStatement))
                return false;
            return true;
        }//end method
    }
}
