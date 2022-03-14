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
    public partial class PaymentForm : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;


        public string paymentform;

        public PaymentForm()
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
            com = new MySqlCommand("Select * from tbl_totalpay", con);
            data = com.ExecuteReader();
            listView1.Items.Clear();

            while (data.Read())
            { 
                ListViewItem lv = new ListViewItem(Convert.ToString(data.GetValue(0)));
                listView1.Items.Add(lv);
            }
            con.Close();
        }

        public void select1()
        {


            con.Open();
            com = new MySqlCommand("Select * from tblpaymentbaptist", con);
            data = com.ExecuteReader();
            listView2.Items.Clear();

            while (data.Read())
            {
                ListViewItem lve = new ListViewItem(Convert.ToString(data.GetValue(0)));
                listView2.Items.Add(lve);
            }
            con.Close();
        }

        public void select2()
        {


            con.Open();
            com = new MySqlCommand("Select * from tbl_funeralpay", con);
            data = com.ExecuteReader();
            listView3.Items.Clear();

            while (data.Read())
            {
                ListViewItem lvee = new ListViewItem(Convert.ToString(data.GetValue(0)));
                listView3.Items.Add(lvee);
            }
            con.Close();
        }








        public void updatee()
        {
            string ex = "Please set your new payment";

        if ((string.IsNullOrWhiteSpace(Paymenttxtbx.Text)))
         {
           MessageBox.Show(ex, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
         }
        else
           {
            con.Open();
            com = new MySqlCommand("update tbl_totalpay set Payment = '" + Paymenttxtbx.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Done!");
            Paymenttxtbx.Text = "";
            select();
             }
        }

        public void updatee1()
        {
            string ex = "Please set your new payment";

            if ((string.IsNullOrWhiteSpace(Paymenttxtbx1.Text)))
            {
                MessageBox.Show(ex, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                com = new MySqlCommand("update tblpaymentbaptist set Money = '" + Paymenttxtbx1.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Done!");
                Paymenttxtbx1.Text = "";
                select();
            }
        }


        public void updatee2()
        {
            string ex = "Please set your new payment";

            if ((string.IsNullOrWhiteSpace(payment.Text)))
            {
                MessageBox.Show(ex, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                com = new MySqlCommand("update tbl_funeralpay set Payment = '" + payment.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Done!");
                payment.Text = "";
                select();
            }
        }






        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = paymentform;
            connection();
            select();
            select1();
            select2();
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            updatee();

            select();

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void savebtn1_Click(object sender, EventArgs e)
        {
            updatee1();
            select1();
        }

        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        private void save_Click(object sender, EventArgs e)
        {
            updatee2();
            select2();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            EditForms ed = new EditForms();
            this.Close();
            ed.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditForms ed = new EditForms();
            this.Close();
            ed.Show();
        }

        private void cancelbtn_Click(object sender, EventArgs e)
        {
            EditForms ed = new EditForms();
            ed.editform = textBox1.Text;
            this.Close();
            ed.Show();
        }

        private void Paymenttxtbx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) != true)
            {
                e.Handled = true;
            }
        }
    }
}
