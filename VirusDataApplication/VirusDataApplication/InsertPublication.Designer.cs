namespace VirusDataApplication
{
    partial class InsertPublication
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
            this.uxTitleLabel = new System.Windows.Forms.Label();
            this.uxTitle = new System.Windows.Forms.TextBox();
            this.uxPublisherLabel = new System.Windows.Forms.Label();
            this.uxPublisherDrop = new System.Windows.Forms.ComboBox();
            this.uxYearLabel = new System.Windows.Forms.Label();
            this.uxYear = new System.Windows.Forms.TextBox();
            this.uxResearchers = new System.Windows.Forms.ListView();
            this.uxStrains = new System.Windows.Forms.ListView();
            this.uxAddPublicationButton = new System.Windows.Forms.Button();
            this.uxAddResearcherButton = new System.Windows.Forms.Button();
            this.uxAddStrainButton = new System.Windows.Forms.Button();
            this.uxAddPublisherButton = new System.Windows.Forms.Button();
            this.uxPublishers = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // uxTitleLabel
            // 
            this.uxTitleLabel.AutoSize = true;
            this.uxTitleLabel.Location = new System.Drawing.Point(62, 30);
            this.uxTitleLabel.Name = "uxTitleLabel";
            this.uxTitleLabel.Size = new System.Drawing.Size(33, 13);
            this.uxTitleLabel.TabIndex = 0;
            this.uxTitleLabel.Text = "Title: ";
            // 
            // uxTitle
            // 
            this.uxTitle.Location = new System.Drawing.Point(121, 27);
            this.uxTitle.Name = "uxTitle";
            this.uxTitle.Size = new System.Drawing.Size(179, 20);
            this.uxTitle.TabIndex = 1;
            this.uxTitle.TextChanged += new System.EventHandler(this.ButtonEnable);
            // 
            // uxPublisherLabel
            // 
            this.uxPublisherLabel.AutoSize = true;
            this.uxPublisherLabel.Location = new System.Drawing.Point(63, 107);
            this.uxPublisherLabel.Name = "uxPublisherLabel";
            this.uxPublisherLabel.Size = new System.Drawing.Size(53, 13);
            this.uxPublisherLabel.TabIndex = 2;
            this.uxPublisherLabel.Text = "Publisher:";
            // 
            // uxPublisherDrop
            // 
            this.uxPublisherDrop.FormattingEnabled = true;
            this.uxPublisherDrop.Location = new System.Drawing.Point(121, 104);
            this.uxPublisherDrop.Name = "uxPublisherDrop";
            this.uxPublisherDrop.Size = new System.Drawing.Size(179, 21);
            this.uxPublisherDrop.TabIndex = 3;
            this.uxPublisherDrop.SelectedIndexChanged += new System.EventHandler(this.uxPublisherDrop_SelectedIndexChanged);
            // 
            // uxYearLabel
            // 
            this.uxYearLabel.AutoSize = true;
            this.uxYearLabel.Location = new System.Drawing.Point(63, 66);
            this.uxYearLabel.Name = "uxYearLabel";
            this.uxYearLabel.Size = new System.Drawing.Size(32, 13);
            this.uxYearLabel.TabIndex = 4;
            this.uxYearLabel.Text = "Year:";
            // 
            // uxYear
            // 
            this.uxYear.Location = new System.Drawing.Point(121, 63);
            this.uxYear.Name = "uxYear";
            this.uxYear.Size = new System.Drawing.Size(179, 20);
            this.uxYear.TabIndex = 5;
            this.uxYear.TextChanged += new System.EventHandler(this.ButtonEnable);
            // 
            // uxResearchers
            // 
            this.uxResearchers.Location = new System.Drawing.Point(12, 175);
            this.uxResearchers.Name = "uxResearchers";
            this.uxResearchers.Size = new System.Drawing.Size(128, 142);
            this.uxResearchers.TabIndex = 6;
            this.uxResearchers.UseCompatibleStateImageBehavior = false;
            this.uxResearchers.View = System.Windows.Forms.View.List;
            // 
            // uxStrains
            // 
            this.uxStrains.Location = new System.Drawing.Point(280, 175);
            this.uxStrains.Name = "uxStrains";
            this.uxStrains.Size = new System.Drawing.Size(128, 142);
            this.uxStrains.TabIndex = 7;
            this.uxStrains.UseCompatibleStateImageBehavior = false;
            this.uxStrains.View = System.Windows.Forms.View.List;
            // 
            // uxAddPublicationButton
            // 
            this.uxAddPublicationButton.Enabled = false;
            this.uxAddPublicationButton.Location = new System.Drawing.Point(146, 328);
            this.uxAddPublicationButton.Name = "uxAddPublicationButton";
            this.uxAddPublicationButton.Size = new System.Drawing.Size(128, 23);
            this.uxAddPublicationButton.TabIndex = 8;
            this.uxAddPublicationButton.Text = "Add Publication";
            this.uxAddPublicationButton.UseVisualStyleBackColor = true;
            this.uxAddPublicationButton.Click += new System.EventHandler(this.uxAddPublicationButton_Click);
            // 
            // uxAddResearcherButton
            // 
            this.uxAddResearcherButton.Location = new System.Drawing.Point(12, 146);
            this.uxAddResearcherButton.Name = "uxAddResearcherButton";
            this.uxAddResearcherButton.Size = new System.Drawing.Size(128, 23);
            this.uxAddResearcherButton.TabIndex = 9;
            this.uxAddResearcherButton.Text = "Add Researcher";
            this.uxAddResearcherButton.UseVisualStyleBackColor = true;
            this.uxAddResearcherButton.Click += new System.EventHandler(this.uxAddResearcherButton_Click);
            // 
            // uxAddStrainButton
            // 
            this.uxAddStrainButton.Location = new System.Drawing.Point(280, 146);
            this.uxAddStrainButton.Name = "uxAddStrainButton";
            this.uxAddStrainButton.Size = new System.Drawing.Size(128, 23);
            this.uxAddStrainButton.TabIndex = 10;
            this.uxAddStrainButton.Text = "Add Strain";
            this.uxAddStrainButton.UseVisualStyleBackColor = true;
            this.uxAddStrainButton.Click += new System.EventHandler(this.uxAddStrainButton_Click);
            // 
            // uxAddPublisherButton
            // 
            this.uxAddPublisherButton.Location = new System.Drawing.Point(146, 146);
            this.uxAddPublisherButton.Name = "uxAddPublisherButton";
            this.uxAddPublisherButton.Size = new System.Drawing.Size(128, 23);
            this.uxAddPublisherButton.TabIndex = 13;
            this.uxAddPublisherButton.Text = "Add Publisher";
            this.uxAddPublisherButton.UseVisualStyleBackColor = true;
            this.uxAddPublisherButton.Click += new System.EventHandler(this.uxAddPublisherButton_Click);
            // 
            // uxPublishers
            // 
            this.uxPublishers.Location = new System.Drawing.Point(146, 175);
            this.uxPublishers.Name = "uxPublishers";
            this.uxPublishers.Size = new System.Drawing.Size(128, 142);
            this.uxPublishers.TabIndex = 12;
            this.uxPublishers.UseCompatibleStateImageBehavior = false;
            this.uxPublishers.View = System.Windows.Forms.View.List;
            // 
            // InsertPublication
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 363);
            this.Controls.Add(this.uxAddPublisherButton);
            this.Controls.Add(this.uxPublishers);
            this.Controls.Add(this.uxAddStrainButton);
            this.Controls.Add(this.uxAddResearcherButton);
            this.Controls.Add(this.uxAddPublicationButton);
            this.Controls.Add(this.uxStrains);
            this.Controls.Add(this.uxResearchers);
            this.Controls.Add(this.uxYear);
            this.Controls.Add(this.uxYearLabel);
            this.Controls.Add(this.uxPublisherDrop);
            this.Controls.Add(this.uxPublisherLabel);
            this.Controls.Add(this.uxTitle);
            this.Controls.Add(this.uxTitleLabel);
            this.Name = "InsertPublication";
            this.Text = "InsertPublication";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxTitleLabel;
        private System.Windows.Forms.TextBox uxTitle;
        private System.Windows.Forms.Label uxPublisherLabel;
        private System.Windows.Forms.ComboBox uxPublisherDrop;
        private System.Windows.Forms.Label uxYearLabel;
        private System.Windows.Forms.TextBox uxYear;
        private System.Windows.Forms.ListView uxResearchers;
        private System.Windows.Forms.ListView uxStrains;
        private System.Windows.Forms.Button uxAddPublicationButton;
        private System.Windows.Forms.Button uxAddResearcherButton;
        private System.Windows.Forms.Button uxAddStrainButton;
        private System.Windows.Forms.Button uxAddPublisherButton;
        private System.Windows.Forms.ListView uxPublishers;
    }
}