namespace ChurchReservation.Resources
{
    partial class RegistrationFormFuneral
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
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lastnametx = new System.Windows.Forms.TextBox();
            this.firstnametx = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.registrationid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(398, 157);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 44);
            this.button2.TabIndex = 23;
            this.button2.Text = "NEXT";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Last name";
            // 
            // lastnametx
            // 
            this.lastnametx.Location = new System.Drawing.Point(321, 90);
            this.lastnametx.Name = "lastnametx";
            this.lastnametx.Size = new System.Drawing.Size(203, 20);
            this.lastnametx.TabIndex = 21;
            // 
            // firstnametx
            // 
            this.firstnametx.Location = new System.Drawing.Point(103, 90);
            this.firstnametx.Name = "firstnametx";
            this.firstnametx.Size = new System.Drawing.Size(203, 20);
            this.firstnametx.TabIndex = 20;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(312, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 31);
            this.button1.TabIndex = 19;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // registrationid
            // 
            this.registrationid.Location = new System.Drawing.Point(103, 15);
            this.registrationid.Name = "registrationid";
            this.registrationid.Size = new System.Drawing.Size(203, 20);
            this.registrationid.TabIndex = 18;
            // 
            // RegistrationFormFuneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 245);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lastnametx);
            this.Controls.Add(this.firstnametx);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.registrationid);
            this.Name = "RegistrationFormFuneral";
            this.Text = "RegistrationFormFuneral";
            this.Load += new System.EventHandler(this.RegistrationFormFuneral_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox lastnametx;
        private System.Windows.Forms.TextBox firstnametx;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox registrationid;
    }
}