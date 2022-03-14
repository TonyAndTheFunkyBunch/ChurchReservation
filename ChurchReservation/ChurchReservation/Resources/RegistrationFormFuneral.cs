using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ChurchReservation.Resources
{
    public partial class RegistrationFormFuneral : Form
    {

        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;


        public RegistrationFormFuneral()
        {
            InitializeComponent();
        }

        public void connection()
        {
            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            com = new MySqlCommand("SELECT MAX(RegistrationID)as maxid FROM tbl_registrationbaptist", con);
            data = com.ExecuteReader();
            data.Read();

            String id = data.GetString("maxid");
            String x = "1";
            int a = Convert.ToInt32(id);
            int b = Convert.ToInt32(x);

            int y = a + b;

            int length = 4;
            String result = y.ToString().PadLeft(length, '0');



            registrationid.Text = result;
            con.Close();
        }

        private void RegistrationFormFuneral_Load(object sender, EventArgs e)
        {
            connection();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (firstnametx.Text == "" || lastnametx.Text == "" || registrationid.Text == "")
            {
                MessageBox.Show("Please fillup all the requirements");
                return;
            }
            else
            {
                string x = "x";

                con.Open();
                com = new MySqlCommand("insert into db_reservation.tbl_registrationbaptist(RegistrationID,Firstname,Lastname,Requirements,Fillup,Payment) values ('" + registrationid.Text + "','" + firstnametx.Text + "','" + lastnametx.Text + "','" + x + "','" + x + "','" + x + "')", con);
                com.ExecuteNonQuery();


                RegistrationListFuneral maa = new RegistrationListFuneral();
                maa.Show();
                this.Hide();
                con.Close();
            }
        }
    }
}
