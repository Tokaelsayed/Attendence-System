namespace Second_Year
{
    partial class QrGenerator
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
            this.Generate_Btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nameTxt = new System.Windows.Forms.TextBox();
            this.LinkTxt = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Generate_Btn
            // 
            this.Generate_Btn.BackColor = System.Drawing.Color.Teal;
            this.Generate_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Generate_Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Generate_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Generate_Btn.Location = new System.Drawing.Point(459, 482);
            this.Generate_Btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Generate_Btn.Name = "Generate_Btn";
            this.Generate_Btn.Size = new System.Drawing.Size(296, 43);
            this.Generate_Btn.TabIndex = 49;
            this.Generate_Btn.Text = "Generate";
            this.Generate_Btn.UseVisualStyleBackColor = false;
            this.Generate_Btn.Click += new System.EventHandler(this.Generate_Btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(433, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(333, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 47;
            this.pictureBox1.TabStop = false;
            // 
            // nameTxt
            // 
            this.nameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.nameTxt.Location = new System.Drawing.Point(369, 428);
            this.nameTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nameTxt.Multiline = true;
            this.nameTxt.Name = "nameTxt";
            this.nameTxt.Size = new System.Drawing.Size(460, 37);
            this.nameTxt.TabIndex = 51;
            this.nameTxt.Text = "Name of Qr pic";
            this.nameTxt.Click += new System.EventHandler(this.nameTxt_Click);
            this.nameTxt.Leave += new System.EventHandler(this.nameTxt_Leave);
            // 
            // LinkTxt
            // 
            this.LinkTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LinkTxt.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.LinkTxt.Location = new System.Drawing.Point(369, 383);
            this.LinkTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.LinkTxt.Multiline = true;
            this.LinkTxt.Name = "LinkTxt";
            this.LinkTxt.Size = new System.Drawing.Size(460, 37);
            this.LinkTxt.TabIndex = 50;
            this.LinkTxt.Text = "https://******";
            this.LinkTxt.Click += new System.EventHandler(this.LinkTxt_Click);
            this.LinkTxt.Leave += new System.EventHandler(this.LinkTxt_Leave);
            // 
            // QrGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.nameTxt);
            this.Controls.Add(this.LinkTxt);
            this.Controls.Add(this.Generate_Btn);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "QrGenerator";
            this.Size = new System.Drawing.Size(1215, 534);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Generate_Btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox nameTxt;
        private System.Windows.Forms.TextBox LinkTxt;
    }
}
