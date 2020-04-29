namespace Second_Year
{
    partial class Classes_Quizes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Enter_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ex_name = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dayCB = new System.Windows.Forms.ComboBox();
            this.monthCB = new System.Windows.Forms.ComboBox();
            this.yearCB = new System.Windows.Forms.ComboBox();
            this.minutesCB = new System.Windows.Forms.ComboBox();
            this.hoursCB = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Enter_Btn
            // 
            this.Enter_Btn.BackColor = System.Drawing.Color.Teal;
            this.Enter_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Enter_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Enter_Btn.Location = new System.Drawing.Point(491, 247);
            this.Enter_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Enter_Btn.Name = "Enter_Btn";
            this.Enter_Btn.Size = new System.Drawing.Size(296, 37);
            this.Enter_Btn.TabIndex = 49;
            this.Enter_Btn.Text = "Search";
            this.Enter_Btn.UseVisualStyleBackColor = false;
            this.Enter_Btn.Click += new System.EventHandler(this.Enter_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 24);
            this.label2.TabIndex = 52;
            this.label2.Text = "Choose Time";
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(25, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 24);
            this.label3.TabIndex = 53;
            this.label3.Text = "Enter date";
            this.label3.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.dataGridView1.Location = new System.Drawing.Point(45, 348);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1016, 251);
            this.dataGridView1.TabIndex = 54;
            // 
            // ex_name
            // 
            this.ex_name.AutoSize = true;
            this.ex_name.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ex_name.Location = new System.Drawing.Point(25, 142);
            this.ex_name.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ex_name.Name = "ex_name";
            this.ex_name.Size = new System.Drawing.Size(135, 24);
            this.ex_name.TabIndex = 60;
            this.ex_name.Text = "Exam Name ";
            this.ex_name.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.textBox1.Location = new System.Drawing.Point(195, 138);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(221, 36);
            this.textBox1.TabIndex = 61;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "All Classes",
            "All Quizes",
            "Specific Quiz",
            "Specific Class"});
            this.comboBox1.Location = new System.Drawing.Point(473, 46);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(203, 33);
            this.comboBox1.TabIndex = 66;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 33);
            this.label1.TabIndex = 67;
            this.label1.Text = "Choose";
            // 
            // dayCB
            // 
            this.dayCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayCB.ForeColor = System.Drawing.Color.Teal;
            this.dayCB.FormattingEnabled = true;
            this.dayCB.Location = new System.Drawing.Point(357, 196);
            this.dayCB.Margin = new System.Windows.Forms.Padding(4);
            this.dayCB.Name = "dayCB";
            this.dayCB.Size = new System.Drawing.Size(72, 32);
            this.dayCB.TabIndex = 70;
            this.dayCB.Visible = false;
            // 
            // monthCB
            // 
            this.monthCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCB.ForeColor = System.Drawing.Color.Teal;
            this.monthCB.FormattingEnabled = true;
            this.monthCB.Location = new System.Drawing.Point(275, 196);
            this.monthCB.Margin = new System.Windows.Forms.Padding(4);
            this.monthCB.Name = "monthCB";
            this.monthCB.Size = new System.Drawing.Size(77, 32);
            this.monthCB.TabIndex = 69;
            this.monthCB.Visible = false;
            // 
            // yearCB
            // 
            this.yearCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearCB.ForeColor = System.Drawing.Color.Teal;
            this.yearCB.FormattingEnabled = true;
            this.yearCB.Location = new System.Drawing.Point(177, 196);
            this.yearCB.Margin = new System.Windows.Forms.Padding(4);
            this.yearCB.Name = "yearCB";
            this.yearCB.Size = new System.Drawing.Size(95, 32);
            this.yearCB.TabIndex = 68;
            this.yearCB.Visible = false;
            // 
            // minutesCB
            // 
            this.minutesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minutesCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesCB.ForeColor = System.Drawing.Color.Teal;
            this.minutesCB.FormattingEnabled = true;
            this.minutesCB.Location = new System.Drawing.Point(288, 259);
            this.minutesCB.Margin = new System.Windows.Forms.Padding(4);
            this.minutesCB.Name = "minutesCB";
            this.minutesCB.Size = new System.Drawing.Size(72, 32);
            this.minutesCB.TabIndex = 71;
            this.minutesCB.Visible = false;
            // 
            // hoursCB
            // 
            this.hoursCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hoursCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursCB.ForeColor = System.Drawing.Color.Teal;
            this.hoursCB.FormattingEnabled = true;
            this.hoursCB.Location = new System.Drawing.Point(206, 259);
            this.hoursCB.Margin = new System.Windows.Forms.Padding(4);
            this.hoursCB.Name = "hoursCB";
            this.hoursCB.Size = new System.Drawing.Size(77, 32);
            this.hoursCB.TabIndex = 72;
            this.hoursCB.Visible = false;
            // 
            // Classes_Quizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.minutesCB);
            this.Controls.Add(this.hoursCB);
            this.Controls.Add(this.dayCB);
            this.Controls.Add(this.monthCB);
            this.Controls.Add(this.yearCB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.ex_name);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Enter_Btn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Classes_Quizes";
            this.Size = new System.Drawing.Size(1407, 646);
            this.Load += new System.EventHandler(this.Classes_Quizes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Enter_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label ex_name;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox dayCB;
        private System.Windows.Forms.ComboBox monthCB;
        private System.Windows.Forms.ComboBox yearCB;
        private System.Windows.Forms.ComboBox minutesCB;
        private System.Windows.Forms.ComboBox hoursCB;
    }
}
