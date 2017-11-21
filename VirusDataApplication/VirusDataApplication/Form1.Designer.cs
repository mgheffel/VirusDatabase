namespace VirusDataApplication
{
    partial class Form1
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
            this.input_tb = new System.Windows.Forms.TextBox();
            this.send_btn = new System.Windows.Forms.Button();
            this.output_lb = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // input_tb
            // 
            this.input_tb.Location = new System.Drawing.Point(23, 12);
            this.input_tb.Name = "input_tb";
            this.input_tb.Size = new System.Drawing.Size(222, 26);
            this.input_tb.TabIndex = 0;
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(251, 15);
            this.send_btn.Name = "send_btn";
            this.send_btn.Size = new System.Drawing.Size(75, 32);
            this.send_btn.TabIndex = 1;
            this.send_btn.Text = "submit";
            this.send_btn.UseVisualStyleBackColor = true;
            this.send_btn.Click += new System.EventHandler(this.send_btn_Click);
            // 
            // output_lb
            // 
            this.output_lb.FormattingEnabled = true;
            this.output_lb.ItemHeight = 20;
            this.output_lb.Location = new System.Drawing.Point(23, 58);
            this.output_lb.Name = "output_lb";
            this.output_lb.Size = new System.Drawing.Size(303, 344);
            this.output_lb.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 560);
            this.Controls.Add(this.output_lb);
            this.Controls.Add(this.send_btn);
            this.Controls.Add(this.input_tb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox input_tb;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.ListBox output_lb;
    }
}

