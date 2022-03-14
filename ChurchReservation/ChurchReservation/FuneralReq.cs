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
    public partial class FuneralReq : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;

        public string funeralreq;

        public FuneralReq()
        {
            InitializeComponent();
        }

        public void connection()
        {
            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();
        }


        public void select()
        {
            con.Open();
            com = new MySqlCommand("Select * from tbl_registrationfuneral WHERE RegistrationID = '" + recievee.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {
   

                aCOPY.Text = data.GetValue(6).ToString();
                bCOPY.Text = data.GetValue(7).ToString();

            }
                con.Close();
        }

        public void check()
        {

            if (aCOPY.Text == "a")
            {
                checkBox1.Checked = true;
            }

            if (bCOPY.Text == "b")
            {
                checkBox2.Checked = true;
            }
        }





        public string resi;






        private void button1_Click(object sender, EventArgs e)
        {

        
                FuneralForm funfrm = new FuneralForm();
                funfrm.funeralform = textBox1.Text;
                funfrm.res = recievee.Text;
                this.Hide();
                funfrm.Show();

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void FuneralReq_Load(object sender, EventArgs e)
        {
                                check();
 
            

            if (aCOPY.Text == "a" || bCOPY.Text == "b")
            {
                button1.Visible = true;

            }
            textBox1.Text = funeralreq;
            recievee.Text = resi;
            connection();
            select();

        }

        private void donebtn_Click(object sender, EventArgs e)
        {
                     
            donebtn.Visible = false;
            cancelbtn.Visible = true;
            nextbtn.Visible = true;

            if (checkBox1.Checked == true && checkBox2.Checked == true )
                {
                    complete.Text = "Complete";
                }




            if(checkBox1.Checked == true)
            {
                a.Text = "a";
            }

            if(checkBox2.Checked == true)
            {
                b.Text = "b";
                
            }
              checkBox1.Enabled = false;
            checkBox2.Enabled = false;
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {
            connection();
            con.Open();
            com = new MySqlCommand("update tbl_registrationfuneral set ReqA = '" + a.Text + "' ,ReqB = '" + b.Text + "',Complete = '" + complete.Text + "'where RegistrationID = '" + recievee.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();

            FuneralForm ma = new FuneralForm();
            ma.Passvalue = complete.Text;
            ma.res = recievee.Text;
            ma.funeralform = textBox1.Text;
            ma.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            check();
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            donebtn.Visible = true;
            button2.Visible = false;
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            complete.Text = "";
            cancelbtn.Visible = false;
            nextbtn.Visible = false;
            donebtn.Visible = true;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
        }


          
        }
        }
    
