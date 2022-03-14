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
    public partial class REQUIREMENTS : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;


        public string requirementss;

        public REQUIREMENTS()
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
            com = new MySqlCommand("Select * from tbl_registration WHERE RegistrationID = '" + recievee.Text + "'", con);
            data = com.ExecuteReader();

            while (data.Read())
            {


                aCOPY.Text = data.GetValue(6).ToString();
                bCOPY.Text = data.GetValue(7).ToString();
                cCOPY.Text = data.GetValue(8).ToString();
                dCOPY.Text = data.GetValue(9).ToString();
                eeCOPY.Text = data.GetValue(10).ToString();

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


            if (cCOPY.Text == "c")
            {
                checkBox3.Checked = true;
            }


            if (dCOPY.Text == "d")
            {
                checkBox4.Checked = true;
            }

            if (eeCOPY.Text == "e")
            {
                checkBox5.Checked = true;
            }
        }


        public void enabled()
        {
            checkBox2.Enabled = true;
            checkBox1.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
        }


        public string resi;

        private void button5_Click(object sender, EventArgs e)
        {


        }

        private void REQUIREMENTS_Load(object sender, EventArgs e)
        {
            textBox1.Text = requirementss;
           

                    check();
 
            

            if (aCOPY.Text == "a" || bCOPY.Text == "b" || cCOPY.Text == "c" || dCOPY.Text == "d" || eeCOPY.Text == "e")
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
            this.Dispose();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

   
            }

        private void button1_Click_2(object sender, EventArgs e)
        {
            
            donebtn.Visible = false;
            cancelbtn.Visible = true;
            nextbtn.Visible = true;

            if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true && checkBox4.Checked == true && checkBox5.Checked == true)
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

            if(checkBox3.Checked == true)
            {
                c.Text = "c";
            }

            if(checkBox4.Checked == true)
            {
                d.Text = "d";

            }

            if(checkBox5.Checked == true)
            {
                ee.Text = "e";
              
            }


            checkBox1.Enabled = false;
            checkBox2.Enabled = false;
            checkBox3.Enabled = false;
            checkBox4.Enabled = false;
            checkBox5.Enabled = false;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            complete.Text = "";
            cancelbtn.Visible = false;
            nextbtn.Visible = false;
            donebtn.Visible = true;
            checkBox1.Enabled = true;
            checkBox2.Enabled = true;
            checkBox3.Enabled = true;
            checkBox4.Enabled = true;
            checkBox5.Enabled = true;
        }

        private void nextbtn_Click(object sender, EventArgs e)
        {

            connection();
              con.Open();
              com = new MySqlCommand("update tbl_registration set ReqA = '" + a.Text + "' ,ReqB = '" + b.Text + "',ReqC = '" + c.Text + "',ReqD = '" + d.Text + "',ReqE = '" + ee.Text + "',Complete = '" + complete.Text + "'where RegistrationID = '" + recievee.Text + "'", con);
              com.ExecuteNonQuery();
              con.Close();

            marriage ma = new marriage();
            ma.Passvalue = complete.Text;
            ma.res = recievee.Text;
            ma.marriagee = textBox1.Text;
            ma.Show();
            this.Hide();

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            check();
            enabled();
            donebtn.Visible = true;
            button1.Visible = false;
        }

        private void aCOPY_TextChanged(object sender, EventArgs e)
        {

            if (aCOPY.Text == "a" || bCOPY.Text == "b" || cCOPY.Text == "c" || dCOPY.Text == "d" || eeCOPY.Text == "e")
            {
                button1.Visible = true;

            }
        }

        private void bCOPY_TextChanged(object sender, EventArgs e)
        {

            if (aCOPY.Text == "a" || bCOPY.Text == "b" || cCOPY.Text == "c" || dCOPY.Text == "d" || eeCOPY.Text == "e")
            {
                button1.Visible = true;

            }
        }

        private void cCOPY_TextChanged(object sender, EventArgs e)
        {

            if (aCOPY.Text == "a" || bCOPY.Text == "b" || cCOPY.Text == "c" || dCOPY.Text == "d" || eeCOPY.Text == "e")
            {
                button1.Visible = true;

            }
        }

        private void dCOPY_TextChanged(object sender, EventArgs e)
        {

            if (aCOPY.Text == "a" || bCOPY.Text == "b" || cCOPY.Text == "c" || dCOPY.Text == "d" || eeCOPY.Text == "e")
            {
                button1.Visible = true;

            }
        }

        private void eeCOPY_TextChanged(object sender, EventArgs e)
        {

            if (aCOPY.Text == "a" || bCOPY.Text == "b" || cCOPY.Text == "c" || dCOPY.Text == "d" || eeCOPY.Text == "e")
            {
                button1.Visible = true;

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            marriage bap = new marriage();
            bap.res = recievee.Text;
            bap.marriagee = textBox1.Text;
            bap.Show();
            this.Hide();
        }
        }
    }

