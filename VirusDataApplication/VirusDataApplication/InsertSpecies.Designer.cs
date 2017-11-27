namespace VirusDataApplication
{
    partial class InsertSpecies
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
            this.uxInsertSpeciesNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.uxName = new System.Windows.Forms.TextBox();
            this.uxAbbreviation = new System.Windows.Forms.TextBox();
            this.uxAddButton = new System.Windows.Forms.Button();
            this.uxGenus = new System.Windows.Forms.TextBox();
            this.uxOrder = new System.Windows.Forms.TextBox();
            this.uxFamily = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // uxInsertSpeciesNameLabel
            // 
            this.uxInsertSpeciesNameLabel.AutoSize = true;
            this.uxInsertSpeciesNameLabel.Location = new System.Drawing.Point(12, 36);
            this.uxInsertSpeciesNameLabel.Name = "uxInsertSpeciesNameLabel";
            this.uxInsertSpeciesNameLabel.Size = new System.Drawing.Size(41, 13);
            this.uxInsertSpeciesNameLabel.TabIndex = 0;
            this.uxInsertSpeciesNameLabel.Text = "Name: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Family: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Genus:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Abbreviation:";
            // 
            // uxName
            // 
            this.uxName.Location = new System.Drawing.Point(85, 36);
            this.uxName.Name = "uxName";
            this.uxName.Size = new System.Drawing.Size(185, 20);
            this.uxName.TabIndex = 1;
            this.uxName.TextChanged += new System.EventHandler(this.buttonUpdate);
            // 
            // uxAbbreviation
            // 
            this.uxAbbreviation.Location = new System.Drawing.Point(85, 225);
            this.uxAbbreviation.Name = "uxAbbreviation";
            this.uxAbbreviation.Size = new System.Drawing.Size(185, 20);
            this.uxAbbreviation.TabIndex = 5;
            this.uxAbbreviation.TextChanged += new System.EventHandler(this.buttonUpdate);
            // 
            // uxAddButton
            // 
            this.uxAddButton.Enabled = false;
            this.uxAddButton.Location = new System.Drawing.Point(108, 277);
            this.uxAddButton.Name = "uxAddButton";
            this.uxAddButton.Size = new System.Drawing.Size(75, 23);
            this.uxAddButton.TabIndex = 6;
            this.uxAddButton.Text = "Add Species";
            this.uxAddButton.UseVisualStyleBackColor = true;
            this.uxAddButton.Click += new System.EventHandler(this.uxAddButton_Click);
            // 
            // uxGenus
            // 
            this.uxGenus.Location = new System.Drawing.Point(85, 180);
            this.uxGenus.Name = "uxGenus";
            this.uxGenus.Size = new System.Drawing.Size(185, 20);
            this.uxGenus.TabIndex = 4;
            this.uxGenus.TextChanged += new System.EventHandler(this.buttonUpdate);
            // 
            // uxOrder
            // 
            this.uxOrder.Location = new System.Drawing.Point(85, 132);
            this.uxOrder.Name = "uxOrder";
            this.uxOrder.Size = new System.Drawing.Size(185, 20);
            this.uxOrder.TabIndex = 3;
            this.uxOrder.TextChanged += new System.EventHandler(this.buttonUpdate);
            // 
            // uxFamily
            // 
            this.uxFamily.Location = new System.Drawing.Point(85, 83);
            this.uxFamily.Name = "uxFamily";
            this.uxFamily.Size = new System.Drawing.Size(185, 20);
            this.uxFamily.TabIndex = 2;
            this.uxFamily.TextChanged += new System.EventHandler(this.buttonUpdate);
            // 
            // InsertSpecies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 329);
            this.Controls.Add(this.uxFamily);
            this.Controls.Add(this.uxOrder);
            this.Controls.Add(this.uxGenus);
            this.Controls.Add(this.uxAddButton);
            this.Controls.Add(this.uxAbbreviation);
            this.Controls.Add(this.uxName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxInsertSpeciesNameLabel);
            this.Name = "InsertSpecies";
            this.Text = "InsertSpecies";
            this.Load += new System.EventHandler(this.InsertSpecies_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxInsertSpeciesNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox uxName;
        private System.Windows.Forms.TextBox uxAbbreviation;
        private System.Windows.Forms.Button uxAddButton;
        private System.Windows.Forms.TextBox uxGenus;
        private System.Windows.Forms.TextBox uxOrder;
        private System.Windows.Forms.TextBox uxFamily;
    }
}