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
    public partial class PaymentBapt : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;


        public string paymentbapt;


        private string Passval;

        public string Val
        {
            get { return Passval; }
            set { Passval = value; }

        }

        public string resic;




        public PaymentBapt()
        {
            InitializeComponent();
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


        private void PaymentBapt_Load(object sender, EventArgs e)
        {
            textBox5.Text = paymentbapt;
            textBox2.Text = resic;
            installbtn.Visible = false;
            button2.Visible = false;
            paybtn.Visible = false;
            notavail();

            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();

            con.Open();
            com = new MySqlCommand("select * from tblPaymentBaptist", con);

            data = com.ExecuteReader();
            while (data.Read())
            {
                totalamount.Text = data.GetString("Money");
                totaltext.Text = data.GetString("Money");

            }
            con.Close();
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

        private void button1_Click_1(object sender, EventArgs e)
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

        private void nextbtn_Click(object sender, EventArgs e)
        {

        }

        private void paybtn_Click(object sender, EventArgs e)
        {
            string a = "Fully Paid";

            con.Open();
            com = new MySqlCommand("update tbl_baptisms set Status = '" + a + "' where Contact = '" + textBox1.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            
            
            
            Baptist maa = new Baptist();
            maa.res = textBox2.Text;
            maa.recie = textBox3.Text;
            maa.baptist = textBox5.Text;
            this.Hide();
            maa.Show();
        }

        private void installbtn_Click(object sender, EventArgs e)
        {
            string a = "installment";


            try
            {

                con.Open();
                MySqlCommand com = new MySqlCommand("UPDATE tbl_baptisms SET Status = '" + a + "', Balance = '" + totaltextt.Text + "' WHERE Contact = '" + textBox2.Text + "';", con);
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            Baptist ma = new Baptist();
            ma.res = textBox2.Text;
            ma.recie = textBox4.Text;
            ma.baptist = textBox5.Text;
            this.Hide();
            ma.Show();



        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Baptist ba = new Baptist();
            ba.baptist = textBox5.Text;
            ba.res = textBox2.Text;
            ba.Show();
            this.Hide();

        }
    }
}
