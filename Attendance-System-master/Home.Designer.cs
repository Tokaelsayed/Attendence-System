namespace attendance_system
{
    partial class Home
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
            this.Review_btn = new System.Windows.Forms.Button();
            this.Attendance_btn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_btn = new System.Windows.Forms.Button();
            this.search_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Review_btn
            // 
            this.Review_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Review_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Review_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Review_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Review_btn.Location = new System.Drawing.Point(8, 2);
            this.Review_btn.Name = "Review_btn";
            this.Review_btn.Size = new System.Drawing.Size(222, 44);
            this.Review_btn.TabIndex = 0;
            this.Review_btn.Text = "Review";
            this.Review_btn.UseVisualStyleBackColor = false;
            this.Review_btn.Click += new System.EventHandler(this.Review_btn_Click);
            // 
            // Attendance_btn
            // 
            this.Attendance_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.Attendance_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Attendance_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Attendance_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Attendance_btn.Location = new System.Drawing.Point(236, 2);
            this.Attendance_btn.Name = "Attendance_btn";
            this.Attendance_btn.Size = new System.Drawing.Size(222, 44);
            this.Attendance_btn.TabIndex = 1;
            this.Attendance_btn.Text = "Attendance";
            this.Attendance_btn.UseVisualStyleBackColor = false;
            this.Attendance_btn.Click += new System.EventHandler(this.Attendance_btn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Location = new System.Drawing.Point(6, 52);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(908, 470);
            this.panel1.TabIndex = 2;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // add_btn
            // 
            this.add_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.add_btn.Location = new System.Drawing.Point(464, 2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(222, 44);
            this.add_btn.TabIndex = 1;
            this.add_btn.Text = "Add Student";
            this.add_btn.UseVisualStyleBackColor = false;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.SteelBlue;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.search_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.search_btn.Location = new System.Drawing.Point(692, 2);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(222, 44);
            this.search_btn.TabIndex = 3;
            this.search_btn.Text = "Search for a Student";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Attendance_btn);
            this.Controls.Add(this.Review_btn);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(919, 527);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Review_btn;
        private System.Windows.Forms.Button Attendance_btn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add_btn;
        private System.Windows.Forms.Button search_btn;
    }
}
