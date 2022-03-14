namespace ChurchReservation
{
    partial class BaptismInstallment
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
            this.contactno = new System.Windows.Forms.TextBox();
            this.holder = new System.Windows.Forms.TextBox();
            this.PaymentGroup = new System.Windows.Forms.GroupBox();
            this.paymentt = new System.Windows.Forms.TextBox();
            this.totaltextt = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.moneytext = new System.Windows.Forms.TextBox();
            this.givenmoney = new System.Windows.Forms.Label();
            this.moneytobepay = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchbtn = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.paybtn = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.PaymentGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // contactno
            // 
            this.contactno.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.contactno.Location = new System.Drawing.Point(481, 82);
            this.contactno.Name = "contactno";
            this.contactno.Size = new System.Drawing.Size(100, 20);
            this.contactno.TabIndex = 12;
            this.contactno.Visible = false;
            // 
            // holder
            // 
            this.holder.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.holder.Location = new System.Drawing.Point(481, 56);
            this.holder.Name = "holder";
            this.holder.Size = new System.Drawing.Size(100, 20);
            this.holder.TabIndex = 11;
            this.holder.Visible = false;
            // 
            // PaymentGroup
            // 
            this.PaymentGroup.BackColor = System.Drawing.Color.Transparent;
            this.PaymentGroup.Controls.Add(this.paybtn);
            this.PaymentGroup.Controls.Add(this.paymentt);
            this.PaymentGroup.Controls.Add(this.totaltextt);
            this.PaymentGroup.Controls.Add(this.label6);
            this.PaymentGroup.Controls.Add(this.label5);
            this.PaymentGroup.Controls.Add(this.groupBox3);
            this.PaymentGroup.Controls.Add(this.givenmoney);
            this.PaymentGroup.Controls.Add(this.moneytobepay);
            this.PaymentGroup.Controls.Add(this.label4);
            this.PaymentGroup.Controls.Add(this.label3);
            this.PaymentGroup.Controls.Add(this.label2);
            this.PaymentGroup.Controls.Add(this.label1);
            this.PaymentGroup.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentGroup.ForeColor = System.Drawing.SystemColors.Control;
            this.PaymentGroup.Location = new System.Drawing.Point(18, 215);
            this.PaymentGroup.Name = "PaymentGroup";
            this.PaymentGroup.Size = new System.Drawing.Size(1023, 418);
            this.PaymentGroup.TabIndex = 10;
            this.PaymentGroup.TabStop = false;
            this.PaymentGroup.Text = "Payment";
            this.PaymentGroup.Visible = false;
            // 
            // paymentt
            // 
            this.paymentt.Enabled = false;
            this.paymentt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paymentt.Location = new System.Drawing.Point(116, 195);
            this.paymentt.Name = "paymentt";
            this.paymentt.Size = new System.Drawing.Size(240, 40);
            this.paymentt.TabIndex = 10;
            // 
            // totaltextt
            // 
            this.totaltextt.Enabled = false;
            this.totaltextt.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totaltextt.Location = new System.Drawing.Point(116, 149);
            this.totaltextt.Name = "totaltextt";
            this.totaltextt.Size = new System.Drawing.Size(240, 40);
            this.totaltextt.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 159);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 25);
            this.label6.TabIndex = 8;
            this.label6.Text = "Balance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Change";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.button3);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.button2);
            this.groupBox3.Controls.Add(this.moneytext);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox3.Location = new System.Drawing.Point(6, 329);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(999, 79);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Payment";
            // 
            // moneytext
            // 
            this.moneytext.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moneytext.Location = new System.Drawing.Point(6, 30);
            this.moneytext.Name = "moneytext";
            this.moneytext.Size = new System.Drawing.Size(364, 40);
            this.moneytext.TabIndex = 7;
            this.moneytext.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.moneytext_KeyPress);
            // 
            // givenmoney
            // 
            this.givenmoney.AutoSize = true;
            this.givenmoney.ForeColor = System.Drawing.SystemColors.Control;
            this.givenmoney.Location = new System.Drawing.Point(221, 110);
            this.givenmoney.Name = "givenmoney";
            this.givenmoney.Size = new System.Drawing.Size(19, 25);
            this.givenmoney.TabIndex = 5;
            this.givenmoney.Text = " ";
            // 
            // moneytobepay
            // 
            this.moneytobepay.AutoSize = true;
            this.moneytobepay.ForeColor = System.Drawing.SystemColors.Control;
            this.moneytobepay.Location = new System.Drawing.Point(221, 58);
            this.moneytobepay.Name = "moneytobepay";
            this.moneytobepay.Size = new System.Drawing.Size(19, 25);
            this.moneytobepay.TabIndex = 4;
            this.moneytobepay.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(184, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "-";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(184, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "-";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(17, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Given money";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(17, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total payment";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.searchbtn);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(18, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 78);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // searchbtn
            // 
            this.searchbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchbtn.Location = new System.Drawing.Point(14, 28);
            this.searchbtn.Name = "searchbtn";
            this.searchbtn.Size = new System.Drawing.Size(399, 40);
            this.searchbtn.TabIndex = 0;
            this.searchbtn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchbtn_KeyPress);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader10,
            this.columnHeader11});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.ForeColor = System.Drawing.SystemColors.Menu;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(18, 112);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1023, 97);
            this.listView1.TabIndex = 8;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Contact";
            this.columnHeader1.Width = 97;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Status";
            this.columnHeader2.Width = 103;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Firstname";
            this.columnHeader3.Width = 174;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Middlename";
            this.columnHeader4.Width = 187;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Lastname";
            this.columnHeader10.Width = 173;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Balance";
            this.columnHeader11.Width = 172;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(871, 28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 13;
            this.textBox1.Visible = false;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::ChurchReservation.Properties.Resources.Capture;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.SystemColors.Control;
            this.button4.Location = new System.Drawing.Point(849, 7);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(204, 57);
            this.button4.TabIndex = 19;
            this.button4.Text = "Back";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // paybtn
            // 
            this.paybtn.BackgroundImage = global::ChurchReservation.Properties.Resources.Capture;
            this.paybtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.paybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paybtn.ForeColor = System.Drawing.SystemColors.Control;
            this.paybtn.Location = new System.Drawing.Point(116, 241);
            this.paybtn.Name = "paybtn";
            this.paybtn.Size = new System.Drawing.Size(204, 57);
            this.paybtn.TabIndex = 18;
            this.paybtn.Text = "Pay";
            this.paybtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.paybtn.UseVisualStyleBackColor = true;
            this.paybtn.Click += new System.EventHandler(this.paybtn_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::ChurchReservation.Properties.Resources.Capture;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.SystemColors.Control;
            this.button3.Location = new System.Drawing.Point(586, 16);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(204, 57);
            this.button3.TabIndex = 19;
            this.button3.Text = " Cancel";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::ChurchReservation.Properties.Resources.Capture;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Location = new System.Drawing.Point(376, 16);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(204, 57);
            this.button1.TabIndex = 8;
            this.button1.Text = "  Check";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = global::ChurchReservation.Properties.Resources.Capture;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.Control;
            this.button2.Location = new System.Drawing.Point(376, 16);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(204, 57);
            this.button2.TabIndex = 10;
            this.button2.Text = "  Clear";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // BaptismInstallment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(1065, 656);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.contactno);
            this.Controls.Add(this.holder);
            this.Controls.Add(this.PaymentGroup);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BaptismInstallment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BaptismInstallment";
            this.Load += new System.EventHandler(this.BaptismInstallment_Load);
            this.PaymentGroup.ResumeLayout(false);
            this.PaymentGroup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox contactno;
        private System.Windows.Forms.TextBox holder;
        private System.Windows.Forms.GroupBox PaymentGroup;
        private System.Windows.Forms.Button paybtn;
        private System.Windows.Forms.TextBox paymentt;
        private System.Windows.Forms.TextBox totaltextt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox moneytext;
        private System.Windows.Forms.Label givenmoney;
        private System.Windows.Forms.Label moneytobepay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox searchbtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox1;

    }
}