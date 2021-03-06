﻿namespace VirusDataApplication
{
    partial class InterfaceV2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.uxSpeciesBox = new System.Windows.Forms.ListBox();
            this.uxStrainsBox = new System.Windows.Forms.ListBox();
            this.uxChoiceBox = new System.Windows.Forms.ListBox();
            this.uxFollowingBox = new System.Windows.Forms.ListBox();
            this.uxDetialsButton = new System.Windows.Forms.Button();
            this.uxOptionsDropdown = new System.Windows.Forms.ComboBox();
            this.species_lbl = new System.Windows.Forms.Label();
            this.strain_lbl = new System.Windows.Forms.Label();
            this.choice_box_lbl = new System.Windows.Forms.Label();
            this.following_box_lbl = new System.Windows.Forms.Label();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.uxTabs = new System.Windows.Forms.TabControl();
            this.uxSearchEdit = new System.Windows.Forms.TabPage();
            this.following_lbl = new System.Windows.Forms.Label();
            this.choice_lbl = new System.Windows.Forms.Label();
            this.uxInsert = new System.Windows.Forms.TabPage();
            this.uxAddORFButton = new System.Windows.Forms.Button();
            this.uxInsertORFDrop = new System.Windows.Forms.ComboBox();
            this.uxORFInsertLabel = new System.Windows.Forms.Label();
            this.uxAddStrainLabelInstruction = new System.Windows.Forms.Label();
            this.uxAddPublicationButton = new System.Windows.Forms.Button();
            this.uxAddPublicationLabel = new System.Windows.Forms.Label();
            this.uxAddStrainButton = new System.Windows.Forms.Button();
            this.uxInsertStrainDrop = new System.Windows.Forms.ComboBox();
            this.uxStrainInsertLabel = new System.Windows.Forms.Label();
            this.uxAddSpecies = new System.Windows.Forms.Button();
            this.uxInsertSpeciesDown = new System.Windows.Forms.ComboBox();
            this.uxInsertSpeciesLabel = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.uxAlignButton = new System.Windows.Forms.Button();
            this.uxORF2Drop = new System.Windows.Forms.ComboBox();
            this.uxStrain2Drop = new System.Windows.Forms.ComboBox();
            this.uxSpecies2Drop = new System.Windows.Forms.ComboBox();
            this.uxORF2Label = new System.Windows.Forms.Label();
            this.uxStrain2Label = new System.Windows.Forms.Label();
            this.uxSpecies2Label = new System.Windows.Forms.Label();
            this.uxORF1Drop = new System.Windows.Forms.ComboBox();
            this.uxStrain1Drop = new System.Windows.Forms.ComboBox();
            this.uxSpecies1Drop = new System.Windows.Forms.ComboBox();
            this.uxOrfLabel1 = new System.Windows.Forms.Label();
            this.uxStrainLabel1 = new System.Windows.Forms.Label();
            this.uxSpeciesLabel1 = new System.Windows.Forms.Label();
            this.uxConsensusTab = new System.Windows.Forms.TabPage();
            this.uxGenerateORFConsensusButton = new System.Windows.Forms.Button();
            this.uxORFConsensusLabel = new System.Windows.Forms.Label();
            this.uxConsensusORFDrop = new System.Windows.Forms.ComboBox();
            this.uxGenerateSpeciesConsensusButton = new System.Windows.Forms.Button();
            this.uxSpeciesConsensusLabel = new System.Windows.Forms.Label();
            this.uxConsensusSpeciesDrop = new System.Windows.Forms.ComboBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.uxNumOfStrainsLabel = new System.Windows.Forms.Label();
            this.uxTabs.SuspendLayout();
            this.uxSearchEdit.SuspendLayout();
            this.uxInsert.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.uxConsensusTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxSpeciesBox
            // 
            this.uxSpeciesBox.FormattingEnabled = true;
            this.uxSpeciesBox.HorizontalScrollbar = true;
            this.uxSpeciesBox.Location = new System.Drawing.Point(12, 32);
            this.uxSpeciesBox.Name = "uxSpeciesBox";
            this.uxSpeciesBox.Size = new System.Drawing.Size(130, 264);
            this.uxSpeciesBox.TabIndex = 0;
            this.uxSpeciesBox.SelectedIndexChanged += new System.EventHandler(this.uxSpeciesBox_SelectedIndexChanged);
            // 
            // uxStrainsBox
            // 
            this.uxStrainsBox.FormattingEnabled = true;
            this.uxStrainsBox.HorizontalScrollbar = true;
            this.uxStrainsBox.Location = new System.Drawing.Point(146, 32);
            this.uxStrainsBox.Name = "uxStrainsBox";
            this.uxStrainsBox.Size = new System.Drawing.Size(128, 264);
            this.uxStrainsBox.TabIndex = 1;
            this.uxStrainsBox.SelectedIndexChanged += new System.EventHandler(this.uxStrainsBox_SelectedIndexChanged);
            // 
            // uxChoiceBox
            // 
            this.uxChoiceBox.FormattingEnabled = true;
            this.uxChoiceBox.HorizontalScrollbar = true;
            this.uxChoiceBox.Location = new System.Drawing.Point(411, 33);
            this.uxChoiceBox.Name = "uxChoiceBox";
            this.uxChoiceBox.Size = new System.Drawing.Size(132, 264);
            this.uxChoiceBox.TabIndex = 2;
            this.uxChoiceBox.SelectedIndexChanged += new System.EventHandler(this.uxChoiceBox_SelectedIndexChanged);
            // 
            // uxFollowingBox
            // 
            this.uxFollowingBox.FormattingEnabled = true;
            this.uxFollowingBox.HorizontalScrollbar = true;
            this.uxFollowingBox.Location = new System.Drawing.Point(552, 33);
            this.uxFollowingBox.Name = "uxFollowingBox";
            this.uxFollowingBox.Size = new System.Drawing.Size(138, 264);
            this.uxFollowingBox.TabIndex = 3;
            // 
            // uxDetialsButton
            // 
            this.uxDetialsButton.Location = new System.Drawing.Point(12, 314);
            this.uxDetialsButton.Name = "uxDetialsButton";
            this.uxDetialsButton.Size = new System.Drawing.Size(130, 23);
            this.uxDetialsButton.TabIndex = 6;
            this.uxDetialsButton.Text = "DisplayDetails";
            this.uxDetialsButton.UseVisualStyleBackColor = true;
            this.uxDetialsButton.Click += new System.EventHandler(this.uxDetialsButton_Click);
            // 
            // uxOptionsDropdown
            // 
            this.uxOptionsDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxOptionsDropdown.Enabled = false;
            this.uxOptionsDropdown.FormattingEnabled = true;
            this.uxOptionsDropdown.Items.AddRange(new object[] {
            "OpenReadingFrames",
            "Publications - Publishers",
            "Publications - Researchers"});
            this.uxOptionsDropdown.Location = new System.Drawing.Point(280, 32);
            this.uxOptionsDropdown.Name = "uxOptionsDropdown";
            this.uxOptionsDropdown.Size = new System.Drawing.Size(125, 21);
            this.uxOptionsDropdown.TabIndex = 7;
            this.uxOptionsDropdown.SelectedIndexChanged += new System.EventHandler(this.uxOptionsDropdown_SelectedIndexChanged);
            // 
            // species_lbl
            // 
            this.species_lbl.AutoSize = true;
            this.species_lbl.Location = new System.Drawing.Point(9, 16);
            this.species_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.species_lbl.Name = "species_lbl";
            this.species_lbl.Size = new System.Drawing.Size(45, 13);
            this.species_lbl.TabIndex = 8;
            this.species_lbl.Text = "Species";
            // 
            // strain_lbl
            // 
            this.strain_lbl.AutoSize = true;
            this.strain_lbl.Location = new System.Drawing.Point(146, 16);
            this.strain_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.strain_lbl.Name = "strain_lbl";
            this.strain_lbl.Size = new System.Drawing.Size(39, 13);
            this.strain_lbl.TabIndex = 9;
            this.strain_lbl.Text = "Strains";
            // 
            // choice_box_lbl
            // 
            this.choice_box_lbl.AutoSize = true;
            this.choice_box_lbl.Location = new System.Drawing.Point(469, 133);
            this.choice_box_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.choice_box_lbl.Name = "choice_box_lbl";
            this.choice_box_lbl.Size = new System.Drawing.Size(0, 13);
            this.choice_box_lbl.TabIndex = 10;
            // 
            // following_box_lbl
            // 
            this.following_box_lbl.AutoSize = true;
            this.following_box_lbl.Location = new System.Drawing.Point(595, 95);
            this.following_box_lbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.following_box_lbl.Name = "following_box_lbl";
            this.following_box_lbl.Size = new System.Drawing.Size(0, 13);
            this.following_box_lbl.TabIndex = 11;
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(411, 299);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(2);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(50, 24);
            this.edit_btn.TabIndex = 12;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(552, 299);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(50, 24);
            this.delete_btn.TabIndex = 13;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // uxTabs
            // 
            this.uxTabs.Controls.Add(this.uxSearchEdit);
            this.uxTabs.Controls.Add(this.uxInsert);
            this.uxTabs.Controls.Add(this.tabPage2);
            this.uxTabs.Controls.Add(this.uxConsensusTab);
            this.uxTabs.Location = new System.Drawing.Point(1, 1);
            this.uxTabs.Margin = new System.Windows.Forms.Padding(2);
            this.uxTabs.Name = "uxTabs";
            this.uxTabs.SelectedIndex = 0;
            this.uxTabs.Size = new System.Drawing.Size(710, 391);
            this.uxTabs.TabIndex = 14;
            // 
            // uxSearchEdit
            // 
            this.uxSearchEdit.Controls.Add(this.uxNumOfStrainsLabel);
            this.uxSearchEdit.Controls.Add(this.following_lbl);
            this.uxSearchEdit.Controls.Add(this.choice_lbl);
            this.uxSearchEdit.Controls.Add(this.species_lbl);
            this.uxSearchEdit.Controls.Add(this.edit_btn);
            this.uxSearchEdit.Controls.Add(this.delete_btn);
            this.uxSearchEdit.Controls.Add(this.uxFollowingBox);
            this.uxSearchEdit.Controls.Add(this.strain_lbl);
            this.uxSearchEdit.Controls.Add(this.uxChoiceBox);
            this.uxSearchEdit.Controls.Add(this.uxStrainsBox);
            this.uxSearchEdit.Controls.Add(this.uxOptionsDropdown);
            this.uxSearchEdit.Controls.Add(this.uxDetialsButton);
            this.uxSearchEdit.Controls.Add(this.uxSpeciesBox);
            this.uxSearchEdit.Location = new System.Drawing.Point(4, 22);
            this.uxSearchEdit.Margin = new System.Windows.Forms.Padding(2);
            this.uxSearchEdit.Name = "uxSearchEdit";
            this.uxSearchEdit.Padding = new System.Windows.Forms.Padding(2);
            this.uxSearchEdit.Size = new System.Drawing.Size(702, 365);
            this.uxSearchEdit.TabIndex = 0;
            this.uxSearchEdit.Text = "Search/Edit";
            this.uxSearchEdit.UseVisualStyleBackColor = true;
            // 
            // following_lbl
            // 
            this.following_lbl.AutoSize = true;
            this.following_lbl.Location = new System.Drawing.Point(552, 16);
            this.following_lbl.Name = "following_lbl";
            this.following_lbl.Size = new System.Drawing.Size(35, 13);
            this.following_lbl.TabIndex = 15;
            this.following_lbl.Text = "label1";
            // 
            // choice_lbl
            // 
            this.choice_lbl.AutoSize = true;
            this.choice_lbl.Location = new System.Drawing.Point(411, 16);
            this.choice_lbl.Name = "choice_lbl";
            this.choice_lbl.Size = new System.Drawing.Size(35, 13);
            this.choice_lbl.TabIndex = 14;
            this.choice_lbl.Text = "label1";
            // 
            // uxInsert
            // 
            this.uxInsert.Controls.Add(this.uxAddORFButton);
            this.uxInsert.Controls.Add(this.uxInsertORFDrop);
            this.uxInsert.Controls.Add(this.uxORFInsertLabel);
            this.uxInsert.Controls.Add(this.uxAddStrainLabelInstruction);
            this.uxInsert.Controls.Add(this.uxAddPublicationButton);
            this.uxInsert.Controls.Add(this.uxAddPublicationLabel);
            this.uxInsert.Controls.Add(this.uxAddStrainButton);
            this.uxInsert.Controls.Add(this.uxInsertStrainDrop);
            this.uxInsert.Controls.Add(this.uxStrainInsertLabel);
            this.uxInsert.Controls.Add(this.uxAddSpecies);
            this.uxInsert.Controls.Add(this.uxInsertSpeciesDown);
            this.uxInsert.Controls.Add(this.uxInsertSpeciesLabel);
            this.uxInsert.Location = new System.Drawing.Point(4, 22);
            this.uxInsert.Name = "uxInsert";
            this.uxInsert.Padding = new System.Windows.Forms.Padding(3);
            this.uxInsert.Size = new System.Drawing.Size(702, 365);
            this.uxInsert.TabIndex = 2;
            this.uxInsert.Text = "Insert";
            this.uxInsert.UseVisualStyleBackColor = true;
            // 
            // uxAddORFButton
            // 
            this.uxAddORFButton.Enabled = false;
            this.uxAddORFButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddORFButton.Location = new System.Drawing.Point(348, 99);
            this.uxAddORFButton.Margin = new System.Windows.Forms.Padding(2);
            this.uxAddORFButton.Name = "uxAddORFButton";
            this.uxAddORFButton.Size = new System.Drawing.Size(159, 29);
            this.uxAddORFButton.TabIndex = 12;
            this.uxAddORFButton.Text = "Add ORFS/Proteins";
            this.uxAddORFButton.UseVisualStyleBackColor = true;
            this.uxAddORFButton.Click += new System.EventHandler(this.uxAddORFButton_Click);
            // 
            // uxInsertORFDrop
            // 
            this.uxInsertORFDrop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uxInsertORFDrop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.uxInsertORFDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInsertORFDrop.FormattingEnabled = true;
            this.uxInsertORFDrop.Location = new System.Drawing.Point(109, 100);
            this.uxInsertORFDrop.Margin = new System.Windows.Forms.Padding(2);
            this.uxInsertORFDrop.Name = "uxInsertORFDrop";
            this.uxInsertORFDrop.Size = new System.Drawing.Size(235, 28);
            this.uxInsertORFDrop.TabIndex = 11;
            this.uxInsertORFDrop.TextChanged += new System.EventHandler(this.EnableInsertORFButton);
            // 
            // uxORFInsertLabel
            // 
            this.uxORFInsertLabel.AutoSize = true;
            this.uxORFInsertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxORFInsertLabel.Location = new System.Drawing.Point(6, 103);
            this.uxORFInsertLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxORFInsertLabel.Name = "uxORFInsertLabel";
            this.uxORFInsertLabel.Size = new System.Drawing.Size(47, 20);
            this.uxORFInsertLabel.TabIndex = 10;
            this.uxORFInsertLabel.Text = "ORF:";
            // 
            // uxAddStrainLabelInstruction
            // 
            this.uxAddStrainLabelInstruction.AutoSize = true;
            this.uxAddStrainLabelInstruction.Location = new System.Drawing.Point(499, 65);
            this.uxAddStrainLabelInstruction.Name = "uxAddStrainLabelInstruction";
            this.uxAddStrainLabelInstruction.Size = new System.Drawing.Size(203, 13);
            this.uxAddStrainLabelInstruction.TabIndex = 9;
            this.uxAddStrainLabelInstruction.Text = "Use this is the strain is not in a publication";
            // 
            // uxAddPublicationButton
            // 
            this.uxAddPublicationButton.Enabled = false;
            this.uxAddPublicationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddPublicationButton.Location = new System.Drawing.Point(348, 142);
            this.uxAddPublicationButton.Margin = new System.Windows.Forms.Padding(2);
            this.uxAddPublicationButton.Name = "uxAddPublicationButton";
            this.uxAddPublicationButton.Size = new System.Drawing.Size(159, 29);
            this.uxAddPublicationButton.TabIndex = 8;
            this.uxAddPublicationButton.Text = "Add Publication";
            this.uxAddPublicationButton.UseVisualStyleBackColor = true;
            this.uxAddPublicationButton.Click += new System.EventHandler(this.uxAddPublicationButton_Click);
            // 
            // uxAddPublicationLabel
            // 
            this.uxAddPublicationLabel.AutoSize = true;
            this.uxAddPublicationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddPublicationLabel.Location = new System.Drawing.Point(6, 146);
            this.uxAddPublicationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxAddPublicationLabel.Name = "uxAddPublicationLabel";
            this.uxAddPublicationLabel.Size = new System.Drawing.Size(90, 20);
            this.uxAddPublicationLabel.TabIndex = 6;
            this.uxAddPublicationLabel.Text = "Publication:";
            // 
            // uxAddStrainButton
            // 
            this.uxAddStrainButton.Enabled = false;
            this.uxAddStrainButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddStrainButton.Location = new System.Drawing.Point(348, 57);
            this.uxAddStrainButton.Margin = new System.Windows.Forms.Padding(2);
            this.uxAddStrainButton.Name = "uxAddStrainButton";
            this.uxAddStrainButton.Size = new System.Drawing.Size(150, 29);
            this.uxAddStrainButton.TabIndex = 5;
            this.uxAddStrainButton.Text = "Add Strain";
            this.uxAddStrainButton.UseVisualStyleBackColor = true;
            this.uxAddStrainButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // uxInsertStrainDrop
            // 
            this.uxInsertStrainDrop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uxInsertStrainDrop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.uxInsertStrainDrop.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxInsertStrainDrop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInsertStrainDrop.FormattingEnabled = true;
            this.uxInsertStrainDrop.Location = new System.Drawing.Point(109, 57);
            this.uxInsertStrainDrop.Margin = new System.Windows.Forms.Padding(2);
            this.uxInsertStrainDrop.Name = "uxInsertStrainDrop";
            this.uxInsertStrainDrop.Size = new System.Drawing.Size(235, 28);
            this.uxInsertStrainDrop.TabIndex = 4;
            this.uxInsertStrainDrop.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // uxStrainInsertLabel
            // 
            this.uxStrainInsertLabel.AutoSize = true;
            this.uxStrainInsertLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStrainInsertLabel.Location = new System.Drawing.Point(6, 60);
            this.uxStrainInsertLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.uxStrainInsertLabel.Name = "uxStrainInsertLabel";
            this.uxStrainInsertLabel.Size = new System.Drawing.Size(59, 20);
            this.uxStrainInsertLabel.TabIndex = 3;
            this.uxStrainInsertLabel.Text = "Strain: ";
            // 
            // uxAddSpecies
            // 
            this.uxAddSpecies.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAddSpecies.Location = new System.Drawing.Point(348, 15);
            this.uxAddSpecies.Margin = new System.Windows.Forms.Padding(2);
            this.uxAddSpecies.Name = "uxAddSpecies";
            this.uxAddSpecies.Size = new System.Drawing.Size(159, 29);
            this.uxAddSpecies.TabIndex = 2;
            this.uxAddSpecies.Text = "Add Species";
            this.uxAddSpecies.UseVisualStyleBackColor = true;
            this.uxAddSpecies.Click += new System.EventHandler(this.uxAddSpecies_Click);
            // 
            // uxInsertSpeciesDown
            // 
            this.uxInsertSpeciesDown.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uxInsertSpeciesDown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.uxInsertSpeciesDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxInsertSpeciesDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInsertSpeciesDown.FormattingEnabled = true;
            this.uxInsertSpeciesDown.Location = new System.Drawing.Point(109, 16);
            this.uxInsertSpeciesDown.Margin = new System.Windows.Forms.Padding(2);
            this.uxInsertSpeciesDown.Name = "uxInsertSpeciesDown";
            this.uxInsertSpeciesDown.Size = new System.Drawing.Size(235, 28);
            this.uxInsertSpeciesDown.TabIndex = 1;
            this.uxInsertSpeciesDown.SelectedIndexChanged += new System.EventHandler(this.uxInsertSpeciesDown_SelectedIndexChanged);
            // 
            // uxInsertSpeciesLabel
            // 
            this.uxInsertSpeciesLabel.AutoSize = true;
            this.uxInsertSpeciesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxInsertSpeciesLabel.Location = new System.Drawing.Point(5, 19);
            this.uxInsertSpeciesLabel.Name = "uxInsertSpeciesLabel";
            this.uxInsertSpeciesLabel.Size = new System.Drawing.Size(74, 20);
            this.uxInsertSpeciesLabel.TabIndex = 0;
            this.uxInsertSpeciesLabel.Text = "Species: ";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.progressBar1);
            this.tabPage2.Controls.Add(this.uxAlignButton);
            this.tabPage2.Controls.Add(this.uxORF2Drop);
            this.tabPage2.Controls.Add(this.uxStrain2Drop);
            this.tabPage2.Controls.Add(this.uxSpecies2Drop);
            this.tabPage2.Controls.Add(this.uxORF2Label);
            this.tabPage2.Controls.Add(this.uxStrain2Label);
            this.tabPage2.Controls.Add(this.uxSpecies2Label);
            this.tabPage2.Controls.Add(this.uxORF1Drop);
            this.tabPage2.Controls.Add(this.uxStrain1Drop);
            this.tabPage2.Controls.Add(this.uxSpecies1Drop);
            this.tabPage2.Controls.Add(this.uxOrfLabel1);
            this.tabPage2.Controls.Add(this.uxStrainLabel1);
            this.tabPage2.Controls.Add(this.uxSpeciesLabel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(702, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Align";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(74, 295);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(543, 23);
            this.progressBar1.TabIndex = 15;
            // 
            // uxAlignButton
            // 
            this.uxAlignButton.Enabled = false;
            this.uxAlignButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxAlignButton.Location = new System.Drawing.Point(294, 230);
            this.uxAlignButton.Name = "uxAlignButton";
            this.uxAlignButton.Size = new System.Drawing.Size(101, 33);
            this.uxAlignButton.TabIndex = 7;
            this.uxAlignButton.Text = "Align";
            this.uxAlignButton.UseVisualStyleBackColor = true;
            this.uxAlignButton.Click += new System.EventHandler(this.uxAlignButton_Click);
            // 
            // uxORF2Drop
            // 
            this.uxORF2Drop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uxORF2Drop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.uxORF2Drop.FormattingEnabled = true;
            this.uxORF2Drop.Location = new System.Drawing.Point(456, 149);
            this.uxORF2Drop.Name = "uxORF2Drop";
            this.uxORF2Drop.Size = new System.Drawing.Size(161, 21);
            this.uxORF2Drop.TabIndex = 6;
            this.uxORF2Drop.SelectedIndexChanged += new System.EventHandler(this.uxORF2Drop_SelectedIndexChanged);
            // 
            // uxStrain2Drop
            // 
            this.uxStrain2Drop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uxStrain2Drop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.uxStrain2Drop.FormattingEnabled = true;
            this.uxStrain2Drop.Location = new System.Drawing.Point(456, 91);
            this.uxStrain2Drop.Name = "uxStrain2Drop";
            this.uxStrain2Drop.Size = new System.Drawing.Size(161, 21);
            this.uxStrain2Drop.TabIndex = 4;
            this.uxStrain2Drop.SelectedIndexChanged += new System.EventHandler(this.uxStrain2Drop_SelectedIndexChanged);
            // 
            // uxSpecies2Drop
            // 
            this.uxSpecies2Drop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uxSpecies2Drop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.uxSpecies2Drop.FormattingEnabled = true;
            this.uxSpecies2Drop.Location = new System.Drawing.Point(456, 39);
            this.uxSpecies2Drop.Name = "uxSpecies2Drop";
            this.uxSpecies2Drop.Size = new System.Drawing.Size(161, 21);
            this.uxSpecies2Drop.TabIndex = 2;
            this.uxSpecies2Drop.SelectedIndexChanged += new System.EventHandler(this.uxSpecies2Drop_SelectedIndexChanged);
            // 
            // uxORF2Label
            // 
            this.uxORF2Label.AutoSize = true;
            this.uxORF2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxORF2Label.Location = new System.Drawing.Point(394, 147);
            this.uxORF2Label.Name = "uxORF2Label";
            this.uxORF2Label.Size = new System.Drawing.Size(56, 20);
            this.uxORF2Label.TabIndex = 8;
            this.uxORF2Label.Text = "ORF2:";
            // 
            // uxStrain2Label
            // 
            this.uxStrain2Label.AutoSize = true;
            this.uxStrain2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStrain2Label.Location = new System.Drawing.Point(386, 89);
            this.uxStrain2Label.Name = "uxStrain2Label";
            this.uxStrain2Label.Size = new System.Drawing.Size(64, 20);
            this.uxStrain2Label.TabIndex = 7;
            this.uxStrain2Label.Text = "Strain2:";
            // 
            // uxSpecies2Label
            // 
            this.uxSpecies2Label.AutoSize = true;
            this.uxSpecies2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSpecies2Label.Location = new System.Drawing.Point(371, 37);
            this.uxSpecies2Label.Name = "uxSpecies2Label";
            this.uxSpecies2Label.Size = new System.Drawing.Size(79, 20);
            this.uxSpecies2Label.TabIndex = 6;
            this.uxSpecies2Label.Text = "Species2:";
            // 
            // uxORF1Drop
            // 
            this.uxORF1Drop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uxORF1Drop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.uxORF1Drop.FormattingEnabled = true;
            this.uxORF1Drop.Location = new System.Drawing.Point(156, 146);
            this.uxORF1Drop.Name = "uxORF1Drop";
            this.uxORF1Drop.Size = new System.Drawing.Size(161, 21);
            this.uxORF1Drop.TabIndex = 5;
            this.uxORF1Drop.SelectedIndexChanged += new System.EventHandler(this.uxORF1Drop_SelectedIndexChanged);
            // 
            // uxStrain1Drop
            // 
            this.uxStrain1Drop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uxStrain1Drop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.uxStrain1Drop.FormattingEnabled = true;
            this.uxStrain1Drop.Location = new System.Drawing.Point(156, 91);
            this.uxStrain1Drop.Name = "uxStrain1Drop";
            this.uxStrain1Drop.Size = new System.Drawing.Size(161, 21);
            this.uxStrain1Drop.TabIndex = 3;
            this.uxStrain1Drop.SelectedIndexChanged += new System.EventHandler(this.uxStrain1Drop_SelectedIndexChanged);
            // 
            // uxSpecies1Drop
            // 
            this.uxSpecies1Drop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uxSpecies1Drop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.uxSpecies1Drop.FormattingEnabled = true;
            this.uxSpecies1Drop.Location = new System.Drawing.Point(156, 35);
            this.uxSpecies1Drop.Name = "uxSpecies1Drop";
            this.uxSpecies1Drop.Size = new System.Drawing.Size(161, 21);
            this.uxSpecies1Drop.TabIndex = 1;
            this.uxSpecies1Drop.SelectedIndexChanged += new System.EventHandler(this.uxSpecies1Drop_SelectedIndexChanged);
            // 
            // uxOrfLabel1
            // 
            this.uxOrfLabel1.AutoSize = true;
            this.uxOrfLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxOrfLabel1.Location = new System.Drawing.Point(93, 147);
            this.uxOrfLabel1.Name = "uxOrfLabel1";
            this.uxOrfLabel1.Size = new System.Drawing.Size(56, 20);
            this.uxOrfLabel1.TabIndex = 2;
            this.uxOrfLabel1.Text = "ORF1:";
            // 
            // uxStrainLabel1
            // 
            this.uxStrainLabel1.AutoSize = true;
            this.uxStrainLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxStrainLabel1.Location = new System.Drawing.Point(85, 92);
            this.uxStrainLabel1.Name = "uxStrainLabel1";
            this.uxStrainLabel1.Size = new System.Drawing.Size(64, 20);
            this.uxStrainLabel1.TabIndex = 1;
            this.uxStrainLabel1.Text = "Strain1:";
            // 
            // uxSpeciesLabel1
            // 
            this.uxSpeciesLabel1.AutoSize = true;
            this.uxSpeciesLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSpeciesLabel1.Location = new System.Drawing.Point(70, 37);
            this.uxSpeciesLabel1.Name = "uxSpeciesLabel1";
            this.uxSpeciesLabel1.Size = new System.Drawing.Size(79, 20);
            this.uxSpeciesLabel1.TabIndex = 0;
            this.uxSpeciesLabel1.Text = "Species1:";
            this.uxSpeciesLabel1.Click += new System.EventHandler(this.label1_Click);
            // 
            // uxConsensusTab
            // 
            this.uxConsensusTab.Controls.Add(this.uxGenerateORFConsensusButton);
            this.uxConsensusTab.Controls.Add(this.uxORFConsensusLabel);
            this.uxConsensusTab.Controls.Add(this.uxConsensusORFDrop);
            this.uxConsensusTab.Controls.Add(this.uxGenerateSpeciesConsensusButton);
            this.uxConsensusTab.Controls.Add(this.uxSpeciesConsensusLabel);
            this.uxConsensusTab.Controls.Add(this.uxConsensusSpeciesDrop);
            this.uxConsensusTab.Location = new System.Drawing.Point(4, 22);
            this.uxConsensusTab.Name = "uxConsensusTab";
            this.uxConsensusTab.Padding = new System.Windows.Forms.Padding(3);
            this.uxConsensusTab.Size = new System.Drawing.Size(702, 365);
            this.uxConsensusTab.TabIndex = 3;
            this.uxConsensusTab.Text = "Consensus";
            this.uxConsensusTab.UseVisualStyleBackColor = true;
            // 
            // uxGenerateORFConsensusButton
            // 
            this.uxGenerateORFConsensusButton.Enabled = false;
            this.uxGenerateORFConsensusButton.Location = new System.Drawing.Point(467, 145);
            this.uxGenerateORFConsensusButton.Name = "uxGenerateORFConsensusButton";
            this.uxGenerateORFConsensusButton.Size = new System.Drawing.Size(116, 35);
            this.uxGenerateORFConsensusButton.TabIndex = 5;
            this.uxGenerateORFConsensusButton.Text = "ORF Consensus";
            this.uxGenerateORFConsensusButton.UseVisualStyleBackColor = true;
            this.uxGenerateORFConsensusButton.Click += new System.EventHandler(this.uxGenerateORFConsensusButton_Click);
            // 
            // uxORFConsensusLabel
            // 
            this.uxORFConsensusLabel.AutoSize = true;
            this.uxORFConsensusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxORFConsensusLabel.Location = new System.Drawing.Point(415, 37);
            this.uxORFConsensusLabel.Name = "uxORFConsensusLabel";
            this.uxORFConsensusLabel.Size = new System.Drawing.Size(51, 20);
            this.uxORFConsensusLabel.TabIndex = 4;
            this.uxORFConsensusLabel.Text = "ORF: ";
            // 
            // uxConsensusORFDrop
            // 
            this.uxConsensusORFDrop.Enabled = false;
            this.uxConsensusORFDrop.FormattingEnabled = true;
            this.uxConsensusORFDrop.Location = new System.Drawing.Point(472, 39);
            this.uxConsensusORFDrop.Name = "uxConsensusORFDrop";
            this.uxConsensusORFDrop.Size = new System.Drawing.Size(121, 21);
            this.uxConsensusORFDrop.TabIndex = 3;
            this.uxConsensusORFDrop.SelectedIndexChanged += new System.EventHandler(this.uxConsensusORFDrop_SelectedIndexChanged);
            // 
            // uxGenerateSpeciesConsensusButton
            // 
            this.uxGenerateSpeciesConsensusButton.Enabled = false;
            this.uxGenerateSpeciesConsensusButton.Location = new System.Drawing.Point(132, 145);
            this.uxGenerateSpeciesConsensusButton.Name = "uxGenerateSpeciesConsensusButton";
            this.uxGenerateSpeciesConsensusButton.Size = new System.Drawing.Size(116, 35);
            this.uxGenerateSpeciesConsensusButton.TabIndex = 2;
            this.uxGenerateSpeciesConsensusButton.Text = "Species Consensus";
            this.uxGenerateSpeciesConsensusButton.UseVisualStyleBackColor = true;
            this.uxGenerateSpeciesConsensusButton.Click += new System.EventHandler(this.uxGenerateSpeciesConsensusButton_Click);
            // 
            // uxSpeciesConsensusLabel
            // 
            this.uxSpeciesConsensusLabel.AutoSize = true;
            this.uxSpeciesConsensusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.uxSpeciesConsensusLabel.Location = new System.Drawing.Point(56, 37);
            this.uxSpeciesConsensusLabel.Name = "uxSpeciesConsensusLabel";
            this.uxSpeciesConsensusLabel.Size = new System.Drawing.Size(70, 20);
            this.uxSpeciesConsensusLabel.TabIndex = 1;
            this.uxSpeciesConsensusLabel.Text = "Species:";
            // 
            // uxConsensusSpeciesDrop
            // 
            this.uxConsensusSpeciesDrop.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.uxConsensusSpeciesDrop.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.uxConsensusSpeciesDrop.FormattingEnabled = true;
            this.uxConsensusSpeciesDrop.Location = new System.Drawing.Point(132, 39);
            this.uxConsensusSpeciesDrop.Name = "uxConsensusSpeciesDrop";
            this.uxConsensusSpeciesDrop.Size = new System.Drawing.Size(121, 21);
            this.uxConsensusSpeciesDrop.TabIndex = 0;
            this.uxConsensusSpeciesDrop.SelectedIndexChanged += new System.EventHandler(this.uxConsensusSpeciesDrop_SelectedIndexChanged);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.WorkerReportsProgress = true;
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // uxNumOfStrainsLabel
            // 
            this.uxNumOfStrainsLabel.AutoSize = true;
            this.uxNumOfStrainsLabel.Location = new System.Drawing.Point(190, 16);
            this.uxNumOfStrainsLabel.Name = "uxNumOfStrainsLabel";
            this.uxNumOfStrainsLabel.Size = new System.Drawing.Size(0, 13);
            this.uxNumOfStrainsLabel.TabIndex = 16;
            // 
            // InterfaceV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 372);
            this.Controls.Add(this.uxTabs);
            this.Controls.Add(this.following_box_lbl);
            this.Controls.Add(this.choice_box_lbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "InterfaceV2";
            this.Text = "InterfaceV2";
            this.Load += new System.EventHandler(this.InterfaceV2_Load);
            this.uxTabs.ResumeLayout(false);
            this.uxSearchEdit.ResumeLayout(false);
            this.uxSearchEdit.PerformLayout();
            this.uxInsert.ResumeLayout(false);
            this.uxInsert.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.uxConsensusTab.ResumeLayout(false);
            this.uxConsensusTab.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uxSpeciesBox;
        private System.Windows.Forms.ListBox uxStrainsBox;
        private System.Windows.Forms.ListBox uxChoiceBox;
        private System.Windows.Forms.ListBox uxFollowingBox;
        private System.Windows.Forms.Button uxDetialsButton;
        private System.Windows.Forms.ComboBox uxOptionsDropdown;
        private System.Windows.Forms.Label species_lbl;
        private System.Windows.Forms.Label strain_lbl;
        private System.Windows.Forms.Label choice_box_lbl;
        private System.Windows.Forms.Label following_box_lbl;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.TabControl uxTabs;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage uxSearchEdit;
        private System.Windows.Forms.Label uxSpeciesLabel1;
        private System.Windows.Forms.Button uxAlignButton;
        private System.Windows.Forms.ComboBox uxORF2Drop;
        private System.Windows.Forms.ComboBox uxStrain2Drop;
        private System.Windows.Forms.ComboBox uxSpecies2Drop;
        private System.Windows.Forms.Label uxORF2Label;
        private System.Windows.Forms.Label uxStrain2Label;
        private System.Windows.Forms.Label uxSpecies2Label;
        private System.Windows.Forms.ComboBox uxORF1Drop;
        private System.Windows.Forms.ComboBox uxStrain1Drop;
        private System.Windows.Forms.ComboBox uxSpecies1Drop;
        private System.Windows.Forms.Label uxOrfLabel1;
        private System.Windows.Forms.Label uxStrainLabel1;
        private System.Windows.Forms.Label choice_lbl;
        private System.Windows.Forms.Label following_lbl;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TabPage uxInsert;
        private System.Windows.Forms.ComboBox uxInsertSpeciesDown;
        private System.Windows.Forms.Label uxInsertSpeciesLabel;
        private System.Windows.Forms.Button uxAddSpecies;
        private System.Windows.Forms.Button uxAddStrainButton;
        private System.Windows.Forms.ComboBox uxInsertStrainDrop;
        private System.Windows.Forms.Label uxStrainInsertLabel;
        private System.Windows.Forms.Button uxAddPublicationButton;
        private System.Windows.Forms.Label uxAddPublicationLabel;
        private System.Windows.Forms.TabPage uxConsensusTab;
        private System.Windows.Forms.Button uxGenerateORFConsensusButton;
        private System.Windows.Forms.Label uxORFConsensusLabel;
        private System.Windows.Forms.ComboBox uxConsensusORFDrop;
        private System.Windows.Forms.Button uxGenerateSpeciesConsensusButton;
        private System.Windows.Forms.Label uxSpeciesConsensusLabel;
        private System.Windows.Forms.ComboBox uxConsensusSpeciesDrop;
        private System.Windows.Forms.Label uxAddStrainLabelInstruction;
        private System.Windows.Forms.Button uxAddORFButton;
        private System.Windows.Forms.ComboBox uxInsertORFDrop;
        private System.Windows.Forms.Label uxORFInsertLabel;
        private System.Windows.Forms.Label uxNumOfStrainsLabel;
    }
}