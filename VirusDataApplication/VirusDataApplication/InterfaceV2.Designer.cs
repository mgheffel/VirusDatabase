namespace VirusDataApplication
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
            this.uxPubRadioButton = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.uxDetialsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxSpeciesBox
            // 
            this.uxSpeciesBox.FormattingEnabled = true;
            this.uxSpeciesBox.Location = new System.Drawing.Point(13, 49);
            this.uxSpeciesBox.Name = "uxSpeciesBox";
            this.uxSpeciesBox.Size = new System.Drawing.Size(130, 277);
            this.uxSpeciesBox.TabIndex = 0;
            // 
            // uxStrainsBox
            // 
            this.uxStrainsBox.FormattingEnabled = true;
            this.uxStrainsBox.Location = new System.Drawing.Point(150, 49);
            this.uxStrainsBox.Name = "uxStrainsBox";
            this.uxStrainsBox.Size = new System.Drawing.Size(128, 277);
            this.uxStrainsBox.TabIndex = 1;
            // 
            // uxChoiceBox
            // 
            this.uxChoiceBox.FormattingEnabled = true;
            this.uxChoiceBox.Location = new System.Drawing.Point(416, 49);
            this.uxChoiceBox.Name = "uxChoiceBox";
            this.uxChoiceBox.Size = new System.Drawing.Size(132, 277);
            this.uxChoiceBox.TabIndex = 2;
            // 
            // uxFollowingBox
            // 
            this.uxFollowingBox.FormattingEnabled = true;
            this.uxFollowingBox.Location = new System.Drawing.Point(554, 49);
            this.uxFollowingBox.Name = "uxFollowingBox";
            this.uxFollowingBox.Size = new System.Drawing.Size(138, 277);
            this.uxFollowingBox.TabIndex = 3;
            // 
            // uxPubRadioButton
            // 
            this.uxPubRadioButton.AutoSize = true;
            this.uxPubRadioButton.Location = new System.Drawing.Point(284, 143);
            this.uxPubRadioButton.Name = "uxPubRadioButton";
            this.uxPubRadioButton.Size = new System.Drawing.Size(82, 17);
            this.uxPubRadioButton.TabIndex = 4;
            this.uxPubRadioButton.TabStop = true;
            this.uxPubRadioButton.Text = "Publications";
            this.uxPubRadioButton.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(285, 167);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(125, 17);
            this.radioButton2.TabIndex = 5;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "OpenReadingFrames";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // uxDetialsButton
            // 
            this.uxDetialsButton.Location = new System.Drawing.Point(13, 333);
            this.uxDetialsButton.Name = "uxDetialsButton";
            this.uxDetialsButton.Size = new System.Drawing.Size(117, 23);
            this.uxDetialsButton.TabIndex = 6;
            this.uxDetialsButton.Text = "DisplayDetails";
            this.uxDetialsButton.UseVisualStyleBackColor = true;
            // 
            // InterfaceV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 372);
            this.Controls.Add(this.uxDetialsButton);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.uxPubRadioButton);
            this.Controls.Add(this.uxFollowingBox);
            this.Controls.Add(this.uxChoiceBox);
            this.Controls.Add(this.uxStrainsBox);
            this.Controls.Add(this.uxSpeciesBox);
            this.Name = "InterfaceV2";
            this.Text = "InterfaceV2";
            this.Load += new System.EventHandler(this.InterfaceV2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox uxSpeciesBox;
        private System.Windows.Forms.ListBox uxStrainsBox;
        private System.Windows.Forms.ListBox uxChoiceBox;
        private System.Windows.Forms.ListBox uxFollowingBox;
        private System.Windows.Forms.RadioButton uxPubRadioButton;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.Button uxDetialsButton;
    }
}