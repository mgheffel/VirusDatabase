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
            this.edit_col2_lbl = new System.Windows.Forms.Label();
            this.edit_col3_lbl = new System.Windows.Forms.Label();
            this.edit_col4_lbl = new System.Windows.Forms.Label();
            this.edit_col5_lbl = new System.Windows.Forms.Label();
            this.edit_col6_lbl = new System.Windows.Forms.Label();
            this.edit_col1_lbl = new System.Windows.Forms.Label();
            this.edit_col6_tb = new System.Windows.Forms.TextBox();
            this.edit_col2_tb = new System.Windows.Forms.TextBox();
            this.edit_col3_tb = new System.Windows.Forms.TextBox();
            this.edit_col4_tb = new System.Windows.Forms.TextBox();
            this.edit_col5_tb = new System.Windows.Forms.TextBox();
            this.edit_col1_tb = new System.Windows.Forms.TextBox();
            this.selected_table_lbl = new System.Windows.Forms.Label();
            this.edit_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.insert_btn = new System.Windows.Forms.Button();
            this.edit_tables_lb = new System.Windows.Forms.ListBox();
            this.selected_table_lv = new System.Windows.Forms.ListView();
            this.edit_rb = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.delete_rb = new System.Windows.Forms.RadioButton();
            this.insert_rb = new System.Windows.Forms.RadioButton();
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
            this.tab_control.Size = new System.Drawing.Size(1210, 717);
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
            this.tabPage3.Size = new System.Drawing.Size(1202, 684);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // edit_tab
            // 
            this.edit_tab.Controls.Add(this.edit_col2_lbl);
            this.edit_tab.Controls.Add(this.edit_col3_lbl);
            this.edit_tab.Controls.Add(this.edit_col4_lbl);
            this.edit_tab.Controls.Add(this.edit_col5_lbl);
            this.edit_tab.Controls.Add(this.edit_col6_lbl);
            this.edit_tab.Controls.Add(this.edit_col1_lbl);
            this.edit_tab.Controls.Add(this.edit_col6_tb);
            this.edit_tab.Controls.Add(this.edit_col2_tb);
            this.edit_tab.Controls.Add(this.edit_col3_tb);
            this.edit_tab.Controls.Add(this.edit_col4_tb);
            this.edit_tab.Controls.Add(this.edit_col5_tb);
            this.edit_tab.Controls.Add(this.edit_col1_tb);
            this.edit_tab.Controls.Add(this.selected_table_lbl);
            this.edit_tab.Controls.Add(this.edit_btn);
            this.edit_tab.Controls.Add(this.delete_btn);
            this.edit_tab.Controls.Add(this.insert_btn);
            this.edit_tab.Controls.Add(this.edit_tables_lb);
            this.edit_tab.Controls.Add(this.selected_table_lv);
            this.edit_tab.Controls.Add(this.edit_rb);
            this.edit_tab.Controls.Add(this.label1);
            this.edit_tab.Controls.Add(this.delete_rb);
            this.edit_tab.Controls.Add(this.insert_rb);
            this.edit_tab.Location = new System.Drawing.Point(4, 29);
            this.edit_tab.Name = "edit_tab";
            this.edit_tab.Padding = new System.Windows.Forms.Padding(3);
            this.edit_tab.Size = new System.Drawing.Size(1202, 684);
            this.edit_tab.TabIndex = 1;
            this.edit_tab.Text = "Edit";
            this.edit_tab.UseVisualStyleBackColor = true;
            // 
            // edit_col2_lbl
            // 
            this.edit_col2_lbl.AutoSize = true;
            this.edit_col2_lbl.Location = new System.Drawing.Point(407, 54);
            this.edit_col2_lbl.Name = "edit_col2_lbl";
            this.edit_col2_lbl.Size = new System.Drawing.Size(0, 20);
            this.edit_col2_lbl.TabIndex = 29;
            // 
            // edit_col3_lbl
            // 
            this.edit_col3_lbl.AutoSize = true;
            this.edit_col3_lbl.Location = new System.Drawing.Point(562, 54);
            this.edit_col3_lbl.Name = "edit_col3_lbl";
            this.edit_col3_lbl.Size = new System.Drawing.Size(0, 20);
            this.edit_col3_lbl.TabIndex = 28;
            // 
            // edit_col4_lbl
            // 
            this.edit_col4_lbl.AutoSize = true;
            this.edit_col4_lbl.Location = new System.Drawing.Point(717, 54);
            this.edit_col4_lbl.Name = "edit_col4_lbl";
            this.edit_col4_lbl.Size = new System.Drawing.Size(0, 20);
            this.edit_col4_lbl.TabIndex = 27;
            // 
            // edit_col5_lbl
            // 
            this.edit_col5_lbl.AutoSize = true;
            this.edit_col5_lbl.Location = new System.Drawing.Point(872, 54);
            this.edit_col5_lbl.Name = "edit_col5_lbl";
            this.edit_col5_lbl.Size = new System.Drawing.Size(0, 20);
            this.edit_col5_lbl.TabIndex = 26;
            // 
            // edit_col6_lbl
            // 
            this.edit_col6_lbl.AutoSize = true;
            this.edit_col6_lbl.Location = new System.Drawing.Point(1027, 54);
            this.edit_col6_lbl.Name = "edit_col6_lbl";
            this.edit_col6_lbl.Size = new System.Drawing.Size(0, 20);
            this.edit_col6_lbl.TabIndex = 25;
            // 
            // edit_col1_lbl
            // 
            this.edit_col1_lbl.AutoSize = true;
            this.edit_col1_lbl.Location = new System.Drawing.Point(252, 54);
            this.edit_col1_lbl.Name = "edit_col1_lbl";
            this.edit_col1_lbl.Size = new System.Drawing.Size(0, 20);
            this.edit_col1_lbl.TabIndex = 24;
            // 
            // edit_col6_tb
            // 
            this.edit_col6_tb.Enabled = false;
            this.edit_col6_tb.Location = new System.Drawing.Point(1031, 86);
            this.edit_col6_tb.Name = "edit_col6_tb";
            this.edit_col6_tb.Size = new System.Drawing.Size(120, 26);
            this.edit_col6_tb.TabIndex = 23;
            // 
            // edit_col2_tb
            // 
            this.edit_col2_tb.Enabled = false;
            this.edit_col2_tb.Location = new System.Drawing.Point(411, 84);
            this.edit_col2_tb.Name = "edit_col2_tb";
            this.edit_col2_tb.Size = new System.Drawing.Size(120, 26);
            this.edit_col2_tb.TabIndex = 17;
            // 
            // edit_col3_tb
            // 
            this.edit_col3_tb.Enabled = false;
            this.edit_col3_tb.Location = new System.Drawing.Point(566, 84);
            this.edit_col3_tb.Name = "edit_col3_tb";
            this.edit_col3_tb.Size = new System.Drawing.Size(120, 26);
            this.edit_col3_tb.TabIndex = 16;
            // 
            // edit_col4_tb
            // 
            this.edit_col4_tb.Enabled = false;
            this.edit_col4_tb.Location = new System.Drawing.Point(721, 84);
            this.edit_col4_tb.Name = "edit_col4_tb";
            this.edit_col4_tb.Size = new System.Drawing.Size(120, 26);
            this.edit_col4_tb.TabIndex = 15;
            // 
            // edit_col5_tb
            // 
            this.edit_col5_tb.Enabled = false;
            this.edit_col5_tb.Location = new System.Drawing.Point(876, 84);
            this.edit_col5_tb.Name = "edit_col5_tb";
            this.edit_col5_tb.Size = new System.Drawing.Size(120, 26);
            this.edit_col5_tb.TabIndex = 14;
            // 
            // edit_col1_tb
            // 
            this.edit_col1_tb.Enabled = false;
            this.edit_col1_tb.Location = new System.Drawing.Point(256, 84);
            this.edit_col1_tb.Name = "edit_col1_tb";
            this.edit_col1_tb.Size = new System.Drawing.Size(120, 26);
            this.edit_col1_tb.TabIndex = 13;
            // 
            // selected_table_lbl
            // 
            this.selected_table_lbl.AutoSize = true;
            this.selected_table_lbl.Location = new System.Drawing.Point(252, 131);
            this.selected_table_lbl.Name = "selected_table_lbl";
            this.selected_table_lbl.Size = new System.Drawing.Size(0, 20);
            this.selected_table_lbl.TabIndex = 12;
            // 
            // edit_btn
            // 
            this.edit_btn.Enabled = false;
            this.edit_btn.Location = new System.Drawing.Point(34, 565);
            this.edit_btn.Name = "edit_btn";
            this.edit_btn.Size = new System.Drawing.Size(144, 29);
            this.edit_btn.TabIndex = 11;
            this.edit_btn.Text = "Edit Row";
            this.edit_btn.UseVisualStyleBackColor = true;
            // 
            // delete_btn
            // 
            this.delete_btn.Enabled = false;
            this.delete_btn.Location = new System.Drawing.Point(34, 510);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(144, 29);
            this.delete_btn.TabIndex = 10;
            this.delete_btn.Text = "Delete Row";
            this.delete_btn.UseVisualStyleBackColor = true;
            this.delete_btn.Click += new System.EventHandler(this.delete_btn_Click);
            // 
            // insert_btn
            // 
            this.insert_btn.Enabled = false;
            this.insert_btn.Location = new System.Drawing.Point(34, 455);
            this.insert_btn.Name = "insert_btn";
            this.insert_btn.Size = new System.Drawing.Size(144, 29);
            this.insert_btn.TabIndex = 9;
            this.insert_btn.Text = "Insert Values";
            this.insert_btn.UseVisualStyleBackColor = true;
            this.insert_btn.Click += new System.EventHandler(this.insert_btn_Click);
            // 
            // edit_tables_lb
            // 
            this.edit_tables_lb.FormattingEnabled = true;
            this.edit_tables_lb.ItemHeight = 20;
            this.edit_tables_lb.Items.AddRange(new object[] {
            "Publishers",
            "Researchers",
            "Publications",
            "OpenReadingFrames",
            "Strains",
            "Species",
            "Proteins",
            "StructuralProteins",
            "NonStructuralProteins"});
            this.edit_tables_lb.Location = new System.Drawing.Point(22, 167);
            this.edit_tables_lb.Name = "edit_tables_lb";
            this.edit_tables_lb.Size = new System.Drawing.Size(169, 264);
            this.edit_tables_lb.TabIndex = 8;
            this.edit_tables_lb.SelectedIndexChanged += new System.EventHandler(this.edit_tables_lb_SelectedIndexChanged);
            // 
            // selected_table_lv
            // 
            this.selected_table_lv.FullRowSelect = true;
            this.selected_table_lv.Location = new System.Drawing.Point(256, 167);
            this.selected_table_lv.Name = "selected_table_lv";
            this.selected_table_lv.Size = new System.Drawing.Size(897, 428);
            this.selected_table_lv.TabIndex = 7;
            this.selected_table_lv.UseCompatibleStateImageBehavior = false;
            this.selected_table_lv.SelectedIndexChanged += new System.EventHandler(this.selected_table_lv_SelectedIndexChanged);
            // 
            // edit_rb
            // 
            this.edit_rb.AutoSize = true;
            this.edit_rb.Location = new System.Drawing.Point(22, 86);
            this.edit_rb.Name = "edit_rb";
            this.edit_rb.Size = new System.Drawing.Size(101, 24);
            this.edit_rb.TabIndex = 3;
            this.edit_rb.Text = "Edit Data";
            this.edit_rb.UseVisualStyleBackColor = true;
            this.edit_rb.CheckedChanged += new System.EventHandler(this.edit_rb_CheckedChanged);
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
            // delete_rb
            // 
            this.delete_rb.AutoSize = true;
            this.delete_rb.Location = new System.Drawing.Point(22, 54);
            this.delete_rb.Name = "delete_rb";
            this.delete_rb.Size = new System.Drawing.Size(120, 24);
            this.delete_rb.TabIndex = 1;
            this.delete_rb.Text = "Delete Data";
            this.delete_rb.UseVisualStyleBackColor = true;
            this.delete_rb.CheckedChanged += new System.EventHandler(this.delete_rb_CheckedChanged);
            // 
            // insert_rb
            // 
            this.insert_rb.AutoSize = true;
            this.insert_rb.Location = new System.Drawing.Point(22, 22);
            this.insert_rb.Name = "insert_rb";
            this.insert_rb.Size = new System.Drawing.Size(114, 24);
            this.insert_rb.TabIndex = 0;
            this.insert_rb.Text = "Insert Data";
            this.insert_rb.UseVisualStyleBackColor = true;
            this.insert_rb.CheckedChanged += new System.EventHandler(this.insert_rb_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 704);
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
        private System.Windows.Forms.Label edit_col2_lbl;
        private System.Windows.Forms.Label edit_col3_lbl;
        private System.Windows.Forms.Label edit_col4_lbl;
        private System.Windows.Forms.Label edit_col5_lbl;
        private System.Windows.Forms.Label edit_col6_lbl;
        private System.Windows.Forms.Label edit_col1_lbl;
        private System.Windows.Forms.TextBox edit_col6_tb;
        private System.Windows.Forms.TextBox edit_col2_tb;
        private System.Windows.Forms.TextBox edit_col3_tb;
        private System.Windows.Forms.TextBox edit_col4_tb;
        private System.Windows.Forms.TextBox edit_col5_tb;
        private System.Windows.Forms.TextBox edit_col1_tb;
        private System.Windows.Forms.Label selected_table_lbl;
        private System.Windows.Forms.Button edit_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button insert_btn;
        private System.Windows.Forms.ListBox edit_tables_lb;
        private System.Windows.Forms.ListView selected_table_lv;
        private System.Windows.Forms.RadioButton edit_rb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton delete_rb;
        private System.Windows.Forms.RadioButton insert_rb;
    }
}

