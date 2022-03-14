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
    public partial class PaymentFuneral : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;

        public string paymentfuneral;

        public PaymentFuneral()
        {
            InitializeComponent();
        }

        private string reciever;

        public string Pass
        {
            get { return reciever; }
            set { reciever = value; }
        }

        public string resic;




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


        public void connection()
        {
            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();

        }



        private void nextbtn_Click(object sender, EventArgs e)
        {

        }


        private void groupBox2_Enter(object sender, EventArgs e)
        {

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

        private void PaymentFuneral_Load(object sender, EventArgs e)
        {

            textBox5.Text = paymentfuneral;
            connection();
            textBox2.Text = resic;

            textBox1.Text = reciever;


            installbtn.Visible = false;
            button2.Visible = false;
            paybtn.Visible = false;
            notavail();


            con.Open();
            com = new MySqlCommand("select * from tbl_funeralpay", con);

            data = com.ExecuteReader();
            while (data.Read())
            {
                totalamount.Text = data.GetString("Payment");
                totaltext.Text = data.GetString("Payment");
               
            } con.Close();
        }


        private void moneytext_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) != true)
            {
                e.Handled = true;
            }
        }

        private void paybtn_Click(object sender, EventArgs e)
        {
            string a = "Fully Paid";

            con.Open();
            com = new MySqlCommand("update tbl_fun set Status = '" + a + "' where Contact = '" + textBox1.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            
            
            
            
            FuneralForm fn = new FuneralForm();

            fn.res = textBox2.Text;
            fn.recie = textBox3.Text;
            fn.funeralform = textBox5.Text;

            this.Hide();

            fn.Show();
        }

        private void installbtn_Click(object sender, EventArgs e)
        {
            string a = "installment";


            try
            {
                con.Open();
                MySqlCommand com = new MySqlCommand("UPDATE tbl_fun SET Statuss = '" + a + "', Balance = '" + totaltextt.Text + "' WHERE Contact = '" + textBox2.Text + "';", con);
                com.ExecuteNonQuery();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

            FuneralForm fn = new FuneralForm();
            fn.res = textBox2.Text;
            fn.recie = textBox4.Text;
            fn.funeralform = textBox5.Text;
            this.Hide();
            fn.Show();




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

        private void button3_Click(object sender, EventArgs e)
        {
            FuneralForm fn = new FuneralForm();
            fn.res = textBox2.Text;
            fn.funeralform = textBox5.Text;
            this.Hide();
            fn.Show();

        }
        }
    
}
