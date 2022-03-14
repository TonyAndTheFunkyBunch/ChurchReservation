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
    public partial class RegistrationListFuneral : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;

        public string registrationlistfuneral;


        public RegistrationListFuneral()
        {
            InitializeComponent();
        }

        public void selection()
        {

            con.Open();
            com = new MySqlCommand("Select * from tbl_registrationfuneral", con);
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


        private void RegistrationListFuneral_Load(object sender, EventArgs e)
        {
            textBox1.Text = registrationlistfuneral;
            connection();
            selection();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            contactno.Text = listView1.Items[listView1.SelectedItems[0].Index].Text;
            if (MessageBox.Show("Are you sure you want to continue this registration with this account?", "Waiting", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                FuneralForm mn = new FuneralForm();
                mn.funeralform = textBox1.Text;
                mn.res = contactno.Text;
                mn.Show();
                this.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RegistrationFormFuneral gg = new RegistrationFormFuneral();
            gg.registrationFormFuneral = textBox1.Text;
            gg.Show();
            this.Hide();
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
