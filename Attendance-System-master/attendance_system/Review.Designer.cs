namespace Second_Year
{
    partial class Review
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
            this.Choose_comboBox = new System.Windows.Forms.ComboBox();
            this.allStud_panel = new System.Windows.Forms.Panel();
            this.stud_dgv = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.oneStudent_panel = new System.Windows.Forms.Panel();
            this.statusTxt = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.statTxt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.genderTxt = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.parentTxt = new System.Windows.Forms.TextBox();
            this.QuizesDGV = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.IdTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.phoneTxt = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gmailTxt = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.ClassesDGV = new System.Windows.Forms.DataGridView();
            this.typeOfSearch = new System.Windows.Forms.ComboBox();
            this.searchTxt = new System.Windows.Forms.TextBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.allStud_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stud_dgv)).BeginInit();
            this.oneStudent_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuizesDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassesDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // Choose_comboBox
            // 
            this.Choose_comboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Choose_comboBox.Font = new System.Drawing.Font("Rockwell", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Choose_comboBox.ForeColor = System.Drawing.Color.Teal;
            this.Choose_comboBox.FormattingEnabled = true;
            this.Choose_comboBox.Items.AddRange(new object[] {
            "All students",
            "Only one student"});
            this.Choose_comboBox.Location = new System.Drawing.Point(965, 5);
            this.Choose_comboBox.Margin = new System.Windows.Forms.Padding(4);
            this.Choose_comboBox.Name = "Choose_comboBox";
            this.Choose_comboBox.Size = new System.Drawing.Size(227, 32);
            this.Choose_comboBox.TabIndex = 4;
            this.Choose_comboBox.SelectedIndexChanged += new System.EventHandler(this.Choose_comboBox_SelectedIndexChanged);
            this.Choose_comboBox.SelectedValueChanged += new System.EventHandler(this.Choose_comboBox_SelectedValueChanged);
            // 
            // allStud_panel
            // 
            this.allStud_panel.Controls.Add(this.stud_dgv);
            this.allStud_panel.Controls.Add(this.label13);
            this.allStud_panel.Controls.Add(this.label12);
            this.allStud_panel.Controls.Add(this.label11);
            this.allStud_panel.Controls.Add(this.textBox5);
            this.allStud_panel.Controls.Add(this.textBox4);
            this.allStud_panel.Controls.Add(this.textBox3);
            this.allStud_panel.Controls.Add(this.textBox2);
            this.allStud_panel.Controls.Add(this.label10);
            this.allStud_panel.Controls.Add(this.textBox1);
            this.allStud_panel.Controls.Add(this.label9);
            this.allStud_panel.Controls.Add(this.button2);
            this.allStud_panel.Controls.Add(this.button1);
            this.allStud_panel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allStud_panel.ForeColor = System.Drawing.SystemColors.InfoText;
            this.allStud_panel.Location = new System.Drawing.Point(4, 85);
            this.allStud_panel.Margin = new System.Windows.Forms.Padding(4);
            this.allStud_panel.Name = "allStud_panel";
            this.allStud_panel.Size = new System.Drawing.Size(1188, 534);
            this.allStud_panel.TabIndex = 5;
            this.allStud_panel.Visible = false;
            // 
            // stud_dgv
            // 
            this.stud_dgv.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stud_dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stud_dgv.GridColor = System.Drawing.SystemColors.ButtonHighlight;
            this.stud_dgv.Location = new System.Drawing.Point(4, 4);
            this.stud_dgv.Margin = new System.Windows.Forms.Padding(4);
            this.stud_dgv.Name = "stud_dgv";
            this.stud_dgv.Size = new System.Drawing.Size(788, 465);
            this.stud_dgv.TabIndex = 17;
            this.stud_dgv.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.stud_dgv_RowHeaderMouseClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label13.Location = new System.Drawing.Point(812, 237);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(167, 29);
            this.label13.TabIndex = 16;
            this.label13.Text = "parent phone";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label12.Location = new System.Drawing.Point(818, 190);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(92, 29);
            this.label12.TabIndex = 15;
            this.label12.Text = " Status";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label11.Location = new System.Drawing.Point(818, 140);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(81, 29);
            this.label11.TabIndex = 14;
            this.label11.Text = "Gmail";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(993, 237);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(177, 34);
            this.textBox5.TabIndex = 13;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(993, 187);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(177, 34);
            this.textBox4.TabIndex = 12;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(993, 140);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(177, 34);
            this.textBox3.TabIndex = 11;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(993, 93);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 34);
            this.textBox2.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label10.Location = new System.Drawing.Point(818, 96);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(86, 29);
            this.label10.TabIndex = 9;
            this.label10.Text = "phone";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(993, 49);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(177, 34);
            this.textBox1.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.InfoText;
            this.label9.Location = new System.Drawing.Point(818, 54);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 29);
            this.label9.TabIndex = 7;
            this.label9.Text = " Name";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Teal;
            this.button2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button2.Location = new System.Drawing.Point(993, 345);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(179, 42);
            this.button2.TabIndex = 3;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Teal;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button1.Location = new System.Drawing.Point(817, 345);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 42);
            this.button1.TabIndex = 2;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oneStudent_panel
            // 
            this.oneStudent_panel.Controls.Add(this.statusTxt);
            this.oneStudent_panel.Controls.Add(this.panel7);
            this.oneStudent_panel.Controls.Add(this.statTxt);
            this.oneStudent_panel.Controls.Add(this.label8);
            this.oneStudent_panel.Controls.Add(this.label7);
            this.oneStudent_panel.Controls.Add(this.panel6);
            this.oneStudent_panel.Controls.Add(this.label6);
            this.oneStudent_panel.Controls.Add(this.genderTxt);
            this.oneStudent_panel.Controls.Add(this.panel5);
            this.oneStudent_panel.Controls.Add(this.label5);
            this.oneStudent_panel.Controls.Add(this.parentTxt);
            this.oneStudent_panel.Controls.Add(this.QuizesDGV);
            this.oneStudent_panel.Controls.Add(this.panel4);
            this.oneStudent_panel.Controls.Add(this.label4);
            this.oneStudent_panel.Controls.Add(this.IdTxt);
            this.oneStudent_panel.Controls.Add(this.label2);
            this.oneStudent_panel.Controls.Add(this.label1);
            this.oneStudent_panel.Controls.Add(this.panel3);
            this.oneStudent_panel.Controls.Add(this.label3);
            this.oneStudent_panel.Controls.Add(this.phoneTxt);
            this.oneStudent_panel.Controls.Add(this.panel1);
            this.oneStudent_panel.Controls.Add(this.gmailTxt);
            this.oneStudent_panel.Controls.Add(this.panel2);
            this.oneStudent_panel.Controls.Add(this.nameTxt);
            this.oneStudent_panel.Controls.Add(this.ClassesDGV);
            this.oneStudent_panel.Controls.Add(this.typeOfSearch);
            this.oneStudent_panel.Controls.Add(this.searchTxt);
            this.oneStudent_panel.Controls.Add(this.searchBtn);
            this.oneStudent_panel.ForeColor = System.Drawing.Color.Goldenrod;
            this.oneStudent_panel.Location = new System.Drawing.Point(8, 54);
            this.oneStudent_panel.Margin = new System.Windows.Forms.Padding(4);
            this.oneStudent_panel.Name = "oneStudent_panel";
            this.oneStudent_panel.Size = new System.Drawing.Size(1188, 594);
            this.oneStudent_panel.TabIndex = 6;
            this.oneStudent_panel.Visible = false;
            this.oneStudent_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.OneStudent_panel_Paint);
            // 
            // statusTxt
            // 
            this.statusTxt.AutoSize = true;
            this.statusTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusTxt.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.statusTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.statusTxt.Location = new System.Drawing.Point(867, 105);
            this.statusTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(74, 25);
            this.statusTxt.TabIndex = 71;
            this.statusTxt.Text = "Status";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Teal;
            this.panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel7.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel7.Location = new System.Drawing.Point(873, 160);
            this.panel7.Margin = new System.Windows.Forms.Padding(4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(279, 2);
            this.panel7.TabIndex = 70;
            // 
            // statTxt
            // 
            this.statTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.statTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statTxt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.statTxt.Location = new System.Drawing.Point(873, 138);
            this.statTxt.Margin = new System.Windows.Forms.Padding(4);
            this.statTxt.Name = "statTxt";
            this.statTxt.Size = new System.Drawing.Size(156, 23);
            this.statTxt.TabIndex = 69;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label8.Location = new System.Drawing.Point(15, 299);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 25);
            this.label8.TabIndex = 68;
            this.label8.Text = "Classes";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label7.Location = new System.Drawing.Point(615, 299);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 25);
            this.label7.TabIndex = 67;
            this.label7.Text = "Quizes";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Teal;
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Location = new System.Drawing.Point(877, 262);
            this.panel6.Margin = new System.Windows.Forms.Padding(4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(279, 2);
            this.panel6.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(872, 207);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 65;
            this.label6.Text = "Gender";
            // 
            // genderTxt
            // 
            this.genderTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.genderTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderTxt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.genderTxt.Location = new System.Drawing.Point(877, 240);
            this.genderTxt.Margin = new System.Windows.Forms.Padding(4);
            this.genderTxt.Name = "genderTxt";
            this.genderTxt.Size = new System.Drawing.Size(279, 23);
            this.genderTxt.TabIndex = 64;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Teal;
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Location = new System.Drawing.Point(436, 262);
            this.panel5.Margin = new System.Windows.Forms.Padding(4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(279, 2);
            this.panel5.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(431, 207);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 25);
            this.label5.TabIndex = 62;
            this.label5.Text = "Parent Phone Number";
            // 
            // parentTxt
            // 
            this.parentTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.parentTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parentTxt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.parentTxt.Location = new System.Drawing.Point(436, 240);
            this.parentTxt.Margin = new System.Windows.Forms.Padding(4);
            this.parentTxt.Name = "parentTxt";
            this.parentTxt.Size = new System.Drawing.Size(279, 23);
            this.parentTxt.TabIndex = 61;
            // 
            // QuizesDGV
            // 
            this.QuizesDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.QuizesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.QuizesDGV.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.QuizesDGV.Location = new System.Drawing.Point(619, 327);
            this.QuizesDGV.Margin = new System.Windows.Forms.Padding(4);
            this.QuizesDGV.Name = "QuizesDGV";
            this.QuizesDGV.Size = new System.Drawing.Size(559, 244);
            this.QuizesDGV.TabIndex = 60;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Teal;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Location = new System.Drawing.Point(27, 69);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(279, 2);
            this.panel4.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(22, 14);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 25);
            this.label4.TabIndex = 58;
            this.label4.Text = "ID";
            // 
            // IdTxt
            // 
            this.IdTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.IdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IdTxt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.IdTxt.Location = new System.Drawing.Point(27, 47);
            this.IdTxt.Margin = new System.Windows.Forms.Padding(4);
            this.IdTxt.Name = "IdTxt";
            this.IdTxt.Size = new System.Drawing.Size(279, 23);
            this.IdTxt.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(21, 207);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 56;
            this.label2.Text = "Gmail";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(21, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 55;
            this.label1.Text = "Name";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Location = new System.Drawing.Point(436, 160);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(279, 2);
            this.panel3.TabIndex = 54;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(431, 105);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 25);
            this.label3.TabIndex = 53;
            this.label3.Text = "Phone Number";
            // 
            // phoneTxt
            // 
            this.phoneTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.phoneTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phoneTxt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.phoneTxt.Location = new System.Drawing.Point(436, 138);
            this.phoneTxt.Margin = new System.Windows.Forms.Padding(4);
            this.phoneTxt.Name = "phoneTxt";
            this.phoneTxt.Size = new System.Drawing.Size(279, 23);
            this.phoneTxt.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Teal;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel1.Location = new System.Drawing.Point(27, 262);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(279, 2);
            this.panel1.TabIndex = 51;
            // 
            // gmailTxt
            // 
            this.gmailTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gmailTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gmailTxt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.gmailTxt.Location = new System.Drawing.Point(27, 240);
            this.gmailTxt.Margin = new System.Windows.Forms.Padding(4);
            this.gmailTxt.Name = "gmailTxt";
            this.gmailTxt.Size = new System.Drawing.Size(279, 23);
            this.gmailTxt.TabIndex = 50;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Teal;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.panel2.Location = new System.Drawing.Point(27, 160);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(279, 2);
            this.panel2.TabIndex = 49;
            // 
            // nameTxt
            // 
            this.nameTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.nameTxt.Location = new System.Drawing.Point(27, 138);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(279, 23);
            this.nameTxt.TabIndex = 48;
            // 
            // ClassesDGV
            // 
            this.ClassesDGV.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClassesDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClassesDGV.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.ClassesDGV.Location = new System.Drawing.Point(15, 327);
            this.ClassesDGV.Margin = new System.Windows.Forms.Padding(4);
            this.ClassesDGV.Name = "ClassesDGV";
            this.ClassesDGV.Size = new System.Drawing.Size(596, 244);
            this.ClassesDGV.TabIndex = 47;
            this.ClassesDGV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // typeOfSearch
            // 
            this.typeOfSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.typeOfSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeOfSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeOfSearch.ForeColor = System.Drawing.Color.Black;
            this.typeOfSearch.FormattingEnabled = true;
            this.typeOfSearch.ItemHeight = 25;
            this.typeOfSearch.Items.AddRange(new object[] {
            "By Id",
            "By Name"});
            this.typeOfSearch.Location = new System.Drawing.Point(310, 5);
            this.typeOfSearch.Margin = new System.Windows.Forms.Padding(4);
            this.typeOfSearch.Name = "typeOfSearch";
            this.typeOfSearch.Size = new System.Drawing.Size(160, 33);
            this.typeOfSearch.TabIndex = 46;
            this.typeOfSearch.SelectedIndexChanged += new System.EventHandler(this.typeOfSearch_SelectedIndexChanged);
            // 
            // searchTxt
            // 
            this.searchTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTxt.Location = new System.Drawing.Point(478, 5);
            this.searchTxt.Margin = new System.Windows.Forms.Padding(4);
            this.searchTxt.Multiline = true;
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(325, 34);
            this.searchTxt.TabIndex = 45;
            this.searchTxt.TextChanged += new System.EventHandler(this.searchTxt_TextChanged);
            // 
            // searchBtn
            // 
            this.searchBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.searchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.searchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchBtn.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.searchBtn.Location = new System.Drawing.Point(802, 5);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(144, 34);
            this.searchBtn.TabIndex = 44;
            this.searchBtn.Text = "Search";
            this.searchBtn.UseVisualStyleBackColor = false;
            this.searchBtn.Visible = false;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(822, 10);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(93, 29);
            this.label14.TabIndex = 7;
            this.label14.Text = "One/All";
            // 
            // Review
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label14);
            this.Controls.Add(this.Choose_comboBox);
            this.Controls.Add(this.oneStudent_panel);
            this.Controls.Add(this.allStud_panel);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Review";
            this.Size = new System.Drawing.Size(1212, 647);
            this.allStud_panel.ResumeLayout(false);
            this.allStud_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.stud_dgv)).EndInit();
            this.oneStudent_panel.ResumeLayout(false);
            this.oneStudent_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QuizesDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassesDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox Choose_comboBox;
        private System.Windows.Forms.Panel allStud_panel;
        private System.Windows.Forms.Panel oneStudent_panel;
        private System.Windows.Forms.DataGridView QuizesDGV;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox phoneTxt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox gmailTxt;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.DataGridView ClassesDGV;
        private System.Windows.Forms.ComboBox typeOfSearch;
        private System.Windows.Forms.TextBox searchTxt;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox genderTxt;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox parentTxt;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox IdTxt;
        private System.Windows.Forms.Label statusTxt;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox statTxt;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView stud_dgv;
        public System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button searchBtn;
    }
}
