using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ChurchReservation
{
    public partial class AccountSetting : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;

        public AccountSetting()
        {
            InitializeComponent();
        }

        public string accountsettings;

        public void selection()
        {
            string a = "Enabled";
            con.Open();
            com = new MySqlCommand("Select * from tbl_user where status = '" + a + "'", con);
            data = com.ExecuteReader();
            listView1.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(3)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(4)));
                listView1.Items.Add(lv);
            }
            con.Close();
        }


        public void selection2()
        {
            string a = "Disabled";
            con.Open();
            com = new MySqlCommand("Select * from tbl_user where status = '" + a + "'", con);
            data = com.ExecuteReader();
            listView2.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(3)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(4)));
                listView2.Items.Add(lv);
            }
            con.Close();
        }



        public void connection()
        {

            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();
            selection();
        }



        private void AccountSetting_Load(object sender, EventArgs e)
        {
            textBox2.Text = accountsettings;
            connection();
            selection();
            selection2();
        }


        private void listView2_ItemActivate(object sender, EventArgs e)
        {
            textBox1.Text = listView2.Items[listView2.SelectedItems[0].Index].Text;
            if (MessageBox.Show("Are you sure you want to activate this account?", "Waiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string a = "Enabled";

                con.Close();
                con.Open();
                com = new MySqlCommand("update tbl_user set Status = '" + a + "'where Username = '" + textBox1.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                selection2();
                selection();
            }
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            textBox1.Text = listView1.Items[listView1.SelectedItems[0].Index].Text;
            if (MessageBox.Show("Are you sure you want to disable this account?", "Waiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string a = "Disabled";

                con.Close();
                con.Open();
                com = new MySqlCommand("update tbl_user set Status = '" + a + "'where Username = '" + textBox1.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                selection2();
                selection();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AccountForm af = new AccountForm();
            af.accountform = textBox2.Text;
            af.Show();
            this.Hide();
        }
    }
}
