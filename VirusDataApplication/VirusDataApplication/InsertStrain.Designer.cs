namespace VirusDataApplication
{
    partial class InsertStrain
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.uxStrainIDLabel = new System.Windows.Forms.Label();
            this.uxBasePairsLabel = new System.Windows.Forms.Label();
            this.uxStrainID = new System.Windows.Forms.TextBox();
            this.uxBasePairs = new System.Windows.Forms.TextBox();
            this.uxAddStrainButton = new System.Windows.Forms.Button();
            this.uxSelectGenomeButton = new System.Windows.Forms.Button();
            this.uxFilePathLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // uxStrainIDLabel
            // 
            this.uxStrainIDLabel.AutoSize = true;
            this.uxStrainIDLabel.Location = new System.Drawing.Point(12, 33);
            this.uxStrainIDLabel.Name = "uxStrainIDLabel";
            this.uxStrainIDLabel.Size = new System.Drawing.Size(48, 13);
            this.uxStrainIDLabel.TabIndex = 0;
            this.uxStrainIDLabel.Text = "StrainID:";
            // 
            // uxBasePairsLabel
            // 
            this.uxBasePairsLabel.AutoSize = true;
            this.uxBasePairsLabel.Location = new System.Drawing.Point(12, 76);
            this.uxBasePairsLabel.Name = "uxBasePairsLabel";
            this.uxBasePairsLabel.Size = new System.Drawing.Size(60, 13);
            this.uxBasePairsLabel.TabIndex = 1;
            this.uxBasePairsLabel.Text = "Base Pairs:";
            // 
            // uxStrainID
            // 
            this.uxStrainID.Location = new System.Drawing.Point(78, 33);
            this.uxStrainID.Name = "uxStrainID";
            this.uxStrainID.Size = new System.Drawing.Size(165, 20);
            this.uxStrainID.TabIndex = 2;
            this.uxStrainID.TextChanged += new System.EventHandler(this.ButtonEnable);
            // 
            // uxBasePairs
            // 
            this.uxBasePairs.Location = new System.Drawing.Point(78, 73);
            this.uxBasePairs.Name = "uxBasePairs";
            this.uxBasePairs.Size = new System.Drawing.Size(165, 20);
            this.uxBasePairs.TabIndex = 3;
            this.uxBasePairs.TextChanged += new System.EventHandler(this.ButtonEnable);
            // 
            // uxAddStrainButton
            // 
            this.uxAddStrainButton.Enabled = false;
            this.uxAddStrainButton.Location = new System.Drawing.Point(100, 294);
            this.uxAddStrainButton.Name = "uxAddStrainButton";
            this.uxAddStrainButton.Size = new System.Drawing.Size(75, 23);
            this.uxAddStrainButton.TabIndex = 4;
            this.uxAddStrainButton.Text = "Add Strain";
            this.uxAddStrainButton.UseVisualStyleBackColor = true;
            this.uxAddStrainButton.Click += new System.EventHandler(this.uxAddStrainButton_Click);
            // 
            // uxSelectGenomeButton
            // 
            this.uxSelectGenomeButton.Location = new System.Drawing.Point(90, 110);
            this.uxSelectGenomeButton.Name = "uxSelectGenomeButton";
            this.uxSelectGenomeButton.Size = new System.Drawing.Size(98, 23);
            this.uxSelectGenomeButton.TabIndex = 5;
            this.uxSelectGenomeButton.Text = "Select Genome";
            this.uxSelectGenomeButton.UseVisualStyleBackColor = true;
            this.uxSelectGenomeButton.Click += new System.EventHandler(this.uxSelectGenomeButton_Click);
            // 
            // uxFilePathLabel
            // 
            this.uxFilePathLabel.Location = new System.Drawing.Point(12, 180);
            this.uxFilePathLabel.Name = "uxFilePathLabel";
            this.uxFilePathLabel.Size = new System.Drawing.Size(258, 23);
            this.uxFilePathLabel.TabIndex = 6;
            this.uxFilePathLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uxFilePathLabel.TextChanged += new System.EventHandler(this.ButtonEnable);
            // 
            // InsertStrain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 329);
            this.Controls.Add(this.uxFilePathLabel);
            this.Controls.Add(this.uxSelectGenomeButton);
            this.Controls.Add(this.uxAddStrainButton);
            this.Controls.Add(this.uxBasePairs);
            this.Controls.Add(this.uxStrainID);
            this.Controls.Add(this.uxBasePairsLabel);
            this.Controls.Add(this.uxStrainIDLabel);
            this.Name = "InsertStrain";
            this.Text = "InsertStrain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label uxStrainIDLabel;
        private System.Windows.Forms.Label uxBasePairsLabel;
        private System.Windows.Forms.TextBox uxStrainID;
        private System.Windows.Forms.TextBox uxBasePairs;
        private System.Windows.Forms.Button uxAddStrainButton;
        private System.Windows.Forms.Button uxSelectGenomeButton;
        private System.Windows.Forms.Label uxFilePathLabel;
    }
}