namespace ChurchReservation
{
    partial class Accounts
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lvlofaccess = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Lnametx = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.fnametx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clearbtn = new System.Windows.Forms.Button();
            this.Checkpass = new System.Windows.Forms.Button();
            this.Checkuser = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Passwordtb = new System.Windows.Forms.TextBox();
            this.Usernametb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.lvlofaccess);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Lnametx);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.fnametx);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.listView1);
            this.groupBox1.Controls.Add(this.clearbtn);
            this.groupBox1.Controls.Add(this.Checkpass);
            this.groupBox1.Controls.Add(this.Checkuser);
            this.groupBox1.Controls.Add(this.Savebtn);
            this.groupBox1.Controls.Add(this.Passwordtb);
            this.groupBox1.Controls.Add(this.Usernametb);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1285, 652);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Creating New Account";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ChurchReservation.Properties.Resources.Capture;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(544, 465);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(177, 55);
            this.button3.TabIndex = 39;
            this.button3.Text = "  Cancel";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(495, 404);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 34);
            this.button2.TabIndex = 38;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lvlofaccess
            // 
            this.lvlofaccess.Enabled = false;
            this.lvlofaccess.FormattingEnabled = true;
            this.lvlofaccess.Items.AddRange(new object[] {
            "Admin",
            "Client"});
            this.lvlofaccess.Location = new System.Drawing.Point(178, 404);
            this.lvlofaccess.Name = "lvlofaccess";
            this.lvlofaccess.Size = new System.Drawing.Size(177, 33);
            this.lvlofaccess.TabIndex = 37;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 412);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(168, 25);
            this.label5.TabIndex = 36;
            this.label5.Text = "Level of access:";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ChurchReservation.Properties.Resources.Capture;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(1102, 591);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(177, 55);
            this.button1.TabIndex = 31;
            this.button1.Text = "  Back";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // Lnametx
            // 
            this.Lnametx.Location = new System.Drawing.Point(178, 262);
            this.Lnametx.Name = "Lnametx";
            this.Lnametx.Size = new System.Drawing.Size(360, 31);
            this.Lnametx.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 265);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 25);
            this.label4.TabIndex = 34;
            this.label4.Text = "Last name:";
            // 
            // fnametx
            // 
            this.fnametx.Location = new System.Drawing.Point(178, 218);
            this.fnametx.Name = "fnametx";
            this.fnametx.Size = new System.Drawing.Size(360, 31);
            this.fnametx.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 25);
            this.label3.TabIndex = 32;
            this.label3.Text = "First name:";
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.ForeColor = System.Drawing.SystemColors.Window;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(20, 30);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1259, 152);
            this.listView1.TabIndex = 31;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Username";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Password";
            this.columnHeader2.Width = 200;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Firstname";
            this.columnHeader3.Width = 200;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Lastname";
            this.columnHeader4.Width = 200;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Level of access";
            this.columnHeader5.Width = 200;
            // 
            // clearbtn
            // 
            this.clearbtn.BackgroundImage = global::ChurchReservation.Properties.Resources.Capture;
            this.clearbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.clearbtn.Location = new System.Drawing.Point(361, 465);
            this.clearbtn.Name = "clearbtn";
            this.clearbtn.Size = new System.Drawing.Size(177, 55);
            this.clearbtn.TabIndex = 30;
            this.clearbtn.Text = "  Clear";
            this.clearbtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.clearbtn.UseVisualStyleBackColor = true;
            this.clearbtn.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Checkpass
            // 
            this.Checkpass.BackColor = System.Drawing.Color.Black;
            this.Checkpass.Location = new System.Drawing.Point(361, 404);
            this.Checkpass.Name = "Checkpass";
            this.Checkpass.Size = new System.Drawing.Size(128, 34);
            this.Checkpass.TabIndex = 29;
            this.Checkpass.Text = "Done";
            this.Checkpass.UseVisualStyleBackColor = false;
            this.Checkpass.Click += new System.EventHandler(this.Checkpass_Click);
            // 
            // Checkuser
            // 
            this.Checkuser.BackColor = System.Drawing.Color.Black;
            this.Checkuser.Location = new System.Drawing.Point(544, 306);
            this.Checkuser.Name = "Checkuser";
            this.Checkuser.Size = new System.Drawing.Size(128, 34);
            this.Checkuser.TabIndex = 28;
            this.Checkuser.Text = "Check";
            this.Checkuser.UseVisualStyleBackColor = false;
            this.Checkuser.Click += new System.EventHandler(this.button3_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.BackgroundImage = global::ChurchReservation.Properties.Resources.Capture;
            this.Savebtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.Savebtn.Location = new System.Drawing.Point(178, 465);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(177, 55);
            this.Savebtn.TabIndex = 25;
            this.Savebtn.Text = "  Save";
            this.Savebtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // Passwordtb
            // 
            this.Passwordtb.Location = new System.Drawing.Point(178, 359);
            this.Passwordtb.Name = "Passwordtb";
            this.Passwordtb.PasswordChar = '*';
            this.Passwordtb.Size = new System.Drawing.Size(360, 31);
            this.Passwordtb.TabIndex = 4;
            // 
            // Usernametb
            // 
            this.Usernametb.Location = new System.Drawing.Point(178, 309);
            this.Usernametb.Name = "Usernametb";
            this.Usernametb.Size = new System.Drawing.Size(360, 31);
            this.Usernametb.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(60, 359);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(902, 591);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 31);
            this.textBox1.TabIndex = 40;
            this.textBox1.Visible = false;
            // 
            // Accounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1309, 676);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Accounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Accounts";
            this.Load += new System.EventHandler(this.Accounts_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Passwordtb;
        private System.Windows.Forms.TextBox Usernametb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.Button Checkpass;
        private System.Windows.Forms.Button Checkuser;
        private System.Windows.Forms.Button clearbtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox lvlofaccess;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Lnametx;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox fnametx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
    }
}