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
    public partial class RegistrationList : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;


        public string registrationlist;


        public RegistrationList()
        {
            InitializeComponent();
        }

        public void selection()
        {

            con.Open();
            com = new MySqlCommand("Select * from tbl_registration", con);
            data = com.ExecuteReader();
            listView1.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(3)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(4)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(5)));
                listView1.Items.Add(lv);
            }
            con.Close();
        }

        public void connection()
        {
            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();
        }




        private void RegistrationList_Load(object sender, EventArgs e)
        {
            textBox1.Text = registrationlist;
            connection();
            selection();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationForm rfb = new RegistrationForm();
            rfb.registrationform = textBox1.Text;
            rfb.Show();
            this.Hide();
        }

        private void listView1_ItemActivate_1(object sender, EventArgs e)
        {
            contactno.Text = listView1.Items[listView1.SelectedItems[0].Index].Text;
            if (MessageBox.Show("Are you sure you want to continue this registration with this account?", "Waiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                marriage mn = new marriage();
                mn.res = contactno.Text;
                mn.marriagee = textBox1.Text;
                mn.Show();
                this.Hide();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main mn = new Main();
            mn.aa = textBox1.Text;
            mn.Show();
            this.Hide();
        }
    }
}
