using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ChurchReservation
{
    public partial class AccountForm : Form
    {
        public AccountForm()
        {
            InitializeComponent();
        }

        public string accountform;

        private void button3_Click(object sender, EventArgs e)
        {
            MoreForm mf = new MoreForm();
            mf.setting = textBox1.Text;
            mf.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Accounts acc = new Accounts();
            acc.accounts = textBox1.Text;
            acc.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountSetting acc = new AccountSetting();
            acc.accountsettings = textBox1.Text;
            acc.Show();
            this.Hide();
        }

        private void AccountForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = accountform;
        }
    }
}
