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
    public partial class marriage : Form
    {


        public string marriagee;



        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;

        private string mnee;

        public string Passvalue
        {
            get { return mnee; }
            set { mnee = value; }
        }



        public marriage()
        {
            InitializeComponent();
        }

        public string res;

        public string recie;

        public string fillupp;




 


        public void select()
        {
            con.Open();
            com = new MySqlCommand("Select * from tbl_registration WHERE RegistrationID = '" + reciever.Text + "'", con);
            data = com.ExecuteReader();
            while (data.Read())
            {
                requirements.Text = data.GetString("Requirements");
                fillupe.Text = data.GetString("Fillup");
                paymentx.Text = data.GetString("Payment");
                Completee.Text = data.GetValue(11).ToString();
                Completee2.Text = data.GetValue(12).ToString();
            }
            con.Close();

        }













        public void connection()
        {
            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            REQUIREMENTS rq = new REQUIREMENTS();
            rq.requirementss = textBox6.Text;
            rq.resi = reciever.Text;
            rq.Show();
            this.Hide();
        }

        private void marriage_Load(object sender, EventArgs e)
        {
            textBox6.Text = marriagee;



            connection();
            textBox4.Text = fillupp;
            textBox5.Text = textBox4.Text;
            reciever.Text = res;
            Payment.Text = recie;
            textBox2.Text = Passvalue;
            select();


            if (textBox5.Text.Equals("Complete"))
            {
                fllbtt.Enabled = false;
                label9.Text = "Complete";
                string cc = "Complete";
                connection();
                con.Open();
                com = new MySqlCommand("update tbl_registration set Fillup = '" + cc + "'where RegistrationID = '" + reciever.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                select();
            }




            if (Payment.Text.Equals("Complete"))
            {
                paybtt.Enabled = false;
                label8.Text = "Complete";
                string cc = "Complete";
                connection();
                con.Open();
                com = new MySqlCommand("update tbl_registration set Payment = '" + cc + "'where RegistrationID = '" + reciever.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                select();
            }

            if (Payment.Text.Equals("Incomplete"))
            {
                paybtt.Enabled = false;
                label8.Text = "Incomplete";
                string cc = "Incomplete";
                connection();
                con.Open();
                com = new MySqlCommand("update tbl_registration set Payment = '" + cc + "'where RegistrationID = '" + reciever.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                select();
            }



            if (Completee.Text.Equals("Complete"))
            {
                reqbtt.Enabled = false;
                label7.Text = "Complete";
                string cc = "Complete";
                connection();
                con.Open();
                com = new MySqlCommand("update tbl_registration set Requirements = '" + cc + "'where RegistrationID = '" + reciever.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                select();
            }










            if (paymentx.Text.Equals("x"))
            {
                label8.Text = "Incomplete";
            }

            if (requirements.Text.Equals("x"))
            {
                label7.Text = "Incomplete";
            }
            if (fillupe.Text.Equals("x"))
            {
                label9.Text = "Incomplete";
            }






        }

        private void fllbtt_Click(object sender, EventArgs e)
        {
            FillupForm fl = new FillupForm();
            fl.fill = reciever.Text;
            fl.fillupform = textBox6.Text;
            this.Hide();
            fl.Show();
        }

        private void paybtt_Click(object sender, EventArgs e)
        {
            Payment paymm = new Payment();
            paymm.resic = reciever.Text;
            paymm.paymentss = textBox6.Text;
            this.Hide();
            paymm.Show();



        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            RegistrationList fs = new RegistrationList();
            fs.registrationlist = textBox6.Text;
            this.Hide();
            fs.Show();
        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void reqbtt_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void lblreq_Click(object sender, EventArgs e)
        {

        }

        private void Completee_TextChanged(object sender, EventArgs e)
        {

        }

        private void Completee2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Payment_TextChanged(object sender, EventArgs e)
        {

        }

        private void paymentx_TextChanged(object sender, EventArgs e)
        {
            if (paymentx.Text.Equals("Complete"))
            {
                label8.Text = "Complete";
                paybtt.Enabled = false;
            }
            if (paymentx.Text.Equals("Incomplete"))
            {
                label8.Text = "Incomplete";
                paybtt.Enabled = false;
            }

        }


        private void fillupe_TextChanged(object sender, EventArgs e)
        {
            if (fillupe.Text.Equals("Complete"))
            {
                fllbtt.Enabled = false;
                label9.Text = "Complete";

            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
        

        private void textBox5_TextChanged(object sender, EventArgs e)
        {



        }

        private void requirements_TextChanged(object sender, EventArgs e)
        {
            if (requirements.Text.Equals("Complete"))
            {
                label7.Text = "Complete";
                reqbtt.Enabled = false;
            }
        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}