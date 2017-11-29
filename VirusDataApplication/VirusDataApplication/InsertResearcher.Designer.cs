namespace VirusDataApplication
{
    partial class InsertResearcher
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
            this.uxNameLabel = new System.Windows.Forms.Label();
            this.uxOrgLabel = new System.Windows.Forms.Label();
            this.uxEmailLabel = new System.Windows.Forms.Label();
            this.uxName = new System.Windows.Forms.TextBox();
            this.uxEmail = new System.Windows.Forms.TextBox();
            this.uxOrganization = new System.Windows.Forms.ComboBox();
            this.uxAddResearcher = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxNameLabel
            // 
            this.uxNameLabel.AutoSize = true;
            this.uxNameLabel.Location = new System.Drawing.Point(12, 17);
            this.uxNameLabel.Name = "uxNameLabel";
            this.uxNameLabel.Size = new System.Drawing.Size(38, 13);
            this.uxNameLabel.TabIndex = 0;
            this.uxNameLabel.Text = "Name:";
            // 
            // uxOrgLabel
            // 
            this.uxOrgLabel.AutoSize = true;
            this.uxOrgLabel.Location = new System.Drawing.Point(12, 83);
            this.uxOrgLabel.Name = "uxOrgLabel";
            this.uxOrgLabel.Size = new System.Drawing.Size(69, 13);
            this.uxOrgLabel.TabIndex = 1;
            this.uxOrgLabel.Text = "Organization:";
            // 
            // uxEmailLabel
            // 
            this.uxEmailLabel.AutoSize = true;
            this.uxEmailLabel.Location = new System.Drawing.Point(12, 49);
            this.uxEmailLabel.Name = "uxEmailLabel";
            this.uxEmailLabel.Size = new System.Drawing.Size(35, 13);
            this.uxEmailLabel.TabIndex = 2;
            this.uxEmailLabel.Text = "Email:";
            // 
            // uxName
            // 
            this.uxName.Location = new System.Drawing.Point(88, 14);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(195, 20);
            this.uxName.TabIndex = 3;
            this.uxName.TextChanged += new System.EventHandler(this.ButtonEnable);
            // 
            // uxEmail
            // 
            this.uxEmail.Location = new System.Drawing.Point(88, 46);
            this.uxEmail.Name = "uxEmail";
            this.uxEmail.Size = new System.Drawing.Size(196, 20);
            this.uxEmail.TabIndex = 4;
            this.uxEmail.TextChanged += new System.EventHandler(this.ButtonEnable);
            // 
            // uxOrganization
            // 
            this.uxOrganization.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.uxOrganization.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.uxOrganization.FormattingEnabled = true;
            this.uxOrganization.Location = new System.Drawing.Point(88, 80);
            this.uxOrganization.Name = "uxOrganization";
            this.uxOrganization.Size = new System.Drawing.Size(195, 21);
            this.uxOrganization.TabIndex = 5;
            this.uxOrganization.TextChanged += new System.EventHandler(this.ButtonEnable);
            // 
            // uxAddResearcher
            // 
            this.uxAddResearcher.Enabled = false;
            this.uxAddResearcher.Location = new System.Drawing.Point(106, 125);
            this.uxAddResearcher.Name = "uxAddResearcher";
            this.uxAddResearcher.Size = new System.Drawing.Size(95, 23);
            this.uxAddResearcher.TabIndex = 6;
            this.uxAddResearcher.Text = "Add Researcher";
            this.uxAddResearcher.UseVisualStyleBackColor = true;
            this.uxAddResearcher.Click += new System.EventHandler(this.uxAddResearcher_Click);
            // 
            // InsertResearcher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 160);
            this.Controls.Add(this.uxAddResearcher);
            this.Controls.Add(this.uxOrganization);
            this.Controls.Add(this.uxEmail);
            this.Controls.Add(this.uxName);
            this.Controls.Add(this.uxEmailLabel);
            this.Controls.Add(this.uxOrgLabel);
            this.Controls.Add(this.uxNameLabel);
            this.Name = "InsertResearcher";
            this.Text = "InsertResearcher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxNameLabel;
        private System.Windows.Forms.Label uxOrgLabel;
        private System.Windows.Forms.Label uxEmailLabel;
        private System.Windows.Forms.TextBox uxName;
        private System.Windows.Forms.TextBox uxEmail;
        private System.Windows.Forms.ComboBox uxOrganization;
        private System.Windows.Forms.Button uxAddResearcher;
    }
}