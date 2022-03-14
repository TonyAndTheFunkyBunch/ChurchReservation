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
    public partial class LoginFrm : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;

        public LoginFrm()
        {
            InitializeComponent();
        }


        public void connection()
        {
            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();
            }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            connection();
        }
        private int c = 4;

        private void logbtt_Click(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("select * from tbl_user where Username = '" + usertext.Text + "'and Password = '" + passtext.Text + "'", con);

            data = com.ExecuteReader();
            int a = 0;
            while (data.Read())
            {
                a++;
            }

            if (a == 1)
            {
                this.Hide();
                Main mn = new Main();
                mn.Passvalue = usertext.Text;
                mn.aa = usertext.Text;
                mn.Show();
            }
            else
            {

                if (passtext.Text != checking.Text)
                {
                    if (c != 0)
                    {
                        c--;
                        MessageBox.Show("Invalid Password Attempts left " + c.ToString(), "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        passtext.Text = "";
                    }
                    if (c == 0)
                    {
                        c--;
                        logbtt.Enabled = false;
                        passtext.Enabled = false;
                        passtext.Text = "";
                        c = 4;

                        MessageBox.Show("This account is this disabled" + Environment.NewLine + "Please do contact the admin", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        string status = "Disabled";

                        con.Close();
                        con.Open();
                        com = new MySqlCommand("update tbl_user set Status = '" + status + "'where Username = '" + usertext.Text + "'", con);
                        com.ExecuteNonQuery();
                        con.Close();

                    }

                }


            } con.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            
            
            cancel.Visible = true;
            label4.Visible = true;
            if (usertext.Text == "")
            {
                MessageBox.Show("Invalid Input");
                check.Visible = true;
                cancel.Visible = false;
                return;
            }

            con.Open();
            com = new MySqlCommand("Select * from tbl_user WHERE Username = '" + usertext.Text + "'", con);
            data = com.ExecuteReader();

            label4.Text = "This Username Doesnt Exist";

            while (data.Read())
            {
                if (data.HasRows)
                {
                    checking.Text = data.GetString("Password");
                    statustext.Text = data.GetString("Status");
                    check.Visible = false;
                    label4.Visible = false;
                    logbtt.Visible = true;
                    usertext.Enabled = false;
                    passtext.Enabled = true;
                }
                
            }
              con.Close();

              if (statustext.Text == "Disabled")
              {
                  MessageBox.Show("This account has been disabled, Please contact the admin to activate it");
                  logbtt.Visible = false;
                  passtext.Enabled = false;
              
              }


            }

        private void cancel_Click(object sender, EventArgs e)
        {
            
            passtext.Text = "";
            logbtt.Enabled = true;
            passtext.Enabled = false;
            logbtt.Visible = false;
            usertext.Text = "";
            check.Visible = true;
            label4.Visible = false;
            cancel.Visible = false;
            usertext.Enabled = true;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}



            


