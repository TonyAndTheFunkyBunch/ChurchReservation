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
    public partial class FuneralInstallment : Form
    {
        MySqlConnection con;
        MySqlCommand com;
        MySqlDataReader data;

        public FuneralInstallment()
        {
            InitializeComponent();
        }

        public string funeralinstallment;

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
            com = new MySqlCommand("select * from tbl_fun where Statuss = '" + a + "'", con);
            data = com.ExecuteReader();
            listView1.Items.Clear();

            while (data.Read())
            {
                ListViewItem lv = new ListViewItem(Convert.ToString(data.GetValue(0)));
                lv.SubItems.Add(Convert.ToString(data.GetValue(16)));
                lv.SubItems.Add(data.GetValue(1).ToString());
                lv.SubItems.Add(data.GetValue(2).ToString());
                lv.SubItems.Add(data.GetValue(3).ToString());
                lv.SubItems.Add(data.GetValue(17).ToString());

                listView1.Items.Add(lv);
            }
            con.Close();
        }

        private void FuneralInstallment_Load(object sender, EventArgs e)
        {
            textBox1.Text = funeralinstallment;
            paybtn.Visible = false;
            connection();
            select();
        }

        private void listView1_ItemActivate(object sender, EventArgs e)
        {

            PaymentGroup.Visible = true;

            moneytobepay.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[5].Text;
            holder.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[5].Text;
            contactno.Text = listView1.Items[listView1.SelectedItems[0].Index].SubItems[0].Text;
        }

        public void realPay()
        {
            if (totaltextt.Text.Equals("0"))
            {
                string ab = "Fully Paid";
                con.Open();
                com = new MySqlCommand("update tbl_fun set Statuss = '" + ab + "',Balance = '" + totaltextt.Text +"'  where Contact = '" + contactno.Text + "'", con);
                com.ExecuteNonQuery();
                con.Close();
                string aa = "Complete";
                con.Open();
                com = new MySqlCommand("UPDATE tbl_registrationfuneral SET Payment = '" + aa + "' WHERE RegistrationID = '" + contactno.Text + "';", con);
                com.ExecuteNonQuery();
                con.Close();

                select();
                clear();
                
            }
            else
            {
            string a = "installment";
            con.Open();
            com = new MySqlCommand("update tbl_fun set Balance = '" + totaltextt.Text + "',Statuss = '" + a + "' where Contact = '" + contactno.Text + "'", con);
            com.ExecuteNonQuery();
            con.Close();
            string bb = "Incomplete";
            con.Open();
            com = new MySqlCommand("UPDATE tbl_registrationbfuneral SET Payment = '" + bb + "' WHERE RegistrationID = '" + contactno.Text + "';", con);
            com.ExecuteNonQuery();
            con.Close();

            select();
            clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            givenmoney.Text = moneytext.Text;
            button1.Visible = false;
            button2.Visible = true;
            if (moneytext.Text == "")
            {
                MessageBox.Show("Please choose a desire account to be pay");
                button1.Visible = true;
                return;
            }

            if (moneytext.Text == "-" || moneytext.Text == "+")
            {
                MessageBox.Show("Invalid input");
                return;
            }




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

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void paybtn_Click(object sender, EventArgs e)
        {
            
            realPay();
            clear();
            button1.Visible = true;
            paybtn.Visible = false;
            PaymentGroup.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
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
        }

        private void moneytext_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsControl(e.KeyChar) != true && Char.IsNumber(e.KeyChar) != true)
            {
                e.Handled = true;
            }
        }

        private void searchbtn_KeyPress(object sender, KeyPressEventArgs e)
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
