namespace hotelMgtSyst_Accounting
{
    partial class Logon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Logon));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.password_txt = new System.Windows.Forms.TextBox();
            this.username_txt = new System.Windows.Forms.TextBox();
            this.logon_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(216, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(292, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Adobe Fangsong Std R", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 44);
            this.label1.TabIndex = 1;
            this.label1.Text = "ACCOUNTS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // password_txt
            // 
            this.password_txt.Location = new System.Drawing.Point(248, 328);
            this.password_txt.Name = "password_txt";
            this.password_txt.Size = new System.Drawing.Size(216, 20);
            this.password_txt.TabIndex = 2;
            this.password_txt.TextChanged += new System.EventHandler(this.password_txt_TextChanged);
            // 
            // username_txt
            // 
            this.username_txt.Location = new System.Drawing.Point(248, 292);
            this.username_txt.Name = "username_txt";
            this.username_txt.Size = new System.Drawing.Size(216, 20);
            this.username_txt.TabIndex = 3;
            // 
            // logon_btn
            // 
            this.logon_btn.Location = new System.Drawing.Point(248, 384);
            this.logon_btn.Name = "logon_btn";
            this.logon_btn.Size = new System.Drawing.Size(216, 23);
            this.logon_btn.TabIndex = 4;
            this.logon_btn.Text = "Logon";
            this.logon_btn.UseVisualStyleBackColor = true;
            this.logon_btn.Click += new System.EventHandler(this.logon_btn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(248, 252);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Username: t";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(400, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password: t";
            // 
            // Logon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(685, 604);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.logon_btn);
            this.Controls.Add(this.username_txt);
            this.Controls.Add(this.password_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Logon";
            this.Text = "Logon";
            this.Load += new System.EventHandler(this.Logon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox password_txt;
        private System.Windows.Forms.TextBox username_txt;
        private System.Windows.Forms.Button logon_btn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

