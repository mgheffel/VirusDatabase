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
            this.uxDetialsButton = new System.Windows.Forms.Button();
            this.uxOptionsDropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // uxSpeciesBox
            // 
            this.uxSpeciesBox.FormattingEnabled = true;
            this.uxSpeciesBox.HorizontalScrollbar = true;
            this.uxSpeciesBox.Location = new System.Drawing.Point(13, 49);
            this.uxSpeciesBox.Name = "uxSpeciesBox";
            this.uxSpeciesBox.Size = new System.Drawing.Size(130, 277);
            this.uxSpeciesBox.TabIndex = 0;
            this.uxSpeciesBox.SelectedIndexChanged += new System.EventHandler(this.uxSpeciesBox_SelectedIndexChanged);
            // 
            // uxStrainsBox
            // 
            this.uxStrainsBox.FormattingEnabled = true;
            this.uxStrainsBox.HorizontalScrollbar = true;
            this.uxStrainsBox.Location = new System.Drawing.Point(150, 49);
            this.uxStrainsBox.Name = "uxStrainsBox";
            this.uxStrainsBox.Size = new System.Drawing.Size(128, 277);
            this.uxStrainsBox.TabIndex = 1;
            this.uxStrainsBox.SelectedIndexChanged += new System.EventHandler(this.uxStrainsBox_SelectedIndexChanged);
            // 
            // uxChoiceBox
            // 
            this.uxChoiceBox.FormattingEnabled = true;
            this.uxChoiceBox.HorizontalScrollbar = true;
            this.uxChoiceBox.Location = new System.Drawing.Point(416, 49);
            this.uxChoiceBox.Name = "uxChoiceBox";
            this.uxChoiceBox.Size = new System.Drawing.Size(132, 277);
            this.uxChoiceBox.TabIndex = 2;
            // 
            // uxFollowingBox
            // 
            this.uxFollowingBox.FormattingEnabled = true;
            this.uxFollowingBox.HorizontalScrollbar = true;
            this.uxFollowingBox.Location = new System.Drawing.Point(554, 49);
            this.uxFollowingBox.Name = "uxFollowingBox";
            this.uxFollowingBox.Size = new System.Drawing.Size(138, 277);
            this.uxFollowingBox.TabIndex = 3;
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
            // uxOptionsDropdown
            // 
            this.uxOptionsDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.uxOptionsDropdown.Enabled = false;
            this.uxOptionsDropdown.FormattingEnabled = true;
            this.uxOptionsDropdown.Items.AddRange(new object[] {
            "OpenReadingFrames",
            "Publications - Publishers",
            "Publications - Researchers"});
            this.uxOptionsDropdown.Location = new System.Drawing.Point(285, 49);
            this.uxOptionsDropdown.Name = "uxOptionsDropdown";
            this.uxOptionsDropdown.Size = new System.Drawing.Size(125, 21);
            this.uxOptionsDropdown.TabIndex = 7;
            this.uxOptionsDropdown.SelectedIndexChanged += new System.EventHandler(this.uxOptionsDropdown_SelectedIndexChanged);
            // 
            // InterfaceV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 372);
            this.Controls.Add(this.uxOptionsDropdown);
            this.Controls.Add(this.uxDetialsButton);
            this.Controls.Add(this.uxFollowingBox);
            this.Controls.Add(this.uxChoiceBox);
            this.Controls.Add(this.uxStrainsBox);
            this.Controls.Add(this.uxSpeciesBox);
            this.Name = "InterfaceV2";
            this.Text = "InterfaceV2";
            this.Load += new System.EventHandler(this.InterfaceV2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox uxSpeciesBox;
        private System.Windows.Forms.ListBox uxStrainsBox;
        private System.Windows.Forms.ListBox uxChoiceBox;
        private System.Windows.Forms.ListBox uxFollowingBox;
        private System.Windows.Forms.Button uxDetialsButton;
        private System.Windows.Forms.ComboBox uxOptionsDropdown;
    }
}