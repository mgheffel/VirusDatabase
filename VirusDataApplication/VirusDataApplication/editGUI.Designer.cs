namespace VirusDataApplication
{
    partial class editGUI
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
            this.edit_tb = new System.Windows.Forms.TextBox();
            this.edit_lbl = new System.Windows.Forms.Label();
            this.submit_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // edit_tb
            // 
            this.edit_tb.Location = new System.Drawing.Point(104, 24);
            this.edit_tb.Name = "edit_tb";
            this.edit_tb.Size = new System.Drawing.Size(215, 26);
            this.edit_tb.TabIndex = 0;
            // 
            // edit_lbl
            // 
            this.edit_lbl.AutoSize = true;
            this.edit_lbl.Location = new System.Drawing.Point(12, 24);
            this.edit_lbl.Name = "edit_lbl";
            this.edit_lbl.Size = new System.Drawing.Size(86, 20);
            this.edit_lbl.TabIndex = 1;
            this.edit_lbl.Text = "Edit Value:";
            // 
            // submit_btn
            // 
            this.submit_btn.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.submit_btn.Location = new System.Drawing.Point(104, 63);
            this.submit_btn.Name = "submit_btn";
            this.submit_btn.Size = new System.Drawing.Size(75, 31);
            this.submit_btn.TabIndex = 2;
            this.submit_btn.Text = "Submit";
            this.submit_btn.UseVisualStyleBackColor = true;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(213, 63);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 31);
            this.cancel_btn.TabIndex = 3;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // editGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 106);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.submit_btn);
            this.Controls.Add(this.edit_lbl);
            this.Controls.Add(this.edit_tb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "editGUI";
            this.Text = "Edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox edit_tb;
        private System.Windows.Forms.Label edit_lbl;
        private System.Windows.Forms.Button submit_btn;
        private System.Windows.Forms.Button cancel_btn;
    }
}