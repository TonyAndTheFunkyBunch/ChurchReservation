namespace ChurchReservation
{
    partial class RegistrationForm
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
            this.registrationid = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.firstnametx = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lastnametx = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // registrationid
            // 
            this.registrationid.Location = new System.Drawing.Point(66, 100);
            this.registrationid.Name = "registrationid";
            this.registrationid.Size = new System.Drawing.Size(387, 35);
            this.registrationid.TabIndex = 0;
            this.registrationid.TextChanged += new System.EventHandler(this.registrationid_TextChanged);
            this.registrationid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.registrationid_KeyPress);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.MenuText;
            this.button1.Location = new System.Drawing.Point(23, 322);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // firstnametx
            // 
            this.firstnametx.Location = new System.Drawing.Point(61, 191);
            this.firstnametx.Name = "firstnametx";
            this.firstnametx.Size = new System.Drawing.Size(392, 35);
            this.firstnametx.TabIndex = 2;
            this.firstnametx.TextChanged += new System.EventHandler(this.firstnametx_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(61, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "* First name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(479, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(150, 29);
            this.label3.TabIndex = 7;
            this.label3.Text = "* Last name";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // lastnametx
            // 
            this.lastnametx.Location = new System.Drawing.Point(484, 191);
            this.lastnametx.Name = "lastnametx";
            this.lastnametx.Size = new System.Drawing.Size(392, 35);
            this.lastnametx.TabIndex = 6;
            this.lastnametx.TextChanged += new System.EventHandler(this.lastnametx_TextChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(723, 291);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(241, 66);
            this.button2.TabIndex = 10;
            this.button2.Text = "Done";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(61, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 29);
            this.label2.TabIndex = 11;
            this.label2.Text = "* Contact No";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(287, 291);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 35);
            this.textBox1.TabIndex = 12;
            this.textBox1.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Red;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.button3.Location = new System.Drawing.Point(902, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(62, 35);
            this.button3.TabIndex = 13;
            this.button3.Text = "X";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = global::ChurchReservation.Properties.Resources.abstract_color_background_picture_8016_wide;
            this.ClientSize = new System.Drawing.Size(976, 369);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastnametx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstnametx);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.registrationid);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegistrationForm";
            this.Load += new System.EventHandler(this.RegistrationForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox registrationid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox firstnametx;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastnametx;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}