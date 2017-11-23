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
            this.tab_control = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.edit_tab = new System.Windows.Forms.TabPage();
            this.insert_rb = new System.Windows.Forms.RadioButton();
            this.delete_rb = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.edit_rb = new System.Windows.Forms.RadioButton();
            this.edit_tables_lb = new System.Windows.Forms.ListBox();
            this.selected_table_lb = new System.Windows.Forms.ListBox();
            this.selected_table_lv = new System.Windows.Forms.ListView();
            this.tab_control.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.edit_tab.SuspendLayout();
            this.SuspendLayout();
            // 
            // input_tb
            // 
            this.input_tb.Location = new System.Drawing.Point(77, 158);
            this.input_tb.Name = "input_tb";
            this.input_tb.Size = new System.Drawing.Size(222, 26);
            this.input_tb.TabIndex = 0;
            // 
            // send_btn
            // 
            this.send_btn.Location = new System.Drawing.Point(288, 158);
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
            this.output_lb.Location = new System.Drawing.Point(203, 242);
            this.output_lb.Name = "output_lb";
            this.output_lb.Size = new System.Drawing.Size(255, 184);
            this.output_lb.TabIndex = 2;
            // 
            // tab_control
            // 
            this.tab_control.Controls.Add(this.tabPage3);
            this.tab_control.Controls.Add(this.edit_tab);
            this.tab_control.Location = new System.Drawing.Point(0, 2);
            this.tab_control.Name = "tab_control";
            this.tab_control.SelectedIndex = 0;
            this.tab_control.Size = new System.Drawing.Size(1091, 728);
            this.tab_control.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.send_btn);
            this.tabPage3.Controls.Add(this.output_lb);
            this.tabPage3.Controls.Add(this.input_tb);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1083, 695);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // edit_tab
            // 
            this.edit_tab.Controls.Add(this.selected_table_lv);
            this.edit_tab.Controls.Add(this.selected_table_lb);
            this.edit_tab.Controls.Add(this.edit_tables_lb);
            this.edit_tab.Controls.Add(this.edit_rb);
            this.edit_tab.Controls.Add(this.label1);
            this.edit_tab.Controls.Add(this.delete_rb);
            this.edit_tab.Controls.Add(this.insert_rb);
            this.edit_tab.Location = new System.Drawing.Point(4, 29);
            this.edit_tab.Name = "edit_tab";
            this.edit_tab.Padding = new System.Windows.Forms.Padding(3);
            this.edit_tab.Size = new System.Drawing.Size(1083, 695);
            this.edit_tab.TabIndex = 1;
            this.edit_tab.Text = "Edit";
            this.edit_tab.UseVisualStyleBackColor = true;
            // 
            // insert_rb
            // 
            this.insert_rb.AutoSize = true;
            this.insert_rb.Location = new System.Drawing.Point(22, 22);
            this.insert_rb.Name = "insert_rb";
            this.insert_rb.Size = new System.Drawing.Size(114, 24);
            this.insert_rb.TabIndex = 0;
            this.insert_rb.TabStop = true;
            this.insert_rb.Text = "Insert Data";
            this.insert_rb.UseVisualStyleBackColor = true;
            // 
            // delete_rb
            // 
            this.delete_rb.AutoSize = true;
            this.delete_rb.Location = new System.Drawing.Point(22, 54);
            this.delete_rb.Name = "delete_rb";
            this.delete_rb.Size = new System.Drawing.Size(120, 24);
            this.delete_rb.TabIndex = 1;
            this.delete_rb.TabStop = true;
            this.delete_rb.Text = "Delete Data";
            this.delete_rb.UseVisualStyleBackColor = true;
            this.delete_rb.CheckedChanged += new System.EventHandler(this.delete_rb_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tables:";
            // 
            // edit_rb
            // 
            this.edit_rb.AutoSize = true;
            this.edit_rb.Location = new System.Drawing.Point(22, 86);
            this.edit_rb.Name = "edit_rb";
            this.edit_rb.Size = new System.Drawing.Size(101, 24);
            this.edit_rb.TabIndex = 3;
            this.edit_rb.TabStop = true;
            this.edit_rb.Text = "Edit Data";
            this.edit_rb.UseVisualStyleBackColor = true;
            // 
            // edit_tables_lb
            // 
            this.edit_tables_lb.FormattingEnabled = true;
            this.edit_tables_lb.ItemHeight = 20;
            this.edit_tables_lb.Items.AddRange(new object[] {
            "Publications",
            "Publishers",
            "Researchers"});
            this.edit_tables_lb.Location = new System.Drawing.Point(22, 154);
            this.edit_tables_lb.Name = "edit_tables_lb";
            this.edit_tables_lb.Size = new System.Drawing.Size(120, 84);
            this.edit_tables_lb.Sorted = true;
            this.edit_tables_lb.TabIndex = 5;
            this.edit_tables_lb.SelectedIndexChanged += new System.EventHandler(this.edit_tables_lb_SelectedIndexChanged);
            // 
            // selected_table_lb
            // 
            this.selected_table_lb.Enabled = false;
            this.selected_table_lb.FormattingEnabled = true;
            this.selected_table_lb.ItemHeight = 20;
            this.selected_table_lb.Location = new System.Drawing.Point(227, 154);
            this.selected_table_lb.Name = "selected_table_lb";
            this.selected_table_lb.Size = new System.Drawing.Size(363, 344);
            this.selected_table_lb.TabIndex = 6;
            // 
            // selected_table_lv
            // 
            this.selected_table_lv.Location = new System.Drawing.Point(671, 190);
            this.selected_table_lv.Name = "selected_table_lv";
            this.selected_table_lv.Size = new System.Drawing.Size(121, 97);
            this.selected_table_lv.TabIndex = 7;
            this.selected_table_lv.UseCompatibleStateImageBehavior = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 704);
            this.Controls.Add(this.tab_control);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tab_control.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.edit_tab.ResumeLayout(false);
            this.edit_tab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox input_tb;
        private System.Windows.Forms.Button send_btn;
        private System.Windows.Forms.ListBox output_lb;
        private System.Windows.Forms.TabControl tab_control;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage edit_tab;
        private System.Windows.Forms.ListBox selected_table_lb;
        private System.Windows.Forms.ListBox edit_tables_lb;
        private System.Windows.Forms.RadioButton edit_rb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton delete_rb;
        private System.Windows.Forms.RadioButton insert_rb;
        private System.Windows.Forms.ListView selected_table_lv;
    }
}

