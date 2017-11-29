namespace VirusDataApplication
{
    partial class InsertORF
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
            this.uxORFIDLabel = new System.Windows.Forms.Label();
            this.uxORFID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.uxStartIndex = new System.Windows.Forms.NumericUpDown();
            this.uxStopIndex = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.uxSelectProteinDown = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.uxCreateStructuralProteinButton = new System.Windows.Forms.Button();
            this.uxCreateNonStructuralProteinButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.uxStructTextBox = new System.Windows.Forms.TextBox();
            this.uxFunctTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.uxProteinName = new System.Windows.Forms.TextBox();
            this.uxCreateORF = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.uxStartIndex)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxStopIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // uxORFIDLabel
            // 
            this.uxORFIDLabel.AutoSize = true;
            this.uxORFIDLabel.Location = new System.Drawing.Point(12, 35);
            this.uxORFIDLabel.Name = "uxORFIDLabel";
            this.uxORFIDLabel.Size = new System.Drawing.Size(36, 13);
            this.uxORFIDLabel.TabIndex = 0;
            this.uxORFIDLabel.Text = "orfID: ";
            // 
            // uxORFID
            // 
            this.uxORFID.Location = new System.Drawing.Point(97, 32);
            this.uxORFID.Name = "uxORFID";
            this.uxORFID.Size = new System.Drawing.Size(173, 20);
            this.uxORFID.TabIndex = 1;
            this.uxORFID.TextChanged += new System.EventHandler(this.EnableCreateORFButton);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Start Index:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Stop Index:";
            // 
            // uxStartIndex
            // 
            this.uxStartIndex.Location = new System.Drawing.Point(97, 61);
            this.uxStartIndex.Name = "uxStartIndex";
            this.uxStartIndex.Size = new System.Drawing.Size(173, 20);
            this.uxStartIndex.TabIndex = 6;
            this.uxStartIndex.ValueChanged += new System.EventHandler(this.EnableCreateORFButton);
            // 
            // uxStopIndex
            // 
            this.uxStopIndex.Location = new System.Drawing.Point(97, 87);
            this.uxStopIndex.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxStopIndex.Name = "uxStopIndex";
            this.uxStopIndex.Size = new System.Drawing.Size(173, 20);
            this.uxStopIndex.TabIndex = 7;
            this.uxStopIndex.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.uxStopIndex.ValueChanged += new System.EventHandler(this.EnableCreateORFButton);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Select Protein:";
            // 
            // uxSelectProteinDown
            // 
            this.uxSelectProteinDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxSelectProteinDown.FormattingEnabled = true;
            this.uxSelectProteinDown.Location = new System.Drawing.Point(97, 114);
            this.uxSelectProteinDown.Name = "uxSelectProteinDown";
            this.uxSelectProteinDown.Size = new System.Drawing.Size(173, 21);
            this.uxSelectProteinDown.TabIndex = 9;
            this.uxSelectProteinDown.SelectedIndexChanged += new System.EventHandler(this.EnableCreateORFButton);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 208);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(283, 23);
            this.label4.TabIndex = 10;
            this.label4.Text = "or create";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uxCreateStructuralProteinButton
            // 
            this.uxCreateStructuralProteinButton.Enabled = false;
            this.uxCreateStructuralProteinButton.Location = new System.Drawing.Point(12, 274);
            this.uxCreateStructuralProteinButton.Name = "uxCreateStructuralProteinButton";
            this.uxCreateStructuralProteinButton.Size = new System.Drawing.Size(123, 23);
            this.uxCreateStructuralProteinButton.TabIndex = 11;
            this.uxCreateStructuralProteinButton.Text = "Structural Protein";
            this.uxCreateStructuralProteinButton.UseVisualStyleBackColor = true;
            this.uxCreateStructuralProteinButton.Click += new System.EventHandler(this.uxCreateStructuralProteinButton_Click);
            // 
            // uxCreateNonStructuralProteinButton
            // 
            this.uxCreateNonStructuralProteinButton.Enabled = false;
            this.uxCreateNonStructuralProteinButton.Location = new System.Drawing.Point(172, 274);
            this.uxCreateNonStructuralProteinButton.Name = "uxCreateNonStructuralProteinButton";
            this.uxCreateNonStructuralProteinButton.Size = new System.Drawing.Size(123, 23);
            this.uxCreateNonStructuralProteinButton.TabIndex = 12;
            this.uxCreateNonStructuralProteinButton.Text = "Non-Structural Protein";
            this.uxCreateNonStructuralProteinButton.UseVisualStyleBackColor = true;
            this.uxCreateNonStructuralProteinButton.Click += new System.EventHandler(this.uxCreateNonStructuralProteinButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(53, 323);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Struct";
            // 
            // uxStructTextBox
            // 
            this.uxStructTextBox.Location = new System.Drawing.Point(15, 358);
            this.uxStructTextBox.Name = "uxStructTextBox";
            this.uxStructTextBox.Size = new System.Drawing.Size(120, 20);
            this.uxStructTextBox.TabIndex = 14;
            this.uxStructTextBox.TextChanged += new System.EventHandler(this.uxStructTextBox_TextChanged);
            // 
            // uxFunctTextBox
            // 
            this.uxFunctTextBox.Location = new System.Drawing.Point(173, 358);
            this.uxFunctTextBox.Name = "uxFunctTextBox";
            this.uxFunctTextBox.Size = new System.Drawing.Size(120, 20);
            this.uxFunctTextBox.TabIndex = 16;
            this.uxFunctTextBox.TextChanged += new System.EventHandler(this.uxFunctTextBox_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(211, 323);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Funct";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(43, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Protein Name:";
            // 
            // uxProteinName
            // 
            this.uxProteinName.Location = new System.Drawing.Point(123, 241);
            this.uxProteinName.Name = "uxProteinName";
            this.uxProteinName.Size = new System.Drawing.Size(159, 20);
            this.uxProteinName.TabIndex = 18;
            // 
            // uxCreateORF
            // 
            this.uxCreateORF.Enabled = false;
            this.uxCreateORF.Location = new System.Drawing.Point(97, 162);
            this.uxCreateORF.Name = "uxCreateORF";
            this.uxCreateORF.Size = new System.Drawing.Size(111, 23);
            this.uxCreateORF.TabIndex = 19;
            this.uxCreateORF.Text = "Create ORF";
            this.uxCreateORF.UseVisualStyleBackColor = true;
            this.uxCreateORF.Click += new System.EventHandler(this.uxCreateORF_Click);
            // 
            // InsertORF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 417);
            this.Controls.Add(this.uxCreateORF);
            this.Controls.Add(this.uxProteinName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.uxFunctTextBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.uxStructTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.uxCreateNonStructuralProteinButton);
            this.Controls.Add(this.uxCreateStructuralProteinButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.uxSelectProteinDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.uxStopIndex);
            this.Controls.Add(this.uxStartIndex);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.uxORFID);
            this.Controls.Add(this.uxORFIDLabel);
            this.Name = "InsertORF";
            this.Text = "InsertORF";
            this.Load += new System.EventHandler(this.InsertORF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.uxStartIndex)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uxStopIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label uxORFIDLabel;
        private System.Windows.Forms.TextBox uxORFID;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown uxStartIndex;
        private System.Windows.Forms.NumericUpDown uxStopIndex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox uxSelectProteinDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button uxCreateStructuralProteinButton;
        private System.Windows.Forms.Button uxCreateNonStructuralProteinButton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox uxStructTextBox;
        private System.Windows.Forms.TextBox uxFunctTextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox uxProteinName;
        private System.Windows.Forms.Button uxCreateORF;
    }
}