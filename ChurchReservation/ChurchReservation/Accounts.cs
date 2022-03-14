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
    public partial class Accounts : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;

        public Accounts()
        {
            InitializeComponent();
        }

        public string accounts;


        public void selection()
        {

            con.Open();
            com = new MySqlCommand("Select * from tbl_user", con);
            data = com.ExecuteReader();
            listView1.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(1)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(2)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(3)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(6)));
                listView1.Items.Add(lv);
            }
            con.Close();
        }



        public void insert()
        {
            string status = "Enabled";
            con.Open();
            com = new MySqlCommand("insert into db_reservation.tbl_user(Username,Password,Firstname,Lastname,Status,Levelofaccess)values ('" + Usernametb.Text + "' , '" + Passwordtb.Text + "','" + fnametx.Text + "','" + Lnametx.Text + "','" + status + "','" + lvlofaccess.Text + "')", con);
            com.ExecuteNonQuery();
            con.Close();
            selection();
            MessageBox.Show("New Account Has Been Added");
        }

        private void button1_Click(object sender, EventArgs e)
        {

            insert();
            button3.Visible = false;
            clearbtn.Visible = false;
            Savebtn.Visible = false;
            Passwordtb.Enabled = false;
            Checkpass.Visible = false;
            Usernametb.Text = "";
            Passwordtb.Text = "";
            fnametx.Text = "";
            Lnametx.Text = "";
            lvlofaccess.Text = "";
            fnametx.Enabled = true;
            Lnametx.Enabled = true;
            Usernametb.Enabled = true;
            Checkuser.Visible = true;


        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            textBox1.Text = accounts;

            clearbtn.Visible = false;
            Savebtn.Visible = false;
            Passwordtb.Enabled = false;
            Checkpass.Visible = false;



            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();
            selection();
        }



        private void button3_Click(object sender, EventArgs e)
        {

            if (Usernametb.Text.Equals(""))
            {
                MessageBox.Show("Invalid Input");
                return;
            }


            con.Open();
            com = new MySqlCommand("Select * from tbl_user WHERE Username = '" + Usernametb.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())

                if (data.HasRows)
                {
                    MessageBox.Show("Username already exist");
                    Usernametb.Text = "";
                    con.Close();
                    return;
                }
            button2.Visible = true;
            Usernametb.Enabled = false;
            lvlofaccess.Enabled = true;
            Passwordtb.Enabled = true;
            Checkuser.Visible = false;
            Checkpass.Enabled = true;
            Checkpass.Visible = true;
            con.Close();
        }

        private void Clearuser_Click(object sender, EventArgs e)
        {
            Savebtn.Enabled = false;
            Checkuser.Visible = true;
            Usernametb.Text = "";
            Usernametb.Enabled = true;
            Passwordtb.Enabled = false;
        }

        private void Checkpass_Click(object sender, EventArgs e)
        {

            if (Passwordtb.Text.Equals("") || fnametx.Text.Equals("") || Lnametx.Text.Equals("") || Usernametb.Text.Equals("") || lvlofaccess.Text.Equals(""))
            {
                MessageBox.Show("All fields are required!");
                return;
            }
            if(lvlofaccess.Text != ("Admin") && lvlofaccess.Text != ("Client"))
            {
                MessageBox.Show("Please choose a proper Level of access");
                lvlofaccess.Text = "";
                return;
            }

            button3.Visible = true;
            fnametx.Enabled = false;
            Lnametx.Enabled = false;
            Usernametb.Enabled = false;
            Passwordtb.Enabled = false;
            lvlofaccess.Enabled = false;
            Savebtn.Visible = true;
            Savebtn.Enabled = true;
            Checkpass.Visible = false;
            clearbtn.Visible = true;
            button2.Visible = false;

            }

        private void Clearpass_Click(object sender, EventArgs e)
        {
            Passwordtb.Enabled = true;
            Passwordtb.Text = "";
            Savebtn.Enabled = false;
            Checkpass.Visible = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            button3.Visible = false;
            fnametx.Enabled = true;
            Lnametx.Enabled = true;
            lvlofaccess.Enabled = false;
            Savebtn.Visible = false;
            clearbtn.Visible = false;
            Usernametb.Text = "";
            lvlofaccess.Text = "";
            fnametx.Text = "";
            Lnametx.Text = "";
            Usernametb.Enabled = true;
            Checkuser.Visible = true;
            Checkuser.Enabled = true;
            Passwordtb.Text = "";
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            AccountForm mff = new AccountForm();
            mff.accountform = textBox1.Text;
            mff.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Passwordtb.Text = "";
            Usernametb.Text = "";
            Usernametb.Enabled = true;
            Checkuser.Visible = true;
            Passwordtb.Enabled = false;
            lvlofaccess.Text = "";
            lvlofaccess.Enabled = false;
            button2.Visible = false;
            Checkpass.Visible = false;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Usernametb.Enabled = false;
            clearbtn.Visible = false;
            Savebtn.Visible = false;
            Passwordtb.Enabled = false;
            Checkpass.Visible = false;
            Passwordtb.Enabled = true;
            fnametx.Enabled = true;
            Lnametx.Enabled = true;
            lvlofaccess.Enabled = true;
            button3.Visible = false;
            Checkpass.Visible = true;
            button2.Visible = true;
        }

    }
}
