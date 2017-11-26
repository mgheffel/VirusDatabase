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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.choice_lbl = new System.Windows.Forms.Label();
            this.following_lbl = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uxSpeciesBox
            // 
            this.uxSpeciesBox.FormattingEnabled = true;
            this.uxSpeciesBox.HorizontalScrollbar = true;
            this.uxSpeciesBox.Location = new System.Drawing.Point(12, 32);
            this.uxSpeciesBox.Name = "uxSpeciesBox";
            this.uxSpeciesBox.Size = new System.Drawing.Size(130, 199);
            this.uxSpeciesBox.TabIndex = 0;
            this.uxSpeciesBox.SelectedIndexChanged += new System.EventHandler(this.uxSpeciesBox_SelectedIndexChanged);
            // 
            // uxStrainsBox
            // 
            this.uxStrainsBox.FormattingEnabled = true;
            this.uxStrainsBox.HorizontalScrollbar = true;
            this.uxStrainsBox.Location = new System.Drawing.Point(146, 32);
            this.uxStrainsBox.Name = "uxStrainsBox";
            this.uxStrainsBox.Size = new System.Drawing.Size(130, 199);
            this.uxStrainsBox.TabIndex = 1;
            this.uxStrainsBox.SelectedIndexChanged += new System.EventHandler(this.uxStrainsBox_SelectedIndexChanged);
            // 
            // uxChoiceBox
            // 
            this.uxChoiceBox.FormattingEnabled = true;
            this.uxChoiceBox.HorizontalScrollbar = true;
            this.uxChoiceBox.Location = new System.Drawing.Point(420, 32);
            this.uxChoiceBox.Name = "uxChoiceBox";
            this.uxChoiceBox.Size = new System.Drawing.Size(130, 199);
            this.uxChoiceBox.TabIndex = 2;
            // 
            // uxFollowingBox
            // 
            this.uxFollowingBox.FormattingEnabled = true;
            this.uxFollowingBox.HorizontalScrollbar = true;
            this.uxFollowingBox.Location = new System.Drawing.Point(557, 32);
            this.uxFollowingBox.Name = "uxFollowingBox";
            this.uxFollowingBox.Size = new System.Drawing.Size(130, 199);
            this.uxFollowingBox.TabIndex = 3;
            // 
            // uxDetialsButton
            // 
            this.uxDetialsButton.Location = new System.Drawing.Point(12, 244);
            this.uxDetialsButton.Name = "uxDetialsButton";
            this.uxDetialsButton.Size = new System.Drawing.Size(117, 23);
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
            this.uxOptionsDropdown.Location = new System.Drawing.Point(285, 32);
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
            this.edit_btn.Location = new System.Drawing.Point(459, 242);
            this.edit_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(50, 24);
            this.edit_btn.TabIndex = 12;
            this.edit_btn.Text = "Edit";
            this.edit_btn.UseVisualStyleBackColor = true;
            this.edit_btn.Click += new System.EventHandler(this.edit_btn_Click);
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(597, 242);
            this.delete_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(50, 24);
            this.delete_btn.TabIndex = 13;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(710, 391);
            this.tabControl1.TabIndex = 14;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage2.Size = new System.Drawing.Size(702, 365);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.following_lbl);
            this.tabPage1.Controls.Add(this.choice_lbl);
            this.tabPage1.Controls.Add(this.species_lbl);
            this.tabPage1.Controls.Add(this.edit_btn);
            this.tabPage1.Controls.Add(this.delete_btn);
            this.tabPage1.Controls.Add(this.uxFollowingBox);
            this.tabPage1.Controls.Add(this.strain_lbl);
            this.tabPage1.Controls.Add(this.uxChoiceBox);
            this.tabPage1.Controls.Add(this.uxStrainsBox);
            this.tabPage1.Controls.Add(this.uxOptionsDropdown);
            this.tabPage1.Controls.Add(this.uxDetialsButton);
            this.tabPage1.Controls.Add(this.uxSpeciesBox);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tabPage1.Size = new System.Drawing.Size(702, 365);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // choice_lbl
            // 
            this.choice_lbl.AutoSize = true;
            this.choice_lbl.Location = new System.Drawing.Point(420, 15);
            this.choice_lbl.Name = "choice_lbl";
            this.choice_lbl.Size = new System.Drawing.Size(35, 13);
            this.choice_lbl.TabIndex = 14;
            this.choice_lbl.Text = "label1";
            this.choice_lbl.Visible = false;
            // 
            // following_lbl
            // 
            this.following_lbl.AutoSize = true;
            this.following_lbl.Location = new System.Drawing.Point(557, 15);
            this.following_lbl.Name = "following_lbl";
            this.following_lbl.Size = new System.Drawing.Size(35, 13);
            this.following_lbl.TabIndex = 15;
            this.following_lbl.Text = "label2";
            this.following_lbl.Visible = false;
            // 
            // InterfaceV2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(707, 306);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.following_box_lbl);
            this.Controls.Add(this.choice_box_lbl);
            this.Name = "InterfaceV2";
            this.Text = "InterfaceV2";
            this.Load += new System.EventHandler(this.InterfaceV2_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label following_lbl;
        private System.Windows.Forms.Label choice_lbl;
    }
}