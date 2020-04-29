namespace Second_Year
{
    partial class Attendance
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.GB = new System.Windows.Forms.GroupBox();
            this.last_C = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.last_Q = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultNameTxt = new System.Windows.Forms.TextBox();
            this.QrPic = new System.Windows.Forms.PictureBox();
            this.Enter_Btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yearCB = new System.Windows.Forms.ComboBox();
            this.monthCB = new System.Windows.Forms.ComboBox();
            this.dayCB = new System.Windows.Forms.ComboBox();
            this.minutesCB = new System.Windows.Forms.ComboBox();
            this.hoursCB = new System.Windows.Forms.ComboBox();
            this.GB.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QrPic)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // GB
            // 
            this.GB.Controls.Add(this.last_C);
            this.GB.Controls.Add(this.label4);
            this.GB.Controls.Add(this.last_Q);
            this.GB.Controls.Add(this.label3);
            this.GB.Controls.Add(this.resultNameTxt);
            this.GB.Controls.Add(this.QrPic);
            this.GB.Enabled = false;
            this.GB.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.GB.Location = new System.Drawing.Point(9, 59);
            this.GB.Margin = new System.Windows.Forms.Padding(4);
            this.GB.Name = "GB";
            this.GB.Padding = new System.Windows.Forms.Padding(4);
            this.GB.Size = new System.Drawing.Size(1189, 559);
            this.GB.TabIndex = 54;
            this.GB.TabStop = false;
            // 
            // last_C
            // 
            this.last_C.ForeColor = System.Drawing.Color.MidnightBlue;
            this.last_C.Location = new System.Drawing.Point(1040, 227);
            this.last_C.Margin = new System.Windows.Forms.Padding(4);
            this.last_C.Multiline = true;
            this.last_C.Name = "last_C";
            this.last_C.Size = new System.Drawing.Size(97, 45);
            this.last_C.TabIndex = 53;
            this.last_C.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(900, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(133, 29);
            this.label4.TabIndex = 52;
            this.label4.Text = "Last Class";
            // 
            // last_Q
            // 
            this.last_Q.ForeColor = System.Drawing.Color.MidnightBlue;
            this.last_Q.Location = new System.Drawing.Point(1040, 159);
            this.last_Q.Margin = new System.Windows.Forms.Padding(4);
            this.last_Q.Multiline = true;
            this.last_Q.Name = "last_Q";
            this.last_Q.Size = new System.Drawing.Size(97, 45);
            this.last_Q.TabIndex = 51;
            this.last_Q.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(900, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 29);
            this.label3.TabIndex = 50;
            this.label3.Text = "Last Quiz";
            // 
            // resultNameTxt
            // 
            this.resultNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultNameTxt.ForeColor = System.Drawing.Color.MidnightBlue;
            this.resultNameTxt.Location = new System.Drawing.Point(831, 42);
            this.resultNameTxt.Margin = new System.Windows.Forms.Padding(4);
            this.resultNameTxt.Multiline = true;
            this.resultNameTxt.Name = "resultNameTxt";
            this.resultNameTxt.ReadOnly = true;
            this.resultNameTxt.Size = new System.Drawing.Size(341, 53);
            this.resultNameTxt.TabIndex = 45;
            this.resultNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // QrPic
            // 
            this.QrPic.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.QrPic.Location = new System.Drawing.Point(11, 18);
            this.QrPic.Margin = new System.Windows.Forms.Padding(4);
            this.QrPic.Name = "QrPic";
            this.QrPic.Size = new System.Drawing.Size(801, 520);
            this.QrPic.TabIndex = 38;
            this.QrPic.TabStop = false;
            // 
            // Enter_Btn
            // 
            this.Enter_Btn.BackColor = System.Drawing.Color.Teal;
            this.Enter_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Enter_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enter_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Enter_Btn.Location = new System.Drawing.Point(840, 9);
            this.Enter_Btn.Margin = new System.Windows.Forms.Padding(4);
            this.Enter_Btn.Name = "Enter_Btn";
            this.Enter_Btn.Size = new System.Drawing.Size(296, 43);
            this.Enter_Btn.TabIndex = 53;
            this.Enter_Btn.Text = "Enter";
            this.Enter_Btn.UseVisualStyleBackColor = false;
            this.Enter_Btn.Click += new System.EventHandler(this.Enter_Btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(505, 15);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 29);
            this.label2.TabIndex = 52;
            this.label2.Text = "Time :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(156, 15);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 29);
            this.label1.TabIndex = 51;
            this.label1.Text = "Date :";
            // 
            // yearCB
            // 
            this.yearCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearCB.ForeColor = System.Drawing.Color.Teal;
            this.yearCB.FormattingEnabled = true;
            this.yearCB.Location = new System.Drawing.Point(231, 10);
            this.yearCB.Margin = new System.Windows.Forms.Padding(4);
            this.yearCB.Name = "yearCB";
            this.yearCB.Size = new System.Drawing.Size(95, 32);
            this.yearCB.TabIndex = 55;
            // 
            // monthCB
            // 
            this.monthCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.monthCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.monthCB.ForeColor = System.Drawing.Color.Teal;
            this.monthCB.FormattingEnabled = true;
            this.monthCB.Location = new System.Drawing.Point(329, 10);
            this.monthCB.Margin = new System.Windows.Forms.Padding(4);
            this.monthCB.Name = "monthCB";
            this.monthCB.Size = new System.Drawing.Size(77, 32);
            this.monthCB.TabIndex = 56;
            // 
            // dayCB
            // 
            this.dayCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dayCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dayCB.ForeColor = System.Drawing.Color.Teal;
            this.dayCB.FormattingEnabled = true;
            this.dayCB.Location = new System.Drawing.Point(411, 10);
            this.dayCB.Margin = new System.Windows.Forms.Padding(4);
            this.dayCB.Name = "dayCB";
            this.dayCB.Size = new System.Drawing.Size(72, 32);
            this.dayCB.TabIndex = 56;
            // 
            // minutesCB
            // 
            this.minutesCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.minutesCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minutesCB.ForeColor = System.Drawing.Color.Teal;
            this.minutesCB.FormattingEnabled = true;
            this.minutesCB.Location = new System.Drawing.Point(679, 10);
            this.minutesCB.Margin = new System.Windows.Forms.Padding(4);
            this.minutesCB.Name = "minutesCB";
            this.minutesCB.Size = new System.Drawing.Size(72, 32);
            this.minutesCB.TabIndex = 57;
            // 
            // hoursCB
            // 
            this.hoursCB.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.hoursCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hoursCB.ForeColor = System.Drawing.Color.Teal;
            this.hoursCB.FormattingEnabled = true;
            this.hoursCB.Location = new System.Drawing.Point(597, 10);
            this.hoursCB.Margin = new System.Windows.Forms.Padding(4);
            this.hoursCB.Name = "hoursCB";
            this.hoursCB.Size = new System.Drawing.Size(77, 32);
            this.hoursCB.TabIndex = 58;
            // 
            // Attendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.minutesCB);
            this.Controls.Add(this.hoursCB);
            this.Controls.Add(this.dayCB);
            this.Controls.Add(this.monthCB);
            this.Controls.Add(this.yearCB);
            this.Controls.Add(this.GB);
            this.Controls.Add(this.Enter_Btn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Attendance";
            this.Size = new System.Drawing.Size(1212, 647);
            this.Load += new System.EventHandler(this.Attendance_Load);
            this.GB.ResumeLayout(false);
            this.GB.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.QrPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox GB;
        private System.Windows.Forms.TextBox resultNameTxt;
        private System.Windows.Forms.PictureBox QrPic;
        private System.Windows.Forms.Button Enter_Btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox yearCB;
        private System.Windows.Forms.ComboBox monthCB;
        private System.Windows.Forms.ComboBox dayCB;
        private System.Windows.Forms.ComboBox minutesCB;
        private System.Windows.Forms.ComboBox hoursCB;
        private System.Windows.Forms.TextBox last_C;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox last_Q;
        private System.Windows.Forms.Label label3;
    }
}
