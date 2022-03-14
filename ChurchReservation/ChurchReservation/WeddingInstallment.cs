﻿using System;
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
    public partial class WeddingInstallment : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;


        public string weddinginstallment;


        public WeddingInstallment()
        {
            InitializeComponent();
        }

        public void connection()
        {
            con = new MySqlConnection("Server = localhost; database = db_reservation; UID = root");
            con.Open();
            con.Close();
        }

        public void clear()
        {

            givenmoney.Text = "";
            totaltextt.Text = "";
            paymentt.Text = "";
            moneytext.Text = "";
        }


        public void select()
        {
            string a = "installment";
            con.Open();
            com = new MySqlCommand("select * from tbl_mar where Status = '" + a + "'", con);
            data = com.ExecuteReader();
            listView1.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(50)));
                lv.SubItems.Add(data.GetValue(1).ToString());
                lv.SubItems.Add(data.GetValue(2).ToString());
                lv.SubItems.Add(data.GetValue(3).ToString());
                lv.SubItems.Add(data.GetValue(21).ToString());
                lv.SubItems.Add(data.GetValue(22).ToString());
                lv.SubItems.Add(data.GetValue(23).ToString());
                lv.SubItems.Add(data.GetValue(51).ToString());



                listView1.Items.Add(lv);
            }
            con.Close();
        }


        public void realPay()
        {
            if (totaltextt.Text.Equals("0"))
            {
                string ab = "Fully Paid";
                con.Open();
                com = new MySqlCommand("update tbl_mar set Status = '" + ab + "',Balance = '" + totaltextt.Text + "'  where Contact = '" + contactno.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                string aa = "Complete";
                con.Open();
                com = new MySqlCommand("UPDATE tbl_registration SET Payment = '" + aa + "' WHERE RegistrationID = '" + contactno.Text + "';", con);
                com.ExecuteNonQuery();
                con.Close();


                select();
                clear();

            }
            else
            {
                string a = "installment";
                con.Open();
                com = new MySqlCommand("update tbl_mar set Balance = '" + totaltextt.Text + "',Status = '" + a + "' where Contact = '" + contactno.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                string bb = "Incomplete";
                con.Open();
                com = new MySqlCommand("UPDATE tbl_registration SET Payment = '" + bb + "' WHERE RegistrationID = '" + contactno.Text + "';", con);
                com.ExecuteNonQuery();
                con.Close();
                select();
                clear();
            }
        }






        private void WeddingInstallment_Load(object sender, EventArgs e)
        {
            textBox1.Text = weddinginstallment;
            connection();
            select();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {
            PaymentGroup.Visible = true;
            moneytobepay.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[8].Text;
            holder.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[8].Text;
            contactno.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[0].Text;
        }

        private void paybtn_Click(object sender, EventArgs e)
        {
            paybtn.Visible = false;
            realPay();
            button1.Visible = true;
            PaymentGroup.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (moneytext.Text == "")
            {
                MessageBox.Show("Please choose a desire account to be pay");
                button1.Visible = true;
                paybtn.Visible = false;
                return;
            }

            if (moneytext.Text == "-" || moneytext.Text == "+")
            {
                MessageBox.Show("Invalid input");
                return;
            }

            paybtn.Visible = true;
            button1.Visible = false;
            button2.Visible = true;


            double payment = Double.Parse(moneytext.Text);
            double balance = Double.Parse(holder.Text);

            double total = balance - payment;
            double totall = payment - balance;
            if (balance > 0)
            {
                paybtn.Visible = true;
            }

            string amountt = totall.ToString();

            string amount = total.ToString();


            paymentt.Text = amountt;
            totaltextt.Text = amount;

            if (total <= 0)
            {
                totaltextt.Text = "0";
                paybtn.Visible = true;
            }
            else if (totall <= 0)
            {
                paymentt.Text = "0";
            }
        }

        private void searchbtn_KeyPress(object sender, KeyPressEventArgs e)
        {


            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) != true)
            {
                e.Handled = true;
            }


            {
                if (searchbtn.Text != "")
                {
                    foreach (ListViewItem item in listView1.Items)
                    {
                        if (item.Text.ToLower().Contains(searchbtn.Text.ToLower()))
                        {
                            item.Selected = true;
                        }
                        else
                        {
                            listView1.Items.Remove(item);
                        }

                    }
                    if (listView1.SelectedItems.Count == 1)
                    {
                        listView1.Focus();
                    }
                }
                else
                {
                    select();
                }
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            paybtn.Visible = false;
            clear();
            button1.Visible = true;
            button2.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            PaymentGroup.Visible = false;
            clear();
            paybtn.Visible = false;
        }

        private void moneytext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) != true)
            {
                e.Handled = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            InstallmentForm iff = new InstallmentForm();
            iff.installmentform = textBox1.Text;
            iff.Show();
            this.Hide();
        }
    }
}
