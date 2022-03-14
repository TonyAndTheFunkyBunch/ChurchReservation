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
    public partial class RegistrationFormBaptist : Form
    {

        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;

        public string registrationFormbaptist;



        public RegistrationFormBaptist()
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

        private void RegistrationFormBaptist_Load(object sender, EventArgs e)
        {
            textBox1.Text = registrationFormbaptist;
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
                con.Open();
                com = new MySqlCommand("Select * from tbl_registrationbaptist WHERE RegistrationID = '" + registrationid.Text + "'", con);
                data = com.ExecuteReader();

                while (data.Read())

                    if (data.HasRows)
                    {
                        MessageBox.Show("Contact is already exist");
                        registrationid.Text = "";
                        con.Close();
                        return;
                    }
                con.Close();



                string x = "x";

                con.Open();
                com = new MySqlCommand("insert into db_reservation.tbl_registrationbaptist(RegistrationID,Firstname,Lastname,Requirements,Fillup,Payment) values ('" + registrationid.Text + "','" + firstnametx.Text + "','" + lastnametx.Text + "','" + x + "','" + x + "','" + x + "')", con);
                com.ExecuteNonQuery();
                con.Close();


                con.Open();
                com = new MySqlCommand("insert into db_reservation.tbl_baptisms(Contact)values ('" + registrationid.Text + "')", con);
                com.ExecuteNonQuery();
                con.Close();



                RegistrationListBaptist maa = new RegistrationListBaptist();

                maa.registrationlistbaptist = textBox1.Text;
                maa.Show();
                this.Hide();
            }
        }

        private void firstnametx_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrationid_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) != true)
            {
                e.Handled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RegistrationListBaptist maa = new RegistrationListBaptist();

            maa.registrationlistbaptist = textBox1.Text;
            maa.Show();
            this.Hide();
        }
    }
}
