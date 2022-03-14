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
    public partial class Payment : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;


        public string paymentss;


        public Payment()
        {
            InitializeComponent();
        }

        public string resic;


        private string ForPayment;

        public string Tagapasa
        {
            get { return ForPayment; }
            set { ForPayment = value; }
        }




        private void label3_Click(object sender, EventArgs e)
        {

        }

        public void connection()
        {
            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();
        }





        public void notavail()
        {


            totaltextt.Enabled = false;
            paymentt.Enabled = false;
            paybtn.Enabled = false;

        }
        public void avail()
        {

            totaltextt.Enabled = true;
            paymentt.Enabled = true;
            paybtn.Enabled = true;
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Payment_Load(object sender, EventArgs e)
        {
            textBox2.Text = resic;
            textBox5.Text = paymentss;

            connection(); 
            
            textBox1.Text = ForPayment;

            installbtn.Visible = false;
            button2.Visible = false;
            paybtn.Visible = false;
            notavail();
            


            con.Open();
            com = new MySqlCommand("select * from tbl_totalpay", con);

            data = com.ExecuteReader();
            while (data.Read())
            {
                totalamount.Text = data.GetString("Payment");
                totaltext.Text = data.GetString("Payment");

            } con.Close();
        }


        private void button1_Click(object sender, EventArgs e)
        {

            if (moneytext.Text == (""))
            {
                notavail();
                MessageBox.Show("Invalid input");
                totaltextt.Text = "";
                paymentt.Text = "";
                moneylbl.Text = "";
                moneytext.Text = "";
                paybtn.Visible = false;
                installbtn.Visible = false;
                return;
            }
            else if (moneytext.Text.Equals("0"))
            {
                MessageBox.Show("Invalid input");
                notavail();
                totaltextt.Text = "";
                paymentt.Text = "";
                moneylbl.Text = "";
                moneytext.Text = "";
                paybtn.Visible = false;
                installbtn.Visible = false;
                return;
            }


            moneylbl.Text = moneytext.Text;

                         double payment = Double.Parse(moneytext.Text);
                         double balance = Double.Parse(totaltext.Text);

                         double total = balance - payment;
                         double totall = payment - balance;
                         avail();
              if (balance > 0)
             {
                 installbtn.Visible = true;
                 paybtn.Visible = false;
             }

                         string amountt = totall.ToString();

                         string amount = total.ToString();


                         paymentt.Text = amountt;
                         totaltextt.Text = amount;
                         button1.Visible = false;
                         button2.Visible = true;


             if (total <= 0)
            {
                totaltextt.Text = "0";
                paybtn.Visible = true;
                installbtn.Visible = false;

                 string a = "Complete";


                con.Open();
                com = new MySqlCommand("update tbl_registration set Complete2 = '" + a + "'where RegistrationID = '" + textBox2.Text  + "'", con);
                com.ExecuteNonQuery();
                con.Close();



            }
            else if (totall <= 0)
            {
                paymentt.Text = "0";
            }

            else
            {
                avail();
            }


            
        }


        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void moneytext_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) != true)
            {
                e.Handled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            string a = "Fully Paid";

            con.Open();
            com = new MySqlCommand("update tbl_mar set Status = '" + a + "' where Contact = '" + textBox2.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            
 
            marriage maa = new marriage();
            maa.res = textBox2.Text;
            maa.recie = textBox3.Text;
            maa.marriagee = textBox5.Text;
            maa.Show();
            this.Hide();

        }

        private void installbtn_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                MySqlCommand com = new MySqlCommand("UPDATE tbl_mar SET Status = '" + installmentnaword.Text + "', Balance = '" + totaltextt.Text + "' WHERE Contact = '" + textBox2.Text + "';", con); 
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            marriage ma = new marriage();
            ma.res = textBox2.Text;
            ma.recie = textBox4.Text;
            ma.marriagee = textBox5.Text;
            this.Hide();
            ma.Show();




        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            button1.Visible = true;
            button2.Visible = false;
            installbtn.Visible = false;
            paymentt.Text = "";
            totaltextt.Text = "";
            paybtn.Visible = false;
            moneylbl.Text = "";
            paymentt.Enabled = false;
            totaltextt.Enabled = false;
            moneytext.Text = "";
        }

        private void moneytext_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter_1(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            marriage ma = new marriage();
            ma.marriagee = textBox5.Text;
            ma.res = textBox2.Text;
            ma.Show();
            this.Hide();
        }

        }
    }
