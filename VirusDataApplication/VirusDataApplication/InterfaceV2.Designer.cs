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
            this.species_lbl = new System.Windows.Forms.Label();
            this.strain_lbl = new System.Windows.Forms.Label();
            this.choice_box_lbl = new System.Windows.Forms.Label();
            this.following_box_lbl = new System.Windows.Forms.Label();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // uxSpeciesBox
            // 
            this.uxSpeciesBox.FormattingEnabled = true;
            this.uxSpeciesBox.HorizontalScrollbar = true;
            this.uxSpeciesBox.ItemHeight = 20;
            this.uxSpeciesBox.Location = new System.Drawing.Point(20, 75);
            this.uxSpeciesBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxSpeciesBox.Name = "uxSpeciesBox";
            this.uxSpeciesBox.Size = new System.Drawing.Size(193, 424);
            this.uxSpeciesBox.TabIndex = 0;
            this.uxSpeciesBox.SelectedIndexChanged += new System.EventHandler(this.uxSpeciesBox_SelectedIndexChanged);
            // 
            // uxStrainsBox
            // 
            this.uxStrainsBox.FormattingEnabled = true;
            this.uxStrainsBox.HorizontalScrollbar = true;
            this.uxStrainsBox.ItemHeight = 20;
            this.uxStrainsBox.Location = new System.Drawing.Point(225, 75);
            this.uxStrainsBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxStrainsBox.Name = "uxStrainsBox";
            this.uxStrainsBox.Size = new System.Drawing.Size(190, 424);
            this.uxStrainsBox.TabIndex = 1;
            this.uxStrainsBox.SelectedIndexChanged += new System.EventHandler(this.uxStrainsBox_SelectedIndexChanged);
            // 
            // uxChoiceBox
            // 
            this.uxChoiceBox.FormattingEnabled = true;
            this.uxChoiceBox.HorizontalScrollbar = true;
            this.uxChoiceBox.ItemHeight = 20;
            this.uxChoiceBox.Location = new System.Drawing.Point(624, 75);
            this.uxChoiceBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxChoiceBox.Name = "uxChoiceBox";
            this.uxChoiceBox.Size = new System.Drawing.Size(196, 424);
            this.uxChoiceBox.TabIndex = 2;
            // 
            // uxFollowingBox
            // 
            this.uxFollowingBox.FormattingEnabled = true;
            this.uxFollowingBox.HorizontalScrollbar = true;
            this.uxFollowingBox.ItemHeight = 20;
            this.uxFollowingBox.Location = new System.Drawing.Point(831, 75);
            this.uxFollowingBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxFollowingBox.Name = "uxFollowingBox";
            this.uxFollowingBox.Size = new System.Drawing.Size(205, 424);
            this.uxFollowingBox.TabIndex = 3;
            // 
            // uxDetialsButton
            // 
            this.uxDetialsButton.Location = new System.Drawing.Point(20, 512);
            this.uxDetialsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxDetialsButton.Name = "uxDetialsButton";
            this.uxDetialsButton.Size = new System.Drawing.Size(176, 35);
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
            this.uxOptionsDropdown.Location = new System.Drawing.Point(428, 75);
            this.uxOptionsDropdown.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uxOptionsDropdown.Name = "uxOptionsDropdown";
            this.uxOptionsDropdown.Size = new System.Drawing.Size(186, 28);
            this.uxOptionsDropdown.TabIndex = 7;
            this.uxOptionsDropdown.SelectedIndexChanged += new System.EventHandler(this.uxOptionsDropdown_SelectedIndexChanged);
            // 
            // species_lbl
            // 
            this.species_lbl.AutoSize = true;
            this.species_lbl.Location = new System.Drawing.Point(16, 50);
            this.species_lbl.Name = "species_lbl";
            this.species_lbl.Size = new System.Drawing.Size(66, 20);
            this.species_lbl.TabIndex = 8;
            this.species_lbl.Text = "Species";
            // 
            // strain_lbl
            // 
            this.strain_lbl.AutoSize = true;
            this.strain_lbl.Location = new System.Drawing.Point(221, 50);
            this.strain_lbl.Name = "strain_lbl";
            this.strain_lbl.Size = new System.Drawing.Size(59, 20);
            this.strain_lbl.TabIndex = 9;
            this.strain_lbl.Text = "Strains";
            // 
            // choice_box_lbl
            // 
            this.choice_box_lbl.AutoSize = true;
            this.choice_box_lbl.Location = new System.Drawing.Point(621, 50);
            this.choice_box_lbl.Name = "choice_box_lbl";
            this.choice_box_lbl.Size = new System.Drawing.Size(0, 20);
            this.choice_box_lbl.TabIndex = 10;
            // 
            // following_box_lbl
            // 
            this.following_box_lbl.AutoSize = true;
            this.following_box_lbl.Location = new System.Drawing.Point(827, 50);
            this.following_box_lbl.Name = "following_box_lbl";
            this.following_box_lbl.Size = new System.Drawing.Size(0, 20);
            this.following_box_lbl.TabIndex = 11;
            // 
            // edit_btn
            // 
            this.edit_btn.Location = new System.Drawing.Point(685, 523);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(75, 37);
            this.edit_btn.TabIndex = 12;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(896, 523);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 37);
            this.delete_btn.TabIndex = 13;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            // 
            // InterfaceV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1060, 572);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.edit_btn);
            this.Controls.Add(this.following_box_lbl);
            this.Controls.Add(this.choice_box_lbl);
            this.Controls.Add(this.strain_lbl);
            this.Controls.Add(this.species_lbl);
            this.Controls.Add(this.uxOptionsDropdown);
            this.Controls.Add(this.uxDetialsButton);
            this.Controls.Add(this.uxFollowingBox);
            this.Controls.Add(this.uxChoiceBox);
            this.Controls.Add(this.uxStrainsBox);
            this.Controls.Add(this.uxSpeciesBox);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
        private System.Windows.Forms.Button uxDetialsButton;
        private System.Windows.Forms.ComboBox uxOptionsDropdown;
        private System.Windows.Forms.Label species_lbl;
        private System.Windows.Forms.Label strain_lbl;
        private System.Windows.Forms.Label choice_box_lbl;
        private System.Windows.Forms.Label following_box_lbl;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
    }
}