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
    public partial class ReqBaptist : Form
    {

        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;

        public ReqBaptist()
        {
            InitializeComponent();
        }

        public string reqbaptistt;

        public void connection()
        {
            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();
        }

        public void select()
        {
            con.Open();
            com = new MySqlCommand("Select * from tbl_registration WHERE RegistrationID = '" + recievee.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
                aCOPY.Text = data.GetString("ReqA");

            }
                con.Close();
        }

        public void check()
        {

            if (aCOPY.Text == "a")
            {
                checkBox1.Checked = true;
            }

        }


        public string resi;




        private void ReqBaptist_Load(object sender, EventArgs e)
        {
            textBox1.Text = reqbaptistt;           
            
          

                    check();
 
            

            if (aCOPY.Text == "a")
            {
                button1.Visible = true;

            }
            
            recievee.Text = resi;
            connection();
            select();

        }

        



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            check();
            checkBox1.Enabled = true;
            donebtn.Visible = true;
            button1.Visible = false;

        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            complete.Text = "";
            cancelbtn.Visible = false;
            nextbtn.Visible = false;
            donebtn.Visible = true;
            checkBox1.Enabled = true;
  
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            connection();
            con.Open();
            com = new MySqlCommand("update tbl_registrationbaptist set ReqA = '" + a.Text + "',Complete = '" + complete.Text + "'where RegistrationID = '" + recievee.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();

            Baptist ma = new Baptist();
            ma.res = recievee.Text;
            ma.baptist = textBox1.Text;
            ma.Passvalue = complete.Text;
            ma.Show();
            this.Hide();
        }

        private void donebtn_Click(object sender, EventArgs e)
        {
            donebtn.Visible = false;
            cancelbtn.Visible = true;
            nextbtn.Visible = true;

            if (checkBox1.Checked == true)
            {
                complete.Text = "Complete";
            }




            if (checkBox1.Checked == true)
            {
                a.Text = "a";
            }




            checkBox1.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Baptist bap = new Baptist();
            bap.baptist = textBox1.Text;
            bap.res = recievee.Text;
            bap.Show();
            this.Hide();
        }
    }
}
