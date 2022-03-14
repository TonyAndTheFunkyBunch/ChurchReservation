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
    public partial class FillupForm2 : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;



        public string mnee;

        public string Passvalue
        {
            get { return mnee; }
            set { mnee = value; }
        }
        public void connection()
        {
            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();
        }

        


        public FillupForm2()
        {
            InitializeComponent();
        }

        private void FillupForm2_Load(object sender, EventArgs e)
        {
            connection();
            textBox1.Text = mnee;
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if ((string.IsNullOrWhiteSpace(Officetxt.Text)) | (string.IsNullOrWhiteSpace(Citytxt.Text)) | (string.IsNullOrWhiteSpace(Provincetxt.Text)) | (string.IsNullOrWhiteSpace(Timetxt.Text)) | (string.IsNullOrWhiteSpace(Husbandtxt.Text)) | (string.IsNullOrWhiteSpace(Wifetxt.Text)) | (string.IsNullOrWhiteSpace(Contracttxt.Text)) | (string.IsNullOrWhiteSpace(Monthtxt.Text)) | (string.IsNullOrWhiteSpace(Yeartxt.Text)))
            {
                MessageBox.Show("Please fill up all the information needed");
                return;
            }
            else
            {
                con.Open();
                com = new MySqlCommand("update tbl_mar set Office = '" + Officetxt.Text + "', City = '" + Citytxt.Text + "',Province = '" + Provincetxt.Text + "',Time = '" + Timetxt.Text + "' where Contact = " + textBox1.Text + "", con);
                com.ExecuteNonQuery();
                con.Close();

                marriage ma = new marriage();
                this.Hide();
                ma.Show();





                this.Hide();
                ma.Show();


            }
        
            
            
            
            

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }
    }
}
