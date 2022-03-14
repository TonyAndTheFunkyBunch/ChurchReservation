namespace ChurchReservation
{
    partial class LoginFrm
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
            this.passtext = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.usertext = new System.Windows.Forms.TextBox();
            this.check = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.logbtt = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.checking = new System.Windows.Forms.TextBox();
            this.statustext = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // passtext
            // 
            this.passtext.Enabled = false;
            this.passtext.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passtext.Location = new System.Drawing.Point(147, 112);
            this.passtext.Name = "passtext";
            this.passtext.PasswordChar = '*';
            this.passtext.Size = new System.Drawing.Size(272, 32);
            this.passtext.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(6, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 29);
            this.label1.TabIndex = 4;
            this.label1.Text = "Username:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button1.Location = new System.Drawing.Point(1262, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(62, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cancel);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.usertext);
            this.groupBox1.Controls.Add(this.check);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.passtext);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.logbtt);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(790, 394);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(525, 254);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "LOG IN";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // cancel
            // 
            this.cancel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.cancel.Location = new System.Drawing.Point(421, 77);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(84, 33);
            this.cancel.TabIndex = 11;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Visible = false;
            this.cancel.Click += new System.EventHandler(this.cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(134, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = " ";
            // 
            // usertext
            // 
            this.usertext.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usertext.Location = new System.Drawing.Point(147, 78);
            this.usertext.Name = "usertext";
            this.usertext.Size = new System.Drawing.Size(272, 32);
            this.usertext.TabIndex = 9;
            // 
            // check
            // 
            this.check.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.check.Location = new System.Drawing.Point(421, 76);
            this.check.Name = "check";
            this.check.Size = new System.Drawing.Size(84, 33);
            this.check.TabIndex = 7;
            this.check.Text = "check";
            this.check.UseVisualStyleBackColor = true;
            this.check.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(6, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Password:";
            // 
            // logbtt
            // 
            this.logbtt.BackgroundImage = global::ChurchReservation.Properties.Resources.Capture1;
            this.logbtt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logbtt.Location = new System.Drawing.Point(138, 169);
            this.logbtt.Name = "logbtt";
            this.logbtt.Size = new System.Drawing.Size(236, 64);
            this.logbtt.TabIndex = 2;
            this.logbtt.Text = " ";
            this.logbtt.UseVisualStyleBackColor = true;
            this.logbtt.Visible = false;
            this.logbtt.Click += new System.EventHandler(this.logbtt_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe Print", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(12, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(898, 85);
            this.label6.TabIndex = 8;
            this.label6.Text = "Saint Arnold Janssen Shrine Parish";
            // 
            // checking
            // 
            this.checking.Location = new System.Drawing.Point(27, 444);
            this.checking.Name = "checking";
            this.checking.Size = new System.Drawing.Size(100, 20);
            this.checking.TabIndex = 9;
            this.checking.Visible = false;
            // 
            // statustext
            // 
            this.statustext.Location = new System.Drawing.Point(27, 470);
            this.statustext.Name = "statustext";
            this.statustext.Size = new System.Drawing.Size(100, 20);
            this.statustext.TabIndex = 10;
            this.statustext.Visible = false;
            // 
            // LoginFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::ChurchReservation.Properties.Resources._12784450_1060624087314269_734985887_n;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1327, 660);
            this.Controls.Add(this.statustext);
            this.Controls.Add(this.checking);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.LoginFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox passtext;
        private System.Windows.Forms.Button logbtt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button check;
        private System.Windows.Forms.TextBox usertext;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox checking;
        private System.Windows.Forms.TextBox statustext;
    }
}

